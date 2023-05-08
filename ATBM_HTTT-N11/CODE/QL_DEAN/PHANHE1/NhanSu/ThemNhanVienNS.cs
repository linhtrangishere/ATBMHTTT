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

namespace PHANHE1.NhanSu
{
    public partial class ThemNhanVienNS : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ThemNhanVienNS(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPhai_SelectedIndexChanged(object sender, EventArgs e)
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

        private void textBoxMaNQL_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMaPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewThemNhanVienNS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand themNhanVienCmd = new OracleCommand(userAdmin + ".USP_THEMNHANVIEN_NS", conn);
                themNhanVienCmd.CommandType = CommandType.StoredProcedure;

                themNhanVienCmd.Parameters.Add("p_MANV", OracleDbType.Varchar2).Value = textBoxMaNV.Text;
                themNhanVienCmd.Parameters.Add("p_TENNV", OracleDbType.Varchar2).Value = textBoxTenNV.Text;
                themNhanVienCmd.Parameters.Add("p_PHAI", OracleDbType.Varchar2).Value = comboBoxPhai.SelectedItem.ToString();
                themNhanVienCmd.Parameters.Add("p_NGAYSINH", OracleDbType.Date).Value = dateTimePickerNgaySinh.Value;
                themNhanVienCmd.Parameters.Add("p_DIACHI", OracleDbType.Varchar2).Value = textBoxDiaChi.Text;
                themNhanVienCmd.Parameters.Add("p_SODT", OracleDbType.Varchar2).Value = textBoxSDT.Text;
                themNhanVienCmd.Parameters.Add("p_VAITRO", OracleDbType.Varchar2).Value = comboBoxVaiTro.SelectedItem.ToString();
                themNhanVienCmd.Parameters.Add("p_MANQL", OracleDbType.Varchar2).Value = comboBoxMaNQL.SelectedItem.ToString();
                themNhanVienCmd.Parameters.Add("p_PHG", OracleDbType.Varchar2).Value = comboBoxPhongBan.SelectedItem.ToString();

                OracleParameter outMessageParam = new OracleParameter("p_out_message", OracleDbType.NVarchar2, 500);
                outMessageParam.Direction = ParameterDirection.Output;
                themNhanVienCmd.Parameters.Add(outMessageParam);

                themNhanVienCmd.ExecuteNonQuery();
                string outMessage = outMessageParam.Value.ToString();
                MessageBox.Show(outMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListNhanVien = conn.CreateCommand();
            getListNhanVien.CommandText = "SELECT * FROM " + userAdmin + " .UV_NHANSU_NHANVIEN ORDER BY MANV ASC";
            getListNhanVien.CommandType = CommandType.Text;
            OracleDataReader temp = getListNhanVien.ExecuteReader();
            DataTable table_DSNhanVien = new DataTable();
            table_DSNhanVien.Load(temp);
            dataGridViewThemNhanVienNS.DataSource = table_DSNhanVien;
        }
        private void LoadDataToComboBox_Phai()
        {
            OracleCommand getMaNVData = conn.CreateCommand();
            getMaNVData.CommandText = "SELECT DISTINCT PHAI FROM " + userAdmin + " .UV_NHANSU_NHANVIEN";
            getMaNVData.CommandType = CommandType.Text;
            OracleDataReader dataReader = getMaNVData.ExecuteReader();

            comboBoxPhai.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxPhai.Items.Add(dataReader["PHAI"].ToString());
            }
        }
        private void LoadDataToComboBox_VaiTro()
        {
            OracleCommand getVaiTroData = conn.CreateCommand();
            getVaiTroData.CommandText = "SELECT DISTINCT VAITRO FROM " + userAdmin + " .UV_NHANSU_NHANVIEN";
            getVaiTroData.CommandType = CommandType.Text;
            OracleDataReader dataReader = getVaiTroData.ExecuteReader();

            comboBoxVaiTro.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxVaiTro.Items.Add(dataReader["VAITRO"].ToString());
            }
        }
        private void LoadDataToComboBox_MaNQL()
        {
            OracleCommand getMaNQLData = conn.CreateCommand();
            getMaNQLData.CommandText = "SELECT MANV FROM " + userAdmin + " .UV_NHANSU_NHANVIEN";
            getMaNQLData.CommandType = CommandType.Text;
            OracleDataReader dataReader = getMaNQLData.ExecuteReader();

            comboBoxMaNQL.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxMaNQL.Items.Add(dataReader["MANV"].ToString());
            }
        }
        private void LoadDataToComboBox_PhongBan()
        {
            OracleCommand getPhongBanData = conn.CreateCommand();
            getPhongBanData.CommandText = "SELECT DISTINCT MAPB FROM " + userAdmin + " .PHONGBAN";
            getPhongBanData.CommandType = CommandType.Text;
            OracleDataReader dataReader = getPhongBanData.ExecuteReader();

            comboBoxPhongBan.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxPhongBan.Items.Add(dataReader["MAPB"].ToString());
            }
        }
        private void ThemNhanVienNS_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox_Phai();
            LoadDataToComboBox_VaiTro();
            LoadDataToComboBox_MaNQL();
            LoadDataToComboBox_PhongBan();
        }

        private void comboBoxMaNQL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
