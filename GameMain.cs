﻿using System;
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
                tmrPortDelay.Start();
            }
            else if (picRedPlayer.Parent.Tag.ToString() == "Roll")
            {
                lstGameLog.Items.Add("And land on a Roll Again tile. Roll again.");
            };
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
        }
    }
}
