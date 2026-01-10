using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class FormMain : Form
    {
        UserComponent userComponent = new UserComponent();
        public FormMain()
        {
            InitializeComponent();
            userComponent.Userid = "";
            userComponent.Username = "";

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            loadLogin();
        }

        public void loadLogin()
        {
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
            FormMainMenu form = new FormMainMenu();
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
