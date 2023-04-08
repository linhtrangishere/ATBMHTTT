﻿using Oracle.ManagedDataAccess.Client;
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
    public partial class ChinhSuaUser : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        public ChinhSuaUser()
        {
            InitializeComponent();
            conn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Run_USP_ALTERUSER()
        {
            string set_script = "alter session set \"_ORACLE_SCRIPT\" = true";
            OracleCommand set_script_cmd = new OracleCommand(set_script, conn);

            OracleCommand cmd = new OracleCommand("USP_ALTERUSER", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("P_USERNAME", OracleDbType.Varchar2);
            OracleParameter param2 = new OracleParameter("P_USER_NEW_PASSWORD", OracleDbType.Varchar2);

            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);
           
            //set giá trị
            param1.Value = textBoxTaiKhoan.Text;
            param2.Value = textBoxMatKhau.Text;

            try
            {
                set_script_cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Chỉnh sửa user thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chỉnh sửa user thất bại, mã lỗi: " + ex.Message);
            }

        }

        private void textBoxTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            Run_USP_ALTERUSER();
        }
    }
}
