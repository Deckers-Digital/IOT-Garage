using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IOT_Garage_Application.Forms;

namespace IOT_Garage_Application.Forms
{
    public partial class AdminLoginForm : Form
    {

        ProgramForm programForm = new ProgramForm();

        string AdminUsername = "Admin";
        string AdminPass = "Admin";

        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void Back_Button(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Login_Button(object sender, EventArgs e)
        {
            if (AdminLoginPasswordsTextbox.Text == AdminPass && AdminLoginUsernameTextBox.Text == AdminUsername)
            {
                AdminLoginPasswordsTextbox.Clear();
                AdminLoginUsernameTextBox.Clear();
                WUOF.Visible = false;
                programForm.openChildForm(new AdminForm());

            }
            else
            {
                AdminLoginPasswordsTextbox.Clear();
                AdminLoginUsernameTextBox.Clear();
                WUOF.Visible = true;
            }
        }
    }
}
