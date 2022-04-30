using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TicTacToeLoad(object sender, EventArgs e)
        {
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    c.Click += new EventHandler(btn_click);
                }
            }
        }
        int XorO = 0;
        public void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (win == false)
            {
                if (btn.Text.Equals(""))
                {
                    if (XorO % 2 == 0)
                    {
                        btn.Text = "X";
                        btn.ForeColor = Color.Black;
                        label1.Text = "Next O";
                        getTheWinner();
                    }
                    else
                    {
                        btn.Text = "O";
                        btn.ForeColor = Color.White;
                        label1.Text = "Next X";
                        getTheWinner();
                    }
                    XorO++;
                }
            }
        }
        bool win = false;

        public void getTheWinner()
        {
            //int moves = 1;

            if (!button1.Text.Equals("") && button1.Text.Equals(button2.Text) && button1.Text.Equals(button3.Text))
            {
                winEffect(button1, button2, button3);
                win = true;
            }
            if (!button4.Text.Equals("") && button4.Text.Equals(button5.Text) && button4.Text.Equals(button6.Text))
            {
                winEffect(button4, button5, button6);
                win = true;
            }
            if (!button7.Text.Equals("") && button7.Text.Equals(button8.Text) && button7.Text.Equals(button9.Text))
            {
                winEffect(button7, button8, button9);
                win = true;
            }
            if (!button1.Text.Equals("") && button1.Text.Equals(button4.Text) && button1.Text.Equals(button7.Text))
            {
                winEffect(button1, button4, button7);
                win = true;
            }
            if (!button2.Text.Equals("") && button2.Text.Equals(button5.Text) && button2.Text.Equals(button8.Text))
            {
                winEffect(button2, button5, button8);
                win = true;
            }
            if (!button3.Text.Equals("") && button3.Text.Equals(button6.Text) && button3.Text.Equals(button9.Text))
            {
                winEffect(button3, button6, button9);
                win = true;
            }
            if (!button1.Text.Equals("") && button1.Text.Equals(button5.Text) && button1.Text.Equals(button9.Text))
            {
                winEffect(button1, button5, button9);
                win = true;
            }
            if (!button3.Text.Equals("") && button3.Text.Equals(button5.Text) && button3.Text.Equals(button7.Text))
            {
                winEffect(button3, button5, button7);
                win = true;
            }

            //moves++;
            //if (moves == 9 && win == false)
            //{
            //    label1.Text = "It is a tie!";
            //}

            if (AllBtnLength() == 9 && win == false)
            {
                label1.Text = "It is a tie!";
                foreach (Control c in panel2.Controls)
                {
                    if (c is Button)
                    {
                        c.BackColor = Color.DarkGray;
                    }
                }
            }
        }

        public int AllBtnLength()
        {
            int moves = 0;
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    moves += c.Text.Length;
                }
            }
            return moves;
        }

        public void winEffect(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.Yellow;
            b2.BackColor = Color.Yellow;
            b3.BackColor = Color.Yellow;

            b1.ForeColor = Color.Blue;
            b2.ForeColor = Color.Blue;
            b3.ForeColor = Color.Blue;

            label1.Text = b1.Text + " wins!";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            XorO = 0;
            win = false;
            label1.Text = "Play now";

            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    c.Text = "";
                    c.BackColor = Color.Silver;
                }
            }
        }
    }
}
