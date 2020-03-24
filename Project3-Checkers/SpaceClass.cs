/*
 * Programmers:     Braeden Trautz + Colin Gilchrist
 * Year:            Early 2020
 * Assignment:      Project III - Modified Checkers
 * Professor:       Frank L Friedman
 * Class:           CIS 3309 Section 1 - Component Based Software Design
 * File:            SpaceClass.cs
 * Description:     The SpaceClass datatype is meant to represent one of the squares
 *                      that makes up the checker board.  Each SpaceClass object contains
 *                      it's row and col coordinates as well as the piece that is currently
 *                      on the space and a boolean for its' color.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_Checkers
{
    class SpaceClass
    {

        private int col, row;               // references where on the board the space is
        private PieceClass currentPiece;    // the piece that is on this space
        private Boolean isBlack;            // is this piece black? (actually red)  

        /// <summary>
        /// Parameterized constructor to create a space on board
        ///     with location "row, col"
        /// </summary>
        /// <param name="row"> The index of the row the piece is at </param>
        /// <param name="col"> The index of the column the piece is at </param>
        public SpaceClass(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        /// <summary>
        /// Gets the piece that is located inside of the space
        /// </summary>
        /// <returns> An instance of a piece or null if space is empty </returns>
        public PieceClass getPiece()
        {
            return this.currentPiece;
        }
        
        /// <summary>
        /// When given a piece, it sets that as the current piece in this space
        /// </summary>
        /// <param name="newPiece"> Piece to put on this space </param>
        public void setPiece(PieceClass newPiece)
        {
            this.currentPiece = newPiece;
        }

        /// <summary>
        /// Sets the current piece on the space to null.
        ///     For use when there's no piece here.
        /// </summary>
        public void pieceNull()
        {
            this.currentPiece = null;
        }

        /// <summary>
        /// Gets the index of the column of the space
        /// </summary>
        /// <returns> An integer </returns>
        public int getCol()
        {
            return this.col;
        }

        /// <summary>
        /// Gets the index of the row of the space
        /// </summary>
        /// <returns> An integer </returns>
        public int getRow()
        {
            return this.row;
        }

        /// <summary>
        /// Returns true if the space is a black space
        /// </summary>
        /// <returns> A boolean </returns>
        public Boolean getIsBlack()
        {
            return this.isBlack;
        }

        /// <summary>
        /// Sets the "isBlack" status of this space
        /// </summary>
        /// <param name="isBlack"> True if the space is black, false if not </param>
        public void setIsBlack(Boolean isBlack)
        {
            this.isBlack = isBlack;
        }

        /// <summary>
        /// Determines if there is a piece in this space or not.
        /// </summary>
        /// <returns> A boolean </returns>
        public Boolean hasPiece()
        {
            if (currentPiece == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
