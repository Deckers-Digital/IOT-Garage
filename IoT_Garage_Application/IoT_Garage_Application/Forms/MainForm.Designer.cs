namespace IOT_Garage_Application.Forms
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
            this.AdminButton = new System.Windows.Forms.Button();
            this.StaticsButton = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.GetCarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminButton
            // 
            this.AdminButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AdminButton.Location = new System.Drawing.Point(509, 150);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(515, 450);
            this.AdminButton.TabIndex = 2;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.Admin_Button);
            // 
            // StaticsButton
            // 
            this.StaticsButton.BackColor = System.Drawing.Color.Transparent;
            this.StaticsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StaticsButton.Location = new System.Drawing.Point(0, 0);
            this.StaticsButton.Name = "StaticsButton";
            this.StaticsButton.Size = new System.Drawing.Size(1024, 150);
            this.StaticsButton.TabIndex = 0;
            this.StaticsButton.Text = "Statics";
            this.StaticsButton.UseVisualStyleBackColor = true;
            this.StaticsButton.Click += new System.EventHandler(this.Stats_Button);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // GetCarButton
            // 
            this.GetCarButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.GetCarButton.Location = new System.Drawing.Point(0, 150);
            this.GetCarButton.Name = "GetCarButton";
            this.GetCarButton.Size = new System.Drawing.Size(503, 450);
            this.GetCarButton.TabIndex = 3;
            this.GetCarButton.Text = "Get Car";
            this.GetCarButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.GetCarButton);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.StaticsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button StaticsButton;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button GetCarButton;
    }
}