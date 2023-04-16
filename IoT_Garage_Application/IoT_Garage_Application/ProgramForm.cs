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
using IOT_Garage_Application.Forms;

namespace IOT_Garage_Application
{
    public partial class ProgramForm : Form
    {

        //AdminLoginForm adminLoginForm = new AdminLoginForm();

        public ProgramForm()
        {
            InitializeComponent();
            InitializeDataBase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /*
        public MySqlConnection dbConn;
        private const String SERVER = "localhost";                             // Server IP
        private const String DATABASE = "ThomasMore_CarStorage_Database";           // Date base name
        private const String TABLE = "CarStorage";                                  // Table name
        private const String UID = "TM_PI";                                   // Date base username
        private const String PASSWORD = "Admin";                                    // Date base password
        public DataTable dtCarStorage;
        public MySqlDataAdapter sqlDA;
        */
        
        public MySqlConnection dbConn;
        private const String SERVER = "192.168.137.34";                            // Server IP
        private const String DATABASE = "ThomasMore_CarStorage_Database";           // Date base name
        private const String TABLE = "CarStorage";                                  // Table name
        private const String UID = "TM_Remote";                                   // Date base username
        private const String PASSWORD = "Admin";                                    // Date base password
        public DataTable dtCarStorage;
        public DataTable StudentTable;
        public MySqlDataAdapter sqlDA;
        

        public void InitializeDataBase()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = SERVER;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;
            builder.SslMode = MySqlSslMode.None;
            //builder.CertificateFile = @"<Path_To_The_File>\client.pfx";
            //builder.CertificatePassword = "<Password_For_The_Cert>";

            String connString = builder.ToString();
            builder = null;

            dbConn = new MySqlConnection(connString);

            string query = "SELECT * FROM CarStorage";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dtCarStorage = new DataTable();

            dbConn.Open();
            dbConn.BeginTransaction();
            cmd.ExecuteNonQuery();

            sqlDA = new MySqlDataAdapter(cmd);

            sqlDA.Fill(dtCarStorage);

            dbConn.Close();


            query = "SELECT * FROM StudentTable";
            cmd = new MySqlCommand(query, dbConn);
            StudentTable = new DataTable();

            dbConn.Open();
            dbConn.BeginTransaction();
            cmd.ExecuteNonQuery();

            sqlDA = new MySqlDataAdapter(cmd);

            sqlDA.Fill(StudentTable);

            dbConn.Close();

        }


        public void DatabaseOpperation(String InsertQuery)
        {

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = SERVER;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;
            builder.SslMode = MySqlSslMode.None;

            String connString = builder.ToString();
            builder = null;

            dbConn = new MySqlConnection(connString);

            MySqlCommand myCommand = new MySqlCommand(InsertQuery, dbConn);
            dbConn.Open();
            myCommand.ExecuteNonQuery();
            dbConn.Close();
        }


        public void UpdateDatabase()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = SERVER;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;
            builder.SslMode = MySqlSslMode.None;

            String connString = builder.ToString();
            builder = null;

            dbConn = new MySqlConnection(connString);

            string query = "SELECT * FROM CarStorage";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dtCarStorage = new DataTable();

            dbConn.Open();

            sqlDA = new MySqlDataAdapter(cmd);

            sqlDA.Fill(dtCarStorage);

            dbConn.Close();

            query = "SELECT * FROM StudentTable";
            cmd = new MySqlCommand(query, dbConn);
            StudentTable = new DataTable();

            dbConn.Open();
            dbConn.BeginTransaction();
            cmd.ExecuteNonQuery();

            sqlDA = new MySqlDataAdapter(cmd);

            sqlDA.Fill(StudentTable);

            dbConn.Close();
        }


        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(childForm);
            ChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        #region Page Buttons

        //This section is for all the page switching buttons.


        private void Stats_button (Object sender, EventArgs e)
        {
            openChildForm(new StatsForm());
        }

        private void Admin_Button (object sender, EventArgs e)
        {
            //adminLoginForm.Show();
            openChildForm(new AdminForm());
        }

        private void GetCar_Button (object sender, EventArgs e)
        {
            openChildForm(new StudentForm());
        }

        public void LoginButtonBridge ()
        {
            openChildForm(new AdminForm());
        }   

        #endregion
    }
}
