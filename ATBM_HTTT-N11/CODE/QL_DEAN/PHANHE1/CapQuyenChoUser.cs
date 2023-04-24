using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE1
{
    public partial class CapQuyenChoUser : Form
    {
        string connectionString = Login.connectionString;

        string[] pri = new string[] { "SELECT", "INSERT", "UPDATE", "DELETE" };
        public CapQuyenChoUser()
        {
            InitializeComponent();
            comboBoxCapQuyen.Items.Add("SELECT");
            comboBoxCapQuyen.Items.Add("INSERT");
            comboBoxCapQuyen.Items.Add("UPDATE");
            comboBoxCapQuyen.Items.Add("DELETE");
            comboBoxCapQuyen.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            try
            {

                DataTable dt2 = new DataTable();
                string temp = "select * from user_tab_privs WHERE GRANTEE NOT LIKE 'RL%' AND OWNER != 'SYS'";
                OracleCommand Cmd = new OracleCommand(temp, conn);
                Cmd.CommandType = CommandType.Text;
                OracleDataAdapter da2 = new OracleDataAdapter(Cmd);
                da2.Fill(dt2);
                comboBoxUserName.DisplayMember = dt2.Columns[0].ColumnName;
                comboBoxUserName.ValueMember = dt2.Columns[0].ColumnName;
                comboBoxUserName.DataSource = dt2;
            }

            catch
            {
                MessageBox.Show("Không tồn tại user nào để cấp quyền!");
            }

            try
            {
                DataTable dt = new DataTable();
                string temp = "select TABLE_NAME from USER_TABLES";
                OracleCommand a_Cmd = new OracleCommand(temp, conn);
                a_Cmd.CommandType = CommandType.Text;
                OracleDataAdapter da = new OracleDataAdapter(a_Cmd);

                da.Fill(dt);

                comboBoxBang.DisplayMember = dt.Columns[0].ColumnName;
                comboBoxBang.ValueMember = dt.Columns[0].ColumnName;
                comboBoxBang.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Không tồn tại table nào để cấp quyền!");
            }

            conn.Close();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCapTrenCot.Checked)
            {
                comboBoxCot.DataSource = null;
            }
        }

        private void comboBoxBang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCapQuyen.SelectedIndex != 1 && comboBoxCapQuyen.SelectedIndex != 3 && !checkBoxCapTrenCot.Checked)
            {
                OracleConnection conn = new OracleConnection(connectionString);
                conn.Open();
                string temp;
                string table = comboBoxBang.SelectedValue.ToString();
                temp = "SELECT column_name FROM USER_TAB_COLUMNS WHERE table_name = '" + table + "'";
                DataTable dt2 = new DataTable();

                OracleCommand Cmd = new OracleCommand(temp, conn);
                Cmd.CommandType = CommandType.Text;
                OracleDataAdapter da2 = new OracleDataAdapter(Cmd);

                da2.Fill(dt2);
                comboBoxCot.DisplayMember = dt2.Columns[0].ColumnName;
                comboBoxCot.ValueMember = dt2.Columns[0].ColumnName;
                comboBoxCot.DataSource = dt2;
                conn.Close();
            }
        }

        private void comboBoxCapQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCapQuyen.SelectedIndex == 1 || comboBoxCapQuyen.SelectedIndex == 3)
            {
                comboBoxCot.DataSource = null;
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string table = comboBoxBang.SelectedValue.ToString();
            int temp = comboBoxCapQuyen.SelectedIndex;
            string username = comboBoxUserName.SelectedValue.ToString();

            if (comboBoxCot.SelectedValue != null && pri[temp] != "SELECT" && pri[temp] != "UPDATE")
            {
                MessageBox.Show("Chỉ được cấp quyền SELECT, UPDATE trên cột!");
            }
            else if (comboBoxCot.SelectedValue == null)
            {
                OracleConnection conn = new OracleConnection(connectionString);
                conn.Open();
                if (checkBoxWithGrantOption.Checked)
                {
                    string text = "GRANT " + pri[temp] + " ON " + table + " TO " + username + " WITH GRANT OPTION";
                    Console.WriteLine(text);
                    OracleCommand command = new OracleCommand(text, conn);
                    command.ExecuteNonQuery();
                }
                else
                {
                    string text = "GRANT " + pri[temp] + " ON " + table + " TO " + username;
                    Console.WriteLine(text);
                    OracleCommand command = new OracleCommand(text, conn);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Cấp quyền thành công!", "Thông báo");
                conn.Close();
            }
            else
            {
                string col = comboBoxCot.SelectedValue.ToString();
                OracleConnection conn = new OracleConnection(connectionString);
                conn.Open();
                string text = "CREATE OR REPLACE VIEW UV_" + username + "_" + table + "_" + col + " AS SELECT " + col + " FROM " + table;
                OracleCommand command = new OracleCommand(text, conn);
                command.ExecuteNonQuery();
                string text2 = "";
                if (pri[temp] == "SELECT")
                {
                    if (checkBoxWithGrantOption.Checked)
                    {
                        text2 = "GRANT " + pri[temp] + " ON UV_" + username + "_" + table + "_" + col + " TO " + username + " WITH GRANT OPTION";
                    }
                    else
                    {
                        text2 = "GRANT " + pri[temp] + " ON UV_" + username + "_" + table + "_" + col + " TO " + username;
                    }
                }
                else if (pri[temp] == "UPDATE")
                {
                    if (checkBoxWithGrantOption.Checked)
                    {
                        text2 = "GRANT " + pri[temp] + "(" + col + ") ON UV_" + username + "_" + table + "_" + col + " TO " + username + " WITH GRANT OPTION";
                    }
                    else
                    {
                        text2 = "GRANT " + pri[temp] + "(" + col + ") ON UV_" + username + "_" + table + "_" + col + " TO " + username;
                    }    
                }
                Console.WriteLine(text2);
                OracleCommand command2 = new OracleCommand(text2, conn);
                command2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Phân quyền thành công!", "Thông báo");
            }

        }

        private void comboBoxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
