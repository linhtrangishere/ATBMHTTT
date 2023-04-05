﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace PHANHE1
{
    public partial class Login : Form
    {
        public static string connectionString = "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)" + "(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));";
        public Login()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {   
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = textBoxTaiKhoan.Text;
            string password = textBoxMatKhau.Text;
            connectionString = connectionString + "User ID = " + username + "; Password = " + password + ";";
            if (username == "")
            {
                MessageBox.Show("Xin vui lòng nhập tên đăng nhập", "Thông báo");
            }
            else if (password == "")
            {
                MessageBox.Show("Xin vui lòng nhập mật khẩu", "Thông báo");
            }
            else
            {
                try
                {
                    OracleConnection conn = new OracleConnection(connectionString);
                    conn.Open();
                    MessageBox.Show("Connect sucessfully");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }

        }
        
    }
}