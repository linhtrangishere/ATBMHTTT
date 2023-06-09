﻿using Oracle.ManagedDataAccess.Client;
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
    public partial class XoaRole : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        public XoaRole()
        {
            InitializeComponent();
            conn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Run_USP_DROPROLE()
        {
            //string set_script = "alter session set \"_ORACLE_SCRIPT\" = true";
            //OracleCommand set_script_cmd = new OracleCommand(set_script, conn);

            OracleCommand cmd = new OracleCommand("USP_DROPROLE", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("p_role_name", OracleDbType.Varchar2);
            cmd.Parameters.Add(param1);


            //set giá trị
            param1.Value = textBoxXoaRole.Text;

            try
            {
                //set_script_cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa role thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                textBoxXoaRole.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa role thất bại, mã lỗi: " + ex.Message);
            }

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            Run_USP_DROPROLE();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
