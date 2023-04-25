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
    public partial class GanRoleChoUser : Form
    {
        string connectionString = Login.connectionString;
        public GanRoleChoUser()
        {
            InitializeComponent();
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
                MessageBox.Show("Không tồn tại user nào để gán Role!");
                this.Close();
            }
            try
            {

                DataTable dt2 = new DataTable();
                string temp = "SELECT DISTINCT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTED_ROLE LIKE 'RL_%'";
                OracleCommand Cmd = new OracleCommand(temp, conn);
                Cmd.CommandType = CommandType.Text;
                OracleDataAdapter da2 = new OracleDataAdapter(Cmd);
                da2.Fill(dt2);
                comboBoxRole.DisplayMember = dt2.Columns[0].ColumnName;
                comboBoxRole.ValueMember = dt2.Columns[0].ColumnName;
                comboBoxRole.DataSource = dt2;
            }

            catch
            {
                MessageBox.Show("Không tồn tại role nào để gán!");
                this.Close();
            }
        }

        private void comboBoxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGan_Click(object sender, EventArgs e)
        {
            string username = comboBoxUserName.SelectedValue.ToString();
            string rolename = comboBoxRole.SelectedValue.ToString();
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            string text = "GRANT " + rolename + " TO " + username;
            Console.WriteLine(text);
            OracleCommand command = new OracleCommand(text, conn);
            command.ExecuteNonQuery();

            MessageBox.Show("Gán role thành công!", "Thông báo");
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
