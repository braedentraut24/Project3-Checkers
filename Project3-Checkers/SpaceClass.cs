using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_Checkers
{
    class SpaceClass
    {

        private int col, row;   //references where on the board the space is
        private PieceClass currentPiece;    //the piece that is on this space
        private Boolean isBlack;

        public SpaceClass(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        public PieceClass getPiece()
        {
            return this.currentPiece;
        }
        
        public void setPiece(PieceClass newPiece)
        {
            this.currentPiece = newPiece;
        }

        //for when there is no piece on that space
        public void pieceNull()
        {
            this.currentPiece = null;
        }

        public int getCol()
        {
            return this.col;
        }

        public int getRow()
        {
            return this.row;
        }

        public Boolean getIsBlack()
        {
            return this.isBlack;
        }

        public void setIsBlack(Boolean isBlack)
        {
            this.isBlack = isBlack;
        }

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
