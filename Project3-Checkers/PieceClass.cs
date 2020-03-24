/*
 * Programmers:     Braeden Trautz + Colin Gilchrist
 * Year:            Early 2020
 * Assignment:      Project III - Modified Checkers
 * Professor:       Frank L Friedman
 * Class:           CIS 3309 Section 1 - Component Based Software Design
 * File:            PieceClass.cs
 * Description:     The PieceClass datatype is meant to represent a "piece" or chip on the checker
 *                      board which is moved by the player that owns it.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_Checkers
{
    class PieceClass
    {
        private Boolean isKing;     // To determine if this piece is a king or not
        private PlayerClass owner;  // The player that is in control of the piece

        /// <summary>
        /// Parameterized constructor - when given a PlayerClass,
        ///     makes a piece with that player as owner.
        /// </summary>
        /// <param name="owner"> Player who controls the piece </param>
        public PieceClass(PlayerClass owner)
        {
            this.owner = owner;
        }

        /// <summary>
        /// Gets the player who controls this piece
        /// </summary>
        /// <returns> An instance of a player </returns>
        public PlayerClass getPlayer()
        {
            return this.owner;
        }

        /// <summary>
        /// Determines if this piece is a king piece or not
        /// </summary>
        /// <returns> A boolean </returns>
        public Boolean getIsKing()
        {
            return this.isKing;
        }

        /// <summary>
        /// Makes this piece a kinged piece
        /// </summary>
        public void makeKing()
        {
            this.isKing = true;
        }

    }
}
