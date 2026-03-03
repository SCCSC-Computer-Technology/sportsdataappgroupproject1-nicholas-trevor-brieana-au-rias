namespace Sports_Project_1
{
    partial class FavoriteTeams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoriteTeams));
            this.lbExit = new System.Windows.Forms.Label();
            this.cbxReceiveUpdates = new System.Windows.Forms.CheckBox();
            this.flpNFL = new System.Windows.Forms.FlowLayoutPanel();
            this.flpNHL = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.Location = new System.Drawing.Point(1571, -2);
            this.lbExit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(53, 57);
            this.lbExit.TabIndex = 23;
            this.lbExit.Text = "X";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // cbxReceiveUpdates
            // 
            this.cbxReceiveUpdates.AutoSize = true;
            this.cbxReceiveUpdates.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxReceiveUpdates.Location = new System.Drawing.Point(374, 811);
            this.cbxReceiveUpdates.Name = "cbxReceiveUpdates";
            this.cbxReceiveUpdates.Size = new System.Drawing.Size(883, 29);
            this.cbxReceiveUpdates.TabIndex = 24;
            this.cbxReceiveUpdates.Text = "Receive email updates about upcoming games, scores and more for your favorite tea" +
    "ms";
            this.cbxReceiveUpdates.UseVisualStyleBackColor = false;
            this.cbxReceiveUpdates.CheckedChanged += new System.EventHandler(this.cbxReceiveUpdates_CheckedChanged);
            // 
            // flpNFL
            // 
            this.flpNFL.Location = new System.Drawing.Point(144, 156);
            this.flpNFL.Name = "flpNFL";
            this.flpNFL.Size = new System.Drawing.Size(601, 622);
            this.flpNFL.TabIndex = 25;
            // 
            // flpNHL
            // 
            this.flpNHL.Location = new System.Drawing.Point(864, 156);
            this.flpNHL.Name = "flpNHL";
            this.flpNHL.Size = new System.Drawing.Size(601, 622);
            this.flpNHL.TabIndex = 26;
            // 
            // FavoriteTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1630, 947);
            this.Controls.Add(this.flpNHL);
            this.Controls.Add(this.flpNFL);
            this.Controls.Add(this.cbxReceiveUpdates);
            this.Controls.Add(this.lbExit);
            this.Name = "FavoriteTeams";
            this.Text = "FavoriteTeams";
            this.Load += new System.EventHandler(this.FavoriteTeams_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.CheckBox cbxReceiveUpdates;
        private System.Windows.Forms.FlowLayoutPanel flpNFL;
        private System.Windows.Forms.FlowLayoutPanel flpNHL;
    }
}