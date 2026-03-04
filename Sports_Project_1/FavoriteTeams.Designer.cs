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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoriteTeams));
            this.lbExit = new System.Windows.Forms.Label();
            this.cbxReceiveUpdates = new System.Windows.Forms.CheckBox();
            this.flpNFL = new System.Windows.Forms.FlowLayoutPanel();
            this.flpNHL = new System.Windows.Forms.FlowLayoutPanel();
            this.ttpSports = new System.Windows.Forms.ToolTip(this.components);
            this.butExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.Location = new System.Drawing.Point(786, -1);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(27, 30);
            this.lbExit.TabIndex = 23;
            this.lbExit.Text = "X";
            this.ttpSports.SetToolTip(this.lbExit, "Click to Exit");
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // cbxReceiveUpdates
            // 
            this.cbxReceiveUpdates.AutoSize = true;
            this.cbxReceiveUpdates.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxReceiveUpdates.Location = new System.Drawing.Point(187, 422);
            this.cbxReceiveUpdates.Margin = new System.Windows.Forms.Padding(2);
            this.cbxReceiveUpdates.Name = "cbxReceiveUpdates";
            this.cbxReceiveUpdates.Size = new System.Drawing.Size(438, 17);
            this.cbxReceiveUpdates.TabIndex = 24;
            this.cbxReceiveUpdates.Text = "Receive email updates about upcoming games, scores and more for your favorite tea" +
    "ms";
            this.ttpSports.SetToolTip(this.cbxReceiveUpdates, "Click for email updates");
            this.cbxReceiveUpdates.UseVisualStyleBackColor = false;
            this.cbxReceiveUpdates.CheckedChanged += new System.EventHandler(this.cbxReceiveUpdates_CheckedChanged);
            // 
            // flpNFL
            // 
            this.flpNFL.Location = new System.Drawing.Point(72, 81);
            this.flpNFL.Margin = new System.Windows.Forms.Padding(2);
            this.flpNFL.Name = "flpNFL";
            this.flpNFL.Size = new System.Drawing.Size(300, 323);
            this.flpNFL.TabIndex = 25;
            // 
            // flpNHL
            // 
            this.flpNHL.Location = new System.Drawing.Point(432, 81);
            this.flpNHL.Margin = new System.Windows.Forms.Padding(2);
            this.flpNHL.Name = "flpNHL";
            this.flpNHL.Size = new System.Drawing.Size(300, 323);
            this.flpNHL.TabIndex = 26;
            // 
            // butExit
            // 
            this.butExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(12, 443);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(87, 37);
            this.butExit.TabIndex = 33;
            this.butExit.Text = "&Exit";
            this.ttpSports.SetToolTip(this.butExit, "Click to Exit");
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // FavoriteTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 492);
            this.ControlBox = false;
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.flpNHL);
            this.Controls.Add(this.flpNFL);
            this.Controls.Add(this.cbxReceiveUpdates);
            this.Controls.Add(this.lbExit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FavoriteTeams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FavoriteTeams_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.CheckBox cbxReceiveUpdates;
        private System.Windows.Forms.FlowLayoutPanel flpNFL;
        private System.Windows.Forms.FlowLayoutPanel flpNHL;
        private System.Windows.Forms.ToolTip ttpSports;
        private System.Windows.Forms.Button butExit;
    }
}