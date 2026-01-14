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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryApp
{
    public partial class FormCatalog : Form
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

        string bookName = "";
        string bookAuthor = "";
        string bookYear = "";

        DataTable sqldata = new DataTable();
        public FormCatalog()
        {
            InitializeComponent();
        }
        public FormMain FormNetwork
        {
            get;
            set;
        }
        private void FormCatalog_Load(object sender, EventArgs e)
        {
            this.sqlconnection = sqlcomp.connectToSQL();
            refreshData();
        }

        private void refreshData()
        {
            sqldata.Clear();
            checkTextboxData();
            getDataFromSQL();
            checkFilter();
            dgv_mainview.DataSource = sqldata;
            PreventSorting();
        }

        private void PreventSorting()
        {
            foreach (DataGridViewColumn column in dgv_mainview.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void checkFilter()
        {
            if (!cbox_avail.Checked)
            {
                removeRowFromDataWithParam("Available");
            }
            if (!cbox_borrow.Checked)
            {
                removeRowFromDataWithParam("Borrowed");
            }
            if (!cbox_unknown.Checked)
            {
                removeRowFromDataWithParam("Missing");
            }
        }

        private void removeRowFromDataWithParam(string condition)
        {
            for (int i = 0; i < sqldata.Rows.Count; i++)
            {
                if (sqldata.Rows[i][3].ToString() == condition)
                {
                    sqldata.Rows.RemoveAt(i);
                    i -= 1;
                }
            }
        }

        private void getDataFromSQL()
        {
            sqlquary = $"call GetBookLoanStatus('{bookName}','{bookAuthor}',{bookYear});";
            connection = new MySqlConnection(sqlconnection);
            command = new MySqlCommand(sqlquary, connection);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(sqldata);
        }

        private void checkTextboxData()
        {
            bookName = tbox_name.Text;
            bookAuthor = tbox_author.Text;
            if (tbox_year.Text == "")
            {
                bookYear = "NULL";
            }
            else
            {
                bookYear = tbox_year.Text;
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            FormNetwork.loadMainMenu();
        }

        private void tbox_name_TextChanged(object sender, EventArgs e)
        {
            checkTextboxData();
            refreshData();
        }

        private void tbox_author_TextChanged(object sender, EventArgs e)
        {
            checkTextboxData();
            refreshData();
        }

        private void tbox_year_TextChanged(object sender, EventArgs e)
        {
            checkTextboxData();
            refreshData();
        }

        private void tbox_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void cbox_avail_CheckStateChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        private void cbox_borrow_CheckedChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        private void cbox_unknown_CheckedChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btn_clear_all_Click(object sender, EventArgs e)
        {
            FormNetwork.loadCatalog();
        }
    }
}
