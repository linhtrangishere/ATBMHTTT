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
    public partial class ThuHoiQuyenTuUser : Form
    {
        string connectionString = Login.connectionString;

        string[] pri = new string[] { "SELECT", "INSERT", "UPDATE", "DELETE" };
        public ThuHoiQuyenTuUser()
        {
            InitializeComponent();
            comboBoxThuHoiQuyen.Items.Add("SELECT");
            comboBoxThuHoiQuyen.Items.Add("INSERT");
            comboBoxThuHoiQuyen.Items.Add("UPDATE");
            comboBoxThuHoiQuyen.Items.Add("DELETE");
            comboBoxThuHoiQuyen.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
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
                MessageBox.Show("Không tồn tại user nào để thu hồi quyền!");
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
                MessageBox.Show("Không tồn tại table nào để thu hồi quyền!");
            }

            conn.Close();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelCapQuyen_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCapTrenCot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCapTrenCot.Checked)
            {
                comboBoxCot.DataSource = null;
            }
        }

        private void comboBoxBang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxThuHoiQuyen.SelectedIndex != 1 && comboBoxThuHoiQuyen.SelectedIndex != 3 && !checkBoxCapTrenCot.Checked)
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

        private void comboBoxThuHoiQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxThuHoiQuyen.SelectedIndex == 1 || comboBoxThuHoiQuyen.SelectedIndex == 3)
            {
                comboBoxCot.DataSource = null;
            }
        }

        private void buttonThuHoi_Click(object sender, EventArgs e)
        {
            string table = comboBoxBang.SelectedValue.ToString();
            int temp = comboBoxThuHoiQuyen.SelectedIndex;
            string username = comboBoxUserName.SelectedValue.ToString();

            if (comboBoxCot.SelectedValue != null && pri[temp] != "SELECT" && pri[temp] != "UPDATE")
            {
                MessageBox.Show("Chỉ được thu hồi quyền SELECT, UPDATE trên cột!");
            }
            else if (comboBoxCot.SelectedValue == null)
            {
                OracleConnection conn = new OracleConnection(connectionString);
                conn.Open();
                string text = "REVOKE " + pri[temp] + " ON " + table + " FROM " + username;
                Console.WriteLine(text);
                OracleCommand command = new OracleCommand(text, conn);
                command.ExecuteNonQuery();

                MessageBox.Show("Thu hồi quyền thành công!", "Thông báo");

            }
            else
            {
                try {
                    string col = comboBoxCot.SelectedValue.ToString();
                    OracleConnection conn = new OracleConnection(connectionString);
                    conn.Open();
                    string text = "REVOKE " + pri[temp] + " ON UV_" + username + "_" + table + "_" + col + " FROM " + username;
                    OracleCommand command = new OracleCommand(text, conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thu hồi quyền thành công!", "Thông báo");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
