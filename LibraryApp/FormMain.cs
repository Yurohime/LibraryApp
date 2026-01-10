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
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            loadLogin();
        }

        private void loadLogin()
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

        private void libaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
