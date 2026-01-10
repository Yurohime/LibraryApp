using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryApp
{
    public partial class FormLogin : Form
    {
        Thread thread;
        SQLComponent sqlcomp = new SQLComponent();

        string sqlquary;
        string sqlconnection;
        string userid;

        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;

        DataTable sqldata = new DataTable();
        public FormMain FormNetwork
        {
            get;
            set;
        }
        public FormLogin()
        {
            InitializeComponent();
            connectToSQL();
            getUserData();
        }

        private void connectToSQL()
        {
            string sqlconnection = $"server={sqlcomp.connection};uid={sqlcomp.username};password={sqlcomp.password};database={sqlcomp.database}";
            this.sqlconnection = sqlconnection;
        }
        private void getUserData()
        {
            sqlquary = $"select * from users;";
            connection = new MySqlConnection(sqlconnection);
            command = new MySqlCommand(sqlquary, connection);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(sqldata);
            //Console.WriteLine(sqldata.Rows[0][0].ToString());
        }

        private void loginAttempt()
        {
            string username = tboxUsername.Text;
            string password = tboxPassword.Text;

            for (int i = 0; i < sqldata.Rows.Count; i++)
            {
                // if username doesnt match, continue search
                if(username != sqldata.Rows[i][2].ToString())
                {
                    continue;
                }

                // if password doesnt match, break
                if (password != sqldata.Rows[i][1].ToString())
                {
                    MessageBox.Show("Wrong Password");
                    break;
                }

                FormNetwork.setGlobalVariable("set", "username", sqldata.Rows[i][2].ToString());
                FormNetwork.setGlobalVariable("set", "userid", sqldata.Rows[i][0].ToString());
                FormNetwork.loadMainMenu();

            }
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginAttempt();
        }
    }
}
