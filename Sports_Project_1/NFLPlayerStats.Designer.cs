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
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.butExit = new System.Windows.Forms.Button();
            this.panelPlayerInfo = new System.Windows.Forms.Panel();
            this.panelPlayerInfoBorder = new System.Windows.Forms.Panel();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTDs = new System.Windows.Forms.Label();
            this.lblPassY = new System.Windows.Forms.Label();
            this.lblReceivingY = new System.Windows.Forms.Label();
            this.lblRushY = new System.Windows.Forms.Label();
            this.lblTackles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtBoxPos = new System.Windows.Forms.TextBox();
            this.txtBoxJNum = new System.Windows.Forms.TextBox();
            this.txtBoxGP = new System.Windows.Forms.TextBox();
            this.txtBoxReceivingYards = new System.Windows.Forms.TextBox();
            this.txtBoxTDs = new System.Windows.Forms.TextBox();
            this.txtBoxRushingYards = new System.Windows.Forms.TextBox();
            this.txtBoxPassingYards = new System.Windows.Forms.TextBox();
            this.txtBoxTackles = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.panelPlayerInfo.SuspendLayout();
            this.panelPlayerInfoBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxLogo.Location = new System.Drawing.Point(71, 79);
            this.pBoxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(268, 220);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLogo.TabIndex = 0;
            this.pBoxLogo.TabStop = false;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(528, 79);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(132, 50);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(805, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "JERSEY NUM: ";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.BackColor = System.Drawing.Color.Transparent;
            this.lblTeamName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(774, 223);
            this.lblTeamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(179, 37);
            this.lblTeamName.TabIndex = 3;
            this.lblTeamName.Text = "TEAM NAME";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.Location = new System.Drawing.Point(580, 54);
            this.lblPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(93, 21);
            this.lblPos.TabIndex = 4;
            this.lblPos.Text = "POSITION: ";
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(410, 217);
            this.butExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(222, 43);
            this.butExit.TabIndex = 5;
            this.butExit.Text = "&Exit";
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
            this.panelPlayerInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPlayerInfo.Name = "panelPlayerInfo";
            this.panelPlayerInfo.Size = new System.Drawing.Size(1018, 120);
            this.panelPlayerInfo.TabIndex = 6;
            // 
            // panelPlayerInfoBorder
            // 
            this.panelPlayerInfoBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(217)))));
            this.panelPlayerInfoBorder.Controls.Add(this.panelPlayerInfo);
            this.panelPlayerInfoBorder.Location = new System.Drawing.Point(60, 307);
            this.panelPlayerInfoBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPlayerInfoBorder.Name = "panelPlayerInfoBorder";
            this.panelPlayerInfoBorder.Size = new System.Drawing.Size(1032, 131);
            this.panelPlayerInfoBorder.TabIndex = 7;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(5, 54);
            this.lblFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(111, 21);
            this.lblFName.TabIndex = 5;
            this.lblFName.Text = "FIRST NAME: ";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(281, 54);
            this.lblLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(107, 21);
            this.lblLName.TabIndex = 6;
            this.lblLName.Text = "LAST NAME: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 485);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "GAMES PLAYED: ";
            // 
            // lblTDs
            // 
            this.lblTDs.AutoSize = true;
            this.lblTDs.BackColor = System.Drawing.Color.Transparent;
            this.lblTDs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDs.Location = new System.Drawing.Point(450, 485);
            this.lblTDs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTDs.Name = "lblTDs";
            this.lblTDs.Size = new System.Drawing.Size(134, 21);
            this.lblTDs.TabIndex = 8;
            this.lblTDs.Text = "TOUCHDOWNS: ";
            // 
            // lblPassY
            // 
            this.lblPassY.AutoSize = true;
            this.lblPassY.BackColor = System.Drawing.Color.Transparent;
            this.lblPassY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassY.Location = new System.Drawing.Point(830, 485);
            this.lblPassY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassY.Name = "lblPassY";
            this.lblPassY.Size = new System.Drawing.Size(140, 21);
            this.lblPassY.TabIndex = 9;
            this.lblPassY.Text = "PASSING YARDS: ";
            // 
            // lblReceivingY
            // 
            this.lblReceivingY.AutoSize = true;
            this.lblReceivingY.BackColor = System.Drawing.Color.Transparent;
            this.lblReceivingY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivingY.Location = new System.Drawing.Point(79, 538);
            this.lblReceivingY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivingY.Name = "lblReceivingY";
            this.lblReceivingY.Size = new System.Drawing.Size(156, 21);
            this.lblReceivingY.TabIndex = 10;
            this.lblReceivingY.Text = "RECEIVING YARDS: ";
            // 
            // lblRushY
            // 
            this.lblRushY.AutoSize = true;
            this.lblRushY.BackColor = System.Drawing.Color.Transparent;
            this.lblRushY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRushY.Location = new System.Drawing.Point(450, 538);
            this.lblRushY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRushY.Name = "lblRushY";
            this.lblRushY.Size = new System.Drawing.Size(145, 21);
            this.lblRushY.TabIndex = 11;
            this.lblRushY.Text = "RUSHING YARDS: ";
            // 
            // lblTackles
            // 
            this.lblTackles.AutoSize = true;
            this.lblTackles.BackColor = System.Drawing.Color.Transparent;
            this.lblTackles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTackles.Location = new System.Drawing.Point(830, 538);
            this.lblTackles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTackles.Name = "lblTackles";
            this.lblTackles.Size = new System.Drawing.Size(83, 21);
            this.lblTackles.TabIndex = 12;
            this.lblTackles.Text = "TACKLES: ";
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
            // txtBoxFName
            // 
            this.txtBoxFName.Location = new System.Drawing.Point(111, 55);
            this.txtBoxFName.Name = "txtBoxFName";
            this.txtBoxFName.Size = new System.Drawing.Size(163, 22);
            this.txtBoxFName.TabIndex = 14;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(387, 55);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(178, 22);
            this.txtLName.TabIndex = 15;
            // 
            // txtBoxPos
            // 
            this.txtBoxPos.Location = new System.Drawing.Point(669, 55);
            this.txtBoxPos.Name = "txtBoxPos";
            this.txtBoxPos.Size = new System.Drawing.Size(114, 22);
            this.txtBoxPos.TabIndex = 16;
            // 
            // txtBoxJNum
            // 
            this.txtBoxJNum.Location = new System.Drawing.Point(919, 55);
            this.txtBoxJNum.Name = "txtBoxJNum";
            this.txtBoxJNum.Size = new System.Drawing.Size(89, 22);
            this.txtBoxJNum.TabIndex = 17;
            // 
            // txtBoxGP
            // 
            this.txtBoxGP.Location = new System.Drawing.Point(222, 486);
            this.txtBoxGP.Name = "txtBoxGP";
            this.txtBoxGP.Size = new System.Drawing.Size(114, 22);
            this.txtBoxGP.TabIndex = 18;
            // 
            // txtBoxReceivingYards
            // 
            this.txtBoxReceivingYards.Location = new System.Drawing.Point(242, 539);
            this.txtBoxReceivingYards.Name = "txtBoxReceivingYards";
            this.txtBoxReceivingYards.Size = new System.Drawing.Size(114, 22);
            this.txtBoxReceivingYards.TabIndex = 19;
            // 
            // txtBoxTDs
            // 
            this.txtBoxTDs.Location = new System.Drawing.Point(598, 486);
            this.txtBoxTDs.Name = "txtBoxTDs";
            this.txtBoxTDs.Size = new System.Drawing.Size(153, 22);
            this.txtBoxTDs.TabIndex = 20;
            // 
            // txtBoxRushingYards
            // 
            this.txtBoxRushingYards.Location = new System.Drawing.Point(598, 539);
            this.txtBoxRushingYards.Name = "txtBoxRushingYards";
            this.txtBoxRushingYards.Size = new System.Drawing.Size(153, 22);
            this.txtBoxRushingYards.TabIndex = 21;
            // 
            // txtBoxPassingYards
            // 
            this.txtBoxPassingYards.Location = new System.Drawing.Point(976, 484);
            this.txtBoxPassingYards.Name = "txtBoxPassingYards";
            this.txtBoxPassingYards.Size = new System.Drawing.Size(96, 22);
            this.txtBoxPassingYards.TabIndex = 22;
            // 
            // txtBoxTackles
            // 
            this.txtBoxTackles.Location = new System.Drawing.Point(920, 539);
            this.txtBoxTackles.Name = "txtBoxTackles";
            this.txtBoxTackles.Size = new System.Drawing.Size(114, 22);
            this.txtBoxTackles.TabIndex = 23;
            // 
            // NFLPlayerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sports_Project_1.Properties.Resources.NFL_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 652);
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
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pBoxLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NFLPlayerStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NFLPlayerStats";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.panelPlayerInfo.ResumeLayout(false);
            this.panelPlayerInfo.PerformLayout();
            this.panelPlayerInfoBorder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.Label lblPlayerName;
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
    }
}