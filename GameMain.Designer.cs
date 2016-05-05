namespace project_451
{
    partial class frmGameMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameMain));
            this.lstGameLog = new System.Windows.Forms.ListBox();
            this.tmrRandomizer = new System.Windows.Forms.Timer(this.components);
            this.lblRandom = new System.Windows.Forms.Label();
            this.btnRollADie = new System.Windows.Forms.Button();
            this.lblGreenName = new System.Windows.Forms.Label();
            this.prgGreenNorm = new System.Windows.Forms.ProgressBar();
            this.lblGreenBooks = new System.Windows.Forms.Label();
            this.lblBlueBooks = new System.Windows.Forms.Label();
            this.prgBlueNorm = new System.Windows.Forms.ProgressBar();
            this.lblBlueName = new System.Windows.Forms.Label();
            this.lblRedBooks = new System.Windows.Forms.Label();
            this.prgRedNorm = new System.Windows.Forms.ProgressBar();
            this.lblRedName = new System.Windows.Forms.Label();
            this.lblGreyBooks = new System.Windows.Forms.Label();
            this.prgGreyNorm = new System.Windows.Forms.ProgressBar();
            this.lblGreyName = new System.Windows.Forms.Label();
            this.lblRedNorm = new System.Windows.Forms.Label();
            this.lblBlueNorm = new System.Windows.Forms.Label();
            this.lblGreenNorm = new System.Windows.Forms.Label();
            this.lblGreyNorm = new System.Windows.Forms.Label();
            this.tmrPortDelay = new System.Windows.Forms.Timer(this.components);
            this.lblHelp = new System.Windows.Forms.Label();
            this.tmrTurnDelay = new System.Windows.Forms.Timer(this.components);
            this.lblNoTime = new System.Windows.Forms.Label();
            this.lblViewAnswers = new System.Windows.Forms.Label();
            this.pnlTileRight3 = new System.Windows.Forms.Panel();
            this.pnlTileLeft3 = new System.Windows.Forms.Panel();
            this.pnlTileRight2 = new System.Windows.Forms.Panel();
            this.pnlHome3 = new System.Windows.Forms.Panel();
            this.picGreenPlayer = new System.Windows.Forms.PictureBox();
            this.pnlTileRight1 = new System.Windows.Forms.Panel();
            this.pnlTileLeft2 = new System.Windows.Forms.Panel();
            this.pnlHome2 = new System.Windows.Forms.Panel();
            this.picBluePlayer = new System.Windows.Forms.PictureBox();
            this.pnlHome4 = new System.Windows.Forms.Panel();
            this.picGreyPlayer = new System.Windows.Forms.PictureBox();
            this.pnlTileBot6 = new System.Windows.Forms.Panel();
            this.pnlHome1 = new System.Windows.Forms.Panel();
            this.picRedPlayer = new System.Windows.Forms.PictureBox();
            this.pnlTileLeft1 = new System.Windows.Forms.Panel();
            this.pnlTileBot5 = new System.Windows.Forms.Panel();
            this.pnlTileTop6 = new System.Windows.Forms.Panel();
            this.pnlTileBot4 = new System.Windows.Forms.Panel();
            this.pnlTileTop5 = new System.Windows.Forms.Panel();
            this.pnlTileBot3 = new System.Windows.Forms.Panel();
            this.pnlTileBot2 = new System.Windows.Forms.Panel();
            this.pnlTileTop4 = new System.Windows.Forms.Panel();
            this.pnlTileBot1 = new System.Windows.Forms.Panel();
            this.pnlTileTop3 = new System.Windows.Forms.Panel();
            this.pnlTileTop2 = new System.Windows.Forms.Panel();
            this.pnlTileTop1 = new System.Windows.Forms.Panel();
            this.lblConfused = new System.Windows.Forms.Label();
            this.pnlHome3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenPlayer)).BeginInit();
            this.pnlHome2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBluePlayer)).BeginInit();
            this.pnlHome4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGreyPlayer)).BeginInit();
            this.pnlHome1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lstGameLog
            // 
            this.lstGameLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstGameLog.FormattingEnabled = true;
            this.lstGameLog.Location = new System.Drawing.Point(912, 0);
            this.lstGameLog.Name = "lstGameLog";
            this.lstGameLog.Size = new System.Drawing.Size(251, 493);
            this.lstGameLog.TabIndex = 3;
            // 
            // tmrRandomizer
            // 
            this.tmrRandomizer.Tick += new System.EventHandler(this.tmrRandomizer_Tick);
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandom.Location = new System.Drawing.Point(321, 166);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(418, 35);
            this.lblRandom.TabIndex = 22;
            this.lblRandom.Text = "Randomizing game board...";
            // 
            // btnRollADie
            // 
            this.btnRollADie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollADie.Location = new System.Drawing.Point(444, 218);
            this.btnRollADie.Name = "btnRollADie";
            this.btnRollADie.Size = new System.Drawing.Size(141, 37);
            this.btnRollADie.TabIndex = 23;
            this.btnRollADie.Text = "Roll a die";
            this.btnRollADie.UseVisualStyleBackColor = true;
            this.btnRollADie.Visible = false;
            this.btnRollADie.Click += new System.EventHandler(this.btnRollADie_Click);
            // 
            // lblGreenName
            // 
            this.lblGreenName.AutoSize = true;
            this.lblGreenName.Location = new System.Drawing.Point(36, 114);
            this.lblGreenName.Name = "lblGreenName";
            this.lblGreenName.Size = new System.Drawing.Size(67, 13);
            this.lblGreenName.TabIndex = 26;
            this.lblGreenName.Text = "Green (CPU)";
            // 
            // prgGreenNorm
            // 
            this.prgGreenNorm.Location = new System.Drawing.Point(39, 130);
            this.prgGreenNorm.Name = "prgGreenNorm";
            this.prgGreenNorm.Size = new System.Drawing.Size(114, 15);
            this.prgGreenNorm.TabIndex = 29;
            // 
            // lblGreenBooks
            // 
            this.lblGreenBooks.Location = new System.Drawing.Point(89, 148);
            this.lblGreenBooks.Name = "lblGreenBooks";
            this.lblGreenBooks.Size = new System.Drawing.Size(67, 13);
            this.lblGreenBooks.TabIndex = 30;
            this.lblGreenBooks.Text = "0 / 100";
            this.lblGreenBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBlueBooks
            // 
            this.lblBlueBooks.Location = new System.Drawing.Point(89, 94);
            this.lblBlueBooks.Name = "lblBlueBooks";
            this.lblBlueBooks.Size = new System.Drawing.Size(67, 13);
            this.lblBlueBooks.TabIndex = 33;
            this.lblBlueBooks.Text = "0 / 100";
            this.lblBlueBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prgBlueNorm
            // 
            this.prgBlueNorm.Location = new System.Drawing.Point(39, 76);
            this.prgBlueNorm.Name = "prgBlueNorm";
            this.prgBlueNorm.Size = new System.Drawing.Size(114, 15);
            this.prgBlueNorm.TabIndex = 32;
            // 
            // lblBlueName
            // 
            this.lblBlueName.AutoSize = true;
            this.lblBlueName.Location = new System.Drawing.Point(36, 60);
            this.lblBlueName.Name = "lblBlueName";
            this.lblBlueName.Size = new System.Drawing.Size(59, 13);
            this.lblBlueName.TabIndex = 31;
            this.lblBlueName.Text = "Blue (CPU)";
            // 
            // lblRedBooks
            // 
            this.lblRedBooks.Location = new System.Drawing.Point(89, 42);
            this.lblRedBooks.Name = "lblRedBooks";
            this.lblRedBooks.Size = new System.Drawing.Size(67, 13);
            this.lblRedBooks.TabIndex = 36;
            this.lblRedBooks.Text = "0 / 100";
            this.lblRedBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prgRedNorm
            // 
            this.prgRedNorm.Location = new System.Drawing.Point(39, 24);
            this.prgRedNorm.Name = "prgRedNorm";
            this.prgRedNorm.Size = new System.Drawing.Size(114, 15);
            this.prgRedNorm.TabIndex = 35;
            // 
            // lblRedName
            // 
            this.lblRedName.AutoSize = true;
            this.lblRedName.Location = new System.Drawing.Point(36, 8);
            this.lblRedName.Name = "lblRedName";
            this.lblRedName.Size = new System.Drawing.Size(55, 13);
            this.lblRedName.TabIndex = 34;
            this.lblRedName.Text = "Red (You)";
            // 
            // lblGreyBooks
            // 
            this.lblGreyBooks.Location = new System.Drawing.Point(89, 202);
            this.lblGreyBooks.Name = "lblGreyBooks";
            this.lblGreyBooks.Size = new System.Drawing.Size(67, 13);
            this.lblGreyBooks.TabIndex = 39;
            this.lblGreyBooks.Text = "0 / 100";
            this.lblGreyBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prgGreyNorm
            // 
            this.prgGreyNorm.Location = new System.Drawing.Point(39, 184);
            this.prgGreyNorm.Name = "prgGreyNorm";
            this.prgGreyNorm.Size = new System.Drawing.Size(114, 15);
            this.prgGreyNorm.TabIndex = 38;
            // 
            // lblGreyName
            // 
            this.lblGreyName.AutoSize = true;
            this.lblGreyName.Location = new System.Drawing.Point(36, 168);
            this.lblGreyName.Name = "lblGreyName";
            this.lblGreyName.Size = new System.Drawing.Size(60, 13);
            this.lblGreyName.TabIndex = 37;
            this.lblGreyName.Text = "Grey (CPU)";
            // 
            // lblRedNorm
            // 
            this.lblRedNorm.AutoSize = true;
            this.lblRedNorm.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedNorm.Location = new System.Drawing.Point(8, 16);
            this.lblRedNorm.Name = "lblRedNorm";
            this.lblRedNorm.Size = new System.Drawing.Size(24, 23);
            this.lblRedNorm.TabIndex = 40;
            this.lblRedNorm.Text = "1";
            // 
            // lblBlueNorm
            // 
            this.lblBlueNorm.AutoSize = true;
            this.lblBlueNorm.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueNorm.Location = new System.Drawing.Point(8, 68);
            this.lblBlueNorm.Name = "lblBlueNorm";
            this.lblBlueNorm.Size = new System.Drawing.Size(24, 23);
            this.lblBlueNorm.TabIndex = 41;
            this.lblBlueNorm.Text = "1";
            // 
            // lblGreenNorm
            // 
            this.lblGreenNorm.AutoSize = true;
            this.lblGreenNorm.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenNorm.Location = new System.Drawing.Point(8, 122);
            this.lblGreenNorm.Name = "lblGreenNorm";
            this.lblGreenNorm.Size = new System.Drawing.Size(24, 23);
            this.lblGreenNorm.TabIndex = 42;
            this.lblGreenNorm.Text = "1";
            // 
            // lblGreyNorm
            // 
            this.lblGreyNorm.AutoSize = true;
            this.lblGreyNorm.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreyNorm.Location = new System.Drawing.Point(8, 176);
            this.lblGreyNorm.Name = "lblGreyNorm";
            this.lblGreyNorm.Size = new System.Drawing.Size(24, 23);
            this.lblGreyNorm.TabIndex = 43;
            this.lblGreyNorm.Text = "1";
            // 
            // tmrPortDelay
            // 
            this.tmrPortDelay.Interval = 2000;
            this.tmrPortDelay.Tick += new System.EventHandler(this.tmrPortDelay_Tick);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(272, 274);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(517, 65);
            this.lblHelp.TabIndex = 44;
            this.lblHelp.Text = resources.GetString("lblHelp.Text");
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrTurnDelay
            // 
            this.tmrTurnDelay.Interval = 1000;
            this.tmrTurnDelay.Tick += new System.EventHandler(this.tmrTurnDelay_Tick);
            // 
            // lblNoTime
            // 
            this.lblNoTime.AutoSize = true;
            this.lblNoTime.Location = new System.Drawing.Point(36, 427);
            this.lblNoTime.Name = "lblNoTime";
            this.lblNoTime.Size = new System.Drawing.Size(92, 26);
            this.lblNoTime.TabIndex = 45;
            this.lblNoTime.Text = "No time to try\r\nall 40+ questions?\r\n";
            this.lblNoTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblViewAnswers
            // 
            this.lblViewAnswers.AutoSize = true;
            this.lblViewAnswers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblViewAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAnswers.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblViewAnswers.Location = new System.Drawing.Point(19, 456);
            this.lblViewAnswers.Name = "lblViewAnswers";
            this.lblViewAnswers.Size = new System.Drawing.Size(130, 13);
            this.lblViewAnswers.TabIndex = 46;
            this.lblViewAnswers.Text = "Click here to view them all";
            this.lblViewAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblViewAnswers.Click += new System.EventHandler(this.lblViewAnswers_Click);
            // 
            // pnlTileRight3
            // 
            this.pnlTileRight3.BackgroundImage = global::project_451.Properties.Resources.quotetile;
            this.pnlTileRight3.Location = new System.Drawing.Point(800, 291);
            this.pnlTileRight3.Name = "pnlTileRight3";
            this.pnlTileRight3.Size = new System.Drawing.Size(90, 90);
            this.pnlTileRight3.TabIndex = 21;
            // 
            // pnlTileLeft3
            // 
            this.pnlTileLeft3.BackgroundImage = global::project_451.Properties.Resources.quotetile;
            this.pnlTileLeft3.Location = new System.Drawing.Point(170, 291);
            this.pnlTileLeft3.Name = "pnlTileLeft3";
            this.pnlTileLeft3.Size = new System.Drawing.Size(90, 90);
            this.pnlTileLeft3.TabIndex = 18;
            // 
            // pnlTileRight2
            // 
            this.pnlTileRight2.BackgroundImage = global::project_451.Properties.Resources.multitile;
            this.pnlTileRight2.Location = new System.Drawing.Point(800, 201);
            this.pnlTileRight2.Name = "pnlTileRight2";
            this.pnlTileRight2.Size = new System.Drawing.Size(90, 90);
            this.pnlTileRight2.TabIndex = 20;
            // 
            // pnlHome3
            // 
            this.pnlHome3.BackgroundImage = global::project_451.Properties.Resources.iconHomeTile;
            this.pnlHome3.Controls.Add(this.picGreenPlayer);
            this.pnlHome3.Location = new System.Drawing.Point(800, 381);
            this.pnlHome3.Name = "pnlHome3";
            this.pnlHome3.Size = new System.Drawing.Size(90, 90);
            this.pnlHome3.TabIndex = 8;
            this.pnlHome3.Tag = "Home";
            // 
            // picGreenPlayer
            // 
            this.picGreenPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picGreenPlayer.Image = global::project_451.Properties.Resources.gnomehat;
            this.picGreenPlayer.Location = new System.Drawing.Point(30, 15);
            this.picGreenPlayer.Name = "picGreenPlayer";
            this.picGreenPlayer.Size = new System.Drawing.Size(34, 57);
            this.picGreenPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGreenPlayer.TabIndex = 26;
            this.picGreenPlayer.TabStop = false;
            // 
            // pnlTileRight1
            // 
            this.pnlTileRight1.BackgroundImage = global::project_451.Properties.Resources.bookstile;
            this.pnlTileRight1.Location = new System.Drawing.Point(800, 111);
            this.pnlTileRight1.Name = "pnlTileRight1";
            this.pnlTileRight1.Size = new System.Drawing.Size(90, 90);
            this.pnlTileRight1.TabIndex = 19;
            // 
            // pnlTileLeft2
            // 
            this.pnlTileLeft2.BackgroundImage = global::project_451.Properties.Resources.multitile;
            this.pnlTileLeft2.Location = new System.Drawing.Point(170, 201);
            this.pnlTileLeft2.Name = "pnlTileLeft2";
            this.pnlTileLeft2.Size = new System.Drawing.Size(90, 90);
            this.pnlTileLeft2.TabIndex = 17;
            // 
            // pnlHome2
            // 
            this.pnlHome2.BackgroundImage = global::project_451.Properties.Resources.iconHomeTile;
            this.pnlHome2.Controls.Add(this.picBluePlayer);
            this.pnlHome2.Location = new System.Drawing.Point(800, 21);
            this.pnlHome2.Name = "pnlHome2";
            this.pnlHome2.Size = new System.Drawing.Size(90, 90);
            this.pnlHome2.TabIndex = 2;
            this.pnlHome2.Tag = "Home";
            // 
            // picBluePlayer
            // 
            this.picBluePlayer.BackColor = System.Drawing.Color.Transparent;
            this.picBluePlayer.Image = global::project_451.Properties.Resources.gnomehatblue;
            this.picBluePlayer.Location = new System.Drawing.Point(30, 17);
            this.picBluePlayer.Name = "picBluePlayer";
            this.picBluePlayer.Size = new System.Drawing.Size(34, 57);
            this.picBluePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBluePlayer.TabIndex = 24;
            this.picBluePlayer.TabStop = false;
            // 
            // pnlHome4
            // 
            this.pnlHome4.BackgroundImage = global::project_451.Properties.Resources.iconHomeTile;
            this.pnlHome4.Controls.Add(this.picGreyPlayer);
            this.pnlHome4.Location = new System.Drawing.Point(170, 381);
            this.pnlHome4.Name = "pnlHome4";
            this.pnlHome4.Size = new System.Drawing.Size(90, 90);
            this.pnlHome4.TabIndex = 6;
            this.pnlHome4.Tag = "Home";
            // 
            // picGreyPlayer
            // 
            this.picGreyPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picGreyPlayer.Image = global::project_451.Properties.Resources.gnomehatgrey;
            this.picGreyPlayer.Location = new System.Drawing.Point(20, 15);
            this.picGreyPlayer.Name = "picGreyPlayer";
            this.picGreyPlayer.Size = new System.Drawing.Size(34, 57);
            this.picGreyPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGreyPlayer.TabIndex = 25;
            this.picGreyPlayer.TabStop = false;
            // 
            // pnlTileBot6
            // 
            this.pnlTileBot6.BackgroundImage = global::project_451.Properties.Resources.quotetile;
            this.pnlTileBot6.Location = new System.Drawing.Point(710, 381);
            this.pnlTileBot6.Name = "pnlTileBot6";
            this.pnlTileBot6.Size = new System.Drawing.Size(90, 90);
            this.pnlTileBot6.TabIndex = 12;
            // 
            // pnlHome1
            // 
            this.pnlHome1.BackgroundImage = global::project_451.Properties.Resources.iconHomeTile;
            this.pnlHome1.Controls.Add(this.picRedPlayer);
            this.pnlHome1.Location = new System.Drawing.Point(170, 21);
            this.pnlHome1.Name = "pnlHome1";
            this.pnlHome1.Size = new System.Drawing.Size(90, 90);
            this.pnlHome1.TabIndex = 1;
            this.pnlHome1.Tag = "Home";
            // 
            // picRedPlayer
            // 
            this.picRedPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picRedPlayer.Image = global::project_451.Properties.Resources.gnomehatred;
            this.picRedPlayer.Location = new System.Drawing.Point(20, 17);
            this.picRedPlayer.Name = "picRedPlayer";
            this.picRedPlayer.Size = new System.Drawing.Size(34, 57);
            this.picRedPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRedPlayer.TabIndex = 23;
            this.picRedPlayer.TabStop = false;
            // 
            // pnlTileLeft1
            // 
            this.pnlTileLeft1.BackgroundImage = global::project_451.Properties.Resources.bookstile;
            this.pnlTileLeft1.Location = new System.Drawing.Point(170, 111);
            this.pnlTileLeft1.Name = "pnlTileLeft1";
            this.pnlTileLeft1.Size = new System.Drawing.Size(90, 90);
            this.pnlTileLeft1.TabIndex = 13;
            // 
            // pnlTileBot5
            // 
            this.pnlTileBot5.BackgroundImage = global::project_451.Properties.Resources.multitile;
            this.pnlTileBot5.Location = new System.Drawing.Point(620, 381);
            this.pnlTileBot5.Name = "pnlTileBot5";
            this.pnlTileBot5.Size = new System.Drawing.Size(90, 90);
            this.pnlTileBot5.TabIndex = 11;
            // 
            // pnlTileTop6
            // 
            this.pnlTileTop6.BackgroundImage = global::project_451.Properties.Resources.quotetile;
            this.pnlTileTop6.Location = new System.Drawing.Point(710, 21);
            this.pnlTileTop6.Name = "pnlTileTop6";
            this.pnlTileTop6.Size = new System.Drawing.Size(90, 90);
            this.pnlTileTop6.TabIndex = 4;
            // 
            // pnlTileBot4
            // 
            this.pnlTileBot4.BackgroundImage = global::project_451.Properties.Resources.iconRollAgainTile;
            this.pnlTileBot4.Location = new System.Drawing.Point(530, 381);
            this.pnlTileBot4.Name = "pnlTileBot4";
            this.pnlTileBot4.Size = new System.Drawing.Size(90, 90);
            this.pnlTileBot4.TabIndex = 9;
            // 
            // pnlTileTop5
            // 
            this.pnlTileTop5.BackgroundImage = global::project_451.Properties.Resources.multitile;
            this.pnlTileTop5.Location = new System.Drawing.Point(620, 21);
            this.pnlTileTop5.Name = "pnlTileTop5";
            this.pnlTileTop5.Size = new System.Drawing.Size(90, 90);
            this.pnlTileTop5.TabIndex = 3;
            // 
            // pnlTileBot3
            // 
            this.pnlTileBot3.BackgroundImage = global::project_451.Properties.Resources.iconTeleportTile;
            this.pnlTileBot3.Location = new System.Drawing.Point(440, 381);
            this.pnlTileBot3.Name = "pnlTileBot3";
            this.pnlTileBot3.Size = new System.Drawing.Size(90, 90);
            this.pnlTileBot3.TabIndex = 10;
            // 
            // pnlTileBot2
            // 
            this.pnlTileBot2.BackgroundImage = global::project_451.Properties.Resources.iconTrueOrFalseTile;
            this.pnlTileBot2.Location = new System.Drawing.Point(350, 381);
            this.pnlTileBot2.Name = "pnlTileBot2";
            this.pnlTileBot2.Size = new System.Drawing.Size(90, 90);
            this.pnlTileBot2.TabIndex = 7;
            // 
            // pnlTileTop4
            // 
            this.pnlTileTop4.BackgroundImage = global::project_451.Properties.Resources.iconRollAgainTile;
            this.pnlTileTop4.Location = new System.Drawing.Point(530, 21);
            this.pnlTileTop4.Name = "pnlTileTop4";
            this.pnlTileTop4.Size = new System.Drawing.Size(90, 90);
            this.pnlTileTop4.TabIndex = 2;
            // 
            // pnlTileBot1
            // 
            this.pnlTileBot1.BackgroundImage = global::project_451.Properties.Resources.bookstile;
            this.pnlTileBot1.Location = new System.Drawing.Point(260, 381);
            this.pnlTileBot1.Name = "pnlTileBot1";
            this.pnlTileBot1.Size = new System.Drawing.Size(90, 90);
            this.pnlTileBot1.TabIndex = 5;
            // 
            // pnlTileTop3
            // 
            this.pnlTileTop3.BackgroundImage = global::project_451.Properties.Resources.iconTeleportTile;
            this.pnlTileTop3.Location = new System.Drawing.Point(440, 21);
            this.pnlTileTop3.Name = "pnlTileTop3";
            this.pnlTileTop3.Size = new System.Drawing.Size(90, 90);
            this.pnlTileTop3.TabIndex = 2;
            // 
            // pnlTileTop2
            // 
            this.pnlTileTop2.BackgroundImage = global::project_451.Properties.Resources.iconTrueOrFalseTile;
            this.pnlTileTop2.Location = new System.Drawing.Point(350, 21);
            this.pnlTileTop2.Name = "pnlTileTop2";
            this.pnlTileTop2.Size = new System.Drawing.Size(90, 90);
            this.pnlTileTop2.TabIndex = 1;
            // 
            // pnlTileTop1
            // 
            this.pnlTileTop1.BackgroundImage = global::project_451.Properties.Resources.bookstile;
            this.pnlTileTop1.Location = new System.Drawing.Point(260, 21);
            this.pnlTileTop1.Name = "pnlTileTop1";
            this.pnlTileTop1.Size = new System.Drawing.Size(90, 90);
            this.pnlTileTop1.TabIndex = 0;
            // 
            // lblConfused
            // 
            this.lblConfused.AutoSize = true;
            this.lblConfused.Location = new System.Drawing.Point(324, 352);
            this.lblConfused.Name = "lblConfused";
            this.lblConfused.Size = new System.Drawing.Size(395, 13);
            this.lblConfused.TabIndex = 47;
            this.lblConfused.Text = "If you\'re still confused, just keep rolling the die and answering trivia. You can" +
    "\'t lose.";
            this.lblConfused.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 493);
            this.Controls.Add(this.lblConfused);
            this.Controls.Add(this.lblViewAnswers);
            this.Controls.Add(this.lblNoTime);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblGreyNorm);
            this.Controls.Add(this.lblGreenNorm);
            this.Controls.Add(this.lblBlueNorm);
            this.Controls.Add(this.lblRedNorm);
            this.Controls.Add(this.lblGreyBooks);
            this.Controls.Add(this.prgGreyNorm);
            this.Controls.Add(this.lblGreyName);
            this.Controls.Add(this.lblRedBooks);
            this.Controls.Add(this.prgRedNorm);
            this.Controls.Add(this.lblRedName);
            this.Controls.Add(this.lblBlueBooks);
            this.Controls.Add(this.prgBlueNorm);
            this.Controls.Add(this.lblBlueName);
            this.Controls.Add(this.lblGreenBooks);
            this.Controls.Add(this.prgGreenNorm);
            this.Controls.Add(this.lblGreenName);
            this.Controls.Add(this.btnRollADie);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.pnlTileRight3);
            this.Controls.Add(this.pnlTileLeft3);
            this.Controls.Add(this.pnlTileRight2);
            this.Controls.Add(this.pnlHome3);
            this.Controls.Add(this.pnlTileRight1);
            this.Controls.Add(this.pnlTileLeft2);
            this.Controls.Add(this.pnlHome2);
            this.Controls.Add(this.pnlHome4);
            this.Controls.Add(this.pnlTileBot6);
            this.Controls.Add(this.pnlHome1);
            this.Controls.Add(this.pnlTileLeft1);
            this.Controls.Add(this.pnlTileBot5);
            this.Controls.Add(this.pnlTileTop6);
            this.Controls.Add(this.pnlTileBot4);
            this.Controls.Add(this.pnlTileTop5);
            this.Controls.Add(this.pnlTileBot3);
            this.Controls.Add(this.lstGameLog);
            this.Controls.Add(this.pnlTileBot2);
            this.Controls.Add(this.pnlTileTop4);
            this.Controls.Add(this.pnlTileBot1);
            this.Controls.Add(this.pnlTileTop3);
            this.Controls.Add(this.pnlTileTop2);
            this.Controls.Add(this.pnlTileTop1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGameMain";
            this.Text = "Project 451";
            this.Load += new System.EventHandler(this.frmGameMain_Load);
            this.pnlHome3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGreenPlayer)).EndInit();
            this.pnlHome2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBluePlayer)).EndInit();
            this.pnlHome4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGreyPlayer)).EndInit();
            this.pnlHome1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRedPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTileTop1;
        private System.Windows.Forms.Panel pnlTileTop2;
        private System.Windows.Forms.Panel pnlTileTop3;
        private System.Windows.Forms.Panel pnlTileTop4;
        private System.Windows.Forms.ListBox lstGameLog;
        private System.Windows.Forms.Panel pnlTileTop5;
        private System.Windows.Forms.Panel pnlTileTop6;
        private System.Windows.Forms.Panel pnlHome1;
        private System.Windows.Forms.Panel pnlHome2;
        private System.Windows.Forms.Panel pnlHome3;
        private System.Windows.Forms.Panel pnlHome4;
        private System.Windows.Forms.Panel pnlTileBot6;
        private System.Windows.Forms.Panel pnlTileBot5;
        private System.Windows.Forms.Panel pnlTileBot4;
        private System.Windows.Forms.Panel pnlTileBot3;
        private System.Windows.Forms.Panel pnlTileBot2;
        private System.Windows.Forms.Panel pnlTileBot1;
        private System.Windows.Forms.Panel pnlTileLeft3;
        private System.Windows.Forms.Panel pnlTileLeft2;
        private System.Windows.Forms.Panel pnlTileLeft1;
        private System.Windows.Forms.Panel pnlTileRight3;
        private System.Windows.Forms.Panel pnlTileRight2;
        private System.Windows.Forms.Panel pnlTileRight1;
        private System.Windows.Forms.Timer tmrRandomizer;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.PictureBox picRedPlayer;
        private System.Windows.Forms.PictureBox picGreenPlayer;
        private System.Windows.Forms.PictureBox picBluePlayer;
        private System.Windows.Forms.PictureBox picGreyPlayer;
        private System.Windows.Forms.Button btnRollADie;
        private System.Windows.Forms.Label lblGreenName;
        private System.Windows.Forms.ProgressBar prgGreenNorm;
        private System.Windows.Forms.Label lblGreenBooks;
        private System.Windows.Forms.Label lblBlueBooks;
        private System.Windows.Forms.ProgressBar prgBlueNorm;
        private System.Windows.Forms.Label lblBlueName;
        private System.Windows.Forms.Label lblRedBooks;
        private System.Windows.Forms.ProgressBar prgRedNorm;
        private System.Windows.Forms.Label lblRedName;
        private System.Windows.Forms.Label lblGreyBooks;
        private System.Windows.Forms.ProgressBar prgGreyNorm;
        private System.Windows.Forms.Label lblGreyName;
        private System.Windows.Forms.Label lblRedNorm;
        private System.Windows.Forms.Label lblBlueNorm;
        private System.Windows.Forms.Label lblGreenNorm;
        private System.Windows.Forms.Label lblGreyNorm;
        private System.Windows.Forms.Timer tmrPortDelay;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Timer tmrTurnDelay;
        private System.Windows.Forms.Label lblNoTime;
        private System.Windows.Forms.Label lblViewAnswers;
        private System.Windows.Forms.Label lblConfused;
    }
}