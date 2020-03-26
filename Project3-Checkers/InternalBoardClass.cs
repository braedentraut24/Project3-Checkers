/*
 * Programmers:     Braeden Trautz + Colin Gilchrist
 * Year:            Early 2020
 * Assignment:      Project III - Modified Checkers
 * Professor:       Frank L Friedman
 * Class:           CIS 3309 Section 1 - Component Based Software Design
 * File:            InternalBoardClass.cs
 * Description:     The InternalBoardClass datatype is meant to represent the board or table
 *                      on which the game is played.  It contains a 2D array of spaces of size
 *                      8 by 8.  Validates and performs moves of pieces on the board.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_Checkers
{
    class InternalBoardClass
    {
        private SpaceClass[,] hiddenBoard;      // 2D Array representation of the table / board
        private SpaceClass capturedSpace;   //reference to a space with a piece that got captured during a move. is null if no capturing happened
        private PlayerClass curPlayer;      //Reference to the player whos turn it is

        /// <summary>
        /// Parameterless Constructor - Creates an 8x8 board and 
        ///     properly initializes the pieces attributes.
        /// </summary>
        public InternalBoardClass()
        {
            this.hiddenBoard = new SpaceClass[8, 8];
            this.curPlayer = DriverForm.p1;

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
                        hiddenBoard[row, col].setPiece(new PieceClass(DriverForm.p1));
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
                        hiddenBoard[row, col].setPiece(new PieceClass(DriverForm.p2));
                    }
                }
            }
        }   //End constructor

        //Switches the current player from one to the other
        //Should be called after each turn
        public void switchCurPlayer()
        {
            if (curPlayer == DriverForm.p1)
            {
                curPlayer = DriverForm.p2;
            }
            else if (curPlayer == DriverForm.p2)
            {
                curPlayer = DriverForm.p1;
            }
        }

        public SpaceClass[,] getHiddenBoard()
        {
            return hiddenBoard;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="curPlayer"></param>
        /// <returns></returns>
        public Boolean isValidPiece(int row, int col)
        {
            if (hiddenBoard[row, col].hasPiece() && hiddenBoard[row, col].getPiece().getPlayer() == curPlayer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determines if where the player clicked is a valid end location 
        ///     for a movement.
        /// </summary>
        /// <param name="moveTo"> Space on board where the player is going to move their piece </param>
        /// <param name="moveFrom"> Space on board where the player is moving from </param>
        /// <param name="curPlayer"> The player currently moving their piece </param>
        /// <returns></returns>
        public Boolean isValidMove(SpaceClass moveTo, SpaceClass moveFrom)
        {
            capturedSpace = null;
            //Cant move to a space with a piece on it
            if (moveTo.hasPiece())
            {
                return false;
            }

            //These 2 else ifs are to prevent the pieces from going backwards
            else if (curPlayer == DriverForm.p1 && moveTo.getRow() < moveFrom.getRow())
            {
                return false;
            }

            else if (curPlayer == DriverForm.p2 && moveTo.getRow() > moveFrom.getRow())
            {
                return false;
            }

            //This would be a valid "slide" move
            else if ((Math.Abs(moveTo.getRow() - moveFrom.getRow()) == 1) && (Math.Abs(moveTo.getCol() - moveFrom.getCol()) == 1))
            {
                return true;
            }

            //This would be a valid "jump" move
            else if ((Math.Abs(moveTo.getRow() - moveFrom.getRow()) == 2) && (Math.Abs(moveTo.getCol() - moveFrom.getCol()) == 2))
            {
                if (curPlayer == DriverForm.p1)
                {
                    if (moveFrom.getCol() < moveTo.getCol() && hiddenBoard[moveFrom.getRow() - 1, moveFrom.getCol() - 1].hasPiece())
                    {
                        if (hiddenBoard[moveFrom.getRow() - 1, moveFrom.getCol() - 1].getPiece().getPlayer() == DriverForm.p2)
                        {
                            capturedSpace = hiddenBoard[moveFrom.getRow() - 1, moveFrom.getCol() - 1];
                            return true;
                        }
                    }

                    else if (moveFrom.getCol() > moveTo.getCol() && hiddenBoard[moveFrom.getRow() - 1, moveFrom.getCol() + 1].hasPiece())
                    {
                        if (hiddenBoard[moveFrom.getRow() - 1, moveFrom.getCol() + 1].getPiece().getPlayer() == DriverForm.p2)
                        {
                            capturedSpace = hiddenBoard[moveFrom.getRow() - 1, moveFrom.getCol() + 1];
                            return true;
                        }
                    }
                }

                else if (curPlayer == DriverForm.p2)
                {
                     if (moveFrom.getCol() < moveTo.getCol() && hiddenBoard[moveFrom.getRow() + 1, moveFrom.getCol() - 1].hasPiece())
                    {
                        if (hiddenBoard[moveFrom.getRow() + 1, moveFrom.getCol() - 1].getPiece().getPlayer() == DriverForm.p1)
                        {
                            capturedSpace = hiddenBoard[moveFrom.getRow() + 1, moveFrom.getCol() - 1];
                            return true;
                        }
                    }

                    else if (moveFrom.getCol() > moveTo.getCol() && hiddenBoard[moveFrom.getRow() + 1, moveFrom.getCol() + 1].hasPiece())
                    {
                        if (hiddenBoard[moveFrom.getRow() + 1, moveFrom.getCol() + 1].getPiece().getPlayer() == DriverForm.p1)
                        {
                            capturedSpace = hiddenBoard[moveFrom.getRow() + 1, moveFrom.getCol() + 1];
                            return true;
                        }
                    }   //End jump move code
                }
            }

            return false;

            //TODO: Write the code for king pieces moving
            
        }

        /// <summary>
        /// Moves a piece from the given space to the other space
        /// </summary>
        /// <param name="moveTo"> Space on board where the player is going to move their piece </param>
        /// <param name="moveFrom"> Space on board where the player is moving from </param>
        public void movePiece(SpaceClass moveTo, SpaceClass moveFrom)
        {
            moveTo.setPiece(moveFrom.getPiece());
            moveFrom.pieceNull();

            //Takes away from the correct player's pieceCount if a capture happened
            if (capturedSpace != null)
            {
                capturedSpace.pieceNull();
                if (curPlayer == DriverForm.p1)
                {
                    DriverForm.p2.lostPiece(true);
                }
                else if (curPlayer == DriverForm.p2)
                {
                    DriverForm.p1.lostPiece(true);
                }
            }
        }
    }
}
