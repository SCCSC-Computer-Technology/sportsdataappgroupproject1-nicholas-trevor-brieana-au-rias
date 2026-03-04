namespace Sports_Project_1
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
            this.butNFL = new System.Windows.Forms.Button();
            this.butNHL = new System.Windows.Forms.Button();
            this.butLogout = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.ttpSports = new System.Windows.Forms.ToolTip(this.components);
            this.butFavTeams = new System.Windows.Forms.Button();
            this.pbxFavorite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFavorite)).BeginInit();
            this.SuspendLayout();
            // 
            // butNFL
            // 
            this.butNFL.BackgroundImage = global::Sports_Project_1.Properties.Resources.NFL_logoCrop;
            this.butNFL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butNFL.FlatAppearance.BorderSize = 0;
            this.butNFL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNFL.Location = new System.Drawing.Point(294, 158);
            this.butNFL.Name = "butNFL";
            this.butNFL.Size = new System.Drawing.Size(242, 290);
            this.butNFL.TabIndex = 0;
            this.ttpSports.SetToolTip(this.butNFL, "Click to View the Football Teams");
            this.butNFL.UseVisualStyleBackColor = true;
            this.butNFL.Click += new System.EventHandler(this.butNFL_Click);
            // 
            // butNHL
            // 
            this.butNHL.BackgroundImage = global::Sports_Project_1.Properties.Resources.NHL_logoCrop;
            this.butNHL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butNHL.FlatAppearance.BorderSize = 0;
            this.butNHL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNHL.Location = new System.Drawing.Point(646, 158);
            this.butNHL.Name = "butNHL";
            this.butNHL.Size = new System.Drawing.Size(242, 290);
            this.butNHL.TabIndex = 1;
            this.ttpSports.SetToolTip(this.butNHL, "Click to view the Hockey Teams");
            this.butNHL.UseVisualStyleBackColor = true;
            this.butNHL.Click += new System.EventHandler(this.butNHL_Click);
            // 
            // butLogout
            // 
            this.butLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butLogout.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.butLogout.Location = new System.Drawing.Point(685, 486);
            this.butLogout.Name = "butLogout";
            this.butLogout.Size = new System.Drawing.Size(180, 49);
            this.butLogout.TabIndex = 2;
            this.butLogout.Text = "L&ogout";
            this.ttpSports.SetToolTip(this.butLogout, "Click to Logout out of this Account");
            this.butLogout.UseVisualStyleBackColor = true;
            this.butLogout.Click += new System.EventHandler(this.butLogout_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(471, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 25);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.Location = new System.Drawing.Point(1092, 25);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(36, 40);
            this.lbExit.TabIndex = 3;
            this.lbExit.Text = "X";
            this.ttpSports.SetToolTip(this.lbExit, "Click to Exit");
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // butFavTeams
            // 
            this.butFavTeams.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.butFavTeams.Location = new System.Drawing.Point(242, 491);
            this.butFavTeams.Name = "butFavTeams";
            this.butFavTeams.Size = new System.Drawing.Size(339, 49);
            this.butFavTeams.TabIndex = 6;
            this.butFavTeams.Text = "Edit / Select Favorite Teams";
            this.ttpSports.SetToolTip(this.butFavTeams, "Click to Select Favorite Teams");
            this.butFavTeams.UseVisualStyleBackColor = true;
            this.butFavTeams.Click += new System.EventHandler(this.butFavTeams_Click);
            // 
            // pbxFavorite
            // 
            this.pbxFavorite.BackColor = System.Drawing.Color.Transparent;
            this.pbxFavorite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxFavorite.BackgroundImage")));
            this.pbxFavorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxFavorite.Location = new System.Drawing.Point(11, 11);
            this.pbxFavorite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxFavorite.Name = "pbxFavorite";
            this.pbxFavorite.Size = new System.Drawing.Size(41, 72);
            this.pbxFavorite.TabIndex = 7;
            this.pbxFavorite.TabStop = false;
            this.ttpSports.SetToolTip(this.pbxFavorite, "Click to view favorite teams");
            this.pbxFavorite.Click += new System.EventHandler(this.pbxFavorite_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sports_Project_1.Properties.Resources.login_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.butLogout;
            this.ClientSize = new System.Drawing.Size(1152, 552);
            this.ControlBox = false;
            this.Controls.Add(this.pbxFavorite);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.butFavTeams);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.butLogout);
            this.Controls.Add(this.butNHL);
            this.Controls.Add(this.butNFL);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbxFavorite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butNFL;
        private System.Windows.Forms.Button butNHL;
        private System.Windows.Forms.Button butLogout;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.ToolTip ttpSports;
        private System.Windows.Forms.Button butFavTeams;
        private System.Windows.Forms.PictureBox pbxFavorite;
    }
}