using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Checkers
{
    class PlayerClass
    {

        // START ATTRIBUTES
        private int hiddenNumOfPieces;  // Number of pieces player has remaining on the board
        public string hiddenName;             // Player's Name
        public char hiddenPieceChar;          // Character to represent the player's pieces on the board
        // END ATTRIBUTES


        // START PROPERTIES
        public int numPieces
        {
            get
            {
                return hiddenNumOfPieces;
            }
        }
        public string name
        {
            get
            {
                return hiddenName;
            }
        }
        public char pieceChar
        {
            get
            {
                return hiddenPieceChar;
            }
        }
        // END PROPERTIES


        // METHODS ONLY BELOW

        /// <summary>
        /// Parameterized player constructor that sets number of starting
        ///     pieces on the board to 12.
        /// </summary>
        /// <param name="name"> Player's name </param>
        /// <param name="piece"> Character to represent player's pieces </param>
        public PlayerClass(string name, char piece)
        {
            hiddenName = name;
            hiddenPieceChar = piece;
            hiddenNumOfPieces = 12;
        }

        /// <summary>
        /// Decrements the amount of pieces the player has by 1
        /// </summary>
        public void lostPiece(bool showCount)
        {
            hiddenNumOfPieces--;

            if(showCount)
                MessageBox.Show("Player " + hiddenName + " has " + hiddenNumOfPieces + " pieces remaining.", "Piece Count Readout",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
