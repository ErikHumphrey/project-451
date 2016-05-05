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
    public partial class frmQuote : Form
    {
        public frmQuote()
        {
            InitializeComponent();
        }

        int question;
        Random rnd = new Random();

        public static bool gotem;

        private void frmQuote_Load_1(object sender, EventArgs e)
        {
            question = rnd.Next(1, 6);
            switch (question)
            {
                case 1:
                    lblQuestion.Text = "”We never burned right . . .”";
                    btnAnswer1.Text = "Guy Montag";
                    btnAnswer2.Text = "Stoneman";
                    btnAnswer3.Text = "Captain Beatty";
                    btnAnswer4.Text = "Smokey Bear";
                    break;
                case 2:
                    lblQuestion.Text = "”Who can stop me? I’m a fireman. I can burn you!”";
                    btnAnswer1.Text = "Jack Merridew";
                    btnAnswer2.Text = "Captain Beatty";
                    btnAnswer3.Text = "Guy Montag";
                    btnAnswer4.Text = "Jackie Chan";
                    break;
                case 3:
                    lblQuestion.Text = "”Books aren’t people. You read and I look all around, but there isn’t anybody!”";
                    btnAnswer1.Text = "Guy Montag";
                    btnAnswer2.Text = "Captain Beatty";
                    btnAnswer3.Text = "Jackie Chan";
                    btnAnswer4.Text = "Mildred Montag";
                    break;
                case 4:
                    lblQuestion.Text = "”Didn’t firemen prevent fires rather than stoke them up and get them going?”";
                    btnAnswer1.Text = "Captain Crunch";
                    btnAnswer2.Text = "Captain Falcon";
                    btnAnswer3.Text = "Captain Beatty";
                    btnAnswer4.Text = "Clarisse McClellan";
                    break;
                case 5:
                    lblQuestion.Text = "”And we are out here, and the city is there, all wrapped up in its own coat of a thousand colours.”";
                    btnAnswer1.Text = "Mildred Montag";
                    btnAnswer2.Text = "Professor Faber";
                    btnAnswer3.Text = "Black";
                    btnAnswer4.Text = "None of the above";
                    break;
            }


        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            if (question == 1)
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
            gotem = false;
            frmGameMain.redBooks -= 20;
            this.Close();
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            if (question == 2)
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
            if (question == 3 || question == 4 || question == 5)
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
