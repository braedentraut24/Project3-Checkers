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

            //Initializing spaces on the board
            for (int row = 1; row < 9; row++)
            {
                for (int col = 1; col < 9; col++)
                {
                    hiddenBoard[row, col] = new SpaceClass(row, col);

                    //Sets each piece as "black" or "not black" for 2 reasons
                    //1 is so we can initialize the pieces (pieces always start on black squares)
                    //2 is so we can stylize the board easier
                    if ((row % 2 == 0 && col % 2 == 0) || (row % 2 == 1 && col % 2 == 1))
                    {
                        hiddenBoard[row, col].setIsBlack(false);
                    }
                    else
                    {
                        hiddenBoard[row, col].setIsBlack(true);
                    }
                }
            }

            //Initializing the starting pieces for player 1
            for(int row = 1; row < 4; row++)
            {
                for (int col = 1; col < 9; col++)
                {
                    if (hiddenBoard[row,col].getIsBlack())
                    {
                        hiddenBoard[row, col].setPiece(new PieceClass(true));
                    }
                }
            }

            //Starting pieces for player 2
            for (int row = 8; row > 5; row--)
            {
                for (int col = 1; col < 9; col++)
                {
                    if (hiddenBoard[row, col].getIsBlack())
                    {
                        hiddenBoard[row, col].setPiece(new PieceClass(false));
                    }
                }
            }
        }
    }
}
