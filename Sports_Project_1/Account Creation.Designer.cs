namespace Sports_Project_1
{
    partial class Account_Creation
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
            this.cBoxSeePass = new System.Windows.Forms.CheckBox();
            this.butExit = new System.Windows.Forms.Button();
            this.butCreateAcc = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.lbCreate = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.ttpSports = new System.Windows.Forms.ToolTip(this.components);
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cBoxSeePass
            // 
            this.cBoxSeePass.AutoSize = true;
            this.cBoxSeePass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxSeePass.Location = new System.Drawing.Point(918, 279);
            this.cBoxSeePass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cBoxSeePass.Name = "cBoxSeePass";
            this.cBoxSeePass.Size = new System.Drawing.Size(208, 40);
            this.cBoxSeePass.TabIndex = 5;
            this.cBoxSeePass.Text = "&see password";
            this.ttpSports.SetToolTip(this.cBoxSeePass, "Click to see/hide password");
            this.cBoxSeePass.UseVisualStyleBackColor = true;
            this.cBoxSeePass.CheckedChanged += new System.EventHandler(this.cBoxSeePass_CheckedChanged);
            // 
            // butExit
            // 
            this.butExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(92, 494);
            this.butExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(272, 67);
            this.butExit.TabIndex = 3;
            this.butExit.Text = "&Exit";
            this.ttpSports.SetToolTip(this.butExit, "Click to Exit");
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butCreateAcc
            // 
            this.butCreateAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCreateAcc.Location = new System.Drawing.Point(810, 494);
            this.butCreateAcc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.butCreateAcc.Name = "butCreateAcc";
            this.butCreateAcc.Size = new System.Drawing.Size(272, 67);
            this.butCreateAcc.TabIndex = 4;
            this.butCreateAcc.Text = "&Create Account";
            this.ttpSports.SetToolTip(this.butCreateAcc, "Click to Create Account");
            this.butCreateAcc.UseVisualStyleBackColor = true;
            this.butCreateAcc.Click += new System.EventHandler(this.butCreateAcc_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.Location = new System.Drawing.Point(140, 437);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(226, 51);
            this.lblFirstName.TabIndex = 15;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBoxFirstName.Location = new System.Drawing.Point(416, 441);
            this.txtBoxFirstName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(446, 42);
            this.txtBoxFirstName.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPass.Location = new System.Drawing.Point(140, 279);
            this.lblPass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(200, 51);
            this.lblPass.TabIndex = 13;
            this.lblPass.Text = "Password:";
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBoxPass.Location = new System.Drawing.Point(416, 288);
            this.txtBoxPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '*';
            this.txtBoxPass.Size = new System.Drawing.Size(446, 42);
            this.txtBoxPass.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(140, 181);
            this.lblUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(211, 51);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "Username:";
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUser.Location = new System.Drawing.Point(416, 190);
            this.txtBoxUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(446, 42);
            this.txtBoxUser.TabIndex = 0;
            // 
            // lbCreate
            // 
            this.lbCreate.AutoSize = true;
            this.lbCreate.BackColor = System.Drawing.Color.Transparent;
            this.lbCreate.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreate.Location = new System.Drawing.Point(316, 50);
            this.lbCreate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCreate.Name = "lbCreate";
            this.lbCreate.Size = new System.Drawing.Size(504, 77);
            this.lbCreate.TabIndex = 20;
            this.lbCreate.Text = "Account Creation";
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.Location = new System.Drawing.Point(1096, 0);
            this.lbExit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(53, 57);
            this.lbExit.TabIndex = 22;
            this.lbExit.Text = "X";
            this.ttpSports.SetToolTip(this.lbExit, "Click to Exit");
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(140, 365);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(129, 51);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(416, 369);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(446, 42);
            this.txtEmail.TabIndex = 24;
            // 
            // Account_Creation
            // 
            this.AcceptButton = this.butCreateAcc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sports_Project_1.Properties.Resources.login_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.butExit;
            this.ClientSize = new System.Drawing.Size(1150, 604);
            this.ControlBox = false;
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.lbCreate);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.cBoxSeePass);
            this.Controls.Add(this.butCreateAcc);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtBoxUser);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Account_Creation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cBoxSeePass;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butCreateAcc;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.Label lbCreate;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.ToolTip ttpSports;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
    }
}