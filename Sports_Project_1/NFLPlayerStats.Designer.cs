namespace Sports_Project_1
{
    partial class NFLPlayerStats
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
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this._NFL_Team__BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportsDBDataSet = new Sports_Project_1.sportsDBDataSet();
            this.lblPos = new System.Windows.Forms.Label();
            this.butExit = new System.Windows.Forms.Button();
            this.panelPlayerInfo = new System.Windows.Forms.Panel();
            this.txtBoxJNum = new System.Windows.Forms.TextBox();
            this._NFL_Players__BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBoxPos = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtBoxFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.panelPlayerInfoBorder = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTDs = new System.Windows.Forms.Label();
            this.lblPassY = new System.Windows.Forms.Label();
            this.lblReceivingY = new System.Windows.Forms.Label();
            this.lblRushY = new System.Windows.Forms.Label();
            this.lblTackles = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxGP = new System.Windows.Forms.TextBox();
            this._NFL_Player_Stats__BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBoxReceivingYards = new System.Windows.Forms.TextBox();
            this.txtBoxTDs = new System.Windows.Forms.TextBox();
            this.txtBoxRushingYards = new System.Windows.Forms.TextBox();
            this.txtBoxPassingYards = new System.Windows.Forms.TextBox();
            this.txtBoxTackles = new System.Windows.Forms.TextBox();
            this.lbExit = new System.Windows.Forms.Label();
            this.ttpSports = new System.Windows.Forms.ToolTip(this.components);
            this._NFL_Player_Stats__TableAdapter = new Sports_Project_1.sportsDBDataSetTableAdapters._NFL_Player_Stats__TableAdapter();
            this._NFL_Players__TableAdapter = new Sports_Project_1.sportsDBDataSetTableAdapters._NFL_Players__TableAdapter();
            this._NFL_Team__TableAdapter = new Sports_Project_1.sportsDBDataSetTableAdapters._NFL_Team__TableAdapter();
            this.tableAdapterManager = new Sports_Project_1.sportsDBDataSetTableAdapters.TableAdapterManager();
            this.lblPName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._NFL_Team__BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDBDataSet)).BeginInit();
            this.panelPlayerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._NFL_Players__BindingSource)).BeginInit();
            this.panelPlayerInfoBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._NFL_Player_Stats__BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxLogo.Location = new System.Drawing.Point(71, 79);
            this.pBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(268, 220);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLogo.TabIndex = 0;
            this.pBoxLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(800, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "JERSEY NUM: ";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.BackColor = System.Drawing.Color.Transparent;
            this.lblTeamName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._NFL_Team__BindingSource, "Team", true));
            this.lblTeamName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(774, 223);
            this.lblTeamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(179, 37);
            this.lblTeamName.TabIndex = 3;
            this.lblTeamName.Text = "TEAM NAME";
            // 
            // _NFL_Team__BindingSource
            // 
            this._NFL_Team__BindingSource.DataMember = "\'NFL Team$\'";
            this._NFL_Team__BindingSource.DataSource = this.sportsDBDataSet;
            // 
            // sportsDBDataSet
            // 
            this.sportsDBDataSet.DataSetName = "sportsDBDataSet";
            this.sportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.Location = new System.Drawing.Point(575, 54);
            this.lblPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(99, 23);
            this.lblPos.TabIndex = 4;
            this.lblPos.Text = "POSITION: ";
            // 
            // butExit
            // 
            this.butExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(410, 217);
            this.butExit.Margin = new System.Windows.Forms.Padding(4);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(222, 43);
            this.butExit.TabIndex = 0;
            this.butExit.Text = "&Exit";
            this.ttpSports.SetToolTip(this.butExit, "Click to Exit");
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // panelPlayerInfo
            // 
            this.panelPlayerInfo.BackColor = System.Drawing.Color.White;
            this.panelPlayerInfo.Controls.Add(this.txtBoxJNum);
            this.panelPlayerInfo.Controls.Add(this.txtBoxPos);
            this.panelPlayerInfo.Controls.Add(this.txtLName);
            this.panelPlayerInfo.Controls.Add(this.txtBoxFName);
            this.panelPlayerInfo.Controls.Add(this.label3);
            this.panelPlayerInfo.Controls.Add(this.lblLName);
            this.panelPlayerInfo.Controls.Add(this.lblFName);
            this.panelPlayerInfo.Controls.Add(this.lblPos);
            this.panelPlayerInfo.Controls.Add(this.label1);
            this.panelPlayerInfo.Location = new System.Drawing.Point(7, 6);
            this.panelPlayerInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelPlayerInfo.Name = "panelPlayerInfo";
            this.panelPlayerInfo.Size = new System.Drawing.Size(1018, 120);
            this.panelPlayerInfo.TabIndex = 6;
            // 
            // txtBoxJNum
            // 
            this.txtBoxJNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._NFL_Players__BindingSource, "Jersey Number", true));
            this.txtBoxJNum.Enabled = false;
            this.txtBoxJNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtBoxJNum.Location = new System.Drawing.Point(919, 49);
            this.txtBoxJNum.Name = "txtBoxJNum";
            this.txtBoxJNum.Size = new System.Drawing.Size(89, 33);
            this.txtBoxJNum.TabIndex = 17;
            // 
            // _NFL_Players__BindingSource
            // 
            this._NFL_Players__BindingSource.DataMember = "\'NFL Players$\'";
            this._NFL_Players__BindingSource.DataSource = this.sportsDBDataSet;
            // 
            // txtBoxPos
            // 
            this.txtBoxPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._NFL_Players__BindingSource, "Position", true));
            this.txtBoxPos.Enabled = false;
            this.txtBoxPos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtBoxPos.Location = new System.Drawing.Point(669, 49);
            this.txtBoxPos.Name = "txtBoxPos";
            this.txtBoxPos.Size = new System.Drawing.Size(114, 33);
            this.txtBoxPos.TabIndex = 16;
            // 
            // txtLName
            // 
            this.txtLName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._NFL_Players__BindingSource, "Last Name", true));
            this.txtLName.Enabled = false;
            this.txtLName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtLName.Location = new System.Drawing.Point(387, 50);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(178, 33);
            this.txtLName.TabIndex = 15;
            // 
            // txtBoxFName
            // 
            this.txtBoxFName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._NFL_Players__BindingSource, "First Name", true));
            this.txtBoxFName.Enabled = false;
            this.txtBoxFName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtBoxFName.Location = new System.Drawing.Point(111, 48);
            this.txtBoxFName.Name = "txtBoxFName";
            this.txtBoxFName.Size = new System.Drawing.Size(163, 33);
            this.txtBoxFName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "PLAYER INFO";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(276, 54);
            this.lblLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(116, 23);
            this.lblLName.TabIndex = 6;
            this.lblLName.Text = "LAST NAME: ";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(0, 54);
            this.lblFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(120, 23);
            this.lblFName.TabIndex = 5;
            this.lblFName.Text = "FIRST NAME: ";
            // 
            // panelPlayerInfoBorder
            // 
            this.panelPlayerInfoBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(217)))));
            this.panelPlayerInfoBorder.Controls.Add(this.panelPlayerInfo);
            this.panelPlayerInfoBorder.Location = new System.Drawing.Point(60, 307);
            this.panelPlayerInfoBorder.Margin = new System.Windows.Forms.Padding(4);
            this.panelPlayerInfoBorder.Name = "panelPlayerInfoBorder";
            this.panelPlayerInfoBorder.Size = new System.Drawing.Size(1032, 131);
            this.panelPlayerInfoBorder.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 485);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "GAMES PLAYED: ";
            // 
            // lblTDs
            // 
            this.lblTDs.AutoSize = true;
            this.lblTDs.BackColor = System.Drawing.Color.Transparent;
            this.lblTDs.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDs.Location = new System.Drawing.Point(445, 485);
            this.lblTDs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTDs.Name = "lblTDs";
            this.lblTDs.Size = new System.Drawing.Size(144, 23);
            this.lblTDs.TabIndex = 8;
            this.lblTDs.Text = "TOUCHDOWNS: ";
            // 
            // lblPassY
            // 
            this.lblPassY.AutoSize = true;
            this.lblPassY.BackColor = System.Drawing.Color.Transparent;
            this.lblPassY.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassY.Location = new System.Drawing.Point(825, 485);
            this.lblPassY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassY.Name = "lblPassY";
            this.lblPassY.Size = new System.Drawing.Size(151, 23);
            this.lblPassY.TabIndex = 9;
            this.lblPassY.Text = "PASSING YARDS: ";
            // 
            // lblReceivingY
            // 
            this.lblReceivingY.AutoSize = true;
            this.lblReceivingY.BackColor = System.Drawing.Color.Transparent;
            this.lblReceivingY.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivingY.Location = new System.Drawing.Point(74, 538);
            this.lblReceivingY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivingY.Name = "lblReceivingY";
            this.lblReceivingY.Size = new System.Drawing.Size(166, 23);
            this.lblReceivingY.TabIndex = 10;
            this.lblReceivingY.Text = "RECEIVING YARDS: ";
            // 
            // lblRushY
            // 
            this.lblRushY.AutoSize = true;
            this.lblRushY.BackColor = System.Drawing.Color.Transparent;
            this.lblRushY.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRushY.Location = new System.Drawing.Point(445, 538);
            this.lblRushY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRushY.Name = "lblRushY";
            this.lblRushY.Size = new System.Drawing.Size(156, 23);
            this.lblRushY.TabIndex = 11;
            this.lblRushY.Text = "RUSHING YARDS: ";
            // 
            // lblTackles
            // 
            this.lblTackles.AutoSize = true;
            this.lblTackles.BackColor = System.Drawing.Color.Transparent;
            this.lblTackles.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTackles.Location = new System.Drawing.Point(825, 538);
            this.lblTackles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTackles.Name = "lblTackles";
            this.lblTackles.Size = new System.Drawing.Size(91, 23);
            this.lblTackles.TabIndex = 12;
            this.lblTackles.Text = "TACKLES: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 444);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 37);
            this.label4.TabIndex = 14;
            this.label4.Text = "PLAYER STATS";
            // 
            // txtBoxGP
            // 
            this.txtBoxGP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._NFL_Player_Stats__BindingSource, "Games Played", true));
            this.txtBoxGP.Enabled = false;
            this.txtBoxGP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtBoxGP.Location = new System.Drawing.Point(222, 479);
            this.txtBoxGP.Name = "txtBoxGP";
            this.txtBoxGP.Size = new System.Drawing.Size(114, 33);
            this.txtBoxGP.TabIndex = 18;
            // 
            // _NFL_Player_Stats__BindingSource
            // 
            this._NFL_Player_Stats__BindingSource.DataMember = "\'NFL Player Stats$\'";
            this._NFL_Player_Stats__BindingSource.DataSource = this.sportsDBDataSet;
            // 
            // txtBoxReceivingYards
            // 
            this.txtBoxReceivingYards.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._NFL_Player_Stats__BindingSource, "Receiving Yards", true));
            this.txtBoxReceivingYards.Enabled = false;
            this.txtBoxReceivingYards.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtBoxReceivingYards.Location = new System.Drawing.Point(242, 532);
            this.txtBoxReceivingYards.Name = "txtBoxReceivingYards";
            this.txtBoxReceivingYards.Size = new System.Drawing.Size(114, 33);
            this.txtBoxReceivingYards.TabIndex = 19;
            // 
            // txtBoxTDs
            // 
            this.txtBoxTDs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._NFL_Player_Stats__BindingSource, "Touchdowns", true));
            this.txtBoxTDs.Enabled = false;
            this.txtBoxTDs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtBoxTDs.Location = new System.Drawing.Point(598, 482);
            this.txtBoxTDs.Name = "txtBoxTDs";
            this.txtBoxTDs.Size = new System.Drawing.Size(153, 33);
            this.txtBoxTDs.TabIndex = 20;
            // 
            // txtBoxRushingYards
            // 
            this.txtBoxRushingYards.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._NFL_Player_Stats__BindingSource, "RushingYards", true));
            this.txtBoxRushingYards.Enabled = false;
            this.txtBoxRushingYards.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtBoxRushingYards.Location = new System.Drawing.Point(598, 535);
            this.txtBoxRushingYards.Name = "txtBoxRushingYards";
            this.txtBoxRushingYards.Size = new System.Drawing.Size(153, 33);
            this.txtBoxRushingYards.TabIndex = 21;
            // 
            // txtBoxPassingYards
            // 
            this.txtBoxPassingYards.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._NFL_Player_Stats__BindingSource, "Passing Yards", true));
            this.txtBoxPassingYards.Enabled = false;
            this.txtBoxPassingYards.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtBoxPassingYards.Location = new System.Drawing.Point(976, 478);
            this.txtBoxPassingYards.Name = "txtBoxPassingYards";
            this.txtBoxPassingYards.Size = new System.Drawing.Size(96, 33);
            this.txtBoxPassingYards.TabIndex = 22;
            // 
            // txtBoxTackles
            // 
            this.txtBoxTackles.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._NFL_Player_Stats__BindingSource, "Tackles", true));
            this.txtBoxTackles.Enabled = false;
            this.txtBoxTackles.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtBoxTackles.Location = new System.Drawing.Point(920, 533);
            this.txtBoxTackles.Name = "txtBoxTackles";
            this.txtBoxTackles.Size = new System.Drawing.Size(114, 33);
            this.txtBoxTackles.TabIndex = 23;
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.Location = new System.Drawing.Point(1093, 22);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(36, 40);
            this.lbExit.TabIndex = 1;
            this.lbExit.Text = "X";
            this.ttpSports.SetToolTip(this.lbExit, "Click to Exit");
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // _NFL_Player_Stats__TableAdapter
            // 
            this._NFL_Player_Stats__TableAdapter.ClearBeforeFill = true;
            // 
            // _NFL_Players__TableAdapter
            // 
            this._NFL_Players__TableAdapter.ClearBeforeFill = true;
            // 
            // _NFL_Team__TableAdapter
            // 
            this._NFL_Team__TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._NFL_Player_Stats__TableAdapter = null;
            this.tableAdapterManager._NFL_Players__TableAdapter = null;
            this.tableAdapterManager._NFL_Team__TableAdapter = null;
            this.tableAdapterManager._NHL_Player_Stats__ExternalData_1TableAdapter = null;
            this.tableAdapterManager._NHL_Player_Stats__TableAdapter = null;
            this.tableAdapterManager._NHL_Players___xlnm__FilterDatabaseTableAdapter = null;
            this.tableAdapterManager._NHL_Players__TableAdapter = null;
            this.tableAdapterManager._NHL_Team__TableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Sports_Project_1.sportsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_TableAdapter = null;
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.BackColor = System.Drawing.Color.Transparent;
            this.lblPName.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.Location = new System.Drawing.Point(529, 79);
            this.lblPName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(103, 40);
            this.lblPName.TabIndex = 24;
            this.lblPName.Text = "NAME";
            // 
            // NFLPlayerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sports_Project_1.Properties.Resources.NFL_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.butExit;
            this.ClientSize = new System.Drawing.Size(1152, 652);
            this.ControlBox = false;
            this.Controls.Add(this.lblPName);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.txtBoxTackles);
            this.Controls.Add(this.txtBoxPassingYards);
            this.Controls.Add(this.txtBoxRushingYards);
            this.Controls.Add(this.txtBoxTDs);
            this.Controls.Add(this.txtBoxReceivingYards);
            this.Controls.Add(this.txtBoxGP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTackles);
            this.Controls.Add(this.lblRushY);
            this.Controls.Add(this.lblReceivingY);
            this.Controls.Add(this.lblPassY);
            this.Controls.Add(this.lblTDs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelPlayerInfoBorder);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.pBoxLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NFLPlayerStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NFLPlayerStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._NFL_Team__BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDBDataSet)).EndInit();
            this.panelPlayerInfo.ResumeLayout(false);
            this.panelPlayerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._NFL_Players__BindingSource)).EndInit();
            this.panelPlayerInfoBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._NFL_Player_Stats__BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Panel panelPlayerInfo;
        private System.Windows.Forms.Panel panelPlayerInfoBorder;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTDs;
        private System.Windows.Forms.Label lblPassY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReceivingY;
        private System.Windows.Forms.Label lblRushY;
        private System.Windows.Forms.Label lblTackles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxJNum;
        private System.Windows.Forms.TextBox txtBoxPos;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtBoxFName;
        private System.Windows.Forms.TextBox txtBoxGP;
        private System.Windows.Forms.TextBox txtBoxReceivingYards;
        private System.Windows.Forms.TextBox txtBoxTDs;
        private System.Windows.Forms.TextBox txtBoxRushingYards;
        private System.Windows.Forms.TextBox txtBoxPassingYards;
        private System.Windows.Forms.TextBox txtBoxTackles;
        private sportsDBDataSet sportsDBDataSet;
        private System.Windows.Forms.BindingSource _NFL_Player_Stats__BindingSource;
        private sportsDBDataSetTableAdapters._NFL_Player_Stats__TableAdapter _NFL_Player_Stats__TableAdapter;
        private sportsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource _NFL_Players__BindingSource;
        private sportsDBDataSetTableAdapters._NFL_Players__TableAdapter _NFL_Players__TableAdapter;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.BindingSource _NFL_Team__BindingSource;
        private sportsDBDataSetTableAdapters._NFL_Team__TableAdapter _NFL_Team__TableAdapter;
        private System.Windows.Forms.ToolTip ttpSports;
        private System.Windows.Forms.Label lblPName;
    }
}