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

        }

        private void pbox_catalog_Click(object sender, EventArgs e)
        {
            FormNetwork.loadCatalog();
        }

        private void pbox_member_Click(object sender, EventArgs e)
        {
            FormNetwork.loadMember();
        }
    }
}
