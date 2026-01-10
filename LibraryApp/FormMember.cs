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
    public partial class FormManage : Form
    {
        public FormManage()
        {
            InitializeComponent();
        }
        public FormMain FormNetwork
        {
            get;
            set;
        }

        private void FormManage_Load(object sender, EventArgs e)
        {

        }
    }
}
