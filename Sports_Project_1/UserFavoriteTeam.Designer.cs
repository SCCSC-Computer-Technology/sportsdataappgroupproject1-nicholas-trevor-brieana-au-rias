namespace Sports_Project_1
{
    partial class UserFavoriteTeam
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbNHLTeams = new System.Windows.Forms.ComboBox();
            this.cmbNFLTeams = new System.Windows.Forms.ComboBox();
            this.lblNhl = new System.Windows.Forms.Label();
            this.lblNfl = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.ttpSport = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(444, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 37);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Cancel";
            this.ttpSport.SetToolTip(this.btnCancel, "Click to Cancel selection and leave form");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(128, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 37);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "&Save";
            this.ttpSport.SetToolTip(this.btnSave, "Click to Save Selected Teams");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbNHLTeams
            // 
            this.cmbNHLTeams.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbNHLTeams.FormattingEnabled = true;
            this.cmbNHLTeams.Location = new System.Drawing.Point(632, 137);
            this.cmbNHLTeams.Name = "cmbNHLTeams";
            this.cmbNHLTeams.Size = new System.Drawing.Size(438, 33);
            this.cmbNHLTeams.TabIndex = 10;
            // 
            // cmbNFLTeams
            // 
            this.cmbNFLTeams.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbNFLTeams.FormattingEnabled = true;
            this.cmbNFLTeams.Location = new System.Drawing.Point(83, 307);
            this.cmbNFLTeams.Name = "cmbNFLTeams";
            this.cmbNFLTeams.Size = new System.Drawing.Size(436, 33);
            this.cmbNFLTeams.TabIndex = 9;
            // 
            // lblNhl
            // 
            this.lblNhl.AutoSize = true;
            this.lblNhl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNhl.Enabled = false;
            this.lblNhl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNhl.Location = new System.Drawing.Point(632, 110);
            this.lblNhl.Name = "lblNhl";
            this.lblNhl.Size = new System.Drawing.Size(480, 27);
            this.lblNhl.TabIndex = 8;
            this.lblNhl.Text = "Select your favorite NHL team(s) from the list below!";
            // 
            // lblNfl
            // 
            this.lblNfl.AutoSize = true;
            this.lblNfl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNfl.Enabled = false;
            this.lblNfl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNfl.Location = new System.Drawing.Point(83, 280);
            this.lblNfl.Name = "lblNfl";
            this.lblNfl.Size = new System.Drawing.Size(475, 27);
            this.lblNfl.TabIndex = 7;
            this.lblNfl.Text = "Select your favorite NFL team(s) from the list below!";
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.Location = new System.Drawing.Point(1093, 23);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(36, 40);
            this.lbExit.TabIndex = 13;
            this.lbExit.Text = "X";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // UserFavoriteTeam
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sports_Project_1.Properties.Resources.login_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1153, 667);
            this.ControlBox = false;
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbNHLTeams);
            this.Controls.Add(this.cmbNFLTeams);
            this.Controls.Add(this.lblNhl);
            this.Controls.Add(this.lblNfl);
            this.Name = "UserFavoriteTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserFavoriteTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbNHLTeams;
        private System.Windows.Forms.ComboBox cmbNFLTeams;
        private System.Windows.Forms.Label lblNhl;
        private System.Windows.Forms.Label lblNfl;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.ToolTip ttpSport;
    }
}