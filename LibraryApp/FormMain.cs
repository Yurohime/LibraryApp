using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class FormMain : Form
    {
        UserComponent userComponent = new UserComponent();
        Thread thread;
        SQLComponent sqlcomp = new SQLComponent();

        string sqlquary;
        string sqlconnection;
        string userid;

        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;

        string myRole = "";
        DataTable sqldata = new DataTable();

        public FormMain()
        {
            InitializeComponent();
        }

        private void checkRoleFromSQL()
        {
            sqldata = new DataTable();
            sqlquary = $"select * from users where userid = '{userComponent.Userid}';";
            connection = new MySqlConnection(sqlconnection);
            command = new MySqlCommand(sqlquary, connection);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(sqldata);
            myRole = sqldata.Rows[0][4].ToString();
        }

        public string checkRole()
        {
            return myRole;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            loadLogin();
            this.sqlconnection = sqlcomp.connectToSQL();
        }

        public void loadLogin()
        {
            userComponent.Userid = "";
            userComponent.Username = "";

            FormLogin form = new FormLogin();
            form.Dock = DockStyle.Top;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.FormNetwork = this;

            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(form);
            form.Show();
        }

        public void loadMainMenu()
        {
            checkRoleFromSQL();
            FormMainMenu form = new FormMainMenu();
            form.Dock = DockStyle.Top;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.FormNetwork = this;

            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(form);
            form.Show();
        }

        public void loadCatalog()
        {
            FormCatalog form = new FormCatalog();
            form.Dock = DockStyle.Top;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.FormNetwork = this;

            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(form);
            form.Show();
        }

        public void loadMember()
        {
            FormManage form = new FormManage();
            form.Dock = DockStyle.Top;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.FormNetwork = this;

            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(form);
            form.Show();
        }

        public void loadManageCatalog()
        {
            FormManageCatalog form = new FormManageCatalog();
            form.Dock = DockStyle.Top;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.FormNetwork = this;

            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(form);
            form.Show();
        }

        public void loadUser()
        {
            FormManageUser form = new FormManageUser();
            form.Dock = DockStyle.Top;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.FormNetwork = this;

            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(form);
            form.Show();
        }

        public void setGlobalVariable(string action, string vartype, string var)
        {
            string newVariable = var;

            // action list
            // set - set new var to old one
            // clear - clear old var and leave blank

            switch (action)
            {
                case "set":
                    newVariable = var;
                    break;
                case "clear":
                    newVariable = "";
                    break;
                default:

                    break;
            }

            switch (vartype)
            {
                case "userid":
                    userComponent.Userid = newVariable;
                    break;
                case "username":
                    userComponent.Username = newVariable;
                    break;
                default:

                    break;
            }
        }

        private void libaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
