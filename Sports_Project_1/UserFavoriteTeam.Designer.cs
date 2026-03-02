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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbNHLTeams = new System.Windows.Forms.ComboBox();
            this.cmbNFLTeams = new System.Windows.Forms.ComboBox();
            this.lblNhl = new System.Windows.Forms.Label();
            this.lblNfl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(444, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 37);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(128, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 37);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbNHLTeams
            // 
            this.cmbNHLTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNHLTeams.FormattingEnabled = true;
            this.cmbNHLTeams.Location = new System.Drawing.Point(632, 137);
            this.cmbNHLTeams.Name = "cmbNHLTeams";
            this.cmbNHLTeams.Size = new System.Drawing.Size(438, 32);
            this.cmbNHLTeams.TabIndex = 10;
            // 
            // cmbNFLTeams
            // 
            this.cmbNFLTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNFLTeams.FormattingEnabled = true;
            this.cmbNFLTeams.Location = new System.Drawing.Point(83, 307);
            this.cmbNFLTeams.Name = "cmbNFLTeams";
            this.cmbNFLTeams.Size = new System.Drawing.Size(436, 32);
            this.cmbNFLTeams.TabIndex = 9;
            // 
            // lblNhl
            // 
            this.lblNhl.AutoSize = true;
            this.lblNhl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNhl.Enabled = false;
            this.lblNhl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhl.Location = new System.Drawing.Point(632, 110);
            this.lblNhl.Name = "lblNhl";
            this.lblNhl.Size = new System.Drawing.Size(440, 26);
            this.lblNhl.TabIndex = 8;
            this.lblNhl.Text = "Select your favorite NHL team(s) from the list below!";
            // 
            // lblNfl
            // 
            this.lblNfl.AutoSize = true;
            this.lblNfl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNfl.Enabled = false;
            this.lblNfl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNfl.Location = new System.Drawing.Point(83, 280);
            this.lblNfl.Name = "lblNfl";
            this.lblNfl.Size = new System.Drawing.Size(438, 26);
            this.lblNfl.TabIndex = 7;
            this.lblNfl.Text = "Select your favorite NFL team(s) from the list below!";
            // 
            // UserFavoriteTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sports_Project_1.Properties.Resources.login_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 667);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbNHLTeams);
            this.Controls.Add(this.cmbNFLTeams);
            this.Controls.Add(this.lblNhl);
            this.Controls.Add(this.lblNfl);
            this.Name = "UserFavoriteTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserFavoriteTeam";
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
    }
}