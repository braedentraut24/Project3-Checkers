using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_Checkers
{
    class PieceClass
    {
        private Boolean isPlayerOne;    //to determine which player owns this piece
        private Boolean isKing; //to determine if this piece is a king or not

        public PieceClass(Boolean isPlayer1)
        {
            this.isPlayerOne = isPlayer1;
            this.isKing = false;
        }

        public Boolean getIsPlayerOne()
        {
            return this.isPlayerOne;
        }

        public Boolean getIsKing()
        {
            return this.isKing;
        }

        public void makeKing()
        {
            this.isKing = true;
        }

    }
}
