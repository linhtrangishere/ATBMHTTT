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
    public partial class ChinhSuaRole : Form
    {

        OracleConnection conn = new OracleConnection(Login.connectionString);
        public ChinhSuaRole()
        {
            InitializeComponent();
            conn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Run_USP_ALTERROLE()
        {
            string set_script = "alter session set \"_ORACLE_SCRIPT\" = true";
            OracleCommand set_script_cmd = new OracleCommand(set_script, conn);

            OracleCommand cmd = new OracleCommand("USP_ALTERROLE", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("P_ROLENAME", OracleDbType.Varchar2);
            OracleParameter param2 = new OracleParameter("P_ROLE_NEW_PASSWORD", OracleDbType.Varchar2);

            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);

            //set giá trị
            param1.Value = textBoxRole.Text;
            param2.Value = textBoxMatKhau.Text;

            try
            {
                set_script_cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đặt mật khẩu cho role thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                textBoxRole.Clear();
                textBoxMatKhau.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đặt mật khẩu cho role thất bại, mã lỗi: " + ex.Message);
            }

        }

        private void buttonCapNhat_Click_1(object sender, EventArgs e)
        {
            Run_USP_ALTERROLE();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
