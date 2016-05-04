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
    public partial class frmGameMain : Form
    {
        public frmGameMain()
        {
            InitializeComponent();
        }

        int randomCount = 0;

        int redTile = 1;
        int blueTile = 8;
        int greenTile = 12;
        int greyTile = 19;

        Random rnd = new Random();
        Image[] tile = new Image[11];
        
        private void frmGameMain_Load(object sender, EventArgs e)
        {
            //picRedPlayer.Parent = this;
            //picBluePlayer.Parent = this;
            //picGreenPlayer.Parent = this;
            //picGreyPlayer.Parent = this;

            picRedPlayer.Left -= 20;
            picBluePlayer.Left += 17;
            picGreenPlayer.Left += 28;
            tile[1] = Properties.Resources.iconHomeTile;
            tile[2] = Properties.Resources.bookstile;
            tile[3] = Properties.Resources.multitile;
            tile[4] = Properties.Resources.iconRollAgainTile;
            tile[5] = Properties.Resources.iconTeleportTile;
            tile[6] = Properties.Resources.iconTrueOrFalseTile;
            tile[7] = Properties.Resources.quotetile;
            tile[8] = Properties.Resources.quotetile;
            tile[9] = Properties.Resources.iconTrueOrFalseTile;
            tile[10] = Properties.Resources.multitile;

            tmrRandomizer.Start();
        }

        private void tmrRandomizer_Tick(object sender, EventArgs e)
        {
            if (randomCount > 29)
            {
                tmrRandomizer.Stop();
                btnRollADie.Enabled = true;
            }
            else
            {
                randomCount++;

                pnlTileLeft1.BackgroundImage = tile[rnd.Next(2, 11)];
                pnlTileLeft2.BackgroundImage = tile[rnd.Next(2, 11)];
                pnlTileLeft3.BackgroundImage = tile[rnd.Next(2, 11)];

                pnlTileRight1.BackgroundImage = tile[rnd.Next(2, 11)];
                pnlTileRight2.BackgroundImage = tile[rnd.Next(2, 11)];
                pnlTileRight3.BackgroundImage = tile[rnd.Next(2, 11)];

                pnlTileTop1.BackgroundImage = tile[rnd.Next(2, 11)];
                pnlTileTop2.BackgroundImage = tile[rnd.Next(2, 11)];
                pnlTileTop3.BackgroundImage = tile[rnd.Next(2, 11)];
                pnlTileTop4.BackgroundImage = tile[rnd.Next(2, 11)];
                pnlTileTop5.BackgroundImage = tile[rnd.Next(2, 11)];
                pnlTileTop6.BackgroundImage = tile[rnd.Next(2, 11)];

                pnlTileBot1.BackgroundImage = tile[rnd.Next(2, 11)];
                pnlTileBot2.BackgroundImage = tile[rnd.Next(2, 11)];
                pnlTileBot3.BackgroundImage = tile[rnd.Next(2, 11)];
                pnlTileBot4.BackgroundImage = tile[rnd.Next(2, 11)];
                pnlTileBot5.BackgroundImage = tile[rnd.Next(2, 11)];
                pnlTileBot6.BackgroundImage = tile[rnd.Next(2, 11)];
            }
        }

        private void btnRollADie_Click(object sender, EventArgs e)
        {
            int roll = rnd.Next(1, 7);
            redTile += roll;

            switch (redTile)
            {
                case 1:
                    picRedPlayer.Parent = pnlHome1;
                    break;
                case 2:
                    picRedPlayer.Parent = pnlTileTop1;
                    break;
                case 3:
                    picRedPlayer.Parent = pnlTileTop2;
                    break;
                case 4:
                    picRedPlayer.Parent = pnlTileTop3;
                    break;
                case 5:
                    picRedPlayer.Parent = pnlTileTop4;
                    break;
                case 6:
                    picRedPlayer.Parent = pnlTileTop5;
                    break;
                case 7:
                    picRedPlayer.Parent = pnlTileTop6;
                    break;
                case 8:
                    picRedPlayer.Parent = pnlHome2;
                    break;
                case 9:
                    picRedPlayer.Parent = pnlTileRight1;
                    break;
                case 10:
                    picRedPlayer.Parent = pnlTileRight2;
                    break;
                case 11:
                    picRedPlayer.Parent = pnlTileRight3;
                    break;
                case 12:
                    picRedPlayer.Parent = pnlHome3;
                    break;
                case 13:
                    picRedPlayer.Parent = pnlTileBot6;
                    break;
                case 14:
                    picRedPlayer.Parent = pnlTileBot5;
                    break;
                case 15:
                    picRedPlayer.Parent = pnlTileBot4;
                    break;
                case 16:
                    picRedPlayer.Parent = pnlTileBot3;
                    break;
                case 17:
                    picRedPlayer.Parent = pnlTileBot2;
                    break;
                case 18:
                    picRedPlayer.Parent = pnlTileBot1;
                    break;
                case 19:
                    picRedPlayer.Parent = pnlHome4;
                    break;
                case 20:
                    picRedPlayer.Parent = pnlTileLeft3;
                    break;
                case 21:
                    picRedPlayer.Parent = pnlTileLeft2;
                    break;
                case 22:
                    picRedPlayer.Parent = pnlTileLeft1;
                    break;
                case 23:
                    picRedPlayer.Parent = pnlHome1;
                    redTile = 1;
                    break;
                case 24:
                    picRedPlayer.Parent = pnlTileTop1;
                    redTile = 2;
                    break;
                case 25:
                    picRedPlayer.Parent = pnlTileTop2;
                    redTile = 3;
                    break;
                case 26:
                    picRedPlayer.Parent = pnlTileTop3;
                    redTile = 4;
                    break;
                case 27:
                    picRedPlayer.Parent = pnlTileTop4;
                    redTile = 5;
                    break;
                case 28:
                    picRedPlayer.Parent = pnlTileTop5;
                    redTile = 6;
                    break;

                  
            }

            button1.Text = (redTile + roll).ToString();
            button2.Text = redTile.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picRedPlayer.Location = new Point(170, 21);
            picRedPlayer.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picRedPlayer.Location = new Point(176, 21);
        }
    }
}
