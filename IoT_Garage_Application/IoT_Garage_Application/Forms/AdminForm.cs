using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySQL.Data;

namespace IOT_Garage_Application.Forms
{
    public partial class AdminForm : Form
    {

        ProgramForm programForm = new ProgramForm();
        StatsForm statsForm = new StatsForm();
        SettingsForm settingsForm = new SettingsForm();

        string NewestSerialRead;

        public AdminForm()
        {
            InitializeComponent();
            programForm.UpdateDatabase();
            InitialeCombobox();
            AdminMenuPanel.BringToFront();

            serialPort1.Open();
        }

        private void Back_Button(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCar_Button (object sender, EventArgs e)
        {
            AddCarSettingsPanel.BringToFront();
        }

        private void Menu_Button(object sender, EventArgs e)
        {
            AdminMenuPanel.BringToFront();
        }


        private void EditCar_Button(object sender, EventArgs e)
        {
            EditCarPanel.BringToFront();
            programForm.UpdateDatabase();
            InitialeCombobox();
        }

        private void ScanRFID_Button(object sender, EventArgs e)
        {
            ScanRFIDPanel.BringToFront();
        }


        private void AddCarToDB_Button (object sender, EventArgs e)
        {

            int CarID = programForm.dtCarStorage.Rows.Count + 1;
            string CarName = CarNameTextBox.Text;
            string CarLisencePlate = CarLicensePlateTextBox.Text;
            string CarRFID = CarRFIDTextBox.Text;

            programForm.DatabaseOpperation(string.Format("INSERT INTO CarStorage (CarNames,LicensePlate,RFID,Availble,CardID,BatteryProcentage) VALUES('{0}', '{1}', '{2}', true, NULL, NULL)", CarName,CarLisencePlate,CarRFID));

            CarRFID = null;
            CarName = null;
            CarLisencePlate = null;
            CarRFID = null;

            CarNameTextBox.Clear();
            CarRFIDTextBox.Clear();
            CarLicensePlateTextBox.Clear();

            programForm.UpdateDatabase();
            InitialeCombobox();

        }

        private void InitialeCombobox()
        {
            CarListDropdown.Items.Clear();

            if (programForm.dtCarStorage.Rows.Count == 0)
            {
                return;
            }else
            {
                foreach (DataRow row in programForm.dtCarStorage.Rows)
                {
                    string CarName = row["CarNames"].ToString();

                    CarListDropdown.Items.Add(CarName);
                }
            } 
        }


        public string CurrentSelected;
        public string CurrentCardID;
        public string CurrentAvailble;
        //public int CurrentBatteryProcentage;

        private void SelectCar(object sender, EventArgs e)
        {

            if (CarListDropdown.SelectedItem == null)
            {
                return;
            }else
            {
                CurrentSelected = CarListDropdown.SelectedItem.ToString();

                DataRow[] result = programForm.dtCarStorage.Select("CarNames='"+CurrentSelected+"'");

                string CurrentSelectedCarName = result[0]["CarNames"].ToString();
                string CurrentSelectedLicensePlate = result[0]["LicensePlate"].ToString();
                string CurrentSelectedRFID = result[0]["RFID"].ToString();
                CurrentCardID = result[0]["CardID"].ToString();
                CurrentAvailble = result[0]["Availble"].ToString();
                //CurrentBatteryProcentage = (int)result[0]["BatteryProcentage"];

                CurrentSelectedCarNameTextBox.Text = CurrentSelectedCarName;
                CurrentSelectedLicensePlateTextBox.Text = CurrentSelectedLicensePlate;
                CurrentSelectedRFIDTextBox.Text = CurrentSelectedRFID;

            }
        }

        private void ScanNewRFIDButton_Click(object sender, EventArgs e)
        {
            CurrentSelectedRFIDTextBox.Text = NewestSerialRead;
        }


        private void ConfirmChanges_Button (object sender, EventArgs e)
        {

            string CurrentSelectedCarName = CurrentSelectedCarNameTextBox.Text;
            string CurrentSelectedLicensePlate = CurrentSelectedLicensePlateTextBox.Text;
            string CurrentSelectedRFID = CurrentSelectedRFIDTextBox.Text;

            programForm.DatabaseOpperation(string.Format("DELETE FROM CarStorage WHERE CarNames='" + CurrentSelected + "'"));
            
            programForm.DatabaseOpperation(string.Format("INSERT INTO CarStorage (CarNames,LicensePlate,RFID,Availble,CardID,BatteryProcentage) VALUES('{0}', '{1}', '{2}', {3}, '{4}', NULL)", CurrentSelectedCarName, CurrentSelectedLicensePlate, CurrentSelectedRFID, CurrentAvailble, CurrentCardID));

            CurrentSelectedCarNameTextBox.Clear();
            CurrentSelectedLicensePlateTextBox.Clear();
            CurrentSelectedRFIDTextBox.Clear();

            programForm.UpdateDatabase();
            InitialeCombobox();
        }


        private void DeleteCar_Button (object sender, EventArgs e)
        {
            programForm.DatabaseOpperation(string.Format("DELETE FROM CarStorage WHERE CarNames='" + CurrentSelected + "'"));

            CurrentSelectedCarNameTextBox.Clear();
            CurrentSelectedLicensePlateTextBox.Clear();
            CurrentSelectedRFIDTextBox.Clear();

            programForm.UpdateDatabase();
            InitialeCombobox();
        }

        private void AddCarScanRFID_Button (object sender, EventArgs e)
        {
            CarRFIDTextBox.Text = NewestSerialRead;
            NewestSerialRead = null;
        }

        private void ScanCarRFID_Button(object sender, EventArgs e)
        {
            string CurrentRFID = NewestSerialRead;

            DataRow[] result = programForm.dtCarStorage.Select("RFID='"+ CurrentRFID+"'");

            if (result.Length == 0)
            {
                MessageBox.Show("unknown rfid tag");
            }else
            {
                string CurrentSelectedCarName = result[0]["CarNames"].ToString();
                string CurrentSelectedLicensePlate = result[0]["LicensePlate"].ToString();

                ScanRFIDTextBox.Text = CurrentRFID;
                ScanRFIDCarName.Text = CurrentSelectedCarName;
                ScanRFIDLicensePlate.Text = CurrentSelectedLicensePlate;

                CurrentRFID = "";
                CurrentSelectedCarName = "";
                CurrentSelectedLicensePlate = "";
            }
        }

        private void VersionLable_Click(object sender, EventArgs e)
        {
            int TriggerclickAmount = 10;
            int CurrentClickAmount = 0;

            if (CurrentClickAmount >= TriggerclickAmount)
            {
                settingsForm.Show();
                CurrentClickAmount = 0;
                MessageBox.Show("test");
            }
            else
            {
                CurrentClickAmount++;
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            NewestSerialRead = serialPort1.ReadLine();
        }
    }
}
