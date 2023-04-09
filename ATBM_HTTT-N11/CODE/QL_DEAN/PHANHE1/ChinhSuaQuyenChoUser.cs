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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PHANHE1
{
    public partial class ChinhSuaQuyenChoUser : Form
    {
        string[] pri = new string[] { "SELECT", "INSERT", "UPDATE", "DELETE" };
        public ChinhSuaQuyenChoUser()
        {
            InitializeComponent();
            comboBoxQuyenMoi.Items.Add("SELECT");
            comboBoxQuyenMoi.Items.Add("INSERT");
            comboBoxQuyenMoi.Items.Add("UPDATE");
            comboBoxQuyenMoi.Items.Add("DELETE");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(Login.connectionString);
            conn.Open();
            try
            {
                //CAC TUY CHON USER
                DataTable dt2 = new DataTable();
                string temp = "SELECT * FROM dba_users WHERE USERNAME NOT LIKE '%SYS%' AND ACCOUNT_STATUS = 'OPEN' ORDER BY created DESC";
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
                //CAC TUY CHON BANG
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
            catch {
                MessageBox.Show("Không tồn tại bảng nào !!!");
            }
            conn.Close();

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void checkBoxCapTrenCot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCapTrenCot.Checked)
            {
                comboBoxCot.DataSource = null;
            }
        }
        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            //XEM CAC QUYEN HIEN TAI CUA USER
            OracleConnection conn = new OracleConnection(Login.connectionString);
            conn.Open();
            string username = comboBoxUserName.SelectedValue.ToString();
            string temp = "SELECT * FROM USER_TAB_PRIVS WHERE GRANTEE = '" + username + "'";
            OracleDataAdapter adp = new OracleDataAdapter(temp, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridViewChinhSuaQuyenChoUser.DataSource = dt;
            conn.Close();
        }

        private void comboBoxBang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CAC TUY CHON COT
            //if (comboBoxQuyenMoi.SelectedValue.ToString() != "INSERT" && comboBoxQuyenMoi.SelectedValue.ToString() != "DELETE" && !checkBoxCapTrenCot.Checked)
            //{
                OracleConnection conn = new OracleConnection(Login.connectionString);
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
            //}
        }

        private void dataGridViewChinhSuaQuyenChoUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string bangCu = null;
        private void dataGridViewChinhSuaQuyenChoUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OracleConnection conn = new OracleConnection(Login.connectionString);
            conn.Open();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewChinhSuaQuyenChoUser.Rows[e.RowIndex];
                textBoxQuyenCu.Text = row.Cells[4].Value.ToString();
                bangCu = row.Cells[2].Value.ToString();
            }
            conn.Close();
        }
        //REVOKE QUYEN TU NGUOI DUNG
        private void buttonChon_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(Login.connectionString);
            conn.Open();
            string table = bangCu;
            string privs = textBoxQuyenCu.Text;
            string username = comboBoxUserName.SelectedValue.ToString();

            if (comboBoxCot.SelectedValue != null && privs != "SELECT" && privs != "UPDATE")
            {
                MessageBox.Show("Quyền này không thể thay đổi !!!");
            }
            else if (comboBoxCot.SelectedValue == null)
            {
                string temp = "REVOKE " + privs + " ON " + table + " FROM " + username;
                Console.WriteLine(temp);
                Console.WriteLine(temp);
                OracleCommand command = new OracleCommand(temp, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Hãy nhập quyền mới");

            }
            else
            {
                try
                {
                    string col = comboBoxCot.SelectedValue.ToString();
                    string text = "REVOKE " + privs + " ON UV_" + username + "_" + table + "_" + col + " FROM " + username;
                    OracleCommand command = new OracleCommand(text, conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Hãy nhập quyền mới");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            conn.Close();

        }
        //XEM QUYEN CUA TAT CA CAC NGUOI DUNG DUOC CAP QUYEN
        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(Login.connectionString);
            conn.Open();
            string temp = "SELECT * FROM USER_TAB_PRIVS";
            OracleDataAdapter adp = new OracleDataAdapter(temp, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridViewChinhSuaQuyenChoUser.DataSource = dt;
            conn.Close();
        }
        //CAP NHAT QUYEN MOI CHO USER
        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(Login.connectionString);
            conn.Open();
            string table = comboBoxBang.SelectedValue.ToString();
            int index = comboBoxQuyenMoi.SelectedIndex;
            string privs = pri[index];
            string username = comboBoxUserName.SelectedValue.ToString();

            if (comboBoxCot.SelectedValue != null && privs != "SELECT" && privs != "UPDATE")
            {
                MessageBox.Show("Quyền này không thể cập nhật");
            }
            else if (comboBoxCot.SelectedValue == null)
            {
                if (checkBoxWithGrantOption.Checked)
                {
                    string text = "GRANT " + privs + " ON " + table + " TO " + username + " WITH GRANT OPTION";
                    Console.WriteLine(text);
                    OracleCommand command = new OracleCommand(text, conn);
                    command.ExecuteNonQuery();
                }
                else
                {
                    string text = "GRANT " + privs + " ON " + table + " TO " + username;
                    Console.WriteLine(text);
                    OracleCommand command = new OracleCommand(text, conn);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
             
            }
            else
            {
                if (comboBoxCot.SelectedValue != null)
                {
                    string col = comboBoxCot.SelectedValue.ToString();
                    string text = "CREATE OR REPLACE VIEW UV_" + username + "_" + table + "_" + col + " AS SELECT " + col + " FROM " + table;
                    OracleCommand command = new OracleCommand(text, conn);
                    command.ExecuteNonQuery();
                    string text2 = "";
                    if (privs == "SELECT")
                    {
                        if (checkBoxWithGrantOption.Checked)
                        {
                            text2 = "GRANT " + privs + " ON UV_" + username + "_" + table + "_" + col + " TO " + username + " WITH GRANT OPTION";
                        }
                        else
                        {
                            text2 = "GRANT " + privs + " ON UV_" + username + "_" + table + "_" + col + " TO " + username;
                        }
                    }
                    else if (privs == "UPDATE")
                    {
                        if (checkBoxWithGrantOption.Checked)
                        {
                            text2 = "GRANT " + privs + "(" + col + ") ON UV_" + username + "_" + table + "_" + col + " TO " + username + " WITH GRANT OPTION";
                        }
                        else
                        {
                            text2 = "GRANT " + privs + "(" + col + ") ON UV_" + username + "_" + table + "_" + col + " TO " + username;
                        }
                    }
                    Console.WriteLine(text2);
                    OracleCommand command2 = new OracleCommand(text2, conn);
                    command2.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Cập nhật thành công !!!", "Thông báo");
                }
                
            }
            conn.Close();
        }

        private void textBoxQuyenCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTenUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
