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

namespace PHANHE1.TruongDeAn
{
    public partial class ThongTinCaNhanTDA : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        String username = "";
        public ThongTinCaNhanTDA(String usrAdmin, String username)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
            this.username = username;
        }

        private void panelThongTinCaNhanQLTT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand updateNhanVienTDA = new OracleCommand(userAdmin + ".USP_UPDATE_NHANVIEN_NHANVIEN", conn);
                updateNhanVienTDA.CommandType = CommandType.StoredProcedure;

                updateNhanVienTDA.Parameters.Add("p_ngaysinh", OracleDbType.Date).Value = dateTimePickerNgaySinh.Value;
                updateNhanVienTDA.Parameters.Add("p_diachi", OracleDbType.NVarchar2).Value = textBoxDiaChi.Text.Trim();
                updateNhanVienTDA.Parameters.Add("p_sodt", OracleDbType.Varchar2).Value = textBoxSDT.Text.Trim();

                OracleParameter outMessageParam = new OracleParameter("p_out_message", OracleDbType.NVarchar2, 500);
                outMessageParam.Direction = ParameterDirection.Output;
                updateNhanVienTDA.Parameters.Add(outMessageParam);

                updateNhanVienTDA.ExecuteNonQuery();
                string outMessage = outMessageParam.Value.ToString();
                MessageBox.Show(outMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData(); // Tải lại dữ liệu sau khi cập nhật
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThongTinCaNhanTDA_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            OracleCommand getNhanVienDataTDA = conn.CreateCommand();
            getNhanVienDataTDA.CommandText = "SELECT * FROM " + userAdmin + " .UV_NHANVIEN_NHANVIEN";
            getNhanVienDataTDA.CommandType = CommandType.Text;
            getNhanVienDataTDA.Parameters.Add("MANV", OracleDbType.Varchar2).Value = userAdmin; // Giả sử userAdmin chính là mã nhân viên
            OracleDataReader dataReader = getNhanVienDataTDA.ExecuteReader();

            if (dataReader.Read())
            {
                labelMaNVValue.Text = dataReader["MANV"].ToString();
                labelTenNVValue.Text = dataReader["TENNV"].ToString();
                labelPhaiValue.Text = dataReader["PHAI"].ToString();
                dateTimePickerNgaySinh.Value = Convert.ToDateTime(dataReader["NGAYSINH"]);
                textBoxDiaChi.Text = dataReader["DIACHI"].ToString();
                textBoxSDT.Text = dataReader["SODT"].ToString();
                //decrypt LUONG TRUONG DE AN
                OracleCommand Cmd = new OracleCommand(userAdmin + ".FUNC_LOGIN_DECRYPT_LUONG", conn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("returnVal", OracleDbType.Varchar2, 200);
                Cmd.Parameters["returnVal"].Direction = ParameterDirection.ReturnValue;
                Cmd.Parameters.Add("cur_user", OracleDbType.Varchar2);
                Cmd.Parameters["cur_user"].Value = username;
                Cmd.ExecuteNonQuery();
                string luong_val = Cmd.Parameters["returnVal"].Value.ToString();
                labelLuongValue.Text = luong_val;
                //decrypt PHUCAP TRUONG AN
                OracleCommand Cmd2 = new OracleCommand(userAdmin + ".FUNC_LOGIN_DECRYPT_PHUCAP", conn);
                Cmd2.CommandType = CommandType.StoredProcedure;
                Cmd2.Parameters.Add("returnVal2", OracleDbType.Varchar2, 200);
                Cmd2.Parameters["returnVal2"].Direction = ParameterDirection.ReturnValue;
                Cmd2.Parameters.Add("cur_user", OracleDbType.Varchar2);
                Cmd2.Parameters["cur_user"].Value = username;
                Cmd2.ExecuteNonQuery();
                string phucap_val = Cmd2.Parameters["returnVal2"].Value.ToString();
                labelPhuCapValue.Text = phucap_val;
                labelNQLValue.Text = dataReader["MANQL"].ToString();
                labelMaPhongValue.Text = dataReader["PHG"].ToString();
            }
        }
    }
}
