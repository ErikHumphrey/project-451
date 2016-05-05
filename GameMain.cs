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

        int norm1 = 15;
        int norm2 = 40;
        int norm3 = 65;
        int norm4 = 200;
        int norm5 = 300;

        int turnDelay = 3;

        public static int redBooks, redNorm, blueBooks, blueNorm, greenBooks, greenNorm, greyBooks, greyNorm;

        Random rnd = new Random();
        Image[] tile = new Image[11];

        private void tmrTurnDelay_Tick(object sender, EventArgs e)
        {
            if (turnDelay == 0)
            {
                btnRollADie.Text = "Roll a die";
                btnRollADie.Enabled = true;
                tmrTurnDelay.Stop();
                lstGameLog.Items.Add("It's your turn.");
                turnDelay = 3;
            }
            else
            {
                btnRollADie.Text = "Roll a die..." + turnDelay;
                turnDelay--;
            }
        }

        private void lblViewAnswers_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1bj3r-xUMvJnp3il5Q_pwIi5mOaXGD8OOx5DLypgZmFw/edit?usp=sharing");
        }

        private void frmGameMain_Load(object sender, EventArgs e)
        {
            redNorm = blueNorm = greenNorm = greyNorm = norm1;
            redBooks = blueBooks = greenBooks = greyBooks = 0;
            prgRedNorm.Maximum = prgBlueNorm.Maximum = prgGreenNorm.Maximum = prgGreyNorm.Maximum = norm1;
            lblRedBooks.Text = lblBlueBooks.Text = lblGreenBooks.Text = lblGreyBooks.Text = "0 / " + norm1;

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
                lblRandom.Visible = false;
                btnRollADie.Visible = true;
            }
            else
            {
                randomCount++;
                int left1 = rnd.Next(2, 11);
                int left2 = rnd.Next(2, 11);
                int left3 = rnd.Next(2, 11);

                int right1 = rnd.Next(2, 11);
                int right2 = rnd.Next(2, 11);
                int right3 = rnd.Next(2, 11);

                int top1 = rnd.Next(2, 11);
                int top2 = rnd.Next(2, 11);
                int top3 = rnd.Next(2, 11);
                int Top6 = rnd.Next(2, 11);
                int top5 = rnd.Next(2, 11);
                int top6 = rnd.Next(2, 11);

                int bot1 = rnd.Next(2, 11);
                int bot2 = rnd.Next(2, 11);
                int bot3 = rnd.Next(2, 11);
                int bot4 = rnd.Next(2, 11);
                int bot5 = rnd.Next(2, 11);
                int bot6 = rnd.Next(2, 11);

                pnlTileLeft1.BackgroundImage = tile[left1];
                pnlTileLeft2.BackgroundImage = tile[left2];
                pnlTileLeft3.BackgroundImage = tile[left3];

                pnlTileRight1.BackgroundImage = tile[right1];
                pnlTileRight2.BackgroundImage = tile[right2];
                pnlTileRight3.BackgroundImage = tile[right3];

                pnlTileTop1.BackgroundImage = tile[top1];
                pnlTileTop2.BackgroundImage = tile[top2];
                pnlTileTop3.BackgroundImage = tile[top3];
                pnlTileTop6.BackgroundImage = tile[Top6];
                pnlTileTop5.BackgroundImage = tile[top5];
                pnlTileTop6.BackgroundImage = tile[top6];

                pnlTileBot1.BackgroundImage = tile[bot1];
                pnlTileBot2.BackgroundImage = tile[bot2];
                pnlTileBot3.BackgroundImage = tile[bot3];
                pnlTileBot4.BackgroundImage = tile[bot4];
                pnlTileBot5.BackgroundImage = tile[bot5];
                pnlTileBot6.BackgroundImage = tile[bot6];

                switch (left1)
                {
                    case 1:
                        pnlTileLeft1.Tag = "Home";
                        break;
                    case 2:
                        pnlTileLeft1.Tag = "Books";
                        break;
                    case 3:
                        pnlTileLeft1.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileLeft1.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileLeft1.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileLeft1.Tag = "TF";
                        break;
                    case 7:
                        pnlTileLeft1.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileLeft1.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileLeft1.Tag = "TF";
                        break;
                    case 10:
                        pnlTileLeft1.Tag = "Multi";
                        break;
                }

                switch (left2)
                {
                    case 1:
                        pnlTileLeft2.Tag = "Home";
                        break;
                    case 2:
                        pnlTileLeft2.Tag = "Books";
                        break;
                    case 3:
                        pnlTileLeft2.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileLeft2.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileLeft2.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileLeft2.Tag = "TF";
                        break;
                    case 7:
                        pnlTileLeft2.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileLeft2.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileLeft2.Tag = "TF";
                        break;
                    case 10:
                        pnlTileLeft2.Tag = "Multi";
                        break;
                }

                switch (left3)
                {
                    case 1:
                        pnlTileLeft3.Tag = "Home";
                        break;
                    case 2:
                        pnlTileLeft3.Tag = "Books";
                        break;
                    case 3:
                        pnlTileLeft3.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileLeft3.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileLeft3.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileLeft3.Tag = "TF";
                        break;
                    case 7:
                        pnlTileLeft3.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileLeft3.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileLeft3.Tag = "TF";
                        break;
                    case 10:
                        pnlTileLeft3.Tag = "Multi";
                        break;
                }

                switch (right1)
                {
                    case 1:
                        pnlTileRight1.Tag = "Home";
                        break;
                    case 2:
                        pnlTileRight1.Tag = "Books";
                        break;
                    case 3:
                        pnlTileRight1.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileRight1.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileRight1.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileRight1.Tag = "TF";
                        break;
                    case 7:
                        pnlTileRight1.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileRight1.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileRight1.Tag = "TF";
                        break;
                    case 10:
                        pnlTileRight1.Tag = "Multi";
                        break;
                }

                switch (right2)
                {
                    case 1:
                        pnlTileRight2.Tag = "Home";
                        break;
                    case 2:
                        pnlTileRight2.Tag = "Books";
                        break;
                    case 3:
                        pnlTileRight2.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileRight2.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileRight2.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileRight2.Tag = "TF";
                        break;
                    case 7:
                        pnlTileRight2.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileRight2.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileRight2.Tag = "TF";
                        break;
                    case 10:
                        pnlTileRight2.Tag = "Multi";
                        break;
                }

                switch (right3)
                {
                    case 1:
                        pnlTileRight3.Tag = "Home";
                        break;
                    case 2:
                        pnlTileRight3.Tag = "Books";
                        break;
                    case 3:
                        pnlTileRight3.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileRight3.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileRight3.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileRight3.Tag = "TF";
                        break;
                    case 7:
                        pnlTileRight3.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileRight3.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileRight3.Tag = "TF";
                        break;
                    case 10:
                        pnlTileRight3.Tag = "Multi";
                        break;
                }

                switch (top1)
                {
                    case 1:
                        pnlTileTop1.Tag = "Home";
                        break;
                    case 2:
                        pnlTileTop1.Tag = "Books";
                        break;
                    case 3:
                        pnlTileTop1.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileTop1.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileTop1.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileTop1.Tag = "TF";
                        break;
                    case 7:
                        pnlTileTop1.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileTop1.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileTop1.Tag = "TF";
                        break;
                    case 10:
                        pnlTileTop1.Tag = "Multi";
                        break;
                }

                switch (top2)
                {
                    case 1:
                        pnlTileTop2.Tag = "Home";
                        break;
                    case 2:
                        pnlTileTop2.Tag = "Books";
                        break;
                    case 3:
                        pnlTileTop2.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileTop2.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileTop2.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileTop2.Tag = "TF";
                        break;
                    case 7:
                        pnlTileTop2.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileTop2.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileTop2.Tag = "TF";
                        break;
                    case 10:
                        pnlTileTop2.Tag = "Multi";
                        break;
                }

                switch (top3)
                {
                    case 1:
                        pnlTileTop3.Tag = "Home";
                        break;
                    case 2:
                        pnlTileTop3.Tag = "Books";
                        break;
                    case 3:
                        pnlTileTop3.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileTop3.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileTop3.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileTop3.Tag = "TF";
                        break;
                    case 7:
                        pnlTileTop3.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileTop3.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileTop3.Tag = "TF";
                        break;
                    case 10:
                        pnlTileTop3.Tag = "Multi";
                        break;
                }

                switch (Top6)
                {
                    case 1:
                        pnlTileTop6.Tag = "Home";
                        break;
                    case 2:
                        pnlTileTop6.Tag = "Books";
                        break;
                    case 3:
                        pnlTileTop6.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileTop6.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileTop6.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileTop6.Tag = "TF";
                        break;
                    case 7:
                        pnlTileTop6.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileTop6.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileTop6.Tag = "TF";
                        break;
                    case 10:
                        pnlTileTop6.Tag = "Multi";
                        break;
                }

                switch (top5)
                {
                    case 1:
                        pnlTileTop5.Tag = "Home";
                        break;
                    case 2:
                        pnlTileTop5.Tag = "Books";
                        break;
                    case 3:
                        pnlTileTop5.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileTop5.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileTop5.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileTop5.Tag = "TF";
                        break;
                    case 7:
                        pnlTileTop5.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileTop5.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileTop5.Tag = "TF";
                        break;
                    case 10:
                        pnlTileTop5.Tag = "Multi";
                        break;
                }

                switch (top6)
                {
                    case 1:
                        pnlTileTop6.Tag = "Home";
                        break;
                    case 2:
                        pnlTileTop6.Tag = "Books";
                        break;
                    case 3:
                        pnlTileTop6.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileTop6.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileTop6.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileTop6.Tag = "TF";
                        break;
                    case 7:
                        pnlTileTop6.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileTop6.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileTop6.Tag = "TF";
                        break;
                    case 10:
                        pnlTileTop6.Tag = "Multi";
                        break;
                }

                switch (bot1)
                {
                    case 1:
                        pnlTileBot1.Tag = "Home";
                        break;
                    case 2:
                        pnlTileBot1.Tag = "Books";
                        break;
                    case 3:
                        pnlTileBot1.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileBot1.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileBot1.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileBot1.Tag = "TF";
                        break;
                    case 7:
                        pnlTileBot1.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileBot1.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileBot1.Tag = "TF";
                        break;
                    case 10:
                        pnlTileBot1.Tag = "Multi";
                        break;
                }

                switch (bot2)
                {
                    case 1:
                        pnlTileBot2.Tag = "Home";
                        break;
                    case 2:
                        pnlTileBot2.Tag = "Books";
                        break;
                    case 3:
                        pnlTileBot2.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileBot2.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileBot2.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileBot2.Tag = "TF";
                        break;
                    case 7:
                        pnlTileBot2.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileBot2.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileBot2.Tag = "TF";
                        break;
                    case 10:
                        pnlTileBot2.Tag = "Multi";
                        break;
                }

                switch (bot3)
                {
                    case 1:
                        pnlTileBot3.Tag = "Home";
                        break;
                    case 2:
                        pnlTileBot3.Tag = "Books";
                        break;
                    case 3:
                        pnlTileBot3.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileBot3.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileBot3.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileBot3.Tag = "TF";
                        break;
                    case 7:
                        pnlTileBot3.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileBot3.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileBot3.Tag = "TF";
                        break;
                    case 10:
                        pnlTileBot3.Tag = "Multi";
                        break;
                }

                switch (bot4)
                {
                    case 1:
                        pnlTileBot4.Tag = "Home";
                        break;
                    case 2:
                        pnlTileBot4.Tag = "Books";
                        break;
                    case 3:
                        pnlTileBot4.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileBot4.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileBot4.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileBot4.Tag = "TF";
                        break;
                    case 7:
                        pnlTileBot4.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileBot4.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileBot4.Tag = "TF";
                        break;
                    case 10:
                        pnlTileBot4.Tag = "Multi";
                        break;
                }

                switch (bot5)
                {
                    case 1:
                        pnlTileBot5.Tag = "Home";
                        break;
                    case 2:
                        pnlTileBot5.Tag = "Books";
                        break;
                    case 3:
                        pnlTileBot5.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileBot5.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileBot5.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileBot5.Tag = "TF";
                        break;
                    case 7:
                        pnlTileBot5.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileBot5.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileBot5.Tag = "TF";
                        break;
                    case 10:
                        pnlTileBot5.Tag = "Multi";
                        break;
                }

                switch (bot6)
                {
                    case 1:
                        pnlTileBot6.Tag = "Home";
                        break;
                    case 2:
                        pnlTileBot6.Tag = "Books";
                        break;
                    case 3:
                        pnlTileBot6.Tag = "Multi";
                        break;
                    case 4:
                        pnlTileBot6.Tag = "Roll";
                        break;
                    case 5:
                        pnlTileBot6.Tag = "Teleport";
                        break;
                    case 6:
                        pnlTileBot6.Tag = "TF";
                        break;
                    case 7:
                        pnlTileBot6.Tag = "Quote";
                        break;
                    case 8:
                        pnlTileBot6.Tag = "Quote";
                        break;
                    case 9:
                        pnlTileBot6.Tag = "TF";
                        break;
                    case 10:
                        pnlTileBot6.Tag = "Multi";
                        break;
                }
            }
        }

        public void redTurn()
        {
            lstGameLog.Items.Add("It's your turn.");

            switch (redNorm)
            {
                case 1:
                    redBooks += 3;
                    prgRedNorm.Value = redBooks;
                    lstGameLog.Items.Add("You receive " + "3" + " books.");
                    break;
                case 2:
                    redBooks += 5;
                    lstGameLog.Items.Add("You receive " + "5" + " books.");
                    break;
                case 3:
                    redBooks += 10;
                    prgRedNorm.Value = redBooks;
                    lstGameLog.Items.Add("You receive " + "10" + " books.");
                    break;
                case 4:
                    redBooks += 20;
                    lstGameLog.Items.Add("You receive " + "20" + " books.");
                    break;
                case 5:
                    redBooks += 40;
                    lstGameLog.Items.Add("You receive " + "40" + " books.");
                    break;
            }

            booksReceived();
        }

        public void booksReceived()
        {
            if (redBooks > prgRedNorm.Maximum)
                prgRedNorm.Value = prgRedNorm.Maximum;
            else
                prgRedNorm.Value = redBooks;

            lblRedBooks.Text = redBooks + " / " + redNorm;
        }

        public void booksLost()
        {
            if (redBooks < prgRedNorm.Minimum)
                prgRedNorm.Value = 0;
            else if (redBooks > prgRedNorm.Maximum)
                prgRedNorm.Value = prgRedNorm.Maximum;
            else
                prgRedNorm.Value = redBooks;

            lblRedBooks.Text = redBooks + " / " + redNorm;
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
                    picRedPlayer.Parent = pnlTileTop6;
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
                    picRedPlayer.Parent = pnlTileTop6;
                    redTile = 5;
                    break;
                case 28:
                    picRedPlayer.Parent = pnlTileTop5;
                    redTile = 6;
                    break;
            }

            lstGameLog.Items.Add("You roll a " + roll + ".");

            if (picRedPlayer.Parent.Tag.ToString() == "Teleport")
            {
                lstGameLog.Items.Add("You land on a Teleport tile...");
                lstGameLog.TopIndex = lstGameLog.Items.Count - 1;
                tmrPortDelay.Start();
                btnRollADie.Enabled = false;
            }
            else if (picRedPlayer.Parent.Tag.ToString() == "Roll")
            {
                lstGameLog.Items.Add("You land on a Roll Again tile. Roll again.");
                lstGameLog.TopIndex = lstGameLog.Items.Count - 1;
            }
            else if (picRedPlayer.Parent.Tag.ToString() == "Multi")
            {
                lstGameLog.Items.Add("You land on a Multiple Choice tile.");
                frmMulti multiChoice = new frmMulti();
                btnRollADie.Enabled = false;
                multiChoice.ShowDialog();
                tmrTurnDelay.Start();
                if (frmMulti.gotem) { lstGameLog.Items.Add("You got the question right and earned 10 books."); booksReceived(); }
                else { lstGameLog.Items.Add("You got the question wrong and lost 20 books."); booksLost(); }
                lstGameLog.TopIndex = lstGameLog.Items.Count - 1;


            }
            else if (picRedPlayer.Parent.Tag.ToString() == "TF")
            {
                lstGameLog.Items.Add("You land on a True or False tile.");
                frmTF trueOrFalse = new frmTF();
                btnRollADie.Enabled = false;
                trueOrFalse.ShowDialog();
                tmrTurnDelay.Start();
                if (frmTF.gotem) { lstGameLog.Items.Add("You got the question right and earned 10 books."); booksReceived(); }
                else { lstGameLog.Items.Add("You got the question wrong and lost 10 books."); booksLost(); }
                lstGameLog.TopIndex = lstGameLog.Items.Count - 1;
            }
            else if (picRedPlayer.Parent.Tag.ToString() == "Books")
            {
                lstGameLog.Items.Add("You land on a Books tile.");
                int booksAwarded = rnd.Next(5, 21);
                lstGameLog.Items.Add("You receive " + booksAwarded + " books.");
                btnRollADie.Enabled = false;
                tmrTurnDelay.Start();
                lstGameLog.TopIndex = lstGameLog.Items.Count - 1;
            }
            else if (picRedPlayer.Parent.Tag.ToString() == "Quote")
            {
                lstGameLog.Items.Add("You land on a Quote tile.");
                frmQuote quoteAttribution = new frmQuote();
                btnRollADie.Enabled = false;
                quoteAttribution.ShowDialog();
                tmrTurnDelay.Start();
                if (frmQuote.gotem) { lstGameLog.Items.Add("You got the question right and earned 10 books."); booksReceived(); }
                else { lstGameLog.Items.Add("You got the question wrong and lost 20 books."); booksLost(); }
                lstGameLog.TopIndex = lstGameLog.Items.Count - 1;
            }
            else if (picRedPlayer.Parent.Tag.ToString() == "Home")
            {
                btnRollADie.Enabled = false;
                tmrTurnDelay.Start();
                lstGameLog.Items.Add("You land on a Home tile.");
                lstGameLog.TopIndex = lstGameLog.Items.Count - 1;
                if (redBooks >= redNorm)
                {
                    if (redNorm == norm1)
                    {
                        redNorm = prgRedNorm.Maximum = norm2;
                        prgRedNorm.Minimum = norm1;
                        lstGameLog.Items.Add("You have completed Norm 1!");
                        lstGameLog.Items.Add("You need " + norm2 + " books to complete the next Norm.");
                        lblRedNorm.Text = "2";
                    }
                    else if (redNorm == norm2)
                    {
                        redNorm = prgRedNorm.Maximum = norm3;
                        prgRedNorm.Minimum = norm2;
                        lstGameLog.Items.Add("You have completed Norm 2!");
                        lstGameLog.Items.Add("You need " + norm3 + " books to complete the next Norm.");
                        lblRedNorm.Text = "3";
                    }
                    else if (redNorm == norm3)
                    {
                        redNorm = prgRedNorm.Maximum = norm4;
                        prgRedNorm.Minimum = norm3;
                        lstGameLog.Items.Add("You have completed Norm 3!");
                        lstGameLog.Items.Add("You need " + norm4 + " books to complete the next Norm.");
                        lblRedNorm.Text = "4";
                    }
                    else if (redNorm == norm4)
                    {
                        redNorm = prgRedNorm.Maximum = norm5;
                        prgRedNorm.Minimum = norm4;
                        lstGameLog.Items.Add("You have completed Norm 4!");
                        lstGameLog.Items.Add("You need " + norm5 + " books to complete the next Norm.");
                        lblRedNorm.Text = "5";
                    }
                    else if (redNorm == norm5)
                    {
                        lstGameLog.Items.Add("You have completed Norm 5!");
                        lstGameLog.Items.Add("You win!");
                        lblRedNorm.Text = "W";
                        lblBlueNorm.Text = lblGreenNorm.Text = lblGreenNorm.Text = "L";
                        MessageBox.Show("You win! Close and reopen the program to play again.", "Victory!");
                        Application.Exit();
                    }

                    lblRedBooks.Text = redBooks + " / " + redNorm;
                }
                else
                {
                    lstGameLog.Items.Add("You need " + (redNorm - redBooks) + " more books to complete your Norm.");
                }
            }
        }

        private void tmrPortDelay_Tick(object sender, EventArgs e)
        {
            int teleportLocation = rnd.Next(1, 29);
            int savedLocation = redTile;
            redTile = teleportLocation;

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
                    picRedPlayer.Parent = pnlTileTop6;
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
                    picRedPlayer.Parent = pnlTileTop6;
                    redTile = 5;
                    break;
                case 28:
                    picRedPlayer.Parent = pnlTileTop5;
                    redTile = 6;
                    break;
            }

            int resultLocation = teleportLocation - savedLocation;

            if (resultLocation < 0)
                resultLocation *= -1;

            if (resultLocation == 0)
                lstGameLog.Items.Add("...and are teleported THE SAME SPOT!");
            else
                lstGameLog.Items.Add("...and are teleported " + (resultLocation) + " tiles away!");

            tmrPortDelay.Stop();
            tmrTurnDelay.Start();
        }
    }
}
