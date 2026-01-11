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
    public partial class FormMainMenu : Form
    {
        Thread thread;
        public FormMain FormNetwork
        {
            get;
            set;
        }
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pboxm1_Click(object sender, EventArgs e)
        {
            FormNetwork.loadManageCatalog();
        }

        private void pbox_catalog_Click(object sender, EventArgs e)
        {
            FormNetwork.loadCatalog();
        }

        private void pbox_member_Click(object sender, EventArgs e)
        {
            FormNetwork.loadMember();
        }

        private void pbox_user_Click(object sender, EventArgs e)
        {
            FormNetwork.loadUser();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormNetwork.loadLogin();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            string myRole = FormNetwork.checkRole();
            if (myRole == "M")
            {
                pnl_catalog.Visible = false;
                pnl_user.Visible = false;
                pnl_lease.Visible = false;
            }
            else
            {
                pnl_catalog.Visible = true;
                pnl_user.Visible = true;
                pnl_lease.Visible = true;
            }
        }
    }
}
