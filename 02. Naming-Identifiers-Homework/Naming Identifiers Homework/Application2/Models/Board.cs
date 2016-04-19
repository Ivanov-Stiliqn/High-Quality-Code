using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application2.Contracts;

namespace Application2.Models
{
    public class Board : IBoard
    {
        private int rows;
        private int cols;
        private readonly char[,] gameField;
        private readonly char[,] bombs;

        public Board(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.gameField=new char[this.Rows,this.Cols];
            this.bombs=new char[this.Rows,this.Cols];
            this.CreateTheField();
            this.PlantBombs();
        }

        public int Rows {
            get { return this.rows; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Rows of the field cannot be neggative");
                }
                this.rows = value;
            } 
        }

        public int Cols
        {
            get { return this.cols; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Cols of the field cannot be neggative");
                }
                this.cols = value;
            }
        }

        public char[,] GameField
        {
            get { return this.gameField; }
        }

        public char[,] Bombs
        {
            get { return this.bombs; }
        }


        public void CreateTheField()
        {

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    this.GameField[i, j] = '?';
                }
            }
        }

        public void PlantBombs()
        {
            
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    this.Bombs[i, j] = '-';
                }
            }

            List<int> r3 = new List<int>();
            while (r3.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!r3.Contains(asfd))
                {
                    r3.Add(asfd);
                }
            }

            foreach (int i2 in r3)
            {
                int col = i2 / this.Cols;
                int row = i2 % this.Cols;
                if (row == 0 && i2 != 0)
                {
                    col--;
                    row = this.Cols;
                }
                else
                {
                    row++;
                }

                this.Bombs[col, row - 1] = '*';
            }
        }


    }
}
