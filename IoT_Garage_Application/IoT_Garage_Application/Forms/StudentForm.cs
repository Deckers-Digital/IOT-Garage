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
    public partial class StudentForm : Form
    {

        ProgramForm programForm;

        public StudentForm()
        {
            programForm = new ProgramForm();

            InitializeComponent();
            serialPort1.Open();

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            
        }

        public void Back_Button(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PassContinue_Button(object sender, EventArgs e)
        {

            if (PassRnumberTextbox.Text.Length == 0)
            {
                PPPOTS.Visible = true;
            }
            else if (CarRFIDTextbox.Text.Length == 0)
            {
                RFIDTagError.Visible = true;
            }
            else
            {
               
                PPPOTS.Visible = false;
                RFIDTagError.Visible = false;

                string CardID = PassRnumberTextbox.Text;
                string CarRFID = CarRFIDTextbox.Text;

                programForm.DatabaseOpperation(string.Format("UPDATE CarStorage SET CardID = '"+ CardID +"' WHERE RFID = '"+ CarRFID +"';"));
                programForm.DatabaseOpperation(string.Format("UPDATE CarStorage SET Availble = false WHERE RFID = '" + CarRFID + "';"));

                PassRnumberTextbox.Clear();
                CarRFIDTextbox.Clear();
                
            }
        }

        string CurrentRFID;

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            CurrentRFID = serialPort1.ReadLine();

            if (RegisterPanel.Visible == true)
            {
                return;
            }else
            {
                if (CurrentRFID.Length <= 9)
                {
                    DataRow[] result = programForm.dtCarStorage.Select("RFID='" + CurrentRFID + "'");

                    if (result.Length == 0)
                    {
                        CarRFIDTextbox.BeginInvoke(new Action(() => CarRFIDTextbox.Clear()));
                        MessageBox.Show("unknown rfid tag");
                    }
                    else
                    {
                        string CurrentSelectedCarName = result[0]["CarNames"].ToString();
                        CarRFIDTextbox.BeginInvoke(new Action(() => CarRFIDTextbox.Text = CurrentSelectedCarName));
                    }
                }
                else
                {
                    DataRow[] result = programForm.StudentTable.Select("RFID='" + CurrentRFID + "'");
                    if (result.Length == 0)
                    {
                        CarRFIDTextbox.BeginInvoke(new Action(() => CarRFIDTextbox.Clear()));
                        RegisterPanel.BeginInvoke(new Action(() => RegisterPanel.Visible = true));
                        RegisterPanel.BeginInvoke(new Action(() => RegisterPanel.BringToFront()));
                        CarRFIDTextbox.BeginInvoke(new Action(() => CarRFIDTextbox.Clear()));
                        PassRnumberTextbox.BeginInvoke(new Action(() => PassRnumberTextbox.Clear()));
                        RegisterCardIDTextbox.BeginInvoke(new Action(() => RegisterCardIDTextbox.Text = CurrentRFID));
                    }
                    else
                    {
                        string CurrentRNumber = result[0]["RNumber"].ToString();
                        PassRnumberTextbox.BeginInvoke(new Action(() => PassRnumberTextbox.Text = CurrentRNumber));
                    }
                }
            }
        }

        private void RescanButton_Click(object sender, EventArgs e)
        {
            RegisterCardIDTextbox.Text = CurrentRFID;
        }

        private void ConfirmRegistrationButton_Click(object sender, EventArgs e)
        {
            string RegisterConfirmCardID = RegisterCardIDTextbox.Text;
            string RegisterConfirmRNumber = RegisterRNumberTextbox.Text;

            programForm.DatabaseOpperation(string.Format("INSERT INTO StudentTable (RFID, RNumber) VALUES('{0}', '{1}')", RegisterConfirmCardID, RegisterConfirmRNumber));

            RegisterRNumberTextbox.Clear();
            RegisterCardIDTextbox.Clear();
            RegisterConfirmCardID = null;
            RegisterConfirmRNumber = null;

            RegisterPanel.SendToBack();
            RegisterPanel.Visible = false;
        }

        private void CloseRegisterButton_Click(object sender, EventArgs e)
        {
            RegisterPanel.SendToBack();
            RegisterPanel.Visible = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string TestRFID = serialPort1.ReadLine();
            PassRnumberTextbox.BeginInvoke(new Action(() => PassRnumberTextbox.Text = TestRFID));
        }
    }
}
