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
                Player p1 = new Player(txtP1Name.Text, Convert.ToChar(txtP1Char.Text));
                Player p2 = new Player(txtP2Name.Text, Convert.ToChar(txtP2Char.Text));
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

        private void createTable()
        {
            int ButtonWidth = 40;
            int ButtonHeight = 40;
            int Distance = 20;
            int start_x = 10;
            int start_y = 10;

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Button tmpButton = new Button();
                    tmpButton.Top = start_x + (x * ButtonHeight + Distance);
                    tmpButton.Left = start_y + (y * ButtonWidth + Distance);
                    tmpButton.Width = ButtonWidth;
                    tmpButton.Height = ButtonHeight;
                    tmpButton.Text = "X: " + x.ToString() + " Y: " + y.ToString();
                    tmpButton.Font = new Font("Arial", 8);
                    // Possible add Buttonclick event etc..
                    this.Controls.Add(tmpButton);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
