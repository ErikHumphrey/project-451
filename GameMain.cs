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

        Random rnd = new Random();
        Image[] tile = new Image[8];
        Image tileBooks = Properties.Resources.bookstile;
        Image tileHome = Properties.Resources.iconHomeTile;
        Image tileMultipleChoice = Properties.Resources.multitile;
        Image tileRollAgain = Properties.Resources.iconRollAgainTile;
        Image tileTeleport = Properties.Resources.iconTeleportTile;
        Image tileTrueOrFalse = Properties.Resources.iconTrueOrFalseTile;
        Image tileQuote = Properties.Resources.quotetile;
        
        private void frmGameMain_Load(object sender, EventArgs e)
        {
            tile[1] = Properties.Resources.bookstile;
            tile[2] = Properties.Resources.iconHomeTile;
            tile[3] = Properties.Resources.multitile;
            tile[4] = Properties.Resources.iconRollAgainTile;
            tile[5] = Properties.Resources.iconTeleportTile;
            tile[6] = Properties.Resources.iconTrueOrFalseTile;
            tile[7] = tileQuote = Properties.Resources.quotetile;

            pnlTileBot1.BackgroundImage = tile[rnd.Next(1, 8)];
        }
    }
}
