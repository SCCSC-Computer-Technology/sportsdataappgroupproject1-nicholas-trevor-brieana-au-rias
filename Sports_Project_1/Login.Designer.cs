namespace Sports_Project_1
{
    partial class Login
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
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.butLogin = new System.Windows.Forms.Button();
            this.butCreateAcc = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.cBoxSeePass = new System.Windows.Forms.CheckBox();
            this.lbExit = new System.Windows.Forms.Label();
            this.ttpSports = new System.Windows.Forms.ToolTip(this.components);
            this.lblForgot = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUser.Location = new System.Drawing.Point(1074, 381);
            this.txtBoxUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(446, 58);
            this.txtBoxUser.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(700, 381);
            this.lblUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(298, 72);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(700, 504);
            this.lblPass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(284, 72);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password:";
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtBoxPass.Location = new System.Drawing.Point(1074, 512);
            this.txtBoxPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '*';
            this.txtBoxPass.Size = new System.Drawing.Size(446, 58);
            this.txtBoxPass.TabIndex = 1;
            // 
            // butLogin
            // 
            this.butLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.Location = new System.Drawing.Point(714, 715);
            this.butLogin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(244, 133);
            this.butLogin.TabIndex = 2;
            this.butLogin.Text = "&Login";
            this.ttpSports.SetToolTip(this.butLogin, "Click to Login");
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // butCreateAcc
            // 
            this.butCreateAcc.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.butCreateAcc.Location = new System.Drawing.Point(1506, 715);
            this.butCreateAcc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.butCreateAcc.Name = "butCreateAcc";
            this.butCreateAcc.Size = new System.Drawing.Size(244, 133);
            this.butCreateAcc.TabIndex = 4;
            this.butCreateAcc.Text = "&Create Account";
            this.ttpSports.SetToolTip(this.butCreateAcc, "Click to Create an Account");
            this.butCreateAcc.UseVisualStyleBackColor = true;
            this.butCreateAcc.Click += new System.EventHandler(this.butCreateAcc_Click);
            // 
            // butExit
            // 
            this.butExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.butExit.Location = new System.Drawing.Point(1126, 848);
            this.butExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(244, 133);
            this.butExit.TabIndex = 3;
            this.butExit.Text = "&Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // cBoxSeePass
            // 
            this.cBoxSeePass.AutoSize = true;
            this.cBoxSeePass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cBoxSeePass.Location = new System.Drawing.Point(1612, 531);
            this.cBoxSeePass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cBoxSeePass.Name = "cBoxSeePass";
            this.cBoxSeePass.Size = new System.Drawing.Size(293, 55);
            this.cBoxSeePass.TabIndex = 5;
            this.cBoxSeePass.Text = "&see password";
            this.ttpSports.SetToolTip(this.cBoxSeePass, "Click to See/Hide Your Password");
            this.cBoxSeePass.UseVisualStyleBackColor = true;
            this.cBoxSeePass.CheckedChanged += new System.EventHandler(this.cBoxSeePass_CheckedChanged);
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.Location = new System.Drawing.Point(2208, 42);
            this.lbExit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(71, 77);
            this.lbExit.TabIndex = 35;
            this.lbExit.Text = "X";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.Location = new System.Drawing.Point(1924, 564);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(186, 25);
            this.lblForgot.TabIndex = 36;
            this.lblForgot.TabStop = true;
            this.lblForgot.Text = "Forgot Password?";
            this.lblForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgot_LinkClicked_1);
            // 
            // Login
            // 
            this.AcceptButton = this.butLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sports_Project_1.Properties.Resources.login_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.butExit;
            this.ClientSize = new System.Drawing.Size(2304, 1238);
            this.ControlBox = false;
            this.Controls.Add(this.lblForgot);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.cBoxSeePass);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butCreateAcc);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtBoxUser);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Button butCreateAcc;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.CheckBox cBoxSeePass;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.ToolTip ttpSports;
        private System.Windows.Forms.LinkLabel lblForgot;
    }
}