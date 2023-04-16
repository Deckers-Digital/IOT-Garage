namespace IOT_Garage_Application.Forms
{
    partial class StudentForm
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
            this.PassRnumberTextbox = new System.Windows.Forms.TextBox();
            this.PresentPassText = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.PPPOTS = new System.Windows.Forms.Label();
            this.PassContinueButton = new System.Windows.Forms.Button();
            this.CarRFIDTextbox = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.RFIDTagError = new System.Windows.Forms.Label();
            this.StudentMainPanel = new System.Windows.Forms.Panel();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.CloseRegisterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ConfirmRegistrationButton = new System.Windows.Forms.Button();
            this.RescanButton = new System.Windows.Forms.Button();
            this.RegisterCardIDTextbox = new System.Windows.Forms.TextBox();
            this.RegisterCardID = new System.Windows.Forms.Label();
            this.RegisterRNumberTextbox = new System.Windows.Forms.TextBox();
            this.RegisterRNumber = new System.Windows.Forms.Label();
            this.RegisterTopText = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.StudentMainPanel.SuspendLayout();
            this.RegisterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PassRnumberTextbox
            // 
            this.PassRnumberTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassRnumberTextbox.Location = new System.Drawing.Point(87, 251);
            this.PassRnumberTextbox.Name = "PassRnumberTextbox";
            this.PassRnumberTextbox.ReadOnly = true;
            this.PassRnumberTextbox.Size = new System.Drawing.Size(282, 38);
            this.PassRnumberTextbox.TabIndex = 28;
            // 
            // PresentPassText
            // 
            this.PresentPassText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentPassText.Location = new System.Drawing.Point(274, 160);
            this.PresentPassText.Name = "PresentPassText";
            this.PresentPassText.Size = new System.Drawing.Size(282, 37);
            this.PresentPassText.TabIndex = 27;
            this.PresentPassText.Text = "Present Pass";
            this.PresentPassText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(674, 589);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(165, 75);
            this.BackButton.TabIndex = 26;
            this.BackButton.Text = "Go Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.Back_Button);
            // 
            // PPPOTS
            // 
            this.PPPOTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPPOTS.Location = new System.Drawing.Point(83, 228);
            this.PPPOTS.Name = "PPPOTS";
            this.PPPOTS.Size = new System.Drawing.Size(282, 20);
            this.PPPOTS.TabIndex = 23;
            this.PPPOTS.Text = "Please Put your pass on the scanner";
            this.PPPOTS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PPPOTS.Visible = false;
            // 
            // PassContinueButton
            // 
            this.PassContinueButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PassContinueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassContinueButton.Location = new System.Drawing.Point(281, 321);
            this.PassContinueButton.Name = "PassContinueButton";
            this.PassContinueButton.Size = new System.Drawing.Size(282, 49);
            this.PassContinueButton.TabIndex = 22;
            this.PassContinueButton.Text = "Continue";
            this.PassContinueButton.UseVisualStyleBackColor = false;
            this.PassContinueButton.Click += new System.EventHandler(this.PassContinue_Button);
            // 
            // CarRFIDTextbox
            // 
            this.CarRFIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarRFIDTextbox.Location = new System.Drawing.Point(468, 251);
            this.CarRFIDTextbox.Name = "CarRFIDTextbox";
            this.CarRFIDTextbox.Size = new System.Drawing.Size(282, 38);
            this.CarRFIDTextbox.TabIndex = 31;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.ReadTimeout = 1;
            this.serialPort1.WriteTimeout = 1;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // RFIDTagError
            // 
            this.RFIDTagError.AutoSize = true;
            this.RFIDTagError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFIDTagError.Location = new System.Drawing.Point(464, 228);
            this.RFIDTagError.Name = "RFIDTagError";
            this.RFIDTagError.Size = new System.Drawing.Size(292, 20);
            this.RFIDTagError.TabIndex = 24;
            this.RFIDTagError.Text = "Please Put the RFID tag on the scanner";
            this.RFIDTagError.Visible = false;
            // 
            // StudentMainPanel
            // 
            this.StudentMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StudentMainPanel.Controls.Add(this.CarRFIDTextbox);
            this.StudentMainPanel.Controls.Add(this.BackButton);
            this.StudentMainPanel.Controls.Add(this.PassRnumberTextbox);
            this.StudentMainPanel.Controls.Add(this.PresentPassText);
            this.StudentMainPanel.Controls.Add(this.PassContinueButton);
            this.StudentMainPanel.Controls.Add(this.PPPOTS);
            this.StudentMainPanel.Controls.Add(this.RFIDTagError);
            this.StudentMainPanel.Location = new System.Drawing.Point(0, 0);
            this.StudentMainPanel.Name = "StudentMainPanel";
            this.StudentMainPanel.Size = new System.Drawing.Size(851, 676);
            this.StudentMainPanel.TabIndex = 32;
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RegisterPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RegisterPanel.Controls.Add(this.CloseRegisterButton);
            this.RegisterPanel.Controls.Add(this.label1);
            this.RegisterPanel.Controls.Add(this.linkLabel1);
            this.RegisterPanel.Controls.Add(this.ConfirmRegistrationButton);
            this.RegisterPanel.Controls.Add(this.RescanButton);
            this.RegisterPanel.Controls.Add(this.RegisterCardIDTextbox);
            this.RegisterPanel.Controls.Add(this.RegisterCardID);
            this.RegisterPanel.Controls.Add(this.RegisterRNumberTextbox);
            this.RegisterPanel.Controls.Add(this.RegisterRNumber);
            this.RegisterPanel.Controls.Add(this.RegisterTopText);
            this.RegisterPanel.Location = new System.Drawing.Point(221, 42);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(381, 505);
            this.RegisterPanel.TabIndex = 32;
            this.RegisterPanel.Visible = false;
            // 
            // CloseRegisterButton
            // 
            this.CloseRegisterButton.BackColor = System.Drawing.Color.Red;
            this.CloseRegisterButton.FlatAppearance.BorderSize = 0;
            this.CloseRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseRegisterButton.Location = new System.Drawing.Point(305, 465);
            this.CloseRegisterButton.Name = "CloseRegisterButton";
            this.CloseRegisterButton.Size = new System.Drawing.Size(75, 39);
            this.CloseRegisterButton.TabIndex = 9;
            this.CloseRegisterButton.Text = "Close";
            this.CloseRegisterButton.UseVisualStyleBackColor = false;
            this.CloseRegisterButton.Click += new System.EventHandler(this.CloseRegisterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "By Clicking continue i accept the";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(128, 382);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 18);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Privacy Agreement";
            // 
            // ConfirmRegistrationButton
            // 
            this.ConfirmRegistrationButton.Location = new System.Drawing.Point(83, 426);
            this.ConfirmRegistrationButton.Name = "ConfirmRegistrationButton";
            this.ConfirmRegistrationButton.Size = new System.Drawing.Size(203, 64);
            this.ConfirmRegistrationButton.TabIndex = 6;
            this.ConfirmRegistrationButton.Text = "Confirm";
            this.ConfirmRegistrationButton.UseVisualStyleBackColor = true;
            this.ConfirmRegistrationButton.Click += new System.EventHandler(this.ConfirmRegistrationButton_Click);
            // 
            // RescanButton
            // 
            this.RescanButton.Location = new System.Drawing.Point(85, 287);
            this.RescanButton.Name = "RescanButton";
            this.RescanButton.Size = new System.Drawing.Size(203, 56);
            this.RescanButton.TabIndex = 5;
            this.RescanButton.Text = "Rescan Card";
            this.RescanButton.UseVisualStyleBackColor = true;
            this.RescanButton.Click += new System.EventHandler(this.RescanButton_Click);
            // 
            // RegisterCardIDTextbox
            // 
            this.RegisterCardIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterCardIDTextbox.Location = new System.Drawing.Point(85, 238);
            this.RegisterCardIDTextbox.Name = "RegisterCardIDTextbox";
            this.RegisterCardIDTextbox.ReadOnly = true;
            this.RegisterCardIDTextbox.Size = new System.Drawing.Size(203, 35);
            this.RegisterCardIDTextbox.TabIndex = 4;
            // 
            // RegisterCardID
            // 
            this.RegisterCardID.AutoSize = true;
            this.RegisterCardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterCardID.Location = new System.Drawing.Point(137, 203);
            this.RegisterCardID.Name = "RegisterCardID";
            this.RegisterCardID.Size = new System.Drawing.Size(101, 30);
            this.RegisterCardID.TabIndex = 3;
            this.RegisterCardID.Text = "Card ID";
            this.RegisterCardID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegisterRNumberTextbox
            // 
            this.RegisterRNumberTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterRNumberTextbox.Location = new System.Drawing.Point(85, 141);
            this.RegisterRNumberTextbox.Name = "RegisterRNumberTextbox";
            this.RegisterRNumberTextbox.Size = new System.Drawing.Size(203, 35);
            this.RegisterRNumberTextbox.TabIndex = 2;
            // 
            // RegisterRNumber
            // 
            this.RegisterRNumber.AutoSize = true;
            this.RegisterRNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterRNumber.Location = new System.Drawing.Point(126, 109);
            this.RegisterRNumber.Name = "RegisterRNumber";
            this.RegisterRNumber.Size = new System.Drawing.Size(124, 30);
            this.RegisterRNumber.TabIndex = 1;
            this.RegisterRNumber.Text = "RNumber";
            this.RegisterRNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegisterTopText
            // 
            this.RegisterTopText.AutoSize = true;
            this.RegisterTopText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterTopText.Location = new System.Drawing.Point(6, 24);
            this.RegisterTopText.Name = "RegisterTopText";
            this.RegisterTopText.Size = new System.Drawing.Size(367, 60);
            this.RegisterTopText.TabIndex = 0;
            this.RegisterTopText.Text = "Hey! \r\nLooks like your card is not in the system yet. \r\nplease fill it in for us!" +
    "\r\n";
            this.RegisterTopText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(851, 676);
            this.Controls.Add(this.StudentMainPanel);
            this.Controls.Add(this.RegisterPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.StudentMainPanel.ResumeLayout(false);
            this.StudentMainPanel.PerformLayout();
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox PassRnumberTextbox;
        private System.Windows.Forms.Label PresentPassText;
        public System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label PPPOTS;
        private System.Windows.Forms.Button PassContinueButton;
        private System.Windows.Forms.TextBox CarRFIDTextbox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label RFIDTagError;
        private System.Windows.Forms.Panel StudentMainPanel;
        private System.Windows.Forms.Panel RegisterPanel;
        private System.Windows.Forms.Label RegisterTopText;
        private System.Windows.Forms.TextBox RegisterCardIDTextbox;
        private System.Windows.Forms.Label RegisterCardID;
        private System.Windows.Forms.TextBox RegisterRNumberTextbox;
        private System.Windows.Forms.Label RegisterRNumber;
        private System.Windows.Forms.Button ConfirmRegistrationButton;
        private System.Windows.Forms.Button RescanButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button CloseRegisterButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}