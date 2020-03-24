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

        public InternalBoardClass()
        {
            this.hiddenBoard = new SpaceClass[8, 8];

            //Initializing spaces on the board
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
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
            for(int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (hiddenBoard[row,col].getIsBlack())
                    {
                        hiddenBoard[row, col].setPiece(new PieceClass(true));
                    }
                }
            }

            //Starting pieces for player 2
            for (int row = 7; row > 4; row--)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (hiddenBoard[row, col].getIsBlack())
                    {
                        hiddenBoard[row, col].setPiece(new PieceClass(false));
                    }
                }
            }
        }   //End constructor

        //Makes sure the space has a piece and that piece belongs to the right player
        public Boolean validPiece(int row, int col, Boolean isPlayer1)
        {
            if (hiddenBoard[row, col].hasPiece() && hiddenBoard[row, col].getPiece().getIsPlayerOne() == isPlayer1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean validMove(SpaceClass moveTo, SpaceClass moveFrom, Boolean isPlayer1)
        {
            //Cant move to a space with a piece on it
            if (moveTo.hasPiece())
            {
                return false;
            }

            //These 2 else ifs are to prevent the pieces from going backwards
            else if (isPlayer1 && moveTo.getRow() < moveFrom.getRow())
            {
                return false;
            }

            else if (!isPlayer1 && moveTo.getRow() > moveFrom.getRow())
            {
                return false;
            }

            //This would be a valid "slide" move
            else if ((Math.Abs(moveTo.getRow() - moveFrom.getRow()) == 1) && (Math.Abs(moveTo.getCol() - moveFrom.getCol()) == 1))
            {
                return true;
            }

            //TODO: Write the code for jumping a piece
            
            return false;   //Temprorary to prevent errors

            //TODO: Write the code for king pieces moving
            
        }

        public void movePiece(SpaceClass moveTo, SpaceClass MoveFrom)
        {
            //TODO
        }
    }
}
