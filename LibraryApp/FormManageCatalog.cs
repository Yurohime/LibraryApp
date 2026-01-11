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
    public partial class FormManageCatalog : Form
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
        string bookMarker = "";

        string currentUserIDSelected = "";
        string currentBookIDSelected = "";

        DataTable sqlBookData = new DataTable();

        string selectMode = "";
        public FormManageCatalog()
        {
            InitializeComponent();
        }
        public FormMain FormNetwork
        {
            get;
            set;
        }
        private void FormManageCatalog_Load(object sender, EventArgs e)
        {
            this.sqlconnection = sqlcomp.connectToSQL();
            refreshData();
        }

        private void refreshData()
        {
            getDataFromSQL();
            dgv_book_list.ClearSelection();
        }

        private void getDataFromSQL()
        {
            sqlBookData = getDataFromSQLUsingQuery($"CALL getBooksByMarker('{bookMarker}');");
            dgv_book_list.DataSource = sqlBookData;
            dgv_book_list.Columns["bookid"].Visible = false;
            dgv_book_list.Columns["bookcondition"].Visible = false;
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormNetwork.loadMainMenu();
        }

        private void tbox_marker_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_book_list_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = dgv_book_list.CurrentCell.RowIndex;
            currentBookIDSelected = sqlBookData.Rows[row][0].ToString();
            tbox_marker.Text = sqlBookData.Rows[row][1].ToString();
            tbox_title.Text = sqlBookData.Rows[row][2].ToString();
            tbox_author.Text = sqlBookData.Rows[row][3].ToString();
            tbox_year.Text = sqlBookData.Rows[row][4].ToString();
        }

        private void tbox_search_TextChanged(object sender, EventArgs e)
        {
            bookMarker = tbox_search.Text;
            getDataFromSQL();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            TextBox[] inputTBOX = { tbox_marker, tbox_title, tbox_year, tbox_author };
            currentBookIDSelected = "";
            for (int i = 0; i < inputTBOX.Length; i++)
            {
                inputTBOX[i].Text = "";
            }
        }

        private void btn_clear_all_Click(object sender, EventArgs e)
        {
            clearAllInput();
        }

        private void clearAllInput()
        {
            TextBox[] inputTBOX = { tbox_marker, tbox_title, tbox_year, tbox_author, tbox_search };
            currentBookIDSelected = "";
            for (int i = 0; i < inputTBOX.Length; i++)
            {
                inputTBOX[i].Text = "";
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool missingInput = false;
            TextBox[] inputTBOX = { tbox_marker, tbox_title, tbox_year, tbox_author };
            for (int i = 0; i < inputTBOX.Length; i++)
            {
                if (inputTBOX[i].Text == "")
                {
                    missingInput = true;
                    break;
                }
            }
            if (missingInput)
            {
                MessageBox.Show("Missing Input, Please Fill all the Relevant Inputs");
            }
            else
            {
                connection.Open();
                sqlquary = $"INSERT INTO `books` (bookid, bookmarker, booktitle, bookauthor, bookyear, bookcondition) VALUES (UUID(), '{inputTBOX[0].Text}', '{inputTBOX[1].Text}', '{inputTBOX[3].Text}', {inputTBOX[2].Text},'G');";
                command = new MySqlCommand(sqlquary, connection);
                reader = command.ExecuteReader();
                connection.Close();
                refreshData();
                clearAllInput();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (currentBookIDSelected != "")
            {
                connection.Open();
                sqlquary = $"UPDATE books SET booktitle = '{tbox_title.Text}', bookauthor = '{tbox_author.Text}', bookyear = {tbox_year.Text}, bookmarker = '{tbox_marker.Text}', bookcondition = 'G' WHERE bookid = '{currentBookIDSelected}';";
                command = new MySqlCommand(sqlquary, connection);
                reader = command.ExecuteReader();
                connection.Close();
                refreshData();
            }
            else
            {
                MessageBox.Show("Please Select a Book First");
            }
            clearAllInput();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (currentBookIDSelected != "")
            {
                connection.Open();
                sqlquary = $"UPDATE books SET bookcondition = 'U' WHERE bookid = '{currentBookIDSelected}';";
                command = new MySqlCommand(sqlquary, connection);
                reader = command.ExecuteReader();
                connection.Close();
                refreshData();
            }
            else
            {
                MessageBox.Show("Please Select a Book First");
            }
            clearAllInput();
        }
    }
}
