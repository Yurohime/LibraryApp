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
    public partial class FormManageUser : Form
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

        DataTable sqlUserData = new DataTable();
        public FormManageUser()
        {
            InitializeComponent();
        }
        public FormMain FormNetwork
        {
            get;
            set;
        }
        private void FormManageUser_Load(object sender, EventArgs e)
        {
            this.sqlconnection = sqlcomp.connectToSQL();
            getDataFromSQL();
        }
        private void getDataFromSQL()
        {
            sqlUserData = getDataFromSQLUsingQuery($"CALL getUsers('{userName}');");
            dgv_user.DataSource = sqlUserData;
            dgv_user.Columns["User ID"].Visible = false;
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

        private void tbox_search_TextChanged(object sender, EventArgs e)
        {
            userName = tbox_search.Text;
            getDataFromSQL();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormNetwork.loadMainMenu();
        }

        private void refreshData()
        {
            getDataFromSQL();
        }

        private void dgv_user_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = dgv_user.CurrentCell.RowIndex;
            currentUserIDSelected = sqlUserData.Rows[row][0].ToString();
            tbox_name.Text = sqlUserData.Rows[row][1].ToString();
            tbox_password.Text = sqlUserData.Rows[row][2].ToString();
            tbox_phone.Text = sqlUserData.Rows[row][3].ToString();
            if (sqlUserData.Rows[row][4].ToString() == "Member")
            {
                rbtn_member.Checked = true;
            }
            else
            {
                rbtn_staff.Checked = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormNetwork.loadUser();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool missingInput = false;
            TextBox[] inputTBOX = { tbox_name, tbox_password, tbox_phone};
            for (int i = 0; i < inputTBOX.Length; i++)
            {
                if (inputTBOX[i].Text == "")
                {
                    missingInput = true;
                    break;
                }
            }
            if (!rbtn_member.Checked && !rbtn_staff.Checked)
            {
                missingInput = true;
            }

            if (missingInput)
            {
                MessageBox.Show("Missing Input, Please Fill all the Relevant Inputs");
            }
            else
            {
                string role = "";
                if (rbtn_staff.Checked)
                {
                    role = "S";
                }
                else
                {
                    role = "M";
                }

                connection.Open();
                sqlquary = $"INSERT INTO `users` (userid,userpassword,username,userrole,userphone) VALUES\r\n(UUID(),'{tbox_password.Text}','{tbox_name.Text}','{role}','{tbox_phone.Text}');";
                command = new MySqlCommand(sqlquary, connection);
                reader = command.ExecuteReader();
                connection.Close();
                refreshData();
                clearAllInput();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string role = "";
            if (rbtn_staff.Checked)
            {
                role = "S";
            }
            else
            {
                role = "M";
            }

            if (currentUserIDSelected != "")
            {
                connection.Open();
                sqlquary = $"UPDATE users SET userpassword = '{tbox_password.Text}', username = '{tbox_name.Text}', userphone = '{tbox_phone.Text}', userrole = '{role}' WHERE userid = '{currentUserIDSelected}';";
                command = new MySqlCommand(sqlquary, connection);
                reader = command.ExecuteReader();
                connection.Close();
                refreshData();
            }
            else
            {
                MessageBox.Show("Please Select a User First");
            }
            clearAllInput();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (currentUserIDSelected != "")
            {
                if (currentUserIDSelected == "admin") 
                {
                    DialogResult result = MessageBox.Show("Your about to delete Admin, Are you sure?","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        deleteUser();
                    }
                }
                else
                {
                    deleteUser();
                }
            }
            else
            {
                MessageBox.Show("Please Select a User First");
            }
            clearAllInput();
        }

        private void deleteUser()
        {
            connection.Open();
            sqlquary = $"UPDATE users SET status_del = true WHERE userid = '{currentUserIDSelected}';";
            command = new MySqlCommand(sqlquary, connection);
            reader = command.ExecuteReader();
            connection.Close();
            refreshData();
        }

        private void clearAllInput()
        {
            TextBox []inputTBOX = { tbox_name, tbox_password, tbox_phone, tbox_search };
            rbtn_member.Checked = false;
            rbtn_staff.Checked = false;
            currentUserIDSelected = "";
            for (int i = 0; i<inputTBOX.Length; i++)
            {
                inputTBOX[i].Text = "";
            }
}
    }
}
