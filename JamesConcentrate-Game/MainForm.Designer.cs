namespace JamesConcentrate.Game
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageListFruits = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTimer = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.buttonGameHistory = new System.Windows.Forms.Button();
            this.labelMatchRate = new System.Windows.Forms.Label();
            this.labelStaticMatchRate = new System.Windows.Forms.Label();
            this.labelGamesPlayed = new System.Windows.Forms.Label();
            this.labelMismatches = new System.Windows.Forms.Label();
            this.labelMatches = new System.Windows.Forms.Label();
            this.labelStaticMatches = new System.Windows.Forms.Label();
            this.labelStaticMismatches = new System.Windows.Forms.Label();
            this.labelStaticGamesPlayed = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelBanner = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTopBarClose = new System.Windows.Forms.Label();
            this.labelTopBarMaximize = new System.Windows.Forms.Label();
            this.labelTopBarMinimize = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panelGameDetails = new System.Windows.Forms.Panel();
            this.listBoxGameDetails = new System.Windows.Forms.ListBox();
            this.buttonReplayPrev = new System.Windows.Forms.Button();
            this.buttonReplayBack = new System.Windows.Forms.Button();
            this.labelGameDetailsNumber = new System.Windows.Forms.Label();
            this.buttonReplayNext = new System.Windows.Forms.Button();
            this.panelGameHistory = new System.Windows.Forms.Panel();
            this.buttonGameHistoryBack = new System.Windows.Forms.Button();
            this.labelStaticGameHistory = new System.Windows.Forms.Label();
            this.panelGameList = new System.Windows.Forms.Panel();
            this.timerDebug = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.panelBanner.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.panelGameDetails.SuspendLayout();
            this.panelGameHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListFruits
            // 
            this.imageListFruits.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFruits.ImageStream")));
            this.imageListFruits.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFruits.Images.SetKeyName(0, "Banana.jpg");
            this.imageListFruits.Images.SetKeyName(1, "Cherry.jpg");
            this.imageListFruits.Images.SetKeyName(2, "Coconut.jpg");
            this.imageListFruits.Images.SetKeyName(3, "Kiwi.jpg");
            this.imageListFruits.Images.SetKeyName(4, "Lemon.jpg");
            this.imageListFruits.Images.SetKeyName(5, "Peach.jpg");
            this.imageListFruits.Images.SetKeyName(6, "Strawberry.jpg");
            this.imageListFruits.Images.SetKeyName(7, "Watermelon.jpg");
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::JamesConcentrate.Game.Properties.Resources.Bkg_Timer;
            this.panel3.Controls.Add(this.labelTimer);
            this.panel3.Location = new System.Drawing.Point(416, 489);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 37);
            this.panel3.TabIndex = 19;
            // 
            // labelTimer
            // 
            this.labelTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTimer.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.ForeColor = System.Drawing.Color.SeaShell;
            this.labelTimer.Location = new System.Drawing.Point(2, 2);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(121, 31);
            this.labelTimer.TabIndex = 1;
            this.labelTimer.Text = "0:00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.Transparent;
            this.panelGrid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGrid.BackgroundImage")));
            this.panelGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGrid.Location = new System.Drawing.Point(213, 74);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(536, 402);
            this.panelGrid.TabIndex = 18;
            // 
            // panelOptions
            // 
            this.panelOptions.AutoScroll = true;
            this.panelOptions.BackColor = System.Drawing.Color.Transparent;
            this.panelOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelOptions.BackgroundImage")));
            this.panelOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelOptions.Controls.Add(this.buttonGameHistory);
            this.panelOptions.Controls.Add(this.labelMatchRate);
            this.panelOptions.Controls.Add(this.labelStaticMatchRate);
            this.panelOptions.Controls.Add(this.labelGamesPlayed);
            this.panelOptions.Controls.Add(this.labelMismatches);
            this.panelOptions.Controls.Add(this.labelMatches);
            this.panelOptions.Controls.Add(this.labelStaticMatches);
            this.panelOptions.Controls.Add(this.labelStaticMismatches);
            this.panelOptions.Controls.Add(this.labelStaticGamesPlayed);
            this.panelOptions.Controls.Add(this.labelUserName);
            this.panelOptions.Controls.Add(this.buttonDisplay);
            this.panelOptions.Controls.Add(this.buttonHide);
            this.panelOptions.Controls.Add(this.buttonStart);
            this.panelOptions.Location = new System.Drawing.Point(15, 74);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(184, 402);
            this.panelOptions.TabIndex = 16;
            // 
            // buttonGameHistory
            // 
            this.buttonGameHistory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonGameHistory.FlatAppearance.BorderSize = 0;
            this.buttonGameHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGameHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGameHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(107)))));
            this.buttonGameHistory.Location = new System.Drawing.Point(22, 161);
            this.buttonGameHistory.Name = "buttonGameHistory";
            this.buttonGameHistory.Size = new System.Drawing.Size(141, 28);
            this.buttonGameHistory.TabIndex = 13;
            this.buttonGameHistory.Text = "Game History";
            this.buttonGameHistory.UseVisualStyleBackColor = false;
            this.buttonGameHistory.Click += new System.EventHandler(this.buttonGameHistory_Click_1);
            // 
            // labelMatchRate
            // 
            this.labelMatchRate.BackColor = System.Drawing.Color.Transparent;
            this.labelMatchRate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchRate.ForeColor = System.Drawing.Color.SeaShell;
            this.labelMatchRate.Location = new System.Drawing.Point(110, 123);
            this.labelMatchRate.Name = "labelMatchRate";
            this.labelMatchRate.Size = new System.Drawing.Size(48, 20);
            this.labelMatchRate.TabIndex = 12;
            this.labelMatchRate.Text = "0";
            this.labelMatchRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelStaticMatchRate
            // 
            this.labelStaticMatchRate.BackColor = System.Drawing.Color.Transparent;
            this.labelStaticMatchRate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaticMatchRate.ForeColor = System.Drawing.Color.SeaShell;
            this.labelStaticMatchRate.Location = new System.Drawing.Point(23, 123);
            this.labelStaticMatchRate.Name = "labelStaticMatchRate";
            this.labelStaticMatchRate.Size = new System.Drawing.Size(81, 20);
            this.labelStaticMatchRate.TabIndex = 11;
            this.labelStaticMatchRate.Text = "Match Rate: ";
            this.labelStaticMatchRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGamesPlayed
            // 
            this.labelGamesPlayed.BackColor = System.Drawing.Color.Transparent;
            this.labelGamesPlayed.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGamesPlayed.ForeColor = System.Drawing.Color.SeaShell;
            this.labelGamesPlayed.Location = new System.Drawing.Point(123, 63);
            this.labelGamesPlayed.Name = "labelGamesPlayed";
            this.labelGamesPlayed.Size = new System.Drawing.Size(35, 20);
            this.labelGamesPlayed.TabIndex = 10;
            this.labelGamesPlayed.Text = "0";
            this.labelGamesPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMismatches
            // 
            this.labelMismatches.BackColor = System.Drawing.Color.Transparent;
            this.labelMismatches.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMismatches.ForeColor = System.Drawing.Color.SeaShell;
            this.labelMismatches.Location = new System.Drawing.Point(123, 103);
            this.labelMismatches.Name = "labelMismatches";
            this.labelMismatches.Size = new System.Drawing.Size(35, 20);
            this.labelMismatches.TabIndex = 9;
            this.labelMismatches.Text = "0";
            this.labelMismatches.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMatches
            // 
            this.labelMatches.BackColor = System.Drawing.Color.Transparent;
            this.labelMatches.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatches.ForeColor = System.Drawing.Color.SeaShell;
            this.labelMatches.Location = new System.Drawing.Point(123, 83);
            this.labelMatches.Name = "labelMatches";
            this.labelMatches.Size = new System.Drawing.Size(35, 20);
            this.labelMatches.TabIndex = 8;
            this.labelMatches.Text = "0";
            this.labelMatches.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelStaticMatches
            // 
            this.labelStaticMatches.BackColor = System.Drawing.Color.Transparent;
            this.labelStaticMatches.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaticMatches.ForeColor = System.Drawing.Color.SeaShell;
            this.labelStaticMatches.Location = new System.Drawing.Point(23, 83);
            this.labelStaticMatches.Name = "labelStaticMatches";
            this.labelStaticMatches.Size = new System.Drawing.Size(105, 20);
            this.labelStaticMatches.TabIndex = 7;
            this.labelStaticMatches.Text = "Matches:";
            this.labelStaticMatches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStaticMismatches
            // 
            this.labelStaticMismatches.BackColor = System.Drawing.Color.Transparent;
            this.labelStaticMismatches.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaticMismatches.ForeColor = System.Drawing.Color.SeaShell;
            this.labelStaticMismatches.Location = new System.Drawing.Point(23, 103);
            this.labelStaticMismatches.Name = "labelStaticMismatches";
            this.labelStaticMismatches.Size = new System.Drawing.Size(105, 20);
            this.labelStaticMismatches.TabIndex = 6;
            this.labelStaticMismatches.Text = "Mismatches:";
            this.labelStaticMismatches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStaticGamesPlayed
            // 
            this.labelStaticGamesPlayed.BackColor = System.Drawing.Color.Transparent;
            this.labelStaticGamesPlayed.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaticGamesPlayed.ForeColor = System.Drawing.Color.SeaShell;
            this.labelStaticGamesPlayed.Location = new System.Drawing.Point(23, 63);
            this.labelStaticGamesPlayed.Name = "labelStaticGamesPlayed";
            this.labelStaticGamesPlayed.Size = new System.Drawing.Size(105, 20);
            this.labelStaticGamesPlayed.TabIndex = 5;
            this.labelStaticGamesPlayed.Text = "Games Played: ";
            this.labelStaticGamesPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUserName
            // 
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelUserName.Location = new System.Drawing.Point(9, 11);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(165, 43);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "James McCarthy";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDisplay.FlatAppearance.BorderSize = 0;
            this.buttonDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(107)))));
            this.buttonDisplay.Location = new System.Drawing.Point(22, 317);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(141, 28);
            this.buttonDisplay.TabIndex = 2;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = false;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonHide.FlatAppearance.BorderSize = 0;
            this.buttonHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(107)))));
            this.buttonHide.Location = new System.Drawing.Point(22, 283);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(141, 28);
            this.buttonHide.TabIndex = 1;
            this.buttonHide.Text = "Hide";
            this.buttonHide.UseVisualStyleBackColor = false;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(107)))));
            this.buttonStart.Location = new System.Drawing.Point(22, 351);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(141, 28);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start New Game";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panelBanner
            // 
            this.panelBanner.BackColor = System.Drawing.Color.Black;
            this.panelBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBanner.BackgroundImage")));
            this.panelBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBanner.Controls.Add(this.panel1);
            this.panelBanner.Controls.Add(this.panel4);
            this.panelBanner.Controls.Add(this.panelTopBar);
            this.panelBanner.Location = new System.Drawing.Point(0, 0);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(960, 60);
            this.panelBanner.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelTopBarClose);
            this.panel1.Controls.Add(this.labelTopBarMaximize);
            this.panel1.Controls.Add(this.labelTopBarMinimize);
            this.panel1.Location = new System.Drawing.Point(847, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 27);
            this.panel1.TabIndex = 2;
            // 
            // labelTopBarClose
            // 
            this.labelTopBarClose.BackColor = System.Drawing.Color.Transparent;
            this.labelTopBarClose.Image = ((System.Drawing.Image)(resources.GetObject("labelTopBarClose.Image")));
            this.labelTopBarClose.Location = new System.Drawing.Point(79, 3);
            this.labelTopBarClose.Name = "labelTopBarClose";
            this.labelTopBarClose.Size = new System.Drawing.Size(18, 18);
            this.labelTopBarClose.TabIndex = 2;
            this.labelTopBarClose.Click += new System.EventHandler(this.topBarClose_Click);
            this.labelTopBarClose.MouseEnter += new System.EventHandler(this.topBarIcon_MouseEnter);
            this.labelTopBarClose.MouseLeave += new System.EventHandler(this.topBarIcon_MouseLeave);
            // 
            // labelTopBarMaximize
            // 
            this.labelTopBarMaximize.Image = ((System.Drawing.Image)(resources.GetObject("labelTopBarMaximize.Image")));
            this.labelTopBarMaximize.Location = new System.Drawing.Point(49, 3);
            this.labelTopBarMaximize.Name = "labelTopBarMaximize";
            this.labelTopBarMaximize.Size = new System.Drawing.Size(18, 18);
            this.labelTopBarMaximize.TabIndex = 1;
            this.labelTopBarMaximize.Click += new System.EventHandler(this.labelTopBarMaximize_Click);
            this.labelTopBarMaximize.MouseEnter += new System.EventHandler(this.topBarIcon_MouseEnter);
            this.labelTopBarMaximize.MouseLeave += new System.EventHandler(this.topBarIcon_MouseLeave);
            // 
            // labelTopBarMinimize
            // 
            this.labelTopBarMinimize.Image = ((System.Drawing.Image)(resources.GetObject("labelTopBarMinimize.Image")));
            this.labelTopBarMinimize.Location = new System.Drawing.Point(13, 4);
            this.labelTopBarMinimize.Name = "labelTopBarMinimize";
            this.labelTopBarMinimize.Size = new System.Drawing.Size(18, 18);
            this.labelTopBarMinimize.TabIndex = 0;
            this.labelTopBarMinimize.Click += new System.EventHandler(this.labelTopBarMinimize_Click);
            this.labelTopBarMinimize.MouseEnter += new System.EventHandler(this.topBarIcon_MouseEnter);
            this.labelTopBarMinimize.MouseLeave += new System.EventHandler(this.topBarIcon_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::JamesConcentrate.Game.Properties.Resources.Logo_Alt;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 34);
            this.panel4.TabIndex = 0;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.Transparent;
            this.panelTopBar.Controls.Add(this.label14);
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(960, 30);
            this.panelTopBar.TabIndex = 1;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightGray;
            this.label14.Location = new System.Drawing.Point(360, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(240, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "James\' Concentr8 Preliminaries";
            this.label14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            // 
            // panelGameDetails
            // 
            this.panelGameDetails.AutoScroll = true;
            this.panelGameDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelGameDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGameDetails.BackgroundImage")));
            this.panelGameDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGameDetails.Controls.Add(this.listBoxGameDetails);
            this.panelGameDetails.Controls.Add(this.buttonReplayPrev);
            this.panelGameDetails.Controls.Add(this.buttonReplayBack);
            this.panelGameDetails.Controls.Add(this.labelGameDetailsNumber);
            this.panelGameDetails.Controls.Add(this.buttonReplayNext);
            this.panelGameDetails.Location = new System.Drawing.Point(761, 74);
            this.panelGameDetails.Name = "panelGameDetails";
            this.panelGameDetails.Size = new System.Drawing.Size(184, 402);
            this.panelGameDetails.TabIndex = 18;
            // 
            // listBoxGameDetails
            // 
            this.listBoxGameDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(197)))));
            this.listBoxGameDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxGameDetails.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGameDetails.ForeColor = System.Drawing.Color.White;
            this.listBoxGameDetails.FormattingEnabled = true;
            this.listBoxGameDetails.ItemHeight = 16;
            this.listBoxGameDetails.Items.AddRange(new object[] {
            "    - Please start a new game -"});
            this.listBoxGameDetails.Location = new System.Drawing.Point(7, 65);
            this.listBoxGameDetails.Name = "listBoxGameDetails";
            this.listBoxGameDetails.Size = new System.Drawing.Size(173, 240);
            this.listBoxGameDetails.TabIndex = 18;
            // 
            // buttonReplayPrev
            // 
            this.buttonReplayPrev.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonReplayPrev.FlatAppearance.BorderSize = 0;
            this.buttonReplayPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReplayPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(107)))));
            this.buttonReplayPrev.Location = new System.Drawing.Point(23, 322);
            this.buttonReplayPrev.Name = "buttonReplayPrev";
            this.buttonReplayPrev.Size = new System.Drawing.Size(64, 23);
            this.buttonReplayPrev.TabIndex = 17;
            this.buttonReplayPrev.Text = "Prev";
            this.buttonReplayPrev.UseVisualStyleBackColor = false;
            this.buttonReplayPrev.Visible = false;
            this.buttonReplayPrev.Click += new System.EventHandler(this.buttonReplayPrev_Click);
            // 
            // buttonReplayBack
            // 
            this.buttonReplayBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonReplayBack.FlatAppearance.BorderSize = 0;
            this.buttonReplayBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReplayBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReplayBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(107)))));
            this.buttonReplayBack.Location = new System.Drawing.Point(23, 351);
            this.buttonReplayBack.Name = "buttonReplayBack";
            this.buttonReplayBack.Size = new System.Drawing.Size(136, 28);
            this.buttonReplayBack.TabIndex = 12;
            this.buttonReplayBack.Text = "Back";
            this.buttonReplayBack.UseVisualStyleBackColor = false;
            this.buttonReplayBack.Visible = false;
            this.buttonReplayBack.Click += new System.EventHandler(this.buttonDetailsBack_Click);
            // 
            // labelGameDetailsNumber
            // 
            this.labelGameDetailsNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelGameDetailsNumber.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameDetailsNumber.ForeColor = System.Drawing.Color.SeaShell;
            this.labelGameDetailsNumber.Location = new System.Drawing.Point(24, 11);
            this.labelGameDetailsNumber.Name = "labelGameDetailsNumber";
            this.labelGameDetailsNumber.Size = new System.Drawing.Size(133, 43);
            this.labelGameDetailsNumber.TabIndex = 11;
            this.labelGameDetailsNumber.Text = "Game Info";
            this.labelGameDetailsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReplayNext
            // 
            this.buttonReplayNext.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonReplayNext.FlatAppearance.BorderSize = 0;
            this.buttonReplayNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReplayNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(107)))));
            this.buttonReplayNext.Location = new System.Drawing.Point(93, 322);
            this.buttonReplayNext.Name = "buttonReplayNext";
            this.buttonReplayNext.Size = new System.Drawing.Size(66, 23);
            this.buttonReplayNext.TabIndex = 16;
            this.buttonReplayNext.Text = "Next";
            this.buttonReplayNext.UseVisualStyleBackColor = false;
            this.buttonReplayNext.Visible = false;
            // 
            // panelGameHistory
            // 
            this.panelGameHistory.AutoScroll = true;
            this.panelGameHistory.BackColor = System.Drawing.Color.Transparent;
            this.panelGameHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGameHistory.BackgroundImage")));
            this.panelGameHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGameHistory.Controls.Add(this.buttonGameHistoryBack);
            this.panelGameHistory.Controls.Add(this.labelStaticGameHistory);
            this.panelGameHistory.Controls.Add(this.panelGameList);
            this.panelGameHistory.Location = new System.Drawing.Point(761, 74);
            this.panelGameHistory.Name = "panelGameHistory";
            this.panelGameHistory.Size = new System.Drawing.Size(184, 402);
            this.panelGameHistory.TabIndex = 17;
            this.panelGameHistory.Visible = false;
            // 
            // buttonGameHistoryBack
            // 
            this.buttonGameHistoryBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonGameHistoryBack.FlatAppearance.BorderSize = 0;
            this.buttonGameHistoryBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGameHistoryBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGameHistoryBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(107)))));
            this.buttonGameHistoryBack.Location = new System.Drawing.Point(23, 355);
            this.buttonGameHistoryBack.Name = "buttonGameHistoryBack";
            this.buttonGameHistoryBack.Size = new System.Drawing.Size(141, 28);
            this.buttonGameHistoryBack.TabIndex = 14;
            this.buttonGameHistoryBack.Text = "Back";
            this.buttonGameHistoryBack.UseVisualStyleBackColor = false;
            this.buttonGameHistoryBack.Click += new System.EventHandler(this.buttonGameHistoryBack_Click);
            // 
            // labelStaticGameHistory
            // 
            this.labelStaticGameHistory.BackColor = System.Drawing.Color.Transparent;
            this.labelStaticGameHistory.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaticGameHistory.ForeColor = System.Drawing.Color.SeaShell;
            this.labelStaticGameHistory.Location = new System.Drawing.Point(24, 11);
            this.labelStaticGameHistory.Name = "labelStaticGameHistory";
            this.labelStaticGameHistory.Size = new System.Drawing.Size(135, 43);
            this.labelStaticGameHistory.TabIndex = 11;
            this.labelStaticGameHistory.Text = "Game History";
            this.labelStaticGameHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGameList
            // 
            this.panelGameList.AutoScroll = true;
            this.panelGameList.BackColor = System.Drawing.Color.Transparent;
            this.panelGameList.ForeColor = System.Drawing.Color.OrangeRed;
            this.panelGameList.Location = new System.Drawing.Point(9, 58);
            this.panelGameList.Name = "panelGameList";
            this.panelGameList.Size = new System.Drawing.Size(166, 284);
            this.panelGameList.TabIndex = 0;
            // 
            // timerDebug
            // 
            this.timerDebug.Enabled = true;
            this.timerDebug.Interval = 1000;
            this.timerDebug.Tick += new System.EventHandler(this.timerDebug_Tick_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.panelBanner);
            this.Controls.Add(this.panelGameHistory);
            this.Controls.Add(this.panelGameDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            this.panelBanner.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelGameDetails.ResumeLayout(false);
            this.panelGameHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.ImageList imageListFruits;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelGameHistory;
        private System.Windows.Forms.Panel panelGameList;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelStaticGamesPlayed;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelGamesPlayed;
        private System.Windows.Forms.Label labelMismatches;
        private System.Windows.Forms.Label labelMatches;
        private System.Windows.Forms.Label labelStaticMatches;
        private System.Windows.Forms.Label labelStaticMismatches;
        private System.Windows.Forms.Label labelStaticGameHistory;
        private System.Windows.Forms.Panel panelGameDetails;
        private System.Windows.Forms.Label labelGameDetailsNumber;
        private System.Windows.Forms.Button buttonReplayPrev;
        private System.Windows.Forms.Button buttonReplayNext;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTopBarMinimize;
        private System.Windows.Forms.Label labelTopBarClose;
        private System.Windows.Forms.Label labelTopBarMaximize;
        private System.Windows.Forms.Button buttonReplayBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBoxGameDetails;
        private System.Windows.Forms.Timer timerDebug;
        private System.Windows.Forms.Label labelMatchRate;
        private System.Windows.Forms.Label labelStaticMatchRate;
        private System.Windows.Forms.Button buttonGameHistory;
        private System.Windows.Forms.Button buttonGameHistoryBack;
    }
}

