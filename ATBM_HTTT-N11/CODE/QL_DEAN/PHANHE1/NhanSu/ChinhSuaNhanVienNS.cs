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
    public partial class ChinhSuaNhanVienNS : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ChinhSuaNhanVienNS(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;

        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadDataToComboBox_MaNV()
        {
            OracleCommand getMaNVData = conn.CreateCommand();
            getMaNVData.CommandText = "SELECT MANV FROM " + userAdmin + " .UV_NHANSU_NHANVIEN";
            getMaNVData.CommandType = CommandType.Text;
            OracleDataReader dataReader = getMaNVData.ExecuteReader();

            comboBoxMaNV.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxMaNV.Items.Add(dataReader["MANV"].ToString());
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
        
        
        private void dataGridViewChinhSuaNhanVienNS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewChinhSuaNhanVienNS.Rows[e.RowIndex];

                comboBoxMaNV.SelectedItem = row.Cells["MANV"].Value.ToString();
                textBoxTenNV.Text = row.Cells["TENNV"].Value.ToString();
                comboBoxPhai.SelectedItem = row.Cells["PHAI"].Value.ToString();
                dateTimePickerNgaySinh.Value = Convert.ToDateTime(row.Cells["NGAYSINH"].Value);
                textBoxDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
                textBoxSDT.Text = row.Cells["SODT"].Value.ToString();
                comboBoxVaiTro.SelectedItem = row.Cells["VAITRO"].Value.ToString();
                textBoxMaNQL.Text = row.Cells["MANQL"].Value.ToString();
                textBoxMaPhong.Text = row.Cells["PHG"].Value.ToString();
            }
        }

        private void ChinhSuaNhanVienNS_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox_MaNV();
            LoadDataToComboBox_Phai();
            LoadDataToComboBox_VaiTro();
            dataGridViewChinhSuaNhanVienNS.CellClick += dataGridViewChinhSuaNhanVienNS_CellClick;
        }

        private void comboBoxMaNV_SelectedIndexChanged(object sender, EventArgs e)
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

        private void buttonChinhSua_Click(object sender, EventArgs e)
        {

            try
            {
                OracleCommand capNhatNhanVienCmd = new OracleCommand(userAdmin + ".USP_CAPNHAT_NHANVIEN_NS", conn);
                capNhatNhanVienCmd.CommandType = CommandType.StoredProcedure;

                capNhatNhanVienCmd.Parameters.Add("p_manv", OracleDbType.Varchar2).Value = comboBoxMaNV.SelectedItem.ToString();
                capNhatNhanVienCmd.Parameters.Add("p_tennv", OracleDbType.Varchar2).Value = textBoxTenNV.Text;
                capNhatNhanVienCmd.Parameters.Add("p_phai", OracleDbType.Varchar2).Value = comboBoxPhai.SelectedItem.ToString();
                capNhatNhanVienCmd.Parameters.Add("p_ngaysinh", OracleDbType.Date).Value = dateTimePickerNgaySinh.Value;
                capNhatNhanVienCmd.Parameters.Add("p_diachi", OracleDbType.Varchar2).Value = textBoxDiaChi.Text;
                capNhatNhanVienCmd.Parameters.Add("p_sodt", OracleDbType.Varchar2).Value = textBoxSDT.Text;
                capNhatNhanVienCmd.Parameters.Add("p_vaitro", OracleDbType.Varchar2).Value = comboBoxVaiTro.Text;
                capNhatNhanVienCmd.Parameters.Add("p_manql", OracleDbType.Varchar2).Value = textBoxMaNQL.Text;
                capNhatNhanVienCmd.Parameters.Add("p_phg", OracleDbType.Varchar2).Value = textBoxMaPhong.Text;

                OracleParameter outMessageParam = new OracleParameter("p_out_message", OracleDbType.NVarchar2, 500);
                outMessageParam.Direction = ParameterDirection.Output;
                capNhatNhanVienCmd.Parameters.Add(outMessageParam);

                capNhatNhanVienCmd.ExecuteNonQuery();
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
            OracleCommand getListPhongBan = conn.CreateCommand();
            getListPhongBan.CommandText = "SELECT * FROM " + userAdmin + " .UV_NHANSU_NHANVIEN ORDER BY MANV ASC";
            getListPhongBan.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhongBan.ExecuteReader();
            DataTable table_DSPhongBan = new DataTable();
            table_DSPhongBan.Load(temp);
            dataGridViewChinhSuaNhanVienNS.DataSource = table_DSPhongBan;
        }
        

        private void dataGridViewChinhSuaNhanVienNS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelChinhSuaNhanVienNS_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
