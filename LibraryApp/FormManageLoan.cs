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
    public partial class FormManage : Form
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
        string userName = "";
        string bookAuthor = "";
        string bookYear = "";

        string currentUserIDSelected = "";
        string currentBookIDSelected = "";

        DataTable sqlMemberData = new DataTable();
        DataTable sqlBookData = new DataTable();
        DataTable sqlHistoryData = new DataTable();

        string selectMode = "";
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
            this.sqlconnection = sqlcomp.connectToSQL();
            loadMemberData();
            refreshData();
            dgv_member.ClearSelection();
        }

        private void refreshData()
        {
            currentBookIDSelected = "";
            selectMode = "";
            dgv_book.ClearSelection();
            dgv_history.ClearSelection();

            setButtonCheckability();
            loadBookData();
            loadHistoryData();
        }

        private void setButtonCheckability()
        {
            // for RETURN and LOAN
            if (selectMode == "Loan")
            {
                btn_loan.Enabled = true;
                btn_return.Enabled = false;

            }
            else if (selectMode == "Return")
            {
                btn_loan.Enabled = false;
                btn_return.Enabled = true;
            }
            else
            {
                btn_loan.Enabled = false;
                btn_return.Enabled = false;
            }
        }

        private void loadMemberData()
        {
            sqlMemberData = getDataFromSQLUsingQuery($"call getMembersByUsername('{userName}');");
            dgv_member.DataSource = sqlMemberData;
            dgv_member.Columns["userid"].Visible = false;
            PreventSorting(dgv_member);
        }
        private void loadBookData()
        {
            if (currentUserIDSelected != "")
            {
                sqlBookData = getDataFromSQLUsingQuery($"call getAvailableBooks('{bookName}');");
                dgv_book.DataSource = sqlBookData;
                dgv_book.Columns["bookid"].Visible = false;
                PreventSorting(dgv_book);
            }
            dgv_book.ClearSelection();
        }
        private void loadHistoryData()
        {
            if (currentUserIDSelected != "")
            {
                sqlHistoryData = getDataFromSQLUsingQuery($"call getUserHistory('{currentUserIDSelected}')");
                dgv_history.DataSource = sqlHistoryData;
                dgv_history.Columns["bookid"].Visible = false;
                PreventSorting(dgv_history);

                for (int i = 0; i < sqlHistoryData.Rows.Count; i++)
                {
                    if (sqlHistoryData.Rows[i][1].ToString() == "Returned")
                    {
                        sqlHistoryData.Rows.RemoveAt(i);
                        i = 0;
                    }
                    if (sqlHistoryData.Rows[i][1].ToString() == "Returned Late")
                    {
                        sqlHistoryData.Rows.RemoveAt(i);
                        i = 0;
                    }
                }
            }
            dgv_history.ClearSelection();
        }

        private void PreventSorting(DataGridView selectedDGV)
        {
            foreach (DataGridViewColumn column in selectedDGV.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private DataTable getDataFromSQLUsingQuery(string query)
        {
            DataTable data = new DataTable();
            sqlquary = query;
            connection = new MySqlConnection(sqlconnection);
            command = new MySqlCommand(sqlquary, connection);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(data);
            return data;
        }

        private void dgv_member_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = dgv_member.CurrentCell.RowIndex;
            currentUserIDSelected = sqlMemberData.Rows[row][0].ToString();
            loadBookData();
            loadHistoryData();
            setButtonCheckability();
        }

        private void dgv_book_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_history.ClearSelection();
            int row = dgv_book.CurrentCell.RowIndex;
            currentBookIDSelected = sqlBookData.Rows[row][0].ToString();
            selectMode = "Loan";
            setButtonCheckability();
        }

        private void dgv_history_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_book.ClearSelection();
            int row = dgv_history.CurrentCell.RowIndex;
            currentBookIDSelected = sqlHistoryData.Rows[row][0].ToString();
            selectMode = "Return";
            setButtonCheckability();
        }

        private void btn_loan_Click(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd");
            connection.Open();
            sqlquary = $"INSERT INTO `loanDetail` (userid, bookid, dateborrow, datereturn) VALUES ('{currentUserIDSelected}', '{currentBookIDSelected}', '{now}', NULL);";
            command = new MySqlCommand(sqlquary, connection);
            reader = command.ExecuteReader();
            connection.Close();
            refreshData();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd");
            connection.Open();
            sqlquary = $"update loanDetail set datereturn = CURDATE() WHERE userid = '{currentUserIDSelected}'  AND bookid = '{currentBookIDSelected}';";
            command = new MySqlCommand(sqlquary, connection);
            reader = command.ExecuteReader();
            connection.Close();
            refreshData();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormNetwork.loadMainMenu();
        }

        private void tbox_name_TextChanged(object sender, EventArgs e)
        {
            userName = tbox_name.Text;
            loadMemberData();
        }

        private void tbox_title_TextChanged(object sender, EventArgs e)
        {
            bookName = tbox_title.Text;
            refreshData();
        }

        private void btn_clear_all_Click(object sender, EventArgs e)
        {
            FormNetwork.loadMember();
        }
    }
}
