
namespace WeAreTheChampions
{
    partial class HomePage
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
            if (Disposing)
            {
                db.Dispose();
            }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabCntrlMatches = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.pbTeam1 = new System.Windows.Forms.PictureBox();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.pbTeam2 = new System.Windows.Forms.PictureBox();
            this.chkHideMatches = new System.Windows.Forms.CheckBox();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.btnDeleteSelectedMatch = new System.Windows.Forms.Button();
            this.btnEditSelectedMatch = new System.Windows.Forms.Button();
            this.btnAddMatch = new System.Windows.Forms.Button();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.tabCntrlTeams = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnTeamRemovePlayer = new System.Windows.Forms.Button();
            this.pboTeamPlayerPhoto = new System.Windows.Forms.PictureBox();
            this.lstTeamPlayers = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pboTeamColorInfo = new System.Windows.Forms.PictureBox();
            this.btnTeamCancel = new System.Windows.Forms.Button();
            this.btnTeamAdd = new System.Windows.Forms.Button();
            this.btnTeamOk = new System.Windows.Forms.Button();
            this.lviTeamColorsToChoose = new System.Windows.Forms.ListView();
            this.imlColors = new System.Windows.Forms.ImageList(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTeamEdit = new System.Windows.Forms.Button();
            this.btnTeamDelete = new System.Windows.Forms.Button();
            this.lviTeamColors = new System.Windows.Forms.ListView();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.tabCntrlColors = new System.Windows.Forms.TabPage();
            this.pboColorWheelInfo = new System.Windows.Forms.PictureBox();
            this.pboColorInfo = new System.Windows.Forms.PictureBox();
            this.btnColorCancel = new System.Windows.Forms.Button();
            this.btnColorOk = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.btnColorEdit = new System.Windows.Forms.Button();
            this.btnColorDelete = new System.Windows.Forms.Button();
            this.btnColorAdd = new System.Windows.Forms.Button();
            this.pboSelectedColor = new System.Windows.Forms.PictureBox();
            this.pboColorWheel = new System.Windows.Forms.PictureBox();
            this.lviColors = new System.Windows.Forms.ListView();
            this.tabCntrlPlayers = new System.Windows.Forms.TabPage();
            this.gbTransfer = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbPlayerTransferTeam = new System.Windows.Forms.ComboBox();
            this.btnPlayerTransferCancel = new System.Windows.Forms.Button();
            this.btnPlayerTransfer = new System.Windows.Forms.Button();
            this.gbPlayerInfo = new System.Windows.Forms.GroupBox();
            this.btnPlayerChangeTeam = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSelectedPlayerTeam = new System.Windows.Forms.TextBox();
            this.txtSelectedPlayerName = new System.Windows.Forms.TextBox();
            this.pboPlayerSelectedPhoto = new System.Windows.Forms.PictureBox();
            this.gbPlayers = new System.Windows.Forms.GroupBox();
            this.btnPlayerEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlayerDelete = new System.Windows.Forms.Button();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.cmbTeams = new System.Windows.Forms.ComboBox();
            this.gbPlayerAdd = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPlayerCancel = new System.Windows.Forms.Button();
            this.btnPlayerSave = new System.Windows.Forms.Button();
            this.btnPlayerBrowse = new System.Windows.Forms.Button();
            this.btnPlayerAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlayerWillAddName = new System.Windows.Forms.TextBox();
            this.cmbPlayerWillAddTeam = new System.Windows.Forms.ComboBox();
            this.txtPlayerPhotoPath = new System.Windows.Forms.TextBox();
            this.pboPlayerWillAddPhoto = new System.Windows.Forms.PictureBox();
            this.tlpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabCntrlMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.tabCntrlTeams.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboTeamPlayerPhoto)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboTeamColorInfo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabCntrlColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboColorWheelInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboColorInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSelectedColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboColorWheel)).BeginInit();
            this.tabCntrlPlayers.SuspendLayout();
            this.gbTransfer.SuspendLayout();
            this.gbPlayerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboPlayerSelectedPhoto)).BeginInit();
            this.gbPlayers.SuspendLayout();
            this.gbPlayerAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboPlayerWillAddPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabCntrlMatches);
            this.tabControlMain.Controls.Add(this.tabCntrlTeams);
            this.tabControlMain.Controls.Add(this.tabCntrlColors);
            this.tabControlMain.Controls.Add(this.tabCntrlPlayers);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(975, 519);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabCntrlMatches
            // 
            this.tabCntrlMatches.BackgroundImage = global::WeAreTheChampions.Properties.Resources.blackwhitefield;
            this.tabCntrlMatches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCntrlMatches.Controls.Add(this.label1);
            this.tabCntrlMatches.Controls.Add(this.lblScore2);
            this.tabCntrlMatches.Controls.Add(this.lblScore1);
            this.tabCntrlMatches.Controls.Add(this.pbTeam1);
            this.tabCntrlMatches.Controls.Add(this.lblTeam1);
            this.tabCntrlMatches.Controls.Add(this.pbTeam2);
            this.tabCntrlMatches.Controls.Add(this.chkHideMatches);
            this.tabCntrlMatches.Controls.Add(this.lblTeam2);
            this.tabCntrlMatches.Controls.Add(this.btnDeleteSelectedMatch);
            this.tabCntrlMatches.Controls.Add(this.btnEditSelectedMatch);
            this.tabCntrlMatches.Controls.Add(this.btnAddMatch);
            this.tabCntrlMatches.Controls.Add(this.dgvMatches);
            this.tabCntrlMatches.Location = new System.Drawing.Point(4, 22);
            this.tabCntrlMatches.Name = "tabCntrlMatches";
            this.tabCntrlMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tabCntrlMatches.Size = new System.Drawing.Size(967, 493);
            this.tabCntrlMatches.TabIndex = 0;
            this.tabCntrlMatches.Text = "Matches";
            this.tabCntrlMatches.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(453, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Result";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(128)))));
            this.lblScore2.Location = new System.Drawing.Point(491, 48);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(20, 24);
            this.lblScore2.TabIndex = 15;
            this.lblScore2.Text = "?";
            this.lblScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(128)))));
            this.lblScore1.Location = new System.Drawing.Point(461, 48);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblScore1.Size = new System.Drawing.Size(20, 24);
            this.lblScore1.TabIndex = 14;
            this.lblScore1.Text = "?";
            this.lblScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbTeam1
            // 
            this.pbTeam1.Image = global::WeAreTheChampions.Properties.Resources.SoccerKing;
            this.pbTeam1.Location = new System.Drawing.Point(116, 293);
            this.pbTeam1.Name = "pbTeam1";
            this.pbTeam1.Size = new System.Drawing.Size(78, 84);
            this.pbTeam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTeam1.TabIndex = 12;
            this.pbTeam1.TabStop = false;
            this.pbTeam1.Visible = false;
            // 
            // lblTeam1
            // 
            this.lblTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeam1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(128)))));
            this.lblTeam1.Location = new System.Drawing.Point(61, 130);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(123, 17);
            this.lblTeam1.TabIndex = 9;
            this.lblTeam1.Text = "Team 1";
            this.lblTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbTeam2
            // 
            this.pbTeam2.Image = global::WeAreTheChampions.Properties.Resources.SoccerKing;
            this.pbTeam2.Location = new System.Drawing.Point(778, 293);
            this.pbTeam2.Name = "pbTeam2";
            this.pbTeam2.Size = new System.Drawing.Size(78, 84);
            this.pbTeam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTeam2.TabIndex = 13;
            this.pbTeam2.TabStop = false;
            this.pbTeam2.Visible = false;
            // 
            // chkHideMatches
            // 
            this.chkHideMatches.AutoSize = true;
            this.chkHideMatches.ForeColor = System.Drawing.Color.White;
            this.chkHideMatches.Location = new System.Drawing.Point(226, 387);
            this.chkHideMatches.Name = "chkHideMatches";
            this.chkHideMatches.Size = new System.Drawing.Size(140, 17);
            this.chkHideMatches.TabIndex = 13;
            this.chkHideMatches.Text = "Hide Unplayed Matches";
            this.chkHideMatches.UseVisualStyleBackColor = true;
            this.chkHideMatches.CheckedChanged += new System.EventHandler(this.chkHideMatches_CheckedChanged);
            // 
            // lblTeam2
            // 
            this.lblTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeam2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(120)))));
            this.lblTeam2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTeam2.Location = new System.Drawing.Point(789, 130);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTeam2.Size = new System.Drawing.Size(122, 17);
            this.lblTeam2.TabIndex = 11;
            this.lblTeam2.Text = "Team 2";
            this.lblTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteSelectedMatch
            // 
            this.btnDeleteSelectedMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(120)))));
            this.btnDeleteSelectedMatch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteSelectedMatch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteSelectedMatch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeleteSelectedMatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDeleteSelectedMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedMatch.Location = new System.Drawing.Point(659, 383);
            this.btnDeleteSelectedMatch.Name = "btnDeleteSelectedMatch";
            this.btnDeleteSelectedMatch.Size = new System.Drawing.Size(86, 23);
            this.btnDeleteSelectedMatch.TabIndex = 3;
            this.btnDeleteSelectedMatch.Text = "Delete";
            this.btnDeleteSelectedMatch.UseVisualStyleBackColor = false;
            this.btnDeleteSelectedMatch.Click += new System.EventHandler(this.btnDeleteSelectedMatch_Click);
            // 
            // btnEditSelectedMatch
            // 
            this.btnEditSelectedMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(120)))));
            this.btnEditSelectedMatch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEditSelectedMatch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditSelectedMatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEditSelectedMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSelectedMatch.Location = new System.Drawing.Point(567, 383);
            this.btnEditSelectedMatch.Name = "btnEditSelectedMatch";
            this.btnEditSelectedMatch.Size = new System.Drawing.Size(86, 23);
            this.btnEditSelectedMatch.TabIndex = 2;
            this.btnEditSelectedMatch.Text = "Edit";
            this.btnEditSelectedMatch.UseVisualStyleBackColor = false;
            this.btnEditSelectedMatch.Click += new System.EventHandler(this.btnEditSelectedMatch_Click);
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(120)))));
            this.btnAddMatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddMatch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddMatch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddMatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMatch.Location = new System.Drawing.Point(659, 100);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(86, 23);
            this.btnAddMatch.TabIndex = 1;
            this.btnAddMatch.Text = "Add Match";
            this.btnAddMatch.UseVisualStyleBackColor = false;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMatches.BackgroundColor = System.Drawing.Color.Black;
            this.dgvMatches.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.GridColor = System.Drawing.Color.Black;
            this.dgvMatches.Location = new System.Drawing.Point(226, 129);
            this.dgvMatches.MultiSelect = false;
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.RowHeadersVisible = false;
            this.dgvMatches.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(519, 248);
            this.dgvMatches.TabIndex = 0;
            this.dgvMatches.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMatches_CellMouseClick);
            // 
            // tabCntrlTeams
            // 
            this.tabCntrlTeams.Controls.Add(this.groupBox6);
            this.tabCntrlTeams.Controls.Add(this.groupBox5);
            this.tabCntrlTeams.Controls.Add(this.groupBox4);
            this.tabCntrlTeams.Location = new System.Drawing.Point(4, 22);
            this.tabCntrlTeams.Name = "tabCntrlTeams";
            this.tabCntrlTeams.Padding = new System.Windows.Forms.Padding(3);
            this.tabCntrlTeams.Size = new System.Drawing.Size(967, 493);
            this.tabCntrlTeams.TabIndex = 1;
            this.tabCntrlTeams.Text = "Teams";
            this.tabCntrlTeams.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.btnTeamRemovePlayer);
            this.groupBox6.Controls.Add(this.pboTeamPlayerPhoto);
            this.groupBox6.Controls.Add(this.lstTeamPlayers);
            this.groupBox6.Location = new System.Drawing.Point(558, 260);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(403, 227);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Players";
            // 
            // btnTeamRemovePlayer
            // 
            this.btnTeamRemovePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeamRemovePlayer.Location = new System.Drawing.Point(237, 197);
            this.btnTeamRemovePlayer.Name = "btnTeamRemovePlayer";
            this.btnTeamRemovePlayer.Size = new System.Drawing.Size(157, 22);
            this.btnTeamRemovePlayer.TabIndex = 2;
            this.btnTeamRemovePlayer.Text = "Remove From Team";
            this.btnTeamRemovePlayer.UseVisualStyleBackColor = true;
            this.btnTeamRemovePlayer.Click += new System.EventHandler(this.btnTeamRemovePlayer_Click);
            // 
            // pboTeamPlayerPhoto
            // 
            this.pboTeamPlayerPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboTeamPlayerPhoto.ErrorImage = global::WeAreTheChampions.Properties.Resources.defaultimage;
            this.pboTeamPlayerPhoto.Image = global::WeAreTheChampions.Properties.Resources.defaultimage;
            this.pboTeamPlayerPhoto.InitialImage = global::WeAreTheChampions.Properties.Resources.defaultimage;
            this.pboTeamPlayerPhoto.Location = new System.Drawing.Point(237, 20);
            this.pboTeamPlayerPhoto.Name = "pboTeamPlayerPhoto";
            this.pboTeamPlayerPhoto.Size = new System.Drawing.Size(157, 169);
            this.pboTeamPlayerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboTeamPlayerPhoto.TabIndex = 1;
            this.pboTeamPlayerPhoto.TabStop = false;
            // 
            // lstTeamPlayers
            // 
            this.lstTeamPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTeamPlayers.DisplayMember = "PlayerName";
            this.lstTeamPlayers.FormattingEnabled = true;
            this.lstTeamPlayers.Location = new System.Drawing.Point(7, 20);
            this.lstTeamPlayers.Name = "lstTeamPlayers";
            this.lstTeamPlayers.Size = new System.Drawing.Size(192, 199);
            this.lstTeamPlayers.TabIndex = 0;
            this.lstTeamPlayers.ValueMember = "Id";
            this.lstTeamPlayers.SelectedIndexChanged += new System.EventHandler(this.lstTeamPlayers_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pboTeamColorInfo);
            this.groupBox5.Controls.Add(this.btnTeamCancel);
            this.groupBox5.Controls.Add(this.btnTeamAdd);
            this.groupBox5.Controls.Add(this.btnTeamOk);
            this.groupBox5.Controls.Add(this.lviTeamColorsToChoose);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtTeamName);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(8, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(544, 481);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add Team";
            // 
            // pboTeamColorInfo
            // 
            this.pboTeamColorInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pboTeamColorInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.pboTeamColorInfo.Image = global::WeAreTheChampions.Properties.Resources.info;
            this.pboTeamColorInfo.Location = new System.Drawing.Point(516, 66);
            this.pboTeamColorInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pboTeamColorInfo.Name = "pboTeamColorInfo";
            this.pboTeamColorInfo.Size = new System.Drawing.Size(20, 20);
            this.pboTeamColorInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboTeamColorInfo.TabIndex = 28;
            this.pboTeamColorInfo.TabStop = false;
            // 
            // btnTeamCancel
            // 
            this.btnTeamCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeamCancel.Location = new System.Drawing.Point(87, 451);
            this.btnTeamCancel.Name = "btnTeamCancel";
            this.btnTeamCancel.Size = new System.Drawing.Size(75, 22);
            this.btnTeamCancel.TabIndex = 27;
            this.btnTeamCancel.Text = "Cancel";
            this.btnTeamCancel.UseVisualStyleBackColor = true;
            this.btnTeamCancel.Visible = false;
            this.btnTeamCancel.Click += new System.EventHandler(this.btnTeamCancel_Click);
            // 
            // btnTeamAdd
            // 
            this.btnTeamAdd.Location = new System.Drawing.Point(445, 451);
            this.btnTeamAdd.Name = "btnTeamAdd";
            this.btnTeamAdd.Size = new System.Drawing.Size(93, 22);
            this.btnTeamAdd.TabIndex = 4;
            this.btnTeamAdd.Text = "Add Team";
            this.btnTeamAdd.UseVisualStyleBackColor = true;
            this.btnTeamAdd.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // btnTeamOk
            // 
            this.btnTeamOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeamOk.Location = new System.Drawing.Point(6, 451);
            this.btnTeamOk.Name = "btnTeamOk";
            this.btnTeamOk.Size = new System.Drawing.Size(75, 22);
            this.btnTeamOk.TabIndex = 26;
            this.btnTeamOk.Text = "Save";
            this.btnTeamOk.UseVisualStyleBackColor = true;
            this.btnTeamOk.Visible = false;
            this.btnTeamOk.Click += new System.EventHandler(this.btnTeamOk_Click);
            // 
            // lviTeamColorsToChoose
            // 
            this.lviTeamColorsToChoose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lviTeamColorsToChoose.HideSelection = false;
            this.lviTeamColorsToChoose.LargeImageList = this.imlColors;
            this.lviTeamColorsToChoose.Location = new System.Drawing.Point(6, 64);
            this.lviTeamColorsToChoose.Name = "lviTeamColorsToChoose";
            this.lviTeamColorsToChoose.Size = new System.Drawing.Size(532, 383);
            this.lviTeamColorsToChoose.TabIndex = 1;
            this.lviTeamColorsToChoose.UseCompatibleStateImageBehavior = false;
            // 
            // imlColors
            // 
            this.imlColors.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlColors.ImageStream")));
            this.imlColors.TransparentColor = System.Drawing.Color.Transparent;
            this.imlColors.Images.SetKeyName(0, "border");
            this.imlColors.Images.SetKeyName(1, "wheel");
            this.imlColors.Images.SetKeyName(2, "heartborder");
            this.imlColors.Images.SetKeyName(3, "fill");
            this.imlColors.Images.SetKeyName(4, "palette");
            this.imlColors.Images.SetKeyName(5, "dropper");
            this.imlColors.Images.SetKeyName(6, "wheels");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Colors";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(87, 19);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(451, 20);
            this.txtTeamName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Team Name :";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnTeamEdit);
            this.groupBox4.Controls.Add(this.btnTeamDelete);
            this.groupBox4.Controls.Add(this.lviTeamColors);
            this.groupBox4.Controls.Add(this.lstTeams);
            this.groupBox4.Location = new System.Drawing.Point(558, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(403, 242);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Teams and Colors";
            // 
            // btnTeamEdit
            // 
            this.btnTeamEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTeamEdit.Location = new System.Drawing.Point(205, 217);
            this.btnTeamEdit.Name = "btnTeamEdit";
            this.btnTeamEdit.Size = new System.Drawing.Size(93, 22);
            this.btnTeamEdit.TabIndex = 4;
            this.btnTeamEdit.Text = "Edit";
            this.btnTeamEdit.UseVisualStyleBackColor = true;
            this.btnTeamEdit.Click += new System.EventHandler(this.btnTeamEdit_Click);
            // 
            // btnTeamDelete
            // 
            this.btnTeamDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTeamDelete.Location = new System.Drawing.Point(301, 217);
            this.btnTeamDelete.Name = "btnTeamDelete";
            this.btnTeamDelete.Size = new System.Drawing.Size(93, 22);
            this.btnTeamDelete.TabIndex = 3;
            this.btnTeamDelete.Text = "Delete";
            this.btnTeamDelete.UseVisualStyleBackColor = true;
            this.btnTeamDelete.Click += new System.EventHandler(this.btnTeamDelete_Click);
            // 
            // lviTeamColors
            // 
            this.lviTeamColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lviTeamColors.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lviTeamColors.HideSelection = false;
            this.lviTeamColors.LargeImageList = this.imlColors;
            this.lviTeamColors.Location = new System.Drawing.Point(205, 19);
            this.lviTeamColors.Name = "lviTeamColors";
            this.lviTeamColors.Size = new System.Drawing.Size(189, 186);
            this.lviTeamColors.TabIndex = 1;
            this.lviTeamColors.UseCompatibleStateImageBehavior = false;
            // 
            // lstTeams
            // 
            this.lstTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTeams.DisplayMember = "TeamName";
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.Location = new System.Drawing.Point(7, 19);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(192, 186);
            this.lstTeams.TabIndex = 0;
            this.lstTeams.ValueMember = "Id";
            this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.lstTeams_SelectedIndexChanged);
            // 
            // tabCntrlColors
            // 
            this.tabCntrlColors.Controls.Add(this.pboColorWheelInfo);
            this.tabCntrlColors.Controls.Add(this.pboColorInfo);
            this.tabCntrlColors.Controls.Add(this.btnColorCancel);
            this.tabCntrlColors.Controls.Add(this.btnColorOk);
            this.tabCntrlColors.Controls.Add(this.txtB);
            this.tabCntrlColors.Controls.Add(this.txtG);
            this.tabCntrlColors.Controls.Add(this.txtR);
            this.tabCntrlColors.Controls.Add(this.label13);
            this.tabCntrlColors.Controls.Add(this.label12);
            this.tabCntrlColors.Controls.Add(this.label11);
            this.tabCntrlColors.Controls.Add(this.label6);
            this.tabCntrlColors.Controls.Add(this.txtColorName);
            this.tabCntrlColors.Controls.Add(this.btnColorEdit);
            this.tabCntrlColors.Controls.Add(this.btnColorDelete);
            this.tabCntrlColors.Controls.Add(this.btnColorAdd);
            this.tabCntrlColors.Controls.Add(this.pboSelectedColor);
            this.tabCntrlColors.Controls.Add(this.pboColorWheel);
            this.tabCntrlColors.Controls.Add(this.lviColors);
            this.tabCntrlColors.Location = new System.Drawing.Point(4, 22);
            this.tabCntrlColors.Name = "tabCntrlColors";
            this.tabCntrlColors.Padding = new System.Windows.Forms.Padding(3);
            this.tabCntrlColors.Size = new System.Drawing.Size(967, 493);
            this.tabCntrlColors.TabIndex = 2;
            this.tabCntrlColors.Text = "Colors";
            this.tabCntrlColors.UseVisualStyleBackColor = true;
            // 
            // pboColorWheelInfo
            // 
            this.pboColorWheelInfo.BackColor = System.Drawing.Color.Transparent;
            this.pboColorWheelInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.pboColorWheelInfo.Image = global::WeAreTheChampions.Properties.Resources.info;
            this.pboColorWheelInfo.Location = new System.Drawing.Point(742, 174);
            this.pboColorWheelInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pboColorWheelInfo.Name = "pboColorWheelInfo";
            this.pboColorWheelInfo.Size = new System.Drawing.Size(20, 20);
            this.pboColorWheelInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboColorWheelInfo.TabIndex = 27;
            this.pboColorWheelInfo.TabStop = false;
            // 
            // pboColorInfo
            // 
            this.pboColorInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pboColorInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.pboColorInfo.Image = global::WeAreTheChampions.Properties.Resources.info;
            this.pboColorInfo.Location = new System.Drawing.Point(530, 23);
            this.pboColorInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pboColorInfo.Name = "pboColorInfo";
            this.pboColorInfo.Size = new System.Drawing.Size(20, 20);
            this.pboColorInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboColorInfo.TabIndex = 26;
            this.pboColorInfo.TabStop = false;
            // 
            // btnColorCancel
            // 
            this.btnColorCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorCancel.Location = new System.Drawing.Point(886, 452);
            this.btnColorCancel.Name = "btnColorCancel";
            this.btnColorCancel.Size = new System.Drawing.Size(75, 23);
            this.btnColorCancel.TabIndex = 25;
            this.btnColorCancel.Text = "Cancel";
            this.btnColorCancel.UseVisualStyleBackColor = true;
            this.btnColorCancel.Visible = false;
            this.btnColorCancel.Click += new System.EventHandler(this.btnColorCancel_Click);
            // 
            // btnColorOk
            // 
            this.btnColorOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorOk.Location = new System.Drawing.Point(886, 423);
            this.btnColorOk.Name = "btnColorOk";
            this.btnColorOk.Size = new System.Drawing.Size(75, 23);
            this.btnColorOk.TabIndex = 24;
            this.btnColorOk.Text = "Save";
            this.btnColorOk.UseVisualStyleBackColor = true;
            this.btnColorOk.Visible = false;
            this.btnColorOk.Click += new System.EventHandler(this.btnColorOk_Click);
            // 
            // txtB
            // 
            this.txtB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtB.Location = new System.Drawing.Point(610, 454);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(152, 20);
            this.txtB.TabIndex = 23;
            // 
            // txtG
            // 
            this.txtG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtG.Location = new System.Drawing.Point(610, 427);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(152, 20);
            this.txtG.TabIndex = 22;
            // 
            // txtR
            // 
            this.txtR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtR.Location = new System.Drawing.Point(610, 399);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(152, 20);
            this.txtR.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(585, 457);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "B:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(585, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "G:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(585, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "R:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Color:";
            // 
            // txtColorName
            // 
            this.txtColorName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColorName.Location = new System.Drawing.Point(610, 23);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(115, 20);
            this.txtColorName.TabIndex = 16;
            // 
            // btnColorEdit
            // 
            this.btnColorEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorEdit.Location = new System.Drawing.Point(886, 49);
            this.btnColorEdit.Name = "btnColorEdit";
            this.btnColorEdit.Size = new System.Drawing.Size(75, 23);
            this.btnColorEdit.TabIndex = 10;
            this.btnColorEdit.Text = "Edit Color";
            this.btnColorEdit.UseVisualStyleBackColor = true;
            this.btnColorEdit.Click += new System.EventHandler(this.btnColorEdit_Click);
            // 
            // btnColorDelete
            // 
            this.btnColorDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorDelete.Location = new System.Drawing.Point(886, 78);
            this.btnColorDelete.Name = "btnColorDelete";
            this.btnColorDelete.Size = new System.Drawing.Size(75, 23);
            this.btnColorDelete.TabIndex = 8;
            this.btnColorDelete.Text = "Delete Color";
            this.btnColorDelete.UseVisualStyleBackColor = true;
            this.btnColorDelete.Click += new System.EventHandler(this.btnColorDelete_Click);
            // 
            // btnColorAdd
            // 
            this.btnColorAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorAdd.Location = new System.Drawing.Point(886, 20);
            this.btnColorAdd.Name = "btnColorAdd";
            this.btnColorAdd.Size = new System.Drawing.Size(75, 23);
            this.btnColorAdd.TabIndex = 7;
            this.btnColorAdd.Text = "Add Color";
            this.btnColorAdd.UseVisualStyleBackColor = true;
            this.btnColorAdd.Click += new System.EventHandler(this.btnColorAdd_Click);
            // 
            // pboSelectedColor
            // 
            this.pboSelectedColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboSelectedColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboSelectedColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboSelectedColor.ErrorImage = null;
            this.pboSelectedColor.Location = new System.Drawing.Point(742, 23);
            this.pboSelectedColor.Name = "pboSelectedColor";
            this.pboSelectedColor.Size = new System.Drawing.Size(20, 20);
            this.pboSelectedColor.TabIndex = 12;
            this.pboSelectedColor.TabStop = false;
            this.pboSelectedColor.Click += new System.EventHandler(this.pboSelectedColor_Click);
            // 
            // pboColorWheel
            // 
            this.pboColorWheel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboColorWheel.Image = global::WeAreTheChampions.Properties.Resources.ColorW;
            this.pboColorWheel.Location = new System.Drawing.Point(588, 174);
            this.pboColorWheel.Name = "pboColorWheel";
            this.pboColorWheel.Size = new System.Drawing.Size(187, 156);
            this.pboColorWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboColorWheel.TabIndex = 11;
            this.pboColorWheel.TabStop = false;
            this.pboColorWheel.Click += new System.EventHandler(this.pboColorWheel_Click);
            // 
            // lviColors
            // 
            this.lviColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lviColors.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lviColors.HideSelection = false;
            this.lviColors.LargeImageList = this.imlColors;
            this.lviColors.Location = new System.Drawing.Point(21, 20);
            this.lviColors.Name = "lviColors";
            this.lviColors.Size = new System.Drawing.Size(532, 458);
            this.lviColors.TabIndex = 1;
            this.lviColors.UseCompatibleStateImageBehavior = false;
            // 
            // tabCntrlPlayers
            // 
            this.tabCntrlPlayers.Controls.Add(this.gbTransfer);
            this.tabCntrlPlayers.Controls.Add(this.gbPlayerInfo);
            this.tabCntrlPlayers.Controls.Add(this.gbPlayers);
            this.tabCntrlPlayers.Controls.Add(this.gbPlayerAdd);
            this.tabCntrlPlayers.Location = new System.Drawing.Point(4, 22);
            this.tabCntrlPlayers.Name = "tabCntrlPlayers";
            this.tabCntrlPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCntrlPlayers.Size = new System.Drawing.Size(967, 493);
            this.tabCntrlPlayers.TabIndex = 3;
            this.tabCntrlPlayers.Text = "Players";
            this.tabCntrlPlayers.UseVisualStyleBackColor = true;
            // 
            // gbTransfer
            // 
            this.gbTransfer.Controls.Add(this.label14);
            this.gbTransfer.Controls.Add(this.cmbPlayerTransferTeam);
            this.gbTransfer.Controls.Add(this.btnPlayerTransferCancel);
            this.gbTransfer.Controls.Add(this.btnPlayerTransfer);
            this.gbTransfer.Enabled = false;
            this.gbTransfer.Location = new System.Drawing.Point(8, 332);
            this.gbTransfer.Name = "gbTransfer";
            this.gbTransfer.Size = new System.Drawing.Size(393, 153);
            this.gbTransfer.TabIndex = 9;
            this.gbTransfer.TabStop = false;
            this.gbTransfer.Text = "Transfer";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(320, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Transfer to...";
            // 
            // cmbPlayerTransferTeam
            // 
            this.cmbPlayerTransferTeam.DisplayMember = "TeamName";
            this.cmbPlayerTransferTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayerTransferTeam.FormattingEnabled = true;
            this.cmbPlayerTransferTeam.Location = new System.Drawing.Point(9, 55);
            this.cmbPlayerTransferTeam.Name = "cmbPlayerTransferTeam";
            this.cmbPlayerTransferTeam.Size = new System.Drawing.Size(378, 21);
            this.cmbPlayerTransferTeam.TabIndex = 5;
            this.cmbPlayerTransferTeam.ValueMember = "Id";
            // 
            // btnPlayerTransferCancel
            // 
            this.btnPlayerTransferCancel.Location = new System.Drawing.Point(9, 123);
            this.btnPlayerTransferCancel.Name = "btnPlayerTransferCancel";
            this.btnPlayerTransferCancel.Size = new System.Drawing.Size(75, 24);
            this.btnPlayerTransferCancel.TabIndex = 7;
            this.btnPlayerTransferCancel.Text = "Cancel";
            this.btnPlayerTransferCancel.UseVisualStyleBackColor = true;
            this.btnPlayerTransferCancel.Visible = false;
            this.btnPlayerTransferCancel.Click += new System.EventHandler(this.btnPlayerTransferCancel_Click);
            // 
            // btnPlayerTransfer
            // 
            this.btnPlayerTransfer.Location = new System.Drawing.Point(311, 123);
            this.btnPlayerTransfer.Name = "btnPlayerTransfer";
            this.btnPlayerTransfer.Size = new System.Drawing.Size(76, 24);
            this.btnPlayerTransfer.TabIndex = 6;
            this.btnPlayerTransfer.Text = "Transfer";
            this.btnPlayerTransfer.UseVisualStyleBackColor = true;
            this.btnPlayerTransfer.Click += new System.EventHandler(this.btnPlayerTransfer_Click);
            // 
            // gbPlayerInfo
            // 
            this.gbPlayerInfo.Controls.Add(this.btnPlayerChangeTeam);
            this.gbPlayerInfo.Controls.Add(this.label15);
            this.gbPlayerInfo.Controls.Add(this.label16);
            this.gbPlayerInfo.Controls.Add(this.txtSelectedPlayerTeam);
            this.gbPlayerInfo.Controls.Add(this.txtSelectedPlayerName);
            this.gbPlayerInfo.Controls.Add(this.pboPlayerSelectedPhoto);
            this.gbPlayerInfo.Location = new System.Drawing.Point(772, 14);
            this.gbPlayerInfo.Name = "gbPlayerInfo";
            this.gbPlayerInfo.Size = new System.Drawing.Size(187, 476);
            this.gbPlayerInfo.TabIndex = 8;
            this.gbPlayerInfo.TabStop = false;
            this.gbPlayerInfo.Text = "Player Information";
            // 
            // btnPlayerChangeTeam
            // 
            this.btnPlayerChangeTeam.Location = new System.Drawing.Point(15, 444);
            this.btnPlayerChangeTeam.Name = "btnPlayerChangeTeam";
            this.btnPlayerChangeTeam.Size = new System.Drawing.Size(157, 23);
            this.btnPlayerChangeTeam.TabIndex = 0;
            this.btnPlayerChangeTeam.Text = "Change Player\'s Team";
            this.btnPlayerChangeTeam.UseVisualStyleBackColor = true;
            this.btnPlayerChangeTeam.Click += new System.EventHandler(this.btnPlayerChangeTeam_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 280);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Team";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Player Name";
            // 
            // txtSelectedPlayerTeam
            // 
            this.txtSelectedPlayerTeam.Enabled = false;
            this.txtSelectedPlayerTeam.Location = new System.Drawing.Point(15, 296);
            this.txtSelectedPlayerTeam.Name = "txtSelectedPlayerTeam";
            this.txtSelectedPlayerTeam.Size = new System.Drawing.Size(157, 20);
            this.txtSelectedPlayerTeam.TabIndex = 4;
            // 
            // txtSelectedPlayerName
            // 
            this.txtSelectedPlayerName.Enabled = false;
            this.txtSelectedPlayerName.Location = new System.Drawing.Point(15, 242);
            this.txtSelectedPlayerName.Name = "txtSelectedPlayerName";
            this.txtSelectedPlayerName.Size = new System.Drawing.Size(157, 20);
            this.txtSelectedPlayerName.TabIndex = 2;
            // 
            // pboPlayerSelectedPhoto
            // 
            this.pboPlayerSelectedPhoto.ErrorImage = global::WeAreTheChampions.Properties.Resources.defaultimage;
            this.pboPlayerSelectedPhoto.Image = global::WeAreTheChampions.Properties.Resources.defaultimage;
            this.pboPlayerSelectedPhoto.InitialImage = global::WeAreTheChampions.Properties.Resources.defaultimage;
            this.pboPlayerSelectedPhoto.Location = new System.Drawing.Point(15, 30);
            this.pboPlayerSelectedPhoto.Name = "pboPlayerSelectedPhoto";
            this.pboPlayerSelectedPhoto.Size = new System.Drawing.Size(157, 169);
            this.pboPlayerSelectedPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboPlayerSelectedPhoto.TabIndex = 1;
            this.pboPlayerSelectedPhoto.TabStop = false;
            // 
            // gbPlayers
            // 
            this.gbPlayers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbPlayers.Controls.Add(this.btnPlayerEdit);
            this.gbPlayers.Controls.Add(this.label2);
            this.gbPlayers.Controls.Add(this.btnPlayerDelete);
            this.gbPlayers.Controls.Add(this.lstPlayers);
            this.gbPlayers.Controls.Add(this.cmbTeams);
            this.gbPlayers.Location = new System.Drawing.Point(416, 14);
            this.gbPlayers.Name = "gbPlayers";
            this.gbPlayers.Size = new System.Drawing.Size(341, 476);
            this.gbPlayers.TabIndex = 6;
            this.gbPlayers.TabStop = false;
            this.gbPlayers.Text = "Players";
            // 
            // btnPlayerEdit
            // 
            this.btnPlayerEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayerEdit.Location = new System.Drawing.Point(161, 445);
            this.btnPlayerEdit.Name = "btnPlayerEdit";
            this.btnPlayerEdit.Size = new System.Drawing.Size(84, 24);
            this.btnPlayerEdit.TabIndex = 9;
            this.btnPlayerEdit.Text = "Edit Player";
            this.btnPlayerEdit.UseVisualStyleBackColor = true;
            this.btnPlayerEdit.Click += new System.EventHandler(this.btnPlayerEdit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Teams: ";
            // 
            // btnPlayerDelete
            // 
            this.btnPlayerDelete.Location = new System.Drawing.Point(251, 444);
            this.btnPlayerDelete.Name = "btnPlayerDelete";
            this.btnPlayerDelete.Size = new System.Drawing.Size(84, 24);
            this.btnPlayerDelete.TabIndex = 3;
            this.btnPlayerDelete.Text = "Delete Player";
            this.btnPlayerDelete.UseVisualStyleBackColor = true;
            this.btnPlayerDelete.Click += new System.EventHandler(this.btnPlayerDelete_Click);
            // 
            // lstPlayers
            // 
            this.lstPlayers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstPlayers.DisplayMember = "PlayerName";
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.Location = new System.Drawing.Point(9, 64);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(326, 368);
            this.lstPlayers.TabIndex = 6;
            this.lstPlayers.ValueMember = "Id";
            this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.lstPlayers_SelectedIndexChanged);
            // 
            // cmbTeams
            // 
            this.cmbTeams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTeams.DisplayMember = "TeamName";
            this.cmbTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeams.FormattingEnabled = true;
            this.cmbTeams.Items.AddRange(new object[] {
            "All"});
            this.cmbTeams.Location = new System.Drawing.Point(54, 24);
            this.cmbTeams.Name = "cmbTeams";
            this.cmbTeams.Size = new System.Drawing.Size(281, 21);
            this.cmbTeams.TabIndex = 7;
            this.cmbTeams.ValueMember = "Id";
            this.cmbTeams.SelectedIndexChanged += new System.EventHandler(this.cmbTeams_SelectedIndexChanged);
            // 
            // gbPlayerAdd
            // 
            this.gbPlayerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPlayerAdd.Controls.Add(this.label10);
            this.gbPlayerAdd.Controls.Add(this.btnPlayerCancel);
            this.gbPlayerAdd.Controls.Add(this.btnPlayerSave);
            this.gbPlayerAdd.Controls.Add(this.btnPlayerBrowse);
            this.gbPlayerAdd.Controls.Add(this.btnPlayerAdd);
            this.gbPlayerAdd.Controls.Add(this.label4);
            this.gbPlayerAdd.Controls.Add(this.label7);
            this.gbPlayerAdd.Controls.Add(this.txtPlayerWillAddName);
            this.gbPlayerAdd.Controls.Add(this.cmbPlayerWillAddTeam);
            this.gbPlayerAdd.Controls.Add(this.txtPlayerPhotoPath);
            this.gbPlayerAdd.Controls.Add(this.pboPlayerWillAddPhoto);
            this.gbPlayerAdd.Location = new System.Drawing.Point(8, 11);
            this.gbPlayerAdd.Name = "gbPlayerAdd";
            this.gbPlayerAdd.Size = new System.Drawing.Size(394, 316);
            this.gbPlayerAdd.TabIndex = 5;
            this.gbPlayerAdd.TabStop = false;
            this.gbPlayerAdd.Text = "Add Player";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Photo Path";
            // 
            // btnPlayerCancel
            // 
            this.btnPlayerCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayerCancel.Location = new System.Drawing.Point(89, 287);
            this.btnPlayerCancel.Name = "btnPlayerCancel";
            this.btnPlayerCancel.Size = new System.Drawing.Size(75, 23);
            this.btnPlayerCancel.TabIndex = 40;
            this.btnPlayerCancel.Text = "Cancel";
            this.btnPlayerCancel.UseVisualStyleBackColor = true;
            this.btnPlayerCancel.Visible = false;
            this.btnPlayerCancel.Click += new System.EventHandler(this.btnPlayerCancel_Click);
            // 
            // btnPlayerSave
            // 
            this.btnPlayerSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayerSave.Location = new System.Drawing.Point(8, 287);
            this.btnPlayerSave.Name = "btnPlayerSave";
            this.btnPlayerSave.Size = new System.Drawing.Size(75, 23);
            this.btnPlayerSave.TabIndex = 39;
            this.btnPlayerSave.Text = "Save";
            this.btnPlayerSave.UseVisualStyleBackColor = true;
            this.btnPlayerSave.Visible = false;
            this.btnPlayerSave.Click += new System.EventHandler(this.btnPlayerSave_Click);
            // 
            // btnPlayerBrowse
            // 
            this.btnPlayerBrowse.Location = new System.Drawing.Point(312, 68);
            this.btnPlayerBrowse.Name = "btnPlayerBrowse";
            this.btnPlayerBrowse.Size = new System.Drawing.Size(76, 23);
            this.btnPlayerBrowse.TabIndex = 38;
            this.btnPlayerBrowse.Text = "Browse";
            this.btnPlayerBrowse.UseVisualStyleBackColor = true;
            this.btnPlayerBrowse.Click += new System.EventHandler(this.btnPlayerBrowse_Click);
            // 
            // btnPlayerAdd
            // 
            this.btnPlayerAdd.Location = new System.Drawing.Point(312, 287);
            this.btnPlayerAdd.Name = "btnPlayerAdd";
            this.btnPlayerAdd.Size = new System.Drawing.Size(76, 23);
            this.btnPlayerAdd.TabIndex = 37;
            this.btnPlayerAdd.Text = "Add Player";
            this.btnPlayerAdd.UseVisualStyleBackColor = true;
            this.btnPlayerAdd.Click += new System.EventHandler(this.btnPlayerAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Team";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Player Name";
            // 
            // txtPlayerWillAddName
            // 
            this.txtPlayerWillAddName.Location = new System.Drawing.Point(203, 135);
            this.txtPlayerWillAddName.Name = "txtPlayerWillAddName";
            this.txtPlayerWillAddName.Size = new System.Drawing.Size(185, 20);
            this.txtPlayerWillAddName.TabIndex = 33;
            // 
            // cmbPlayerWillAddTeam
            // 
            this.cmbPlayerWillAddTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPlayerWillAddTeam.DisplayMember = "TeamName";
            this.cmbPlayerWillAddTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayerWillAddTeam.FormattingEnabled = true;
            this.cmbPlayerWillAddTeam.Location = new System.Drawing.Point(203, 174);
            this.cmbPlayerWillAddTeam.Name = "cmbPlayerWillAddTeam";
            this.cmbPlayerWillAddTeam.Size = new System.Drawing.Size(185, 21);
            this.cmbPlayerWillAddTeam.TabIndex = 34;
            this.cmbPlayerWillAddTeam.ValueMember = "Id";
            // 
            // txtPlayerPhotoPath
            // 
            this.txtPlayerPhotoPath.Location = new System.Drawing.Point(203, 42);
            this.txtPlayerPhotoPath.Name = "txtPlayerPhotoPath";
            this.txtPlayerPhotoPath.Size = new System.Drawing.Size(185, 20);
            this.txtPlayerPhotoPath.TabIndex = 31;
            // 
            // pboPlayerWillAddPhoto
            // 
            this.pboPlayerWillAddPhoto.ErrorImage = global::WeAreTheChampions.Properties.Resources.defaultimage;
            this.pboPlayerWillAddPhoto.Image = global::WeAreTheChampions.Properties.Resources.defaultimage;
            this.pboPlayerWillAddPhoto.InitialImage = global::WeAreTheChampions.Properties.Resources.defaultimage;
            this.pboPlayerWillAddPhoto.Location = new System.Drawing.Point(8, 26);
            this.pboPlayerWillAddPhoto.Name = "pboPlayerWillAddPhoto";
            this.pboPlayerWillAddPhoto.Size = new System.Drawing.Size(157, 169);
            this.pboPlayerWillAddPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboPlayerWillAddPhoto.TabIndex = 32;
            this.pboPlayerWillAddPhoto.TabStop = false;
            // 
            // tlpInfo
            // 
            this.tlpInfo.AutoPopDelay = 5000;
            this.tlpInfo.InitialDelay = 1;
            this.tlpInfo.ReshowDelay = 100;
            this.tlpInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tlpInfo.ToolTipTitle = "Info";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(975, 519);
            this.Controls.Add(this.tabControlMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "We Are The Champions";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabCntrlMatches.ResumeLayout(false);
            this.tabCntrlMatches.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.tabCntrlTeams.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboTeamPlayerPhoto)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboTeamColorInfo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tabCntrlColors.ResumeLayout(false);
            this.tabCntrlColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboColorWheelInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboColorInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSelectedColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboColorWheel)).EndInit();
            this.tabCntrlPlayers.ResumeLayout(false);
            this.gbTransfer.ResumeLayout(false);
            this.gbTransfer.PerformLayout();
            this.gbPlayerInfo.ResumeLayout(false);
            this.gbPlayerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboPlayerSelectedPhoto)).EndInit();
            this.gbPlayers.ResumeLayout(false);
            this.gbPlayers.PerformLayout();
            this.gbPlayerAdd.ResumeLayout(false);
            this.gbPlayerAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboPlayerWillAddPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabCntrlMatches;
        private System.Windows.Forms.TabPage tabCntrlTeams;
        private System.Windows.Forms.TabPage tabCntrlColors;
        private System.Windows.Forms.TabPage tabCntrlPlayers;
        private System.Windows.Forms.Button btnDeleteSelectedMatch;
        private System.Windows.Forms.Button btnEditSelectedMatch;
        private System.Windows.Forms.Button btnAddMatch;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnTeamRemovePlayer;
        private System.Windows.Forms.PictureBox pboTeamPlayerPhoto;
        private System.Windows.Forms.ListBox lstTeamPlayers;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnTeamAdd;
        private System.Windows.Forms.ListView lviTeamColorsToChoose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTeamEdit;
        private System.Windows.Forms.Button btnTeamDelete;
        private System.Windows.Forms.ListView lviTeamColors;
        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.Button btnColorDelete;
        private System.Windows.Forms.Button btnColorAdd;
        private System.Windows.Forms.ListView lviColors;
        private System.Windows.Forms.GroupBox gbPlayers;
        private System.Windows.Forms.Button btnPlayerDelete;
        private System.Windows.Forms.GroupBox gbPlayerAdd;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.PictureBox pboColorWheel;
        private System.Windows.Forms.Button btnColorEdit;
        private System.Windows.Forms.PictureBox pboSelectedColor;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imlColors;
        private System.Windows.Forms.Button btnColorCancel;
        private System.Windows.Forms.Button btnColorOk;
        private System.Windows.Forms.CheckBox chkHideMatches;
        private System.Windows.Forms.Button btnTeamCancel;
        private System.Windows.Forms.Button btnTeamOk;
        private System.Windows.Forms.Button btnPlayerEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.ComboBox cmbTeams;
        private System.Windows.Forms.GroupBox gbPlayerInfo;
        private System.Windows.Forms.Button btnPlayerChangeTeam;
        private System.Windows.Forms.PictureBox pboColorInfo;
        private System.Windows.Forms.ToolTip tlpInfo;
        private System.Windows.Forms.PictureBox pboTeamColorInfo;
        private System.Windows.Forms.PictureBox pboColorWheelInfo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSelectedPlayerTeam;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSelectedPlayerName;
        private System.Windows.Forms.Button btnPlayerTransfer;
        private System.Windows.Forms.PictureBox pboPlayerSelectedPhoto;
        private System.Windows.Forms.Button btnPlayerTransferCancel;
        private System.Windows.Forms.ComboBox cmbPlayerTransferTeam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPlayerCancel;
        private System.Windows.Forms.Button btnPlayerSave;
        private System.Windows.Forms.Button btnPlayerBrowse;
        private System.Windows.Forms.Button btnPlayerAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlayerWillAddName;
        private System.Windows.Forms.ComboBox cmbPlayerWillAddTeam;
        private System.Windows.Forms.TextBox txtPlayerPhotoPath;
        private System.Windows.Forms.PictureBox pboPlayerWillAddPhoto;
        private System.Windows.Forms.GroupBox gbTransfer;
        private System.Windows.Forms.PictureBox pbTeam2;
        private System.Windows.Forms.PictureBox pbTeam1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label label1;
    }
}

