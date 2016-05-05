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
    public partial class frmTF : Form
    {
        int question;
        Random rnd = new Random();

        public static bool gotem;

        public frmTF()
        {
            InitializeComponent();
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            if (question == 1 || question == 5 || question == 6 || question == 10 || question == 11 || question == 19 || question == 20 || question == 21 || question == 23)
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
            if (question == 2 || question == 3 ||
                question == 4 || question == 7 ||
                question == 8 || question == 9 ||
                question == 12 || question == 13 ||
                question == 14 || question == 15 ||
                question == 16 || question == 17 ||
                question == 18 || question == 22)
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

        private void frmTF_Load(object sender, EventArgs e)
        {
            question = rnd.Next(1, 24);
            switch (question)
            {
                case 1:
                    lblQuestion.Text = "Clarisse suggests that rain tastes like wine.";
                    break;
                case 2:
                    lblQuestion.Text = "A robot known as the Steeltooth Panther hunted down criminals like Montag.";
                    break;
                case 3:
                    lblQuestion.Text = "Professor Faber is a world-renowned archaelogist.";
                    break;
                case 4:
                    lblQuestion.Text = "Montag convinced Faber to help him by methodically eating slices of chocolate cake in front of him.";
                    break;
                case 5:
                    lblQuestion.Text = "Faber survives the bombing of the city.";
                    break;
                case 6:
                    lblQuestion.Text = "At the beginning of the novel, Montag enjoys his job.";
                    break;
                case 7:
                    lblQuestion.Text = "At the end of the novel, Montag learns to appreciate his job and goes on to become the new fire captain.";
                    break;
                case 8:
                    lblQuestion.Text = "Over the course of the novel, Montag memorizes a book called “The Psychopathology of Everyday Life.”";
                    break;
                case 9:
                    lblQuestion.Text = "Mildred works in the Armed Forces.";
                    break;
                case 10:
                    lblQuestion.Text = "Clarisse says to Montag  “And if you look . . . there's a man in the moon.”";
                    break;
                case 11:
                    lblQuestion.Text = "Montag’s first name is Guy.";
                    break;
                case 12:
                    lblQuestion.Text = "Montag’s frst name is Joe.";
                    break;
                case 13:
                    lblQuestion.Text = "In Part 2, Montag kills Captain Beatty and subdues the other firemen.";
                    break;
                case 14:
                    lblQuestion.Text = "Mildred is a poet who recites quotes from epics.";
                    break;
                case 15:
                    lblQuestion.Text = "Beatty tells Montag that Claudius has murdered his father.";
                    break;
                case 16:
                    lblQuestion.Text = "Mildred tells Montag that Clarisse was run over by a car.";
                    break;
                case 17:
                    lblQuestion.Text = "Mildred makes it out of the city before the bomb hits it.";
                    break;
                case 18:
                    lblQuestion.Text = "Faber hijacks an emergency helicopter to leave the city. ";
                    break;
                case 19:
                    lblQuestion.Text = "The firemen have an image of a salamander on their uniforms.";
                    break;
                case 20:
                    lblQuestion.Text = "Clarisse is seventeen years old.";
                    break;
                case 21:
                    lblQuestion.Text = "Montag gets attacked by the Mechanical Hound.";
                    break;
                case 22:
                    lblQuestion.Text = "Beatty burned the old woman after she told him to stop counting.";
                    break;
                case 23:
                    lblQuestion.Text = "The fourth wall-TV would cost one-third of Montag’s yearly pay.";
                    break;
            }
        }
    }
}
