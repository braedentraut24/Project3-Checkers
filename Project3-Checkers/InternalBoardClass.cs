using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_Checkers
{
    class InternalBoardClass
    {
        private SpaceClass[,] hiddenBoard;
        private SpaceClass rightPath;
        private SpaceClass leftPath;

        public InternalBoardClass()
        {
            this.hiddenBoard = new SpaceClass[10, 10];

            for (int row = 1; row < 9; row++)
            {
                for (int col = 1; col < 9; col++)
                {
                    hiddenBoard[row, col] = new SpaceClass(row, col);
                }
            }
        }
    }
}
