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
    public partial class Form1 : Form
    {
        public int turn = 0;
        public string save;
        public bool Win = false;
        
        public Form1()
        {
            InitializeComponent();
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";





        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("    By Parsa Arani", "Information");
        }

        private void a1_Click(object sender, EventArgs e)
        {
            
            O.Text = "";
            X.Text = "";
            label8.Text = "";
            turn = Convert.ToInt32(label1.Text);
            turn = turn + 1;
            label1.Text = turn.ToString();
            if(turn%2 == 0)
            {

                a1.Text = "X";
                a1.BackColor = Color.DarkRed;
                O.Text = "     Your Turn .";
            }
            if(turn%2 == 1)
            {
                a1.Text = "O";
                a1.BackColor = Color.DarkGreen;
                X.Text = "     Your Turn .";
            }
            a1.Enabled = false;
            if(a1.Text == a2.Text && a2.Text == a3.Text)
            {
                if(a1.Text == "X")
                { 
                    
                MessageBox.Show("  You won "+textBox1.Text, "Congratulations");
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
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                X.Text = "     Game Finishid .";
                O.Text = "     Game Finishid .";
            }

        }

        private void a2_Click(object sender, EventArgs e)
        {
            O.Text = "";
            X.Text = "";
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
                X.Text = "     Your Turn .";

            }
            a2.Enabled = false;
            if (a1.Text == a2.Text && a2.Text == a3.Text)
            {
                if (a2.Text == "X")
                {
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                X.Text = "     Game Finishid .";
                O.Text = "     Game Finishid .";
            }


        }

        private void a3_Click(object sender, EventArgs e)
        {
            O.Text = "";
            X.Text = "";
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
                X.Text = "     Your Turn .";

            }
            a3.Enabled = false;
            if (a1.Text == a2.Text && a2.Text == a3.Text)
            {
                if (a3.Text == "X")
                {
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                X.Text = "     Game Finishid .";
                O.Text = "     Game Finishid .";
            }

        }

        private void b1_Click(object sender, EventArgs e)
        {
            O.Text = "";
            X.Text = "";
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
                X.Text = "     Your Turn .";

            }
            b1.Enabled = false;
            if (b1.Text == b2.Text && b2.Text == b3.Text)
            {
                if (b1.Text == "X")
                {
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                X.Text = "     Game Finishid .";
                O.Text = "     Game Finishid .";
            }

        }

        private void b2_Click(object sender, EventArgs e)
        {
            O.Text = "";
            X.Text = "";
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
                X.Text = "     Your Turn .";

            }
            b2.Enabled = false;
            if (a1.Text == b2.Text && b2.Text == c3.Text)
            {
                if (b2.Text == "X")
                {
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                X.Text = "     Game Finishid .";
                O.Text = "     Game Finishid .";
            }

        }

        private void b3_Click(object sender, EventArgs e)
        {
            O.Text = "";
            X.Text = "";
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
                X.Text = "     Your Turn .";

            }
            b3.Enabled = false;
            if (a3.Text == b3.Text && b3.Text == c3.Text)
            {
                if (b3.Text == "X")
                {
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                X.Text = "     Game Finishid .";
                O.Text = "     Game Finishid .";
            }


        }

        private void c1_Click(object sender, EventArgs e)
        {
            O.Text = "";
            X.Text = "";
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
                X.Text = "     Your Turn .";

            }
            c1.Enabled = false;
            if (a1.Text == b1.Text && b1.Text == c1.Text)
            {
                if (c1.Text == "X")
                {
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                X.Text = "     Game Finishid .";
                O.Text = "     Game Finishid .";
            }


        }

        private void c2_Click(object sender, EventArgs e)
        {
            O.Text = "";
            X.Text = "";
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
                X.Text = "     Your Turn .";

            }
            c2.Enabled = false;
            if (a2.Text == b2.Text && b2.Text == c2.Text)
            {
                if (c2.Text == "X")
                {
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                X.Text = "     Game Finishid .";
                O.Text = "     Game Finishid .";
            }

        }

        private void c3_Click(object sender, EventArgs e)
        {
            O.Text = "";
            X.Text = "";
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
                X.Text = "     Your Turn .";

            }
            c3.Enabled = false;
            if (a3.Text == b3.Text && b3.Text == c3.Text)
            {
                if (c3.Text == "X")
                {
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
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
                X.Text = "     Game Finishid .";
                O.Text = "     Game Finishid .";
            }
            if (turn == 9 && Win == false)
            {
                MessageBox.Show("   The game equalised !", "Information");
            }
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";
        }

        private void whatIsXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have to write you name after ' X : ' for become an X player .", "What is ' X : ' ?");
        }

        private void whatIsOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have to write you name after ' O : ' for become an O player .", "What is ' O : ' ?");
        }

        private void newPlayersToolStripMenuItem_Click(object sender, EventArgs e)
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
            textBox1.Text = "";
            textBox2.Text = "";
            X.Text = "Please write your name .";
            O.Text = "Please write your name . ";
            label8.Text = "You will start .";        
            
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
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

        }

        private void switchPlayersToolStripMenuItem_Click(object sender, EventArgs e)
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
          save=  textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = save;
        }

        private void startNewGameWithComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Disable()
        {
            try
            {
                foreach (Control c in Controls)
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
