using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHANHE1;
using Oracle.ManagedDataAccess.Client;
using System.Threading;
using PHANHE1.TruongDeAn;
using PHANHE1.NhanVien;
using PHANHE1.NhanSu;
using PHANHE1.QLTrucTiep;
using PHANHE1.TaiChinh;
using PHANHE1.TruongPhong;
using static PHANHE1.ThemTable;
using System.Data.SqlClient;

namespace PHANHE1
{
    public partial class Login : Form
    {
        public static string connectionString = "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)" + "(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));";
        public Login()
        {
            InitializeComponent();
        }

        //string userAdmin = "ADMIN_PRJ";

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool IsUserRole(string username, string roleToCheck)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string roleQuery = "SELECT granted_role FROM user_role_privs WHERE username = '" + username + "'";
                
                OracleCommand cmd = new OracleCommand(roleQuery, conn);
                cmd.Parameters.Add(new OracleParameter("username", username.ToUpper()));

                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();

                List<string> roles = new List<string>();
                while (reader.Read())
                {
                    roles.Add(reader["granted_role"].ToString());
                }
                conn.Close();

                return roles.Contains(roleToCheck.ToUpper());
            }
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
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

                    if (IsUserRole(username, "DBA"))
                    {
                        Main openDba = new Main(username);
                        openDba.Show();
                       
                    }
                    else if (IsUserRole(username, "RL_TRUONGDA")) 
                    {
                        TruongDeAn.Main_TruongDeAn openTruongDean = new Main_TruongDeAn(username);
                        openTruongDean.Show();
                    }
                    else if (IsUserRole(username, "RL_NHANVIEN"))
                    {
                        NhanVien.Main_NhanVien openNhanVien = new Main_NhanVien(username, userAdmin);
                        openNhanVien.Show();
                    }
                    else if (IsUserRole(username, "RL_NHANSU"))
                    {
                        NhanSu.Main_NhanSu openNhanSu = new Main_NhanSu();
                        openNhanSu.Show();
                    }
                    else if (IsUserRole(username, "RL_QLTRUCTIEP"))
                    {
                        QLTrucTiep.Main_QLTrucTiep openQLTrucTiep = new Main_QLTrucTiep();
                        openQLTrucTiep.Show();
                    }
                    else if (IsUserRole(username, "RL_TAICHINH"))
                    {
                        TaiChinh.Main_TaiChinh openTaiChinh = new Main_TaiChinh();
                        openTaiChinh.Show();
                    }
                    else if (IsUserRole(username, "RL_TRUONGPHONG"))
                    {
                        TruongPhong.Main_TruongPhong openTruongPhong = new Main_TruongPhong();
                        openTruongPhong.Show();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy user", "Thông báo");
                    }
                }
                catch (Oracle.ManagedDataAccess.Client.OracleException ex)
                {
                    if (ex.Number == 1017) // ORA-01017: invalid username/password; logon denied
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng kiểm tra lại.", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

       
    }
}