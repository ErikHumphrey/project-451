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

        Random rnd = new Random();
        Image[] tile = new Image[11];
        
        private void frmGameMain_Load(object sender, EventArgs e)
        {
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
    }
}
