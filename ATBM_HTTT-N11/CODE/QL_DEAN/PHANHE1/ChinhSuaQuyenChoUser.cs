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
            comboBoxQuyenMoi.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(Login.connectionString);
            conn.Open();
            //combobox username
            try
            {
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
                MessageBox.Show("Không tồn tại user nào!");
            }
            //combobox table
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
        }

        private void dataGridViewChinhSuaQuyenChoUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string bangCu = null;
        public string typ = null;
        //xem quyen hien co cua mot user
        private void dataGridViewChinhSuaQuyenChoUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OracleConnection conn = new OracleConnection(Login.connectionString);
            conn.Open();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewChinhSuaQuyenChoUser.Rows[e.RowIndex];//lay dong hien tai dang chon
                textBoxQuyenCu.Text = row.Cells[4].Value.ToString();//lay quyen cua dong dang chon bo vao quyen cu
                bangCu = row.Cells[2].Value.ToString();//lay bang cua dong dang chon bo vao bang cu
                typ = row.Cells[8].Value.ToString();//kiem tra xem day la table or view
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

            //revoke quyen cu
            string tabName = bangCu; // bang chua quyen cu can thay doi
            string tbType = typ;
            string privs = textBoxQuyenCu.Text;// quyen cu can thay doi
            string username = comboBoxUserName.SelectedValue.ToString();

            if (tbType == "VIEW" && privs != "SELECT" && privs != "UPDATE")
            {
                MessageBox.Show("Chỉ được thu hồi quyền SELECT, UPDATE trên cột !!!");
            }
            else // TH: Table or view with privs select or update
            {
                try
                {
                    string temp = "REVOKE " + privs + " ON " + tabName + " FROM " + username;
                    Console.WriteLine(temp);
                    OracleCommand command = new OracleCommand(temp, conn);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


            
            //cap nhat lai quyen moi
            string table = comboBoxBang.SelectedValue.ToString();
            int index = comboBoxQuyenMoi.SelectedIndex;
            string privs2 = pri[index];
            string username2 = comboBoxUserName.SelectedValue.ToString();

            if (comboBoxCot.SelectedValue != null && privs2 != "SELECT" && privs2 != "UPDATE")
            {
                MessageBox.Show("Chỉ được cấp quyền SELECT, UPDATE trên cột!");
            }
            else if (comboBoxCot.SelectedValue == null)
            {
                if (checkBoxWithGrantOption.Checked)
                {
                    string text = "GRANT " + privs2 + " ON " + table + " TO " + username2 + " WITH GRANT OPTION";
                    Console.WriteLine(text);
                    OracleCommand command = new OracleCommand(text, conn);
                    command.ExecuteNonQuery();
                }
                else
                {
                    string text = "GRANT " + privs2 + " ON " + table + " TO " + username2;
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
                    string text = "CREATE OR REPLACE VIEW UV_" + username2 + "_" + table + "_" + col + " AS SELECT " + col + " FROM " + table;
                    OracleCommand command = new OracleCommand(text, conn);
                    command.ExecuteNonQuery();
                    string text2 = "";
                    if (privs2 == "SELECT")
                    {
                        if (checkBoxWithGrantOption.Checked)
                        {
                            text2 = "GRANT " + privs2 + " ON UV_" + username2 + "_" + table + "_" + col + " TO " + username2 + " WITH GRANT OPTION";
                        }
                        else
                        {
                            text2 = "GRANT " + privs2 + " ON UV_" + username2 + "_" + table + "_" + col + " TO " + username2;
                        }
                    }
                    else if (privs2 == "UPDATE")
                    {
                        if (checkBoxWithGrantOption.Checked)
                        {
                            text2 = "GRANT " + privs2 + "(" + col + ") ON UV_" + username2 + "_" + table + "_" + col + " TO " + username2 + " WITH GRANT OPTION";
                        }
                        else
                        {
                            text2 = "GRANT " + privs2 + "(" + col + ") ON UV_" + username2 + "_" + table + "_" + col + " TO " + username2;
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

