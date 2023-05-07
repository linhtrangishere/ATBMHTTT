using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PHANHE1
{
    public partial class XoaUser : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        public XoaUser()
        {
            InitializeComponent();
            conn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Run_USP_DROPUSER()
        {
            //string set_script = "alter session set \"_ORACLE_SCRIPT\" = true";
            //OracleCommand set_script_cmd = new OracleCommand(set_script, conn);

            OracleCommand cmd = new OracleCommand("USP_DROPUSER", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("p_username", OracleDbType.Varchar2);

            cmd.Parameters.Add(param1);


            //set giá trị
            param1.Value = textBoxXoaUser.Text;

            try
            {
                //set_script_cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa user thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                textBoxXoaUser.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tạo role thất bại, mã lỗi: " + ex.Message);
            }

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            Run_USP_DROPUSER();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
