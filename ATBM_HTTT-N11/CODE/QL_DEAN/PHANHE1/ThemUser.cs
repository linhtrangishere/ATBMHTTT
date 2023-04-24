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
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace PHANHE1
{
    public partial class ThemUser : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        

        public ThemUser()
        {
            InitializeComponent();
            conn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Run_USP_THEMUSER()
        {
            string set_script = "alter session set \"_ORACLE_SCRIPT\" = true";
            OracleCommand set_script_cmd = new OracleCommand(set_script, conn);

            OracleCommand cmd = new OracleCommand("USP_CREATEUSER", conn);
            cmd.CommandType = CommandType.StoredProcedure;


            OracleParameter param1 = new OracleParameter("p_username", OracleDbType.Varchar2);
            OracleParameter param2 = new OracleParameter("p_password", OracleDbType.Varchar2);
            
            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);
            

            //set giá trị
            param1.Value = textBoxTaiKhoan.Text;
            param2.Value = textBoxMatKhau.Text;

            //int result = Convert.ToInt32(param3.Value);
            try
            {
                //if (result == 1) 
                //{
                //    MessageBox.Show("Thêm user thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                set_script_cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm user thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTaiKhoan.Clear();
                textBoxMatKhau.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tạo user thất bại, mã lỗi: " + ex.Message);
            }

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            Run_USP_THEMUSER();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBoxTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void panelThemUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
