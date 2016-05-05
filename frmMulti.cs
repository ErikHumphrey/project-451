using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_451
{
    public partial class frmMulti : Form
    {
        int question;
        Random rnd = new Random();

        public static bool gotem;

        public frmMulti()
        {
            InitializeComponent();
        }

        private void frmMulti_Load(object sender, EventArgs e)
        {
            question = rnd.Next(1, 13);
            switch (question)
            {
                case 1:
                    lblQuestion.Text = "Who is the author of Fahrenheit 451?";
                    btnAnswer1.Text = "Ethan Bradberry";
                    btnAnswer2.Text = "Jay Gatsby";
                    btnAnswer3.Text = "Ray Bradbury";
                    btnAnswer4.Text = "Ray William Johnson";
                    break;
                case 2:
                    lblQuestion.Text = "What is Faber’s destination?";
                    btnAnswer1.Text = "San Francisco";
                    btnAnswer2.Text = "New Delhi";
                    btnAnswer3.Text = "New York";
                    btnAnswer4.Text = "St. Louis";
                    break;
                case 3:
                    lblQuestion.Text = "Montag took a book from the old woman’s ___________.";
                    btnAnswer1.Text = "bedroom";
                    btnAnswer2.Text = "library";
                    btnAnswer3.Text = "basement";
                    btnAnswer4.Text = "attic";
                    break;
                case 4:
                    lblQuestion.Text = "This smelled like perfume to Montag.";
                    btnAnswer1.Text = "kerosene";
                    btnAnswer2.Text = "petroleum";
                    btnAnswer3.Text = "Faber’s book collection";
                    btnAnswer4.Text = "gasoline";
                    break;
                case 5:
                    lblQuestion.Text = "Mildred took an overdose of ___________.";
                    btnAnswer1.Text = "books";
                    btnAnswer2.Text = "cough medicine";
                    btnAnswer3.Text = "sleeping pills";
                    btnAnswer4.Text = "painkillers";
                    break;
                case 6:
                    lblQuestion.Text = "The device Montag used to communicate with Faber.";
                    btnAnswer1.Text = "a Seashell radio";
                    btnAnswer2.Text = "a walkie-talkie";
                    btnAnswer3.Text = "a flip phone";
                    btnAnswer4.Text = "a GPS disguised as an e-reader";
                    break;
                case 7:
                    lblQuestion.Text = "She liked to think and talk.";
                    btnAnswer1.Text = "the old woman";
                    btnAnswer2.Text = "Montag's mother";
                    btnAnswer3.Text = "Clarisse";
                    btnAnswer4.Text = "the President";
                    break;
                case 8:
                    lblQuestion.Text = "Captain of the firemen.";
                    btnAnswer1.Text = "Old Major";
                    btnAnswer2.Text = "Montag";
                    btnAnswer3.Text = "Beatty";
                    btnAnswer4.Text = "Dallas";
                    break;
                case 9:
                    lblQuestion.Text = "Rule 3 of the fireman’s rule book.";
                    btnAnswer1.Text = "Drink deep flame's knowledge.";
                    btnAnswer2.Text = "Burn everything.";
                    btnAnswer3.Text = "Walk a warrior’s way.";
                    btnAnswer4.Text = "You do not talk about FIRE CLUB.";
                    break;
                case 10:
                    lblQuestion.Text = "What the firemen called their fire trucks.";
                    btnAnswer1.Text = "Salamanders";
                    btnAnswer2.Text = "Phoenixes";
                    btnAnswer3.Text = "Fire Serpents";
                    btnAnswer4.Text = "Wyverns";
                    break;
                case 11:
                    lblQuestion.Text = "What number is featured on the firemen’s uniforms?";
                    btnAnswer1.Text = "9";
                    btnAnswer2.Text = "451";
                    btnAnswer3.Text = "233";
                    btnAnswer4.Text = "100";
                    break;
                case 12:
                    lblQuestion.Text = "Montag’s coworkers.";
                    btnAnswer1.Text = "Blaze and Igneus";
                    btnAnswer2.Text = "Granger and Weasley";
                    btnAnswer3.Text = "Stoneman and Black";
                    btnAnswer4.Text = "Mildred and Freud";
                    break;
            }

            
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            if (question == 4 || question == 6 || question == 10)
            {
                gotem = true;
                frmGameMain.redBooks += 10;
            }
            else
            {
                gotem = false;
                frmGameMain.redBooks -= 20;
            }

            this.Close();
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            if (question == 9 || question == 11)
            {
                gotem = true;
                frmGameMain.redBooks += 10;
            }
            else
            {
                gotem = false;
                frmGameMain.redBooks -= 20;
            }

            this.Close();
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            if (question == 1 || question == 5 || question == 7 || question == 8 || question == 12)
            {
                gotem = true;
                frmGameMain.redBooks += 10;
            }
            else
            {
                gotem = false;
                frmGameMain.redBooks -= 20;
            }

            this.Close();
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            if (question == 2 || question == 3)
            {
                gotem = true;
                frmGameMain.redBooks += 10;
            }
            else
            {
                gotem = false;
                frmGameMain.redBooks -= 20;
            }

            this.Close();
        }
    }
}
