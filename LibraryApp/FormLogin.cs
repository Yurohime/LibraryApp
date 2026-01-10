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

            string sqlconnection = $"server={sqlcomp.connection};uid={sqlcomp.username};password={sqlcomp.password};database={sqlcomp.database}";
            this.sqlconnection = sqlconnection;
            getUserData();
        }

        private void getUserData()
        {
            sqlquary = $"select * from users;";
            connection = new MySqlConnection(sqlconnection);
            command = new MySqlCommand(sqlquary, connection);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(sqldata);
            Console.WriteLine(sqldata.Rows[0][0].ToString());
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
