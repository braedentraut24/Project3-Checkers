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

        /// <summary>
        /// Parameterless Constructor - Creates an 8x8 board and 
        ///     properly initializes the pieces attributes.
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="curPlayer"></param>
        /// <returns></returns>
        public Boolean isValidPiece(int row, int col, PlayerClass curPlayer)
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
        public Boolean isValidMove(SpaceClass moveTo, SpaceClass moveFrom, PlayerClass curPlayer)
        {
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

            //TODO: Write the code for jumping a piece
            
            return false;   //Temprorary to prevent errors

            //TODO: Write the code for king pieces moving
            
        }

        /// <summary>
        /// Moves a piece from the given space to the other space
        /// </summary>
        /// <param name="moveTo"> Space on board where the player is going to move their piece </param>
        /// <param name="moveFrom"> Space on board where the player is moving from </param>
        public void movePiece(SpaceClass moveTo, SpaceClass moveFrom)
        {
            //TODO set the location of the piece at moveFrom to moveTo
        }
    }
}
