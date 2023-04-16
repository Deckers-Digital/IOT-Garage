using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using MySql.Data.MySqlClient;
using MySQL.Data;
using System.Data.SqlClient;
using IOT_Garage_Application.Forms;

namespace IOT_Garage_Application
{
    class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProgramForm());
        }
    }
}
