using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOT_Garage_Application.Forms
{
    public partial class MainForm : Form
    {


        ProgramForm programForm;

        AdminForm adminForm;


        public MainForm()
        {
            programForm = new ProgramForm();
            adminForm = new AdminForm();

            InitializeComponent();
        }


        private void Admin_Button (object sender, EventArgs e)
        {
            programForm.openChildForm(new AdminLoginForm());
        }

        private void Stats_Button(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
