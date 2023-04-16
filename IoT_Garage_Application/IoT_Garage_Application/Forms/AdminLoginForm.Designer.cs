namespace IOT_Garage_Application.Forms
{
    partial class AdminLoginForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.WUOF = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.AdminLoginPasswordsTextbox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.AdminLoginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackButton.Location = new System.Drawing.Point(663, 420);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(141, 57);
            this.BackButton.TabIndex = 20;
            this.BackButton.Text = "Go Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.Back_Button);
            // 
            // WUOF
            // 
            this.WUOF.AutoSize = true;
            this.WUOF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WUOF.Location = new System.Drawing.Point(202, 85);
            this.WUOF.Name = "WUOF";
            this.WUOF.Size = new System.Drawing.Size(303, 26);
            this.WUOF.TabIndex = 19;
            this.WUOF.Text = "Wrong username or password";
            this.WUOF.Visible = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(241, 234);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(221, 43);
            this.LoginButton.TabIndex = 18;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.Login_Button);
            // 
            // AdminLoginPasswordsTextbox
            // 
            this.AdminLoginPasswordsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginPasswordsTextbox.Location = new System.Drawing.Point(241, 189);
            this.AdminLoginPasswordsTextbox.Name = "AdminLoginPasswordsTextbox";
            this.AdminLoginPasswordsTextbox.Size = new System.Drawing.Size(221, 38);
            this.AdminLoginPasswordsTextbox.TabIndex = 17;
            this.AdminLoginPasswordsTextbox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(58, 189);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(167, 37);
            this.PasswordLabel.TabIndex = 16;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(58, 114);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(173, 37);
            this.UsernameLabel.TabIndex = 15;
            this.UsernameLabel.Text = "Username:";
            // 
            // AdminLoginUsernameTextBox
            // 
            this.AdminLoginUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginUsernameTextBox.Location = new System.Drawing.Point(241, 114);
            this.AdminLoginUsernameTextBox.Name = "AdminLoginUsernameTextBox";
            this.AdminLoginUsernameTextBox.Size = new System.Drawing.Size(221, 38);
            this.AdminLoginUsernameTextBox.TabIndex = 14;
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.WUOF);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.AdminLoginPasswordsTextbox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.AdminLoginUsernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLoginForm";
            this.Text = "AdminLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label WUOF;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox AdminLoginPasswordsTextbox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox AdminLoginUsernameTextBox;
    }
}