using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application2.Contracts;
using Application2.Exceptions;
using Application2.Models;

namespace Application2.Core
{
    public class Engine : IRunnable
    {
        private const int CellsInField = 35;

        private IDatabase database;
        private IBoard board;

        private int playerPoints = 0;
        private int playerRow = 0;
        private int playerCol = 0;
        private bool initialStart = true;
        private bool isDead = false;
        private bool isWin = false;

        public Engine(IDatabase database,IBoard board)
        {
            this.database = database;
            this.board = board;
        }

        public void Run()
        {
            while (true)
            {
                if (this.initialStart)
                {
                    Console.WriteLine(
                        "Lets play \"Minesweeper\". Try to find all cells without bombs."
                        + " Type 'top' for top 5 player's list, 'restart' for new game, 'exit' for quit!");
                    PrintField(this.board.GameField);
                    this.initialStart = false;
                }

                Console.Write("Enter row and column : ");
                string command = Console.ReadLine().Trim();
                this.ExecuteCommands(command);
                this.Update();
            }
        }

        protected virtual void ExecuteCommands(string command)
        {
            switch (command)
            {
                case "top":
                    PrintTopPlayers(this.database.TopPlayers);
                    break;
                case "restart":
                    RestartGame();
                    break;
                case "exit":
                    Console.WriteLine("Bye,bye :)) !");
                    Environment.Exit(0);
                    break;
                default:
                    try
                    {
                        CheckForCorrectInput(command);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Invalid command");
                        break;
                    }
                    catch (InvalidFieldRow)
                    {
                        Console.WriteLine("Invalid input row of the field");
                        break;
                    }
                    catch (InvalidFieldColumn)
                    {
                        Console.WriteLine("Invalid input col of the field");
                        break;
                    }

                    this.OpenCell();
                    break;
            }
        }

        private void Update()
        {
            if (this.isDead)
            {
                this.ReviewField(this.board.Bombs);
                
                Console.Write("\nHrrrrrr! You are dead. You made {0} points. " + "Enter your name: ", this.playerPoints);
                string playerName = Console.ReadLine();
                Player player = new Player(playerName, this.playerPoints);
                if (this.database.TopPlayers.Count < 5)
                {
                    this.database.TopPlayers.Add(player);
                }
                else
                {
                    for (int i = 0; i < this.database.TopPlayers.Count; i++)
                    {
                        if (this.database.TopPlayers[i].Points < player.Points)
                        {
                            this.database.TopPlayers.Insert(i, player);
                            this.database.TopPlayers.RemoveAt(this.database.TopPlayers.Count - 1);
                            break;
                        }
                    }
                }

                this.database.TopPlayers.Sort((IPlayer r1, IPlayer r2) => r2.Name.CompareTo(r1.Name));
                this.database.TopPlayers.Sort((IPlayer r1, IPlayer r2) => r2.Points.CompareTo(r1.Points));
                PrintTopPlayers(this.database.TopPlayers);

                this.board.CreateTheField();
                this.board.PlantBombs();
                this.playerPoints = 0;
                isDead = false;
                initialStart = true;
            }

            if (this.isWin)
            {
                Console.WriteLine("\nGood job! You find all {0} cells.",CellsInField);
                PrintField(this.board.Bombs);

                Console.WriteLine("Enter your name: ");
                string playerName = Console.ReadLine();

                Player player = new Player(playerName, this.playerPoints);
                this.database.TopPlayers.Add(player);
                PrintTopPlayers(this.database.TopPlayers);

                this.board.CreateTheField();
                this.board.PlantBombs();
                this.playerPoints = 0;
                this.isDead = false;
                initialStart = true;
            }
        }

        private void CheckForCorrectInput(string command)
        {
            if (command.Length > 3)
            {
                throw new ArgumentException();
            }
            if (!int.TryParse(command[0].ToString(), out this.playerRow) ||
                    this.playerRow >= this.board.GameField.GetLength(0))
            {
                    throw new InvalidFieldRow();
            }

            if (!int.TryParse(command[2].ToString(), out this.playerCol) ||
                this.playerCol >= this.board.GameField.GetLength(1))
            {
                throw new InvalidFieldColumn();
            }
            
            
        }

        private void OpenCell()
        {
            if (this.board.Bombs[this.playerRow, this.playerCol] != '*')
            {
                if (this.board.Bombs[this.playerRow, this.playerCol] == '-')
                {
                    this.FindNearBombs();
                    this.playerPoints++;
                }

                if (CellsInField == this.playerPoints)
                {
                    this.isWin = true;
                }
                else
                {
                    PrintField(this.board.GameField);
                }
            }
            else
            {
                this.isDead = true;
            }

        }

        private void FindNearBombs()
        {
            char surroundingBombs = CountSurroundingBombs(this.board.Bombs,this.playerRow,this.playerCol);
            this.board.Bombs[this.playerRow, this.playerCol] = surroundingBombs;
            this.board.GameField[this.playerRow, this.playerCol] = surroundingBombs;
        }

        private void PrintTopPlayers(IList<IPlayer> players)
        {
            Console.WriteLine("\nPoints:");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, players[i].Name, players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No top players at the moment!\n");
            }
        }


        private void PrintField(char[,] field)
        {
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(string.Format("{0} ", field[row, col]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private void RestartGame()
        {
            this.board.CreateTheField();
            this.board.PlantBombs();
            PrintField(this.board.GameField);
            isDead = false;
            initialStart = false;
        }

        private void ReviewField(char[,] field)
        {
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (field[row, col] != '*')
                    {
                        char surroundingBombs = CountSurroundingBombs(field,row,col);
                        field[row, col] = surroundingBombs;
                    }
                }
            }

            this.PrintField(field);
        }

        private char CountSurroundingBombs(char[,] bombs, int row, int col)
        {
            int surroundingBombs = 0;
            int bombRows = bombs.GetLength(0);
            int bombCols = bombs.GetLength(1);

            int minRow = Math.Max(row - 1, 0);
            int maxRow = Math.Min(row + 1, bombRows - 1);
            int minCol = Math.Max(col - 1, 0);
            int maxCol = Math.Min(col + 1, bombCols - 1);

            for (int currentRow = minRow; currentRow <= maxRow; currentRow++)
            {
                for (int currentCol = minCol; currentCol <= maxCol; currentCol++)
                {
                    if (currentRow == row && currentCol == col)
                    {
                        continue;
                    }

                    if (bombs[currentRow, currentCol] == '*')
                    {
                        surroundingBombs++;
                    }
                }
            }

            return char.Parse(surroundingBombs.ToString());
        }
    }
}
