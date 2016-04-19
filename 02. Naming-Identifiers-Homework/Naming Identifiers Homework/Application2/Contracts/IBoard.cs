using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2.Contracts
{
    public interface IBoard
    {
        int Rows { get; }

        int Cols { get; }

        char[,] GameField { get; }

        char[,] Bombs { get; }

        void CreateTheField();

        void PlantBombs();

    }
}
