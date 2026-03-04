namespace Sports_Project_1
{
    partial class NHLPlayersForm
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
            System.Windows.Forms.Label jersey_NumberLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NHLPlayersForm));
            this.lblTeamName = new System.Windows.Forms.Label();
            this.tbTeamName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPlayerStatsTag = new System.Windows.Forms.Label();
            this.lblPlayerInformationTag = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbJerseyNumber = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblPIM = new System.Windows.Forms.Label();
            this.lblPlusMinus = new System.Windows.Forms.Label();
            this.lblPTS = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblGP = new System.Windows.Forms.Label();
            this.tbPIM = new System.Windows.Forms.TextBox();
            this.tbPlusMinus = new System.Windows.Forms.TextBox();
            this.tbPTS = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbG = new System.Windows.Forms.TextBox();
            this.tbGP = new System.Windows.Forms.TextBox();
            this.cmbPlayers = new System.Windows.Forms.ComboBox();
            this.PictureBoxTeamLogo = new System.Windows.Forms.PictureBox();
            this.lbExit = new System.Windows.Forms.Label();
            this.ttpSports = new System.Windows.Forms.ToolTip(this.components);
            jersey_NumberLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTeamLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // jersey_NumberLabel
            // 
            jersey_NumberLabel.AutoSize = true;
            jersey_NumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            jersey_NumberLabel.Enabled = false;
            jersey_NumberLabel.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            jersey_NumberLabel.Location = new System.Drawing.Point(412, 253);
            jersey_NumberLabel.Name = "jersey_NumberLabel";
            jersey_NumberLabel.Size = new System.Drawing.Size(123, 18);
            jersey_NumberLabel.TabIndex = 49;
            jersey_NumberLabel.Text = "Jersey Number:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            positionLabel.Enabled = false;
            positionLabel.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            positionLabel.Location = new System.Drawing.Point(648, 253);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(72, 18);
            positionLabel.TabIndex = 47;
            positionLabel.Text = "Position:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            last_NameLabel.Enabled = false;
            last_NameLabel.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            last_NameLabel.Location = new System.Drawing.Point(206, 253);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(91, 18);
            last_NameLabel.TabIndex = 45;
            last_NameLabel.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label3.Enabled = false;
            label3.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            label3.Location = new System.Drawing.Point(1, 253);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 18);
            label3.TabIndex = 58;
            label3.Text = "First Name:";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(596, 142);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(112, 20);
            this.lblTeamName.TabIndex = 57;
            this.lblTeamName.Text = "TEAM NAME";
            // 
            // tbTeamName
            // 
            this.tbTeamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTeamName.Enabled = false;
            this.tbTeamName.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tbTeamName.ForeColor = System.Drawing.Color.Black;
            this.tbTeamName.Location = new System.Drawing.Point(545, 165);
            this.tbTeamName.Name = "tbTeamName";
            this.tbTeamName.Size = new System.Drawing.Size(209, 23);
            this.tbTeamName.TabIndex = 56;
            this.tbTeamName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(356, 163);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 23);
            this.btnExit.TabIndex = 55;
            this.btnExit.Text = "Exit Player Stats";
            this.ttpSports.SetToolTip(this.btnExit, "Click to Exit");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPlayerStatsTag
            // 
            this.lblPlayerStatsTag.AutoSize = true;
            this.lblPlayerStatsTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerStatsTag.Location = new System.Drawing.Point(337, 286);
            this.lblPlayerStatsTag.Name = "lblPlayerStatsTag";
            this.lblPlayerStatsTag.Size = new System.Drawing.Size(140, 20);
            this.lblPlayerStatsTag.TabIndex = 54;
            this.lblPlayerStatsTag.Text = "PLAYER STATS";
            // 
            // lblPlayerInformationTag
            // 
            this.lblPlayerInformationTag.AutoSize = true;
            this.lblPlayerInformationTag.Enabled = false;
            this.lblPlayerInformationTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerInformationTag.Location = new System.Drawing.Point(305, 202);
            this.lblPlayerInformationTag.Name = "lblPlayerInformationTag";
            this.lblPlayerInformationTag.Size = new System.Drawing.Size(206, 20);
            this.lblPlayerInformationTag.TabIndex = 53;
            this.lblPlayerInformationTag.Text = "PLAYER INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-89, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1099, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-9, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1099, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // tbJerseyNumber
            // 
            this.tbJerseyNumber.Enabled = false;
            this.tbJerseyNumber.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJerseyNumber.Location = new System.Drawing.Point(541, 253);
            this.tbJerseyNumber.Name = "tbJerseyNumber";
            this.tbJerseyNumber.Size = new System.Drawing.Size(100, 23);
            this.tbJerseyNumber.TabIndex = 50;
            // 
            // tbPosition
            // 
            this.tbPosition.Enabled = false;
            this.tbPosition.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tbPosition.Location = new System.Drawing.Point(726, 252);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(100, 23);
            this.tbPosition.TabIndex = 48;
            // 
            // tbLastName
            // 
            this.tbLastName.Enabled = false;
            this.tbLastName.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tbLastName.Location = new System.Drawing.Point(303, 253);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 23);
            this.tbLastName.TabIndex = 46;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tbFirstName.Location = new System.Drawing.Point(100, 252);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 23);
            this.tbFirstName.TabIndex = 44;
            // 
            // lblPIM
            // 
            this.lblPIM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPIM.Enabled = false;
            this.lblPIM.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblPIM.Location = new System.Drawing.Point(615, 378);
            this.lblPIM.Name = "lblPIM";
            this.lblPIM.Size = new System.Drawing.Size(144, 23);
            this.lblPIM.TabIndex = 43;
            this.lblPIM.Text = "Penalty Minutes (PIM)";
            this.lblPIM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlusMinus
            // 
            this.lblPlusMinus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlusMinus.Enabled = false;
            this.lblPlusMinus.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblPlusMinus.Location = new System.Drawing.Point(329, 378);
            this.lblPlusMinus.Name = "lblPlusMinus";
            this.lblPlusMinus.Size = new System.Drawing.Size(144, 23);
            this.lblPlusMinus.TabIndex = 42;
            this.lblPlusMinus.Text = "PlusMinus (+/-)";
            this.lblPlusMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPTS
            // 
            this.lblPTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPTS.Enabled = false;
            this.lblPTS.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblPTS.Location = new System.Drawing.Point(37, 378);
            this.lblPTS.Name = "lblPTS";
            this.lblPTS.Size = new System.Drawing.Size(144, 23);
            this.lblPTS.TabIndex = 41;
            this.lblPTS.Text = "Points (PTS)";
            this.lblPTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblA
            // 
            this.lblA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblA.Enabled = false;
            this.lblA.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblA.Location = new System.Drawing.Point(615, 315);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(144, 23);
            this.lblA.TabIndex = 40;
            this.lblA.Text = "Assist (A)";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblG
            // 
            this.lblG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblG.Enabled = false;
            this.lblG.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblG.Location = new System.Drawing.Point(329, 315);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(144, 23);
            this.lblG.TabIndex = 39;
            this.lblG.Text = "Goals (G)";
            this.lblG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGP
            // 
            this.lblGP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGP.Enabled = false;
            this.lblGP.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblGP.Location = new System.Drawing.Point(37, 315);
            this.lblGP.Name = "lblGP";
            this.lblGP.Size = new System.Drawing.Size(144, 23);
            this.lblGP.TabIndex = 38;
            this.lblGP.Text = "Games Played (GP)";
            this.lblGP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPIM
            // 
            this.tbPIM.Enabled = false;
            this.tbPIM.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tbPIM.Location = new System.Drawing.Point(618, 404);
            this.tbPIM.Name = "tbPIM";
            this.tbPIM.Size = new System.Drawing.Size(141, 23);
            this.tbPIM.TabIndex = 37;
            // 
            // tbPlusMinus
            // 
            this.tbPlusMinus.Enabled = false;
            this.tbPlusMinus.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tbPlusMinus.Location = new System.Drawing.Point(332, 404);
            this.tbPlusMinus.Name = "tbPlusMinus";
            this.tbPlusMinus.Size = new System.Drawing.Size(141, 23);
            this.tbPlusMinus.TabIndex = 36;
            // 
            // tbPTS
            // 
            this.tbPTS.Enabled = false;
            this.tbPTS.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tbPTS.Location = new System.Drawing.Point(40, 404);
            this.tbPTS.Name = "tbPTS";
            this.tbPTS.Size = new System.Drawing.Size(141, 23);
            this.tbPTS.TabIndex = 35;
            // 
            // tbA
            // 
            this.tbA.Enabled = false;
            this.tbA.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tbA.Location = new System.Drawing.Point(618, 341);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(141, 23);
            this.tbA.TabIndex = 34;
            // 
            // tbG
            // 
            this.tbG.Enabled = false;
            this.tbG.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tbG.Location = new System.Drawing.Point(332, 341);
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(141, 23);
            this.tbG.TabIndex = 33;
            // 
            // tbGP
            // 
            this.tbGP.Enabled = false;
            this.tbGP.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tbGP.Location = new System.Drawing.Point(40, 341);
            this.tbGP.Name = "tbGP";
            this.tbGP.Size = new System.Drawing.Size(141, 23);
            this.tbGP.TabIndex = 32;
            // 
            // cmbPlayers
            // 
            this.cmbPlayers.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.cmbPlayers.FormattingEnabled = true;
            this.cmbPlayers.Location = new System.Drawing.Point(332, 69);
            this.cmbPlayers.Name = "cmbPlayers";
            this.cmbPlayers.Size = new System.Drawing.Size(468, 24);
            this.cmbPlayers.TabIndex = 31;
            // 
            // PictureBoxTeamLogo
            // 
            this.PictureBoxTeamLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxTeamLogo.Location = new System.Drawing.Point(6, 11);
            this.PictureBoxTeamLogo.Name = "PictureBoxTeamLogo";
            this.PictureBoxTeamLogo.Size = new System.Drawing.Size(320, 178);
            this.PictureBoxTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxTeamLogo.TabIndex = 30;
            this.PictureBoxTeamLogo.TabStop = false;
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.Location = new System.Drawing.Point(784, 9);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(36, 40);
            this.lbExit.TabIndex = 59;
            this.lbExit.Text = "X";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // NHLPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 458);
            this.ControlBox = false;
            this.Controls.Add(this.lbExit);
            this.Controls.Add(label3);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.tbTeamName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPlayerStatsTag);
            this.Controls.Add(this.lblPlayerInformationTag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(jersey_NumberLabel);
            this.Controls.Add(this.tbJerseyNumber);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblPIM);
            this.Controls.Add(this.lblPlusMinus);
            this.Controls.Add(this.lblPTS);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblGP);
            this.Controls.Add(this.tbPIM);
            this.Controls.Add(this.tbPlusMinus);
            this.Controls.Add(this.tbPTS);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.tbGP);
            this.Controls.Add(this.cmbPlayers);
            this.Controls.Add(this.PictureBoxTeamLogo);
            this.Name = "NHLPlayersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NHLPlayersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTeamLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.TextBox tbTeamName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPlayerStatsTag;
        private System.Windows.Forms.Label lblPlayerInformationTag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbJerseyNumber;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblPIM;
        private System.Windows.Forms.Label lblPlusMinus;
        private System.Windows.Forms.Label lblPTS;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblGP;
        private System.Windows.Forms.TextBox tbPIM;
        private System.Windows.Forms.TextBox tbPlusMinus;
        private System.Windows.Forms.TextBox tbPTS;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbG;
        private System.Windows.Forms.TextBox tbGP;
        private System.Windows.Forms.ComboBox cmbPlayers;
        private System.Windows.Forms.PictureBox PictureBoxTeamLogo;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.ToolTip ttpSports;
    }
}