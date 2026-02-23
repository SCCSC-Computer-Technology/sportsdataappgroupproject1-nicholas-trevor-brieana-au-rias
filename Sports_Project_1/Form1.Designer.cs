namespace Sports_Project_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxBruins = new System.Windows.Forms.PictureBox();
            this.pbxDucks = new System.Windows.Forms.PictureBox();
            this.pbxCapitals = new System.Windows.Forms.PictureBox();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBruins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapitals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxBruins
            // 
            this.pbxBruins.BackColor = System.Drawing.Color.Transparent;
            this.pbxBruins.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxBruins.BackgroundImage")));
            this.pbxBruins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBruins.Location = new System.Drawing.Point(52, 62);
            this.pbxBruins.Name = "pbxBruins";
            this.pbxBruins.Size = new System.Drawing.Size(96, 98);
            this.pbxBruins.TabIndex = 0;
            this.pbxBruins.TabStop = false;
            this.pbxBruins.Tag = "1";
            this.pbxBruins.Click += new System.EventHandler(this.pbxBruins_Click);
            // 
            // pbxDucks
            // 
            this.pbxDucks.BackColor = System.Drawing.Color.Transparent;
            this.pbxDucks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxDucks.BackgroundImage")));
            this.pbxDucks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxDucks.Location = new System.Drawing.Point(154, 62);
            this.pbxDucks.Name = "pbxDucks";
            this.pbxDucks.Size = new System.Drawing.Size(96, 98);
            this.pbxDucks.TabIndex = 1;
            this.pbxDucks.TabStop = false;
            this.pbxDucks.Tag = "2";
            // 
            // pbxCapitals
            // 
            this.pbxCapitals.BackColor = System.Drawing.Color.Transparent;
            this.pbxCapitals.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxCapitals.BackgroundImage")));
            this.pbxCapitals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCapitals.Location = new System.Drawing.Point(256, 62);
            this.pbxCapitals.Name = "pbxCapitals";
            this.pbxCapitals.Size = new System.Drawing.Size(96, 98);
            this.pbxCapitals.TabIndex = 2;
            this.pbxCapitals.TabStop = false;
            this.pbxCapitals.Tag = "3";
            // 
            // pbxExit
            // 
            this.pbxExit.BackColor = System.Drawing.Color.Transparent;
            this.pbxExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxExit.BackgroundImage")));
            this.pbxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxExit.Location = new System.Drawing.Point(741, -6);
            this.pbxExit.Name = "pbxExit";
            this.pbxExit.Size = new System.Drawing.Size(64, 65);
            this.pbxExit.TabIndex = 3;
            this.pbxExit.TabStop = false;
            this.pbxExit.Tag = "2";
            this.pbxExit.Click += new System.EventHandler(this.pbxExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxExit);
            this.Controls.Add(this.pbxCapitals);
            this.Controls.Add(this.pbxDucks);
            this.Controls.Add(this.pbxBruins);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBruins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapitals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBruins;
        private System.Windows.Forms.PictureBox pbxDucks;
        private System.Windows.Forms.PictureBox pbxCapitals;
        private System.Windows.Forms.PictureBox pbxExit;
    }
}

