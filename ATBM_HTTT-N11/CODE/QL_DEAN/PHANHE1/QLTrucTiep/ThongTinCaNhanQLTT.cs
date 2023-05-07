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

namespace PHANHE1.QLTrucTiep
{
    public partial class ThongTinCaNhanQLTT : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ThongTinCaNhanQLTT(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void ThongTinCaNhanQLTT_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            OracleCommand getViewNhanVienQLTT = conn.CreateCommand();
            getViewNhanVienQLTT.CommandText = "SELECT * FROM " + userAdmin + " .UV_NHANVIEN_NHANVIEN";
            getViewNhanVienQLTT.CommandType = CommandType.Text;
            getViewNhanVienQLTT.Parameters.Add("MANV", OracleDbType.Varchar2).Value = userAdmin; // Giả sử userAdmin chính là mã nhân viên
            OracleDataReader dataReader = getViewNhanVienQLTT.ExecuteReader();

            if (dataReader.Read())
            {
                labelMaNVValue.Text = dataReader["MANV"].ToString();
                labelTenNVValue.Text = dataReader["TENNV"].ToString();
                labelPhaiValue.Text = dataReader["PHAI"].ToString();
                dateTimePickerNgaySinh.Value = Convert.ToDateTime(dataReader["NGAYSINH"]);
                textBoxDiaChi.Text = dataReader["DIACHI"].ToString();
                textBoxSDT.Text = dataReader["SODT"].ToString();
                labelLuongValue.Text = dataReader["LUONG"].ToString();
                labelPhuCapValue.Text = dataReader["PHUCAP"].ToString();
                labelNQLValue.Text = dataReader["MANQL"].ToString();
                labelMaPhongValue.Text = dataReader["PHG"].ToString();
            }
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand updateNhanVienQLTT = new OracleCommand(userAdmin + ".USP_UPDATE_NHANVIEN_NHANVIEN", conn);
                updateNhanVienQLTT.CommandType = CommandType.StoredProcedure;

                updateNhanVienQLTT.Parameters.Add("p_ngaysinh", OracleDbType.Date).Value = dateTimePickerNgaySinh.Value;
                updateNhanVienQLTT.Parameters.Add("p_diachi", OracleDbType.NVarchar2).Value = textBoxDiaChi.Text.Trim();
                updateNhanVienQLTT.Parameters.Add("p_sodt", OracleDbType.Varchar2).Value = textBoxSDT.Text.Trim();

                OracleParameter outMessageParam = new OracleParameter("p_out_message", OracleDbType.NVarchar2, 500);
                outMessageParam.Direction = ParameterDirection.Output;
                updateNhanVienQLTT.Parameters.Add(outMessageParam);

                updateNhanVienQLTT.ExecuteNonQuery();
                string outMessage = outMessageParam.Value.ToString();
                MessageBox.Show(outMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData(); // Tải lại dữ liệu sau khi cập nhật
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
