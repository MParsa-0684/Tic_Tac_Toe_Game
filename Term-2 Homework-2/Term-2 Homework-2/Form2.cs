using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Term_2_Homework_2
{
    public partial class Form2 : Form
    {
        public int turn = 0;
        public int One = 1;
        public int Two = 1;
        public int Three = 1;
        public int Four = 1;
        public int Five = 1;
        public int Six = 1;
        public int Seven = 1;
        public int Eight = 1;
        public int Nine = 1;
        public int counter = 0;
        public int enable = 0;
        public bool Win = false;


        public Form2()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void a1_Click(object sender, EventArgs e)
        {
            O.Text = "";
            label8.Text = "";
            turn = Convert.ToInt32(label1.Text);
            turn = turn + 1;
            label1.Text = turn.ToString();
            label1.Text = turn.ToString();
            if (turn % 2 == 0)
            {

                a1.Text = "X";
                a1.BackColor = Color.DarkRed;
                O.Text = "     Your Turn .";
            }
            if (turn % 2 == 1)
            {
                a1.Text = "O";
                a1.BackColor = Color.DarkGreen;
            }
            a1.Enabled = false;
            One = 0;
            if (a1.Text == a2.Text && a2.Text == a3.Text)
            {
                if (a1.Text == "X")
                {

                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Win = true;
                }
                if (a1.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
            }
            if (a1.Text == b1.Text && b1.Text == c1.Text)
            {
                if (a1.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (a1.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (a1.Text == b2.Text && b2.Text == c3.Text)
            {
                if (a1.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (a1.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (turn == 9 && Win == false)
            {
                MessageBox.Show("   The game equalised !", "Information");
            }
            if (Win == true)
            {
                O.Text = "     Game Finishid .";
            }

            computer_turn();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void a2_Click(object sender, EventArgs e)
        {

        }

        private void newPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("    By Parsa Arani", "Information");

        }

        private void whatIsOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have to write you name after ' O : ' for become an O player .", "What is ' O : ' ?");

        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void swicthWithComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void a2_Click_1(object sender, EventArgs e)
        {
            O.Text = "";
            label8.Text = "";

            turn = Convert.ToInt32(label1.Text);
            turn = turn + 1;
            label1.Text = turn.ToString();
            if (turn % 2 == 0)
            {
                a2.Text = "X";
                a2.BackColor = Color.DarkRed;
                O.Text = "     Your Turn .";

            }
            if (turn % 2 == 1)
            {
                a2.Text = "O";
                a2.BackColor = Color.DarkGreen;

            }
            a2.Enabled = false;
            if (a1.Text == a2.Text && a2.Text == a3.Text)
            {
                if (a2.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (a2.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;

                }

            }
            if (a2.Text == b2.Text && b2.Text == c2.Text)
            {
                if (a2.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (a2.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }
            }
            if (turn == 9 && Win == false)
            {
                MessageBox.Show("   The game equalised !", "Information");
            }
            if (Win == true)
            {
                O.Text = "     Game Finishid .";
            }

            computer_turn();

        }

        private void a3_Click(object sender, EventArgs e)
        {
            O.Text = "";
            label8.Text = "";

            turn = Convert.ToInt32(label1.Text);
            turn = turn + 1;
            label1.Text = turn.ToString();
            if (turn % 2 == 0)
            {
                a3.Text = "X";
                a3.BackColor = Color.DarkRed;
                O.Text = "     Your Turn .";

            }
            if (turn % 2 == 1)
            {
                a3.Text = "O";
                a3.BackColor = Color.DarkGreen;

            }
            a3.Enabled = false;
            if (a1.Text == a2.Text && a2.Text == a3.Text)
            {
                if (a3.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (a3.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (a3.Text == b3.Text && b3.Text == c3.Text)
            {
                if (a3.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (a3.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (a3.Text == b2.Text && b2.Text == c1.Text)
            {
                if (a3.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (a3.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (turn == 9 && Win == false)
            {
                MessageBox.Show("   The game equalised !", "Information");
            }
            if (Win == true)
            {
                O.Text = "     Game Finishid .";
            }

            computer_turn();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            O.Text = "";
            label8.Text = "";

            turn = Convert.ToInt32(label1.Text);
            turn = turn + 1;
            label1.Text = turn.ToString();
            if (turn % 2 == 0)
            {
                b1.Text = "X";
                b1.BackColor = Color.DarkRed;
                O.Text = "     Your Turn .";

            }
            if (turn % 2 == 1)
            {
                b1.Text = "O";
                b1.BackColor = Color.DarkGreen;

            }
            b1.Enabled = false;
            if (b1.Text == b2.Text && b2.Text == b3.Text)
            {
                if (b1.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (b1.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (a1.Text == b1.Text && b1.Text == c1.Text)
            {
                if (b1.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (b1.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (turn == 9 && Win == false)
            {
                MessageBox.Show("   The game equalised !", "Information");
            }
            if (Win == true)
            {
                O.Text = "     Game Finishid .";
            }

            computer_turn();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            O.Text = "";
            label8.Text = "";

            turn = Convert.ToInt32(label1.Text);
            turn = turn + 1;
            label1.Text = turn.ToString();
            if (turn % 2 == 0)
            {
                b2.Text = "X";
                b2.BackColor = Color.DarkRed;
                O.Text = "     Your Turn .";

            }
            if (turn % 2 == 1)
            {
                b2.Text = "O";
                b2.BackColor = Color.DarkGreen;

            }
            b2.Enabled = false;
            if (a1.Text == b2.Text && b2.Text == c3.Text)
            {
                if (b2.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (b2.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (a2.Text == b2.Text && b2.Text == c2.Text)
            {
                if (b2.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (b2.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (a3.Text == b2.Text && b2.Text == c1.Text)
            {
                if (b2.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (b2.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (b3.Text == b2.Text && b2.Text == b1.Text)
            {
                if (b2.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (b2.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (turn == 9 && Win == false)
            {
                MessageBox.Show("   The game equalised !", "Information");
            }
            if (Win == true)
            {
                O.Text = "     Game Finishid .";
            }

            computer_turn();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            O.Text = "";
            label8.Text = "";

            turn = Convert.ToInt32(label1.Text);
            turn = turn + 1;
            label1.Text = turn.ToString();
            if (turn % 2 == 0)
            {
                b3.Text = "X";
                b3.BackColor = Color.DarkRed;
                O.Text = "     Your Turn .";

            }
            if (turn % 2 == 1)
            {
                b3.Text = "O";
                b3.BackColor = Color.DarkGreen;

            }
            b3.Enabled = false;
            if (a3.Text == b3.Text && b3.Text == c3.Text)
            {
                if (b3.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (b3.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (b1.Text == b2.Text && b2.Text == b3.Text)
            {
                if (b3.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (b3.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (turn == 9 && Win == false)
            {
                MessageBox.Show("   The game equalised !", "Information");
            }
            if (Win == true)
            {
                O.Text = "     Game Finishid .";
            }

            computer_turn();
        }

        private void c1_Click(object sender, EventArgs e)
        {
            O.Text = "";
            label8.Text = "";

            turn = Convert.ToInt32(label1.Text);
            turn = turn + 1;
            label1.Text = turn.ToString();
            if (turn % 2 == 0)
            {
                c1.Text = "X";
                c1.BackColor = Color.DarkRed;
                O.Text = "     Your Turn .";


            }
            if (turn % 2 == 1)
            {
                c1.Text = "O";
                c1.BackColor = Color.DarkGreen;

            }
            c1.Enabled = false;
            if (a1.Text == b1.Text && b1.Text == c1.Text)
            {
                if (c1.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (c1.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (c1.Text == b2.Text && b2.Text == a3.Text)
            {
                if (c1.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (c1.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;

                }

            }
            if (c1.Text == c2.Text && c2.Text == c3.Text)
            {
                if (c1.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (c1.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }

            if (turn == 9 && Win == false)
            {
                MessageBox.Show("   The game equalised !", "Information");
            }
            if (Win == true)
            {
                O.Text = "     Game Finishid .";
            }

            computer_turn();
        }

        private void c2_Click(object sender, EventArgs e)
        {
            O.Text = "";
            label8.Text = "";

            turn = Convert.ToInt32(label1.Text);
            turn = turn + 1;
            label1.Text = turn.ToString();
            if (turn % 2 == 0)
            {
                c2.Text = "X";
                c2.BackColor = Color.DarkRed;
                O.Text = "     Your Turn .";

            }
            if (turn % 2 == 1)
            {
                c2.Text = "O";
                c2.BackColor = Color.DarkGreen;

            }
            c2.Enabled = false;
            if (a2.Text == b2.Text && b2.Text == c2.Text)
            {
                if (c2.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (c2.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (c1.Text == c2.Text && c2.Text == c3.Text)
            {
                if (c2.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (c2.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (turn == 9 && Win == false)
            {
                MessageBox.Show("   The game equalised !", "Information");
            }
            if (Win == true)
            {
                O.Text = "     Game Finishid .";
            }

            computer_turn();
       }

        private void c3_Click(object sender, EventArgs e)
        {
            O.Text = "";
            label8.Text = "";

            turn = Convert.ToInt32(label1.Text);
            turn = turn + 1;
            label1.Text = turn.ToString();
            if (turn % 2 == 0)
            {
                c3.Text = "X";
                c3.BackColor = Color.DarkRed;
                O.Text = "     Your Turn .";

            }
            if (turn % 2 == 1)
            {
                c3.Text = "O";
                c3.BackColor = Color.DarkGreen;
            }
            c3.Enabled = false;
            if (a3.Text == b3.Text && b3.Text == c3.Text)
            {
                if (c3.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (c3.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (a1.Text == b2.Text && b2.Text == c3.Text)
            {
                if (c3.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (c3.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (a1.Text == c2.Text && c2.Text == c3.Text)
            {
                if (c3.Text == "X")
                {
                    MessageBox.Show("  You won " + label5.Text, "Congratulations");
                    Disable();

                    Win = true;

                }
                if (c3.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();

                    Win = true;


                }

            }
            if (turn == 9 && Win == false)
            {
                MessageBox.Show("   The game equalised !", "Information");
            }
            if (Win == true)
            {
                O.Text = "     Game Finishid .";
            }

            computer_turn();
        }
        public void computer_turn()
        {
            turn = Convert.ToInt32(label1.Text);
            turn = turn + 1;
            label1.Text = turn.ToString();

            Random rnd = new Random();
            while (counter < 10)
            {
                enable = rnd.Next(1, 10);
                if (enable == 1 && a1.Enabled == true)
                {
                    if (turn % 2 == 0)
                    {

                        a1.Text = "X";
                        a1.BackColor = Color.DarkRed;
                        O.Text = "     Your Turn .";

                    }
                    if (turn % 2 == 1)
                    {
                        a1.Text = "O";
                        a1.BackColor = Color.DarkGreen;
                    }
                    a1.Enabled = false;
                    One = 0;
                    if (a1.Text == a2.Text && a2.Text == a3.Text)
                    {
                        if (a1.Text == "X")
                        {

                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;


                        }
                        if (a1.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;


                        }
                    }
                    if (a1.Text == b1.Text && b1.Text == c1.Text)
                    {
                        if (a1.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (a1.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;


                        }

                    }
                    if (a1.Text == b2.Text && b2.Text == c3.Text)
                    {
                        if (a1.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (a1.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;


                        }

                    }
                    if (Win == true)
                    {
                        O.Text = "     Game Finishid .";
                    }

                    break;

                
                }
                if (enable == 2 && a2.Enabled == true)
                {
                    if (turn % 2 == 0)
                    {

                        a2.Text = "X";
                        a2.BackColor = Color.DarkRed;
                        O.Text = "     Your Turn .";

                    }
                    if (turn % 2 == 1)
                    {
                        a2.Text = "O";
                        a2.BackColor = Color.DarkGreen;
                    }
                    a2.Enabled = false;
                    Two = 0;
                    if (a1.Text == a2.Text && a2.Text == a3.Text)
                    {
                        if (a2.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (a2.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;


                        }

                    }
                    if (a2.Text == b2.Text && b2.Text == c2.Text)
                    {
                        if (a2.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (a2.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;


                        }

                    }
                    if (Win == true)
                    {
                        O.Text = "     Game Finishid .";
                    }

                    break;

                }
                if (enable == 3 && a3.Enabled == true)
                {
                    if (turn % 2 == 0)
                    {

                        a3.Text = "X";
                        a3.BackColor = Color.DarkRed;
                        O.Text = "     Your Turn .";

                    }
                    if (turn % 2 == 1)
                    {
                        a3.Text = "O";
                        a3.BackColor = Color.DarkGreen;
                    }
                    a3.Enabled = false;
                    Three = 0;
                    if (a1.Text == a2.Text && a2.Text == a3.Text)
                    {
                        if (a3.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (a3.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }

                    }
                    if (a3.Text == b3.Text && b3.Text == c3.Text)
                    {
                        if (a3.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (a3.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }

                    }
                    if (a3.Text == b2.Text && b2.Text == c1.Text)
                    {
                        if (a3.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (a3.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }

                    }
                    if (Win == true)
                    {
                        O.Text = "     Game Finishid .";
                    }

                    break;
                }
                if (enable == 4 && b1.Enabled == true)
                {
                    if (turn % 2 == 0)
                    {

                        b1.Text = "X";
                        b1.BackColor = Color.DarkRed;
                        O.Text = "     Your Turn .";

                    }
                    if (turn % 2 == 1)
                    {
                        b1.Text = "O";
                        b1.BackColor = Color.DarkGreen;
                    }
                    b1.Enabled = false;
                    Four = 0;
                    if (b1.Text == b2.Text && b2.Text == b3.Text)
                    {
                        if (b1.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (b1.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;


                        }

                    }
                    if (a1.Text == b1.Text && b1.Text == c1.Text)
                    {
                        if (b1.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (b1.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }

                    }
                    if (Win == true)
                    {
                        O.Text = "     Game Finishid .";
                    }

                    break;
                }

                if (enable == 5 && b2.Enabled == true)
                {
                    if (turn % 2 == 0)
                    {

                        b2.Text = "X";
                        b2.BackColor = Color.DarkRed;
                        O.Text = "     Your Turn .";

                    }
                    if (turn % 2 == 1)
                    {
                        b2.Text = "O";
                        b2.BackColor = Color.DarkGreen;
                    }
                    b2.Enabled = false;
                    Five = 0;
                    if (a1.Text == b2.Text && b2.Text == c3.Text)
                    {
                        if (b2.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (b2.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;


                        }

                    }
                    if (a2.Text == b2.Text && b2.Text == c2.Text)
                    {
                        if (b2.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (b2.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;


                        }

                    }
                    if (a3.Text == b2.Text && b2.Text == c1.Text)
                    {
                        if (b2.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (b2.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }

                    }
                    if (b3.Text == b2.Text && b2.Text == b1.Text)
                    {
                        if (b2.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (b2.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;


                        }

                    }
                    if (Win == true)
                    {
                        O.Text = "     Game Finishid .";
                    }

                    break;
                }
                if (enable == 6 && b3.Enabled == true)
                {
                    if (turn % 2 == 0)
                    {

                        b3.Text = "X";
                        b3.BackColor = Color.DarkRed;
                        O.Text = "     Your Turn .";

                    }
                    if (turn % 2 == 1)
                    {
                        b3.Text = "O";
                        b3.BackColor = Color.DarkGreen;
                    }
                    b3.Enabled = false;
                    Six = 0;
                    if (a3.Text == b3.Text && b3.Text == c3.Text)
                    {
                        if (b3.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (b3.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }

                    }
                    if (b1.Text == b2.Text && b2.Text == b3.Text)
                    {
                        if (b3.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (b3.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;


                        }

                    }
                    if (Win == true)
                    {
                        O.Text = "     Game Finishid .";
                    }

                    break;
                }


                if (enable == 7 && c1.Enabled == true)
                {
                    if (turn % 2 == 0)
                    {

                        c1.Text = "X";
                        c1.BackColor = Color.DarkRed;
                        O.Text = "     Your Turn .";

                    }
                    if (turn % 2 == 1)
                    {
                        c1.Text = "O";
                        c1.BackColor = Color.DarkGreen;
                    }
                    c1.Enabled = false;
                    Seven = 0;
                    if (a1.Text == b1.Text && b1.Text == c1.Text)
                    {
                        if (c1.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (c1.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }

                    }
                    if (c1.Text == b2.Text && b2.Text == a3.Text)
                    {
                        if (c1.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (c1.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;


                        }

                    }
                    if (c1.Text == c2.Text && c2.Text == c3.Text)
                    {
                        if (c1.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (c1.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }

                    }
                    if (Win == true)
                    {
                        O.Text = "     Game Finishid .";
                    }

                    break;
                }

                if (enable == 8 && c2.Enabled == true)
                {
                    if (turn % 2 == 0)
                    {

                        c2.Text = "X";
                        c2.BackColor = Color.DarkRed;
                        O.Text = "     Your Turn .";

                    }
                    if (turn % 2 == 1)
                    {
                        c2.Text = "O";
                        c2.BackColor = Color.DarkGreen;
                    }
                    c2.Enabled = false;
                    Eight = 0;
                    if (a2.Text == b2.Text && b2.Text == c2.Text)
                    {
                        if (c2.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (c2.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;


                        }

                    }
                    if (c1.Text == c2.Text && c2.Text == c3.Text)
                    {
                        if (c2.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (c2.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }

                    }
                    if (Win == true)
                    {
                        O.Text = "     Game Finishid .";
                    }

                    break;
                }

                if (enable == 9 && c3.Enabled == true)
                {
                    if (turn % 2 == 0)
                    {

                        c3.Text = "X";
                        c3.BackColor = Color.DarkRed;
                        O.Text = "     Your Turn .";

                    }
                    if (turn % 2 == 1)
                    {
                        c3.Text = "O";
                        c3.BackColor = Color.DarkGreen;
                    }
                    c3.Enabled = false;
                    Nine = 0;
                    if (a3.Text == b3.Text && b3.Text == c3.Text)
                    {
                        if (c3.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (c3.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }

                    }
                    if (a1.Text == b2.Text && b2.Text == c3.Text)
                    {
                        if (c3.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();

                            Win = true;

                        }
                        if (c3.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();

                            Win = true;


                        }

                    }
                    if (a1.Text == c2.Text && c2.Text == c3.Text)
                    {
                        if (c3.Text == "X")
                        {
                            MessageBox.Show("  You won " + label5.Text, "Congratulations");
                            Disable();
                            Win = true;

                        }
                        if (c3.Text == "O")
                        {
                            MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                            Disable();
                            Win = true;


                        }

                    }
                    if (Win == true)
                    {
                        O.Text = "     Game Finishid .";
                    }

                    break;
                }





                counter++;

            }
            if (turn == 9 && Win == false)
            {
                MessageBox.Show("   The game equalised !", "Information");
            }


        }

        private void startNewGameWithComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            a1.Text = "";
            a1.Enabled = true;
            a1.BackColor = Color.SteelBlue;
            a2.Text = "";
            a2.Enabled = true;
            a2.BackColor = Color.SteelBlue;
            a3.Text = "";
            a3.Enabled = true;
            a3.BackColor = Color.SteelBlue;
            b1.Text = "";
            b1.Enabled = true;
            b1.BackColor = Color.SteelBlue;
            b2.Text = "";
            b2.Enabled = true;
            b2.BackColor = Color.SteelBlue;
            b3.Text = "";
            b3.Enabled = true;
            b3.BackColor = Color.SteelBlue;
            c1.Text = "";
            c1.Enabled = true;
            c1.BackColor = Color.SteelBlue;
            c2.Text = "";
            c2.Enabled = true;
            c2.BackColor = Color.SteelBlue;
            c3.Text = "";
            c3.Enabled = true;
            c3.BackColor = Color.SteelBlue;
            textBox2.Text = "";
            O.Text = "Please write your name . ";
            label8.Text = "You will start .";
            counter = 0;
            enable = 0;
            Win = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Disable()
        {
            try
            {
                foreach(Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;

                }
                
            }
            catch
            {

            }
        }

    }
    }
