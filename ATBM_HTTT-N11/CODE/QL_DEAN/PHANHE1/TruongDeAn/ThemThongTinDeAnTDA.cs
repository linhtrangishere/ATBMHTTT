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
    public partial class ThemThongTinDeAnTDA : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ThemThongTinDeAnTDA(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListThongTinDeAnTDA = conn.CreateCommand();
            getListThongTinDeAnTDA.CommandText = "SELECT * FROM " + userAdmin + " .DEAN";
            getListThongTinDeAnTDA.CommandType = CommandType.Text;
            OracleDataReader temp = getListThongTinDeAnTDA.ExecuteReader();
            DataTable table_DSDeAnTC = new DataTable();
            table_DSDeAnTC.Load(temp);
            dataGridViewThemThongTinDeAnTDA.DataSource = table_DSDeAnTC;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand updateNhanVienTDA = new OracleCommand(userAdmin + ".USP_UPDATE_NHANVIEN_NHANVIEN", conn);
                updateNhanVienTDA.CommandType = CommandType.StoredProcedure;

                updateNhanVienTDA.Parameters.Add("p_mada", OracleDbType.Date).Value = textBoxMaDeAn.Text.Trim();
                updateNhanVienTDA.Parameters.Add("p_tenda", OracleDbType.Date).Value = textBoxTenDeAn.Text.Trim();
                updateNhanVienTDA.Parameters.Add("p_ngaybatdau", OracleDbType.NVarchar2).Value = dateTimePickerNgayBatDau.Value;
                updateNhanVienTDA.Parameters.Add("p_phong", OracleDbType.Varchar2).Value = comboBoxPhongBan.Text.Trim();

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

        private void ThemThongTinDeAnTDA_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private void LoadDataToComboBox()
        {
            OracleCommand getPhongBanDataTDA = conn.CreateCommand();
            getPhongBanDataTDA.CommandText = "SELECT MAPB FROM " + userAdmin + " .PHONGBAN";
            getPhongBanDataTDA.CommandType = CommandType.Text;
            OracleDataReader dataReader = getPhongBanDataTDA.ExecuteReader();

            comboBoxPhongBan.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxPhongBan.Items.Add(dataReader["MAPB"].ToString());
            }
        }

        private void LoadData()
        {
            OracleCommand getNhanVienDataTDA = conn.CreateCommand();
            getNhanVienDataTDA.CommandText = "SELECT * FROM " + userAdmin + " .DEAN";
            getNhanVienDataTDA.CommandType = CommandType.Text;
            getNhanVienDataTDA.Parameters.Add("MADA", OracleDbType.Varchar2).Value = userAdmin; // Giả sử userAdmin chính là mã nhân viên
            OracleDataReader dataReader = getNhanVienDataTDA.ExecuteReader();

            if (dataReader.Read())
            {
                textBoxMaDeAn.Text = dataReader["MADA"].ToString();
                textBoxTenDeAn.Text = dataReader["TENDA"].ToString();
                dateTimePickerNgayBatDau.Value = Convert.ToDateTime(dataReader["NGAYBD"]);
                comboBoxPhongBan.Text = dataReader["PHONG"].ToString();
            }
        }
    }
}
