
namespace IOT_Garage_Application
{
    partial class ProgramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramForm));
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.AdminButton = new System.Windows.Forms.Button();
            this.StaticsButton = new System.Windows.Forms.Button();
            this.GetCarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ChildFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ChildFormPanel.Controls.Add(this.AdminButton);
            this.ChildFormPanel.Controls.Add(this.StaticsButton);
            this.ChildFormPanel.Controls.Add(this.GetCarButton);
            this.ChildFormPanel.Location = new System.Drawing.Point(12, 12);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(851, 676);
            this.ChildFormPanel.TabIndex = 0;
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AdminButton.Location = new System.Drawing.Point(429, 222);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(419, 451);
            this.AdminButton.TabIndex = 4;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.Admin_Button);
            // 
            // StaticsButton
            // 
            this.StaticsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StaticsButton.Location = new System.Drawing.Point(4, 4);
            this.StaticsButton.Name = "StaticsButton";
            this.StaticsButton.Size = new System.Drawing.Size(844, 212);
            this.StaticsButton.TabIndex = 5;
            this.StaticsButton.Text = " Statistics";
            this.StaticsButton.UseVisualStyleBackColor = false;
            this.StaticsButton.Click += new System.EventHandler(this.Stats_button);
            // 
            // GetCarButton
            // 
            this.GetCarButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GetCarButton.Location = new System.Drawing.Point(4, 222);
            this.GetCarButton.Name = "GetCarButton";
            this.GetCarButton.Size = new System.Drawing.Size(419, 451);
            this.GetCarButton.TabIndex = 3;
            this.GetCarButton.Text = "Get Car";
            this.GetCarButton.UseVisualStyleBackColor = false;
            this.GetCarButton.Click += new System.EventHandler(this.GetCar_Button);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Car";
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(875, 700);
            this.Controls.Add(this.ChildFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProgramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarKeys";
            this.TopMost = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ChildFormPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button StaticsButton;
        private System.Windows.Forms.Button GetCarButton;
    }
}

