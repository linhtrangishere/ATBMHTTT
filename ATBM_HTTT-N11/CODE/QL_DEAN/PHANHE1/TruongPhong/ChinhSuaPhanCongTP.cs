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
    public partial class ChinhSuaPhanCongTP : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ChinhSuaPhanCongTP(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChinhSuaPhanCongTP_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox_MaNV();
            LoadDataToComboBox_MaDA();
            dataGridViewThemThongTinDeAnTDA.CellClick += dataGridViewThemThongTinDeAnTDA_CellClick;
        }
        private void dataGridViewThemThongTinDeAnTDA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewThemThongTinDeAnTDA.Rows[e.RowIndex];
                comboBoxNhanVien.SelectedItem = row.Cells["MANV"].Value.ToString();
                comboBoxDeAn.SelectedItem = row.Cells["MADA"].Value.ToString();
                dateTimePickerNgayBatDau.Value = Convert.ToDateTime(row.Cells["THOIGIAN"].Value);
            }
        }

        private void comboBoxNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDeAn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void LoadDataToComboBox_MaNV()
        {
            OracleCommand getMaNVData = conn.CreateCommand();
            getMaNVData.CommandText = "SELECT DISTINCT MANV FROM " + userAdmin + " .UV_TRUONGPHONG_PHANCONG";
            getMaNVData.CommandType = CommandType.Text;
            OracleDataReader dataReader = getMaNVData.ExecuteReader();

            comboBoxNhanVien.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxNhanVien.Items.Add(dataReader["MANV"].ToString());
            }
        }
        private void LoadDataToComboBox_MaDA()
        {
            OracleCommand getMaDAData = conn.CreateCommand();
            getMaDAData.CommandText = "SELECT DISTINCT MADA FROM " + userAdmin + " .UV_TRUONGPHONG_PHANCONG";
            getMaDAData.CommandType = CommandType.Text;
            OracleDataReader dataReader = getMaDAData.ExecuteReader();

            comboBoxDeAn.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxDeAn.Items.Add(dataReader["MADA"].ToString());
            }
        }
        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand updatePhanCongCmd = new OracleCommand(userAdmin + ".USP_UPDATE_PHANCONG_TP", conn);
                updatePhanCongCmd.CommandType = CommandType.StoredProcedure;

                updatePhanCongCmd.Parameters.Add("p_manv", OracleDbType.Varchar2).Value = comboBoxNhanVien.SelectedItem.ToString();
                updatePhanCongCmd.Parameters.Add("p_mada", OracleDbType.Varchar2).Value = comboBoxDeAn.SelectedItem.ToString();
                updatePhanCongCmd.Parameters.Add("p_thoigian", OracleDbType.Date).Value = dateTimePickerNgayBatDau.Value;

                OracleParameter outMessageParam = new OracleParameter("p_out_message", OracleDbType.NVarchar2, 500);
                outMessageParam.Direction = ParameterDirection.Output;
                updatePhanCongCmd.Parameters.Add(outMessageParam);

                updatePhanCongCmd.ExecuteNonQuery();
                string outMessage = outMessageParam.Value.ToString();
                MessageBox.Show(outMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //LoadData(); // Tải lại dữ liệu sau khi cập nhật (nếu cần)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListPhanCong = conn.CreateCommand();
            getListPhanCong.CommandText = "SELECT * FROM " + userAdmin + " .UV_TRUONGPHONG_PHANCONG ORDER BY MANV ASC";
            getListPhanCong.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhanCong.ExecuteReader();
            DataTable table_DSPhanCong = new DataTable();
            table_DSPhanCong.Load(temp);
            dataGridViewThemThongTinDeAnTDA.DataSource = table_DSPhanCong;
        }

        private void dataGridViewThemThongTinDeAnTDA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePickerNgayBatDau_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
