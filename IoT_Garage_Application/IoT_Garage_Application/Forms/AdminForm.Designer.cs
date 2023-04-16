namespace IOT_Garage_Application.Forms
{
    partial class AdminForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.AdminMenuButton = new System.Windows.Forms.Button();
            this.ScanRFID = new System.Windows.Forms.Button();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.EditCar = new System.Windows.Forms.Button();
            this.AddCarSettingsPanel = new System.Windows.Forms.Panel();
            this.AddCarScanRFID = new System.Windows.Forms.Button();
            this.RFIDTagLable = new System.Windows.Forms.Label();
            this.LicensePlateLable = new System.Windows.Forms.Label();
            this.CarNameLabel = new System.Windows.Forms.Label();
            this.CarRFIDTextBox = new System.Windows.Forms.TextBox();
            this.CarLicensePlateTextBox = new System.Windows.Forms.TextBox();
            this.CarNameTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmAddCar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ScanRFIDPanel = new System.Windows.Forms.Panel();
            this.ScanRFIDButton = new System.Windows.Forms.Button();
            this.ScanRFIDLicencePlateLabel = new System.Windows.Forms.Label();
            this.ScanRFIDCarNameLabel = new System.Windows.Forms.Label();
            this.ScanRFIDLabel = new System.Windows.Forms.Label();
            this.ScanRFIDLicensePlate = new System.Windows.Forms.TextBox();
            this.ScanRFIDCarName = new System.Windows.Forms.TextBox();
            this.ScanRFIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EditCarPanel = new System.Windows.Forms.Panel();
            this.ScanNewRFIDButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteCarButton = new System.Windows.Forms.Button();
            this.ConfirmChangesButton = new System.Windows.Forms.Button();
            this.CurrentSelectedRFIDTextBox = new System.Windows.Forms.TextBox();
            this.CurrentSelectedLicensePlateTextBox = new System.Windows.Forms.TextBox();
            this.CurrentSelectedCarNameTextBox = new System.Windows.Forms.TextBox();
            this.CarListDropdown = new System.Windows.Forms.ComboBox();
            this.EditCarLabel = new System.Windows.Forms.Label();
            this.AdminMenuPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.VersionLable = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.AddCarSettingsPanel.SuspendLayout();
            this.ScanRFIDPanel.SuspendLayout();
            this.EditCarPanel.SuspendLayout();
            this.AdminMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(674, 589);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(165, 75);
            this.BackButton.TabIndex = 20;
            this.BackButton.Text = "Go Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.Back_Button);
            // 
            // AdminMenuButton
            // 
            this.AdminMenuButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AdminMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminMenuButton.Location = new System.Drawing.Point(12, 12);
            this.AdminMenuButton.Name = "AdminMenuButton";
            this.AdminMenuButton.Size = new System.Drawing.Size(247, 100);
            this.AdminMenuButton.TabIndex = 16;
            this.AdminMenuButton.Text = "Menu";
            this.AdminMenuButton.UseVisualStyleBackColor = false;
            this.AdminMenuButton.Click += new System.EventHandler(this.Menu_Button);
            // 
            // ScanRFID
            // 
            this.ScanRFID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ScanRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanRFID.Location = new System.Drawing.Point(12, 330);
            this.ScanRFID.Name = "ScanRFID";
            this.ScanRFID.Size = new System.Drawing.Size(247, 100);
            this.ScanRFID.TabIndex = 17;
            this.ScanRFID.Text = "Scan RDIF";
            this.ScanRFID.UseVisualStyleBackColor = false;
            this.ScanRFID.Click += new System.EventHandler(this.ScanRFID_Button);
            // 
            // AddCarButton
            // 
            this.AddCarButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarButton.Location = new System.Drawing.Point(12, 118);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(247, 100);
            this.AddCarButton.TabIndex = 18;
            this.AddCarButton.Text = "Add Car";
            this.AddCarButton.UseVisualStyleBackColor = false;
            this.AddCarButton.Click += new System.EventHandler(this.AddCar_Button);
            // 
            // EditCar
            // 
            this.EditCar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCar.Location = new System.Drawing.Point(12, 224);
            this.EditCar.Name = "EditCar";
            this.EditCar.Size = new System.Drawing.Size(247, 100);
            this.EditCar.TabIndex = 19;
            this.EditCar.Text = "Edit Car";
            this.EditCar.UseVisualStyleBackColor = false;
            this.EditCar.Click += new System.EventHandler(this.EditCar_Button);
            // 
            // AddCarSettingsPanel
            // 
            this.AddCarSettingsPanel.Controls.Add(this.AddCarScanRFID);
            this.AddCarSettingsPanel.Controls.Add(this.RFIDTagLable);
            this.AddCarSettingsPanel.Controls.Add(this.LicensePlateLable);
            this.AddCarSettingsPanel.Controls.Add(this.CarNameLabel);
            this.AddCarSettingsPanel.Controls.Add(this.CarRFIDTextBox);
            this.AddCarSettingsPanel.Controls.Add(this.CarLicensePlateTextBox);
            this.AddCarSettingsPanel.Controls.Add(this.CarNameTextBox);
            this.AddCarSettingsPanel.Controls.Add(this.ConfirmAddCar);
            this.AddCarSettingsPanel.Controls.Add(this.label7);
            this.AddCarSettingsPanel.Location = new System.Drawing.Point(270, 12);
            this.AddCarSettingsPanel.Name = "AddCarSettingsPanel";
            this.AddCarSettingsPanel.Size = new System.Drawing.Size(569, 571);
            this.AddCarSettingsPanel.TabIndex = 24;
            // 
            // AddCarScanRFID
            // 
            this.AddCarScanRFID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddCarScanRFID.Location = new System.Drawing.Point(207, 252);
            this.AddCarScanRFID.Name = "AddCarScanRFID";
            this.AddCarScanRFID.Size = new System.Drawing.Size(104, 26);
            this.AddCarScanRFID.TabIndex = 9;
            this.AddCarScanRFID.Text = "Scan RFID";
            this.AddCarScanRFID.UseVisualStyleBackColor = false;
            this.AddCarScanRFID.Click += new System.EventHandler(this.AddCarScanRFID_Button);
            // 
            // RFIDTagLable
            // 
            this.RFIDTagLable.AutoSize = true;
            this.RFIDTagLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFIDTagLable.Location = new System.Drawing.Point(47, 218);
            this.RFIDTagLable.Name = "RFIDTagLable";
            this.RFIDTagLable.Size = new System.Drawing.Size(105, 26);
            this.RFIDTagLable.TabIndex = 8;
            this.RFIDTagLable.Text = "RFID Tag";
            // 
            // LicensePlateLable
            // 
            this.LicensePlateLable.AutoSize = true;
            this.LicensePlateLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicensePlateLable.Location = new System.Drawing.Point(42, 136);
            this.LicensePlateLable.Name = "LicensePlateLable";
            this.LicensePlateLable.Size = new System.Drawing.Size(143, 26);
            this.LicensePlateLable.TabIndex = 6;
            this.LicensePlateLable.Text = "Licence Plate";
            // 
            // CarNameLabel
            // 
            this.CarNameLabel.AutoSize = true;
            this.CarNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarNameLabel.Location = new System.Drawing.Point(47, 65);
            this.CarNameLabel.Name = "CarNameLabel";
            this.CarNameLabel.Size = new System.Drawing.Size(112, 26);
            this.CarNameLabel.TabIndex = 5;
            this.CarNameLabel.Text = "Car Name";
            // 
            // CarRFIDTextBox
            // 
            this.CarRFIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarRFIDTextBox.Location = new System.Drawing.Point(45, 252);
            this.CarRFIDTextBox.Name = "CarRFIDTextBox";
            this.CarRFIDTextBox.Size = new System.Drawing.Size(157, 26);
            this.CarRFIDTextBox.TabIndex = 3;
            // 
            // CarLicensePlateTextBox
            // 
            this.CarLicensePlateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarLicensePlateTextBox.Location = new System.Drawing.Point(44, 171);
            this.CarLicensePlateTextBox.Name = "CarLicensePlateTextBox";
            this.CarLicensePlateTextBox.Size = new System.Drawing.Size(157, 26);
            this.CarLicensePlateTextBox.TabIndex = 3;
            // 
            // CarNameTextBox
            // 
            this.CarNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarNameTextBox.Location = new System.Drawing.Point(44, 94);
            this.CarNameTextBox.Name = "CarNameTextBox";
            this.CarNameTextBox.Size = new System.Drawing.Size(157, 26);
            this.CarNameTextBox.TabIndex = 3;
            // 
            // ConfirmAddCar
            // 
            this.ConfirmAddCar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfirmAddCar.Location = new System.Drawing.Point(342, 291);
            this.ConfirmAddCar.Name = "ConfirmAddCar";
            this.ConfirmAddCar.Size = new System.Drawing.Size(159, 58);
            this.ConfirmAddCar.TabIndex = 2;
            this.ConfirmAddCar.Text = "Add Car";
            this.ConfirmAddCar.UseVisualStyleBackColor = false;
            this.ConfirmAddCar.Click += new System.EventHandler(this.AddCarToDB_Button);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Add Car";
            // 
            // ScanRFIDPanel
            // 
            this.ScanRFIDPanel.Controls.Add(this.ScanRFIDButton);
            this.ScanRFIDPanel.Controls.Add(this.ScanRFIDLicencePlateLabel);
            this.ScanRFIDPanel.Controls.Add(this.ScanRFIDCarNameLabel);
            this.ScanRFIDPanel.Controls.Add(this.ScanRFIDLabel);
            this.ScanRFIDPanel.Controls.Add(this.ScanRFIDLicensePlate);
            this.ScanRFIDPanel.Controls.Add(this.ScanRFIDCarName);
            this.ScanRFIDPanel.Controls.Add(this.ScanRFIDTextBox);
            this.ScanRFIDPanel.Controls.Add(this.label4);
            this.ScanRFIDPanel.Location = new System.Drawing.Point(270, 12);
            this.ScanRFIDPanel.Name = "ScanRFIDPanel";
            this.ScanRFIDPanel.Size = new System.Drawing.Size(569, 571);
            this.ScanRFIDPanel.TabIndex = 21;
            // 
            // ScanRFIDButton
            // 
            this.ScanRFIDButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ScanRFIDButton.Location = new System.Drawing.Point(317, 277);
            this.ScanRFIDButton.Name = "ScanRFIDButton";
            this.ScanRFIDButton.Size = new System.Drawing.Size(159, 59);
            this.ScanRFIDButton.TabIndex = 5;
            this.ScanRFIDButton.Text = "Scan RFID";
            this.ScanRFIDButton.UseVisualStyleBackColor = false;
            this.ScanRFIDButton.Click += new System.EventHandler(this.ScanCarRFID_Button);
            // 
            // ScanRFIDLicencePlateLabel
            // 
            this.ScanRFIDLicencePlateLabel.AutoSize = true;
            this.ScanRFIDLicencePlateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanRFIDLicencePlateLabel.Location = new System.Drawing.Point(13, 234);
            this.ScanRFIDLicencePlateLabel.Name = "ScanRFIDLicencePlateLabel";
            this.ScanRFIDLicencePlateLabel.Size = new System.Drawing.Size(158, 29);
            this.ScanRFIDLicencePlateLabel.TabIndex = 4;
            this.ScanRFIDLicencePlateLabel.Text = "License Plate";
            // 
            // ScanRFIDCarNameLabel
            // 
            this.ScanRFIDCarNameLabel.AutoSize = true;
            this.ScanRFIDCarNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanRFIDCarNameLabel.Location = new System.Drawing.Point(13, 153);
            this.ScanRFIDCarNameLabel.Name = "ScanRFIDCarNameLabel";
            this.ScanRFIDCarNameLabel.Size = new System.Drawing.Size(51, 29);
            this.ScanRFIDCarNameLabel.TabIndex = 3;
            this.ScanRFIDCarNameLabel.Text = "Car";
            // 
            // ScanRFIDLabel
            // 
            this.ScanRFIDLabel.AutoSize = true;
            this.ScanRFIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanRFIDLabel.Location = new System.Drawing.Point(13, 75);
            this.ScanRFIDLabel.Name = "ScanRFIDLabel";
            this.ScanRFIDLabel.Size = new System.Drawing.Size(68, 29);
            this.ScanRFIDLabel.TabIndex = 2;
            this.ScanRFIDLabel.Text = "RFID";
            // 
            // ScanRFIDLicensePlate
            // 
            this.ScanRFIDLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanRFIDLicensePlate.Location = new System.Drawing.Point(13, 266);
            this.ScanRFIDLicensePlate.Name = "ScanRFIDLicensePlate";
            this.ScanRFIDLicensePlate.ReadOnly = true;
            this.ScanRFIDLicensePlate.Size = new System.Drawing.Size(164, 32);
            this.ScanRFIDLicensePlate.TabIndex = 1;
            // 
            // ScanRFIDCarName
            // 
            this.ScanRFIDCarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanRFIDCarName.Location = new System.Drawing.Point(18, 185);
            this.ScanRFIDCarName.Name = "ScanRFIDCarName";
            this.ScanRFIDCarName.ReadOnly = true;
            this.ScanRFIDCarName.Size = new System.Drawing.Size(164, 32);
            this.ScanRFIDCarName.TabIndex = 1;
            // 
            // ScanRFIDTextBox
            // 
            this.ScanRFIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanRFIDTextBox.Location = new System.Drawing.Point(18, 108);
            this.ScanRFIDTextBox.Name = "ScanRFIDTextBox";
            this.ScanRFIDTextBox.ReadOnly = true;
            this.ScanRFIDTextBox.Size = new System.Drawing.Size(164, 32);
            this.ScanRFIDTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Scan RFID";
            // 
            // EditCarPanel
            // 
            this.EditCarPanel.Controls.Add(this.ScanNewRFIDButton);
            this.EditCarPanel.Controls.Add(this.label2);
            this.EditCarPanel.Controls.Add(this.label3);
            this.EditCarPanel.Controls.Add(this.label5);
            this.EditCarPanel.Controls.Add(this.DeleteCarButton);
            this.EditCarPanel.Controls.Add(this.ConfirmChangesButton);
            this.EditCarPanel.Controls.Add(this.CurrentSelectedRFIDTextBox);
            this.EditCarPanel.Controls.Add(this.CurrentSelectedLicensePlateTextBox);
            this.EditCarPanel.Controls.Add(this.CurrentSelectedCarNameTextBox);
            this.EditCarPanel.Controls.Add(this.CarListDropdown);
            this.EditCarPanel.Controls.Add(this.EditCarLabel);
            this.EditCarPanel.Location = new System.Drawing.Point(270, 12);
            this.EditCarPanel.Name = "EditCarPanel";
            this.EditCarPanel.Size = new System.Drawing.Size(569, 571);
            this.EditCarPanel.TabIndex = 22;
            // 
            // ScanNewRFIDButton
            // 
            this.ScanNewRFIDButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ScanNewRFIDButton.Location = new System.Drawing.Point(292, 188);
            this.ScanNewRFIDButton.Name = "ScanNewRFIDButton";
            this.ScanNewRFIDButton.Size = new System.Drawing.Size(184, 60);
            this.ScanNewRFIDButton.TabIndex = 20;
            this.ScanNewRFIDButton.Text = "Scan new RFID";
            this.ScanNewRFIDButton.UseVisualStyleBackColor = false;
            this.ScanNewRFIDButton.Click += new System.EventHandler(this.ScanNewRFIDButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "RFID Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Licence Plate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Car Name";
            // 
            // DeleteCarButton
            // 
            this.DeleteCarButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteCarButton.Location = new System.Drawing.Point(292, 277);
            this.DeleteCarButton.Name = "DeleteCarButton";
            this.DeleteCarButton.Size = new System.Drawing.Size(184, 57);
            this.DeleteCarButton.TabIndex = 16;
            this.DeleteCarButton.Text = "Delete car";
            this.DeleteCarButton.UseVisualStyleBackColor = false;
            this.DeleteCarButton.Click += new System.EventHandler(this.DeleteCar_Button);
            // 
            // ConfirmChangesButton
            // 
            this.ConfirmChangesButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfirmChangesButton.Location = new System.Drawing.Point(18, 277);
            this.ConfirmChangesButton.Name = "ConfirmChangesButton";
            this.ConfirmChangesButton.Size = new System.Drawing.Size(184, 57);
            this.ConfirmChangesButton.TabIndex = 15;
            this.ConfirmChangesButton.Text = "Confirm Changes";
            this.ConfirmChangesButton.UseVisualStyleBackColor = false;
            this.ConfirmChangesButton.Click += new System.EventHandler(this.ConfirmChanges_Button);
            // 
            // CurrentSelectedRFIDTextBox
            // 
            this.CurrentSelectedRFIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentSelectedRFIDTextBox.Location = new System.Drawing.Point(18, 218);
            this.CurrentSelectedRFIDTextBox.Name = "CurrentSelectedRFIDTextBox";
            this.CurrentSelectedRFIDTextBox.ReadOnly = true;
            this.CurrentSelectedRFIDTextBox.Size = new System.Drawing.Size(184, 30);
            this.CurrentSelectedRFIDTextBox.TabIndex = 4;
            // 
            // CurrentSelectedLicensePlateTextBox
            // 
            this.CurrentSelectedLicensePlateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentSelectedLicensePlateTextBox.Location = new System.Drawing.Point(292, 142);
            this.CurrentSelectedLicensePlateTextBox.Name = "CurrentSelectedLicensePlateTextBox";
            this.CurrentSelectedLicensePlateTextBox.Size = new System.Drawing.Size(184, 30);
            this.CurrentSelectedLicensePlateTextBox.TabIndex = 3;
            // 
            // CurrentSelectedCarNameTextBox
            // 
            this.CurrentSelectedCarNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentSelectedCarNameTextBox.Location = new System.Drawing.Point(18, 142);
            this.CurrentSelectedCarNameTextBox.Name = "CurrentSelectedCarNameTextBox";
            this.CurrentSelectedCarNameTextBox.Size = new System.Drawing.Size(184, 30);
            this.CurrentSelectedCarNameTextBox.TabIndex = 2;
            // 
            // CarListDropdown
            // 
            this.CarListDropdown.FormattingEnabled = true;
            this.CarListDropdown.Location = new System.Drawing.Point(18, 65);
            this.CarListDropdown.Name = "CarListDropdown";
            this.CarListDropdown.Size = new System.Drawing.Size(183, 21);
            this.CarListDropdown.TabIndex = 1;
            this.CarListDropdown.SelectedIndexChanged += new System.EventHandler(this.SelectCar);
            // 
            // EditCarLabel
            // 
            this.EditCarLabel.AutoSize = true;
            this.EditCarLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.EditCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCarLabel.Location = new System.Drawing.Point(11, 15);
            this.EditCarLabel.Name = "EditCarLabel";
            this.EditCarLabel.Size = new System.Drawing.Size(133, 37);
            this.EditCarLabel.TabIndex = 0;
            this.EditCarLabel.Text = "Edit Car";
            // 
            // AdminMenuPanel
            // 
            this.AdminMenuPanel.Controls.Add(this.label6);
            this.AdminMenuPanel.Location = new System.Drawing.Point(270, 12);
            this.AdminMenuPanel.Name = "AdminMenuPanel";
            this.AdminMenuPanel.Size = new System.Drawing.Size(569, 571);
            this.AdminMenuPanel.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Menu";
            // 
            // VersionLable
            // 
            this.VersionLable.AutoSize = true;
            this.VersionLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLable.Location = new System.Drawing.Point(8, 647);
            this.VersionLable.Name = "VersionLable";
            this.VersionLable.Size = new System.Drawing.Size(93, 20);
            this.VersionLable.TabIndex = 25;
            this.VersionLable.Text = "Version: 1.0";
            this.VersionLable.Click += new System.EventHandler(this.VersionLable_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.ReadTimeout = 1;
            this.serialPort1.WriteTimeout = 1;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(851, 676);
            this.Controls.Add(this.VersionLable);
            this.Controls.Add(this.AddCarButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AdminMenuButton);
            this.Controls.Add(this.ScanRFID);
            this.Controls.Add(this.EditCar);
            this.Controls.Add(this.AdminMenuPanel);
            this.Controls.Add(this.AddCarSettingsPanel);
            this.Controls.Add(this.ScanRFIDPanel);
            this.Controls.Add(this.EditCarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.AddCarSettingsPanel.ResumeLayout(false);
            this.AddCarSettingsPanel.PerformLayout();
            this.ScanRFIDPanel.ResumeLayout(false);
            this.ScanRFIDPanel.PerformLayout();
            this.EditCarPanel.ResumeLayout(false);
            this.EditCarPanel.PerformLayout();
            this.AdminMenuPanel.ResumeLayout(false);
            this.AdminMenuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AdminMenuButton;
        private System.Windows.Forms.Button ScanRFID;
        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.Button EditCar;
        private System.Windows.Forms.Panel AddCarSettingsPanel;
        private System.Windows.Forms.Button AddCarScanRFID;
        private System.Windows.Forms.Label RFIDTagLable;
        private System.Windows.Forms.Label LicensePlateLable;
        private System.Windows.Forms.Label CarNameLabel;
        private System.Windows.Forms.TextBox CarRFIDTextBox;
        private System.Windows.Forms.TextBox CarLicensePlateTextBox;
        private System.Windows.Forms.TextBox CarNameTextBox;
        private System.Windows.Forms.Button ConfirmAddCar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel ScanRFIDPanel;
        private System.Windows.Forms.Button ScanRFIDButton;
        private System.Windows.Forms.Label ScanRFIDLicencePlateLabel;
        private System.Windows.Forms.Label ScanRFIDCarNameLabel;
        private System.Windows.Forms.Label ScanRFIDLabel;
        private System.Windows.Forms.TextBox ScanRFIDLicensePlate;
        private System.Windows.Forms.TextBox ScanRFIDCarName;
        private System.Windows.Forms.TextBox ScanRFIDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel EditCarPanel;
        public System.Windows.Forms.Button ScanNewRFIDButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button DeleteCarButton;
        public System.Windows.Forms.Button ConfirmChangesButton;
        private System.Windows.Forms.TextBox CurrentSelectedRFIDTextBox;
        private System.Windows.Forms.TextBox CurrentSelectedLicensePlateTextBox;
        private System.Windows.Forms.TextBox CurrentSelectedCarNameTextBox;
        private System.Windows.Forms.ComboBox CarListDropdown;
        private System.Windows.Forms.Label EditCarLabel;
        private System.Windows.Forms.Panel AdminMenuPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label VersionLable;
        private System.IO.Ports.SerialPort serialPort1;
    }
}