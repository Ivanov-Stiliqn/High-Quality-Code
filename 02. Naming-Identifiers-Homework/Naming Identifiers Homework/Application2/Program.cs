using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application2.Contracts;
using Application2.Core;
using Application2.Models;

namespace mini4ki
{
    public class Minesweeper
    {

        private static void Main()
        {
            const int boardRows = 5;
            const int boardCols = 10;

            IDatabase database=new Database();
            IBoard board = new Board(boardRows,boardCols);
   
            IRunnable engine=new Engine(database,board);

            engine.Run();
        }
    }
}