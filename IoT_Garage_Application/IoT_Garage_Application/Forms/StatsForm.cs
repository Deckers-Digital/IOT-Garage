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
    public partial class StatsForm : Form
    {
        ProgramForm programForm;
        

        public StatsForm()
        {
            programForm = new ProgramForm();

            InitializeComponent();
            InitializeCarTreeView();
        }

        private void Back_Button(object sender, EventArgs e)
        {
            this.Close();
        }


        public void InitializeCarTreeView()
        {

            if (programForm.dtCarStorage.Rows.Count == 0)
            {
                return;
            }else
            {
                CarListSetup.BeginUpdate();

                foreach(DataRow row in programForm.dtCarStorage.Rows)
                {
                    string CarName = row["CarNames"].ToString();
                    string LicensePlate = row["LicensePlate"].ToString();
                    string RFID = row["RFID"].ToString();
                    string Availble = row["Availble"].ToString();

                    TreeNode a1 = new TreeNode(CarName);
                    //TreeNode a2 = new TreeNode("LicensePlate: " + LicensePlate);
                    //TreeNode a3 = new TreeNode("RFID: " + RFID);
                    //TreeNode a4 = new TreeNode("Availble: " + Availble);
                    CarListSetup.Nodes.Add(a1);
                    //a1.Nodes.Add(a2);
                    //a1.Nodes.Add(a3);
                    //a1.Nodes.Add(a4);
                }

                CarListSetup.EndUpdate();
            }  
        }

        private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            string CurrentSelected = e.Node.Text;

            DataRow[] result = programForm.dtCarStorage.Select("CarNames='" + CurrentSelected + "'");

            string CurrentSelectedCarName = result[0]["CarNames"].ToString();
            string CurrentSelectedLicensePlate = result[0]["LicensePlate"].ToString();
            string CurrentSelectedRFID = result[0]["RFID"].ToString();
            string CurrentCardID = result[0]["CardID"].ToString();
            string CurrentAvailble = result[0]["Availble"].ToString();
            //string CurrentBatteryProcentage = result[0]["BatteryProcentage"].ToString();

            StatsCarName.Text = "Car Name: " + CurrentSelectedCarName;
            StatsLicenseplate.Text = "Licenseplate: " + CurrentSelectedLicensePlate;
            StatsRFID.Text = "RFID: " + CurrentSelectedRFID;

            if (CurrentAvailble == "false")
            {
                StatsAvailble.Text = "Not Availble";

            }else
            {
                StatsAvailble.Text = "Availble";
            }
        }
    }
}
