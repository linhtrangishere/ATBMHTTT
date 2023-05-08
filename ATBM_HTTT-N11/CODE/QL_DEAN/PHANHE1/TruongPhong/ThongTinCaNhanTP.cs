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

namespace PHANHE1.TruongPhong
{
    public partial class ThongTinCaNhanTP : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        String username = "";
        public ThongTinCaNhanTP(String usrAdmin, String username)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
            this.username = username;
        }

        private void ThongTinCaNhanTP_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            OracleCommand getNhanVienData = conn.CreateCommand();
            getNhanVienData.CommandText = "SELECT * FROM " + userAdmin + " .UV_NHANVIEN_NHANVIEN";
            getNhanVienData.CommandType = CommandType.Text;
            getNhanVienData.Parameters.Add("MANV", OracleDbType.Varchar2).Value = userAdmin; // Giả sử userAdmin chính là mã nhân viên
            OracleDataReader dataReader = getNhanVienData.ExecuteReader();

            if (dataReader.Read())
            {
                labelMaNVValue.Text = dataReader["MANV"].ToString();
                labelTenNVValue.Text = dataReader["TENNV"].ToString();
                labelPhaiValue.Text = dataReader["PHAI"].ToString();
                dateTimePickerNgaySinh.Value = Convert.ToDateTime(dataReader["NGAYSINH"]);
                textBoxDiaChi.Text = dataReader["DIACHI"].ToString();
                textBoxSDT.Text = dataReader["SODT"].ToString();
                //decrypt LUONG QL TRUC TIEP
                OracleCommand Cmd = new OracleCommand(userAdmin + ".FUNC_LOGIN_DECRYPT_LUONG", conn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("returnVal", OracleDbType.Varchar2, 200);
                Cmd.Parameters["returnVal"].Direction = ParameterDirection.ReturnValue;
                Cmd.Parameters.Add("cur_user", OracleDbType.Varchar2);
                Cmd.Parameters["cur_user"].Value = username;
                Cmd.ExecuteNonQuery();
                string luong_val = Cmd.Parameters["returnVal"].Value.ToString();
                labelLuongValue.Text = luong_val;
                //decrypt PHUCAP QL TRUC TIEP
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

        private void labelMaNVValue_Click(object sender, EventArgs e)
        {

        }

        private void labelTenNVValue_Click(object sender, EventArgs e)
        {

        }

        private void panelChildFormTTCN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelPhaiValue_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLuongValue_Click(object sender, EventArgs e)
        {

        }

        private void labelPhuCapValue_Click(object sender, EventArgs e)
        {

        }

        private void labelNQLValue_Click(object sender, EventArgs e)
        {

        }

        private void labelMaPhongValue_Click(object sender, EventArgs e)
        {

        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand updateNhanVienCmd = new OracleCommand(userAdmin + ".USP_UPDATE_NHANVIEN_NHANVIEN", conn);
                updateNhanVienCmd.CommandType = CommandType.StoredProcedure;

                updateNhanVienCmd.Parameters.Add("p_ngaysinh", OracleDbType.Date).Value = dateTimePickerNgaySinh.Value;
                updateNhanVienCmd.Parameters.Add("p_diachi", OracleDbType.NVarchar2).Value = textBoxDiaChi.Text.Trim();
                updateNhanVienCmd.Parameters.Add("p_sodt", OracleDbType.Varchar2).Value = textBoxSDT.Text.Trim();

                OracleParameter outMessageParam = new OracleParameter("p_out_message", OracleDbType.NVarchar2, 500);
                outMessageParam.Direction = ParameterDirection.Output;
                updateNhanVienCmd.Parameters.Add(outMessageParam);

                updateNhanVienCmd.ExecuteNonQuery();
                string outMessage = outMessageParam.Value.ToString();
                MessageBox.Show(outMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData(); // Tải lại dữ liệu sau khi cập nhật
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelThongTinCaNhanTDA_Click(object sender, EventArgs e)
        {

        }
    }
}
