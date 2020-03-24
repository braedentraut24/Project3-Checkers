using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Checkers
{
    public class PlayerClass
    {

        // START ATTRIBUTES
        private int hiddenNumOfPieces;        // Number of pieces player has remaining on the board
        public string hiddenName;             // Player's Name
        public string hiddenSymbol;          // Character to represent the player's pieces on the board
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
        public string pieceChar
        {
            get
            {
                return hiddenSymbol;
            }
        }
        // END PROPERTIES


        // METHODS ONLY BELOW

        /// <summary>
        /// Parameterized player constructor that sets number of starting
        ///     pieces on the board to 12.
        /// </summary>
        /// <param name="name"> Player's name </param>
        /// <param name="symbol"> Character to represent player's pieces </param>
        public PlayerClass(string name, string symbol)
        {
            hiddenName = name;
            hiddenSymbol = symbol;
            hiddenNumOfPieces = 12;
        }

        /// <summary>
        /// Decrements the amount of pieces the player has on the board
        /// </summary>
        /// <param name="showCount"> Make true to display how many pieces are left after running </param>
        public void lostPiece(bool showCount)
        {
            hiddenNumOfPieces--;

            if(showCount)
                MessageBox.Show("Player " + hiddenName + " has " + hiddenNumOfPieces + " pieces remaining.", "Piece Count Readout",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
