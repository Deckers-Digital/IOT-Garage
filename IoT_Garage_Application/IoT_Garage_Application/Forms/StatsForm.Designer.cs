namespace IOT_Garage_Application.Forms
{
    partial class StatsForm
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
            this.CarListSetup = new System.Windows.Forms.TreeView();
            this.BackButton = new System.Windows.Forms.Button();
            this.KeysAvailblePannel = new System.Windows.Forms.Panel();
            this.StatsAvailble = new System.Windows.Forms.Label();
            this.StatsRFID = new System.Windows.Forms.Label();
            this.StatsLicenseplate = new System.Windows.Forms.Label();
            this.StatsCarName = new System.Windows.Forms.Label();
            this.KeysAvailblePannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarListSetup
            // 
            this.CarListSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CarListSetup.Dock = System.Windows.Forms.DockStyle.Left;
            this.CarListSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarListSetup.Location = new System.Drawing.Point(0, 0);
            this.CarListSetup.Name = "CarListSetup";
            this.CarListSetup.Size = new System.Drawing.Size(288, 676);
            this.CarListSetup.TabIndex = 17;
            this.CarListSetup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(674, 589);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(165, 75);
            this.BackButton.TabIndex = 18;
            this.BackButton.Text = "Go Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.Back_Button);
            // 
            // KeysAvailblePannel
            // 
            this.KeysAvailblePannel.AutoScroll = true;
            this.KeysAvailblePannel.BackColor = System.Drawing.Color.Transparent;
            this.KeysAvailblePannel.Controls.Add(this.StatsAvailble);
            this.KeysAvailblePannel.Controls.Add(this.StatsRFID);
            this.KeysAvailblePannel.Controls.Add(this.StatsLicenseplate);
            this.KeysAvailblePannel.Controls.Add(this.StatsCarName);
            this.KeysAvailblePannel.Location = new System.Drawing.Point(294, 12);
            this.KeysAvailblePannel.Name = "KeysAvailblePannel";
            this.KeysAvailblePannel.Size = new System.Drawing.Size(545, 527);
            this.KeysAvailblePannel.TabIndex = 19;
            // 
            // StatsAvailble
            // 
            this.StatsAvailble.AutoSize = true;
            this.StatsAvailble.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsAvailble.Location = new System.Drawing.Point(3, 211);
            this.StatsAvailble.Name = "StatsAvailble";
            this.StatsAvailble.Size = new System.Drawing.Size(138, 39);
            this.StatsAvailble.TabIndex = 3;
            this.StatsAvailble.Text = "Availble";
            // 
            // StatsRFID
            // 
            this.StatsRFID.AutoSize = true;
            this.StatsRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsRFID.Location = new System.Drawing.Point(3, 146);
            this.StatsRFID.Name = "StatsRFID";
            this.StatsRFID.Size = new System.Drawing.Size(107, 39);
            this.StatsRFID.TabIndex = 2;
            this.StatsRFID.Text = "RFID:";
            // 
            // StatsLicenseplate
            // 
            this.StatsLicenseplate.AutoSize = true;
            this.StatsLicenseplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsLicenseplate.Location = new System.Drawing.Point(3, 75);
            this.StatsLicenseplate.Name = "StatsLicenseplate";
            this.StatsLicenseplate.Size = new System.Drawing.Size(218, 39);
            this.StatsLicenseplate.TabIndex = 1;
            this.StatsLicenseplate.Text = "Licenseplate:";
            // 
            // StatsCarName
            // 
            this.StatsCarName.AutoSize = true;
            this.StatsCarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsCarName.Location = new System.Drawing.Point(3, 10);
            this.StatsCarName.Name = "StatsCarName";
            this.StatsCarName.Size = new System.Drawing.Size(181, 39);
            this.StatsCarName.TabIndex = 0;
            this.StatsCarName.Text = "Car Name:";
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(851, 676);
            this.Controls.Add(this.CarListSetup);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.KeysAvailblePannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.KeysAvailblePannel.ResumeLayout(false);
            this.KeysAvailblePannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView CarListSetup;
        public System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel KeysAvailblePannel;
        private System.Windows.Forms.Label StatsRFID;
        private System.Windows.Forms.Label StatsLicenseplate;
        private System.Windows.Forms.Label StatsCarName;
        private System.Windows.Forms.Label StatsAvailble;
    }
}