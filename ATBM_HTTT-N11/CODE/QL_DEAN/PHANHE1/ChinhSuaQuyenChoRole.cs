using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE1
{
    public partial class ChinhSuaQuyenChoRole : Form
    {
        string[] pri = new string[] { "SELECT", "INSERT", "UPDATE", "DELETE" };
        public ChinhSuaQuyenChoRole()
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
            try
            {
                DataTable dt2 = new DataTable();
                string tmp = "SELECT DISTINCT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTED_ROLE LIKE 'RL_%'";
                OracleCommand Cmd = new OracleCommand(tmp, conn);
                Cmd.CommandType = CommandType.Text;
                OracleDataAdapter da2 = new OracleDataAdapter(Cmd);
                da2.Fill(dt2);
                comboBoxRoleName.DisplayMember = dt2.Columns[0].ColumnName;
                comboBoxRoleName.ValueMember = dt2.Columns[0].ColumnName;
                comboBoxRoleName.DataSource = dt2;
            }
             catch
            {
                MessageBox.Show("Không tồn tại role nào!!!");
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
                MessageBox.Show("Không tồn tại bảng nào!");
            }
            conn.Close();

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(Login.connectionString);
            conn.Open();
            string rolename = comboBoxRoleName.SelectedValue.ToString();
            string temp = "SELECT * FROM ROLE_TAB_PRIVS WHERE ROLE = '"+ rolename +"'";
            OracleDataAdapter adp = new OracleDataAdapter(temp, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridViewChinhSuaQuyenChoRole.DataSource = dt;
            conn.Close();
        }

        private void labelChinhSuaQuyenChoRole_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(Login.connectionString);
            conn.Open();
            string rolename = comboBoxRoleName.SelectedValue.ToString();
            string temp = "SELECT * FROM ROLE_TAB_PRIVS WHERE ROLE LIKE 'RL_%'";
            OracleDataAdapter adp = new OracleDataAdapter(temp, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridViewChinhSuaQuyenChoRole.DataSource = dt;
            conn.Close();
        }

        private void textBoxQuyenCu_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void dataGridViewChinhSuaQuyenChoRole_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void checkBoxCapTrenCot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCapTrenCot.Checked)
            {
                comboBoxCot.DataSource = null;
            }
        }
        public string bangCu = null;
      
        private void dataGridViewChinhSuaQuyenChoRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OracleConnection conn = new OracleConnection(Login.connectionString);
            conn.Open();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewChinhSuaQuyenChoRole.Rows[e.RowIndex];
                textBoxQuyenCu.Text = row.Cells[4].Value.ToString();
                bangCu = row.Cells[2].Value.ToString();
             
            }
            conn.Close();
        }
        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            //revoke quyền
            OracleConnection conn = new OracleConnection(Login.connectionString);
            conn.Open();
            string table1 = bangCu;
            string privs1 = textBoxQuyenCu.Text;
            string role1 = comboBoxRoleName.SelectedValue.ToString();
            //cat chuoi ten cua bang cu kiem tra xem co phai view khong
            string check = bangCu.Substring(0, 2);
            if (check == "UV" && privs1 != "SELECT" && privs1 != "UPDATE")//TH: view with insert and delete => khong the cap tren cot
            {
                MessageBox.Show("Chỉ được chỉnh sửa quyền SELECT, UPDATE trên cột !!!");
            }
            else //TH: table or view with privs select and update
            {
                string temp1 = "REVOKE " + privs1 + " ON " + table1 + " FROM " + role1;
                Console.WriteLine(temp1);
                OracleCommand command = new OracleCommand(temp1, conn);
                command.ExecuteNonQuery();
            }



            //grant quyền mới cho role
            string table = comboBoxBang.SelectedValue.ToString();
            int temp = comboBoxQuyenMoi.SelectedIndex;
            string privs = pri[temp];
            string role = comboBoxRoleName.SelectedValue.ToString();

            if (comboBoxCot.SelectedValue != null && privs != "SELECT" && privs != "UPDATE")
            {
                MessageBox.Show("Chỉ được cấp quyền SELECT, UPDATE trên cột!");
            }
            else if (comboBoxCot.SelectedValue == null)
            {
                string text = "GRANT " + privs + " ON " + table + " TO " + role;
                Console.WriteLine(text);
                OracleCommand command = new OracleCommand(text, conn);
                command.ExecuteNonQuery();

                MessageBox.Show("Chỉnh sửa quyền thành công!", "Thông báo");

            }
            else
            {
                string col = comboBoxCot.SelectedValue.ToString();
                string text = "CREATE OR REPLACE VIEW UV_" + role + "_" + table + "_" + col + " AS SELECT " + col + " FROM " + table;
                OracleCommand command = new OracleCommand(text, conn);
                command.ExecuteNonQuery();
                string text2 = "";
                if (privs == "SELECT")
                {
                    text2 = "GRANT " + privs + " ON UV_" + role + "_" + table + "_" + col + " TO " + role;
                }
                else if (privs == "UPDATE")
                {
                    text2 = "GRANT " + privs + "(" + col + ") ON UV_" + role + "_" + table + "_" + col + " TO " + role;
                }
                Console.WriteLine(text2);
                OracleCommand command2 = new OracleCommand(text2, conn);
                command2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Chỉnh sửa quyền thành công!", "Thông báo");
            }
            
        }

    }
}
