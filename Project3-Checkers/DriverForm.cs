/*
 * Programmers:     Braeden Trautz + Colin Gilchrist
 * Year:            Early 2020
 * Assignment:      Project III - Modified Checkers
 * Professor:       Frank L Friedman
 * Class:           CIS 3309 Section 1 - Component Based Software Design
 * File:            DriverForm.cs
 * Description:     The Driver Form is just that: the form which drives the game.
 *                      This form allows users to enter their names and choices
 *                      of any keyboard character to represent their pieces on the board.
 *                      The form is then cleared and populated with a playable checkers game.
 * RULE CHANGES:    You can move any piece anywhere after you perform a jump, not just the same
 *                      piece making a jump again.  Also, you don't have to perform a jump
 *                      if you do not want to.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Checkers
{
    public partial class DriverForm : Form
    {
        private const int BoardSize = 8;
        Button[,] newCell = new Button[BoardSize, BoardSize];
        public static PlayerClass p1;
        public static PlayerClass p2;
        InternalBoardClass internalBoard;
        String curMove;
        SpaceClass moveTo;
        SpaceClass moveFrom;
        Label lblPlayerIndicator = new Label();
        
        /// <summary>
        /// Initializes the form.
        /// </summary>
        public DriverForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Quits the entire program
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Verifies the entries for player's names and pieces are valid and 
        ///     unique before clearing the form and drawing the game.
        /// </summary>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (validateEntries() == true)
            {
                p1 = new PlayerClass(txtP1Name.Text, txtP1Char.Text);
                p2 = new PlayerClass(txtP2Name.Text, txtP2Char.Text);
                internalBoard = new InternalBoardClass();
                this.Controls.Clear();
                createTable();
                curMove = "pick";
                refreshBoard();
            }
        }

        /// <summary>
        /// Validates the entries for names and pieces are both non-null and unique.
        /// </summary>
        /// <returns></returns>
        public bool validateEntries()
        {
            bool validEntries = true;
            if (txtP1Name.Text == "")
            {
                MessageBox.Show("Player one, please enter a name!", "P1 Missing Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validEntries = false;
                txtP1Name.Focus();
            }
            if (txtP1Char.Text == "")
            {
                MessageBox.Show("Player one, please enter a symbol for your checkers pieces!", "P1 Missing Symbol",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validEntries = false;
                txtP1Char.Focus();
            }
            if (txtP2Name.Text == "")
            {
                MessageBox.Show("Player two, please enter a name!", "P2 Missing Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validEntries = false;
                txtP2Name.Focus();
            }
            if (txtP2Char.Text == "")
            {
                MessageBox.Show("Player two, please enter a symbol for your checkers pieces!", "P2 Missing Symbol",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validEntries = false;
                txtP2Char.Focus();
            }
            if (txtP1Char.Text == txtP2Char.Text)
            {
                MessageBox.Show("Players cannot have the same symbol! Choose again.", "Non Unique Symbols",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validEntries = false;
                txtP1Char.Text = "";
                txtP2Char.Text = "";
                txtP1Char.Focus();
            }
            if (txtP1Name.Text == txtP2Name.Text)
            {
                MessageBox.Show("Players cannot have the same name! Choose agin.", "Non Unique Names",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validEntries = false;
                txtP1Name.Text = "";
                txtP2Name.Text = "";
                txtP1Name.Focus();
            }

            return validEntries;
        }

        /// <summary>
        /// Draws the buttons that act as spaces and colors 
        ///     them in a checker pattern.
        /// </summary>
        private void createTable()
        {
            this.Controls.Add(lblPlayerIndicator);
            lblPlayerIndicator.Location = new Point(0, 0);
            lblPlayerIndicator.Font = new Font("Arial", 14);
            lblPlayerIndicator.Visible = true;
            lblPlayerIndicator.Text = p1.name;
            lblPlayerIndicator.AutoSize = true;

            int ButtonWidth = 60;
            int ButtonHeight = 60;
            int Distance = 20;
            int start_x = 10;
            int start_y = 10;
            this.Size = new Size(550, 575);

            // Draw Buttons on screen as well as name and create EventHandler
            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    newCell[row, col] = new Button();
                    newCell[row, col].Top = start_x + (row * ButtonHeight + Distance);
                    newCell[row, col].Left = start_y + (col * ButtonWidth + Distance);
                    newCell[row, col].Width = ButtonWidth;
                    newCell[row, col].Height = ButtonHeight;
                    //newCell[row, col].Text = "r: " + row.ToString() + " c: " + col.ToString();
                    newCell[row, col].ForeColor = Color.Aqua;
                    newCell[row, col].Font = new Font("Consolas", 22, FontStyle.Bold);
                    newCell[row, col].Name = "btn" + row.ToString() + col.ToString();
                    newCell[row, col].Click += new EventHandler(Button_Click);
                    this.Controls.Add(newCell[row, col]);
                }
            }

            // Color the buttons in a checker pattern
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (row % 2 == 0)
                    {
                        if (col % 2 == 0)
                        {
                            newCell[row, col].BackColor = Color.Gray;
                        }
                        else
                        {
                            newCell[row, col].BackColor = Color.BurlyWood;
                        }
                    }
                    else
                    {
                        if (col % 2 == 0)
                        {
                            newCell[row, col].BackColor = Color.BurlyWood;
                        }
                        else
                        {
                            newCell[row, col].BackColor = Color.Gray;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// When a player chooses a piece, the piece is validated as theirs and the next action
        ///     is set to move.  Then, when they click another space, the space is validated
        ///     as a proper move.  If the player jumped a piece, the opponent's piece is removed
        ///     from the board and they go again.  Otherwise, the active player swaps and their
        ///     action is set to pick.
        /// </summary>
        private void Button_Click(object sender, EventArgs e)
        {
            int rowID = Convert.ToInt32(Convert.ToString(((Button)sender).Name[3]));
            int colID = Convert.ToInt32(Convert.ToString(((Button)sender).Name[4]));
            bool capturedPiece = false;

            switch (curMove)
            {
                case "pick":
                    if (internalBoard.isValidPiece(rowID, colID))
                    {
                        moveFrom = internalBoard.getHiddenBoard()[rowID, colID];
                        curMove = "move";
                        newCell[rowID, colID].ForeColor = Color.Red;
                    }
                    else
                    {
                        MessageBox.Show("There is no piece on that space or it is not your piece");
                    }
                    break;
                case "move":
                    moveTo = internalBoard.getHiddenBoard()[rowID, colID];

                    if(moveTo == moveFrom)
                    {
                        curMove = "pick";
                        MessageBox.Show("Piece unchosen, choose another.");
                        newCell[rowID, colID].ForeColor = Color.Black;
                        return;
                    }

                    if (internalBoard.isValidMove(moveTo, moveFrom))
                    {
                        internalBoard.movePiece(moveTo, moveFrom,ref capturedPiece);
                        if (!capturedPiece)
                        {
                            internalBoard.switchCurPlayer();
                        }
                        curMove = "pick";
                        refreshBoard();
                    }
                    else
                    {
                        MessageBox.Show("You cannot move your piece there");
                    }
                    break;
            }
        }

        /// <summary>
        /// Redraws the board and the pieces that are inside of the spaces.
        /// Also labels the top of the game with the appropriate current
        /// player.
        /// </summary>
        private void refreshBoard()
        {
            internalBoard.checkForKings();
            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    if (internalBoard.getHiddenBoard()[row, col].hasPiece())
                    {
                        if(internalBoard.getHiddenBoard()[row, col].getPiece().getPlayer() == p1)
                        {
                            newCell[row, col].Text = p1.hiddenSymbol;
                        }
                        else if (internalBoard.getHiddenBoard()[row, col].getPiece().getPlayer() == p2)
                        {
                            newCell[row, col].Text = p2.hiddenSymbol;
                        }
                        newCell[row, col].ForeColor = Color.Black;

                        if (internalBoard.getHiddenBoard()[row, col].getPiece().getIsKing())
                        {
                            newCell[row, col].Text += "*";
                        }
                    }
                    else
                    {
                        newCell[row, col].Text = "";
                    }
                }
            }
            lblPlayerIndicator.Text = "Current Player: " + internalBoard.player.name;
        }

    }
}