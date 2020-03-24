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

        Button[,] newCell = new Button[8, 8];
        InternalBoardClass internalBoard = new InternalBoardClass();
        public static PlayerClass p1;
        public static PlayerClass p2;

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
                p1 = new PlayerClass(txtP1Name.Text, Convert.ToChar(txtP1Char.Text));
                p2 = new PlayerClass(txtP2Name.Text, Convert.ToChar(txtP2Char.Text));
                this.Controls.Clear();
                createTable();
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
            int ButtonWidth = 60;
            int ButtonHeight = 60;
            int Distance = 20;
            int start_x = 10;
            int start_y = 10;
            this.Size = new Size(550, 575);

            // Draw Buttons on screen as well as name and create EventHandler
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    newCell[row, col] = new Button();
                    newCell[row, col].Top = start_x + (row * ButtonHeight + Distance);
                    newCell[row, col].Left = start_y + (col * ButtonWidth + Distance);
                    newCell[row, col].Width = ButtonWidth;
                    newCell[row, col].Height = ButtonHeight;
                    newCell[row, col].Text = "r: " + row.ToString() + " c: " + col.ToString();
                    newCell[row, col].ForeColor = Color.Aqua;
                    newCell[row, col].Font = new Font("Arial", 8);
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
                            newCell[row, col].BackColor = Color.Red;
                        }
                        else
                        {
                            newCell[row, col].BackColor = Color.Black;
                        }
                    }
                    else
                    {
                        if (col % 2 == 0)
                        {
                            newCell[row, col].BackColor = Color.Black;
                        }
                        else
                        {
                            newCell[row, col].BackColor = Color.Red;
                        }
                    }
                }
            }

            // Draw label that will indicate which player is up for their turn.
            Label lblPlayerIndicator = new Label();
            lblPlayerIndicator.AutoSize = true;
            lblPlayerIndicator.Font = new Font("Arial", 12);
            lblPlayerIndicator.Location = new Point(0, 0);
            lblPlayerIndicator.Text = "Current Player: " + p1.name;
            this.Controls.Add(lblPlayerIndicator);
        }

        /// <summary>
        /// STUB
        /// </summary>
        private void Button_Click(object sender, EventArgs e)
        {
            int rowID = Convert.ToInt32(Convert.ToString(((Button)sender).Name[3]));
            int colID = Convert.ToInt32(Convert.ToString(((Button)sender).Name[4]));

            MessageBox.Show(((Button)sender).Name.ToString());
        }

        private void refreshBoard()
        {
            
        }
    }
}