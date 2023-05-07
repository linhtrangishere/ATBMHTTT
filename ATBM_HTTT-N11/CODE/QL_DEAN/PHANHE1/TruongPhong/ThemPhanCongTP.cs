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
    public partial class ThemPhanCongTP : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ThemPhanCongTP(String usrAdmin)
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
            OracleCommand getListPhanCong = conn.CreateCommand();
            getListPhanCong.CommandText = "SELECT * FROM " + userAdmin + " .UV_TRUONGPHONG_PHANCONG ORDER BY MANV ASC";
            getListPhanCong.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhanCong.ExecuteReader();
            DataTable table_DSPhanCong = new DataTable();
            table_DSPhanCong.Load(temp);
            dataGridViewThemThongTinDeAnTDA.DataSource = table_DSPhanCong;
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

        private void dataGridViewThemThongTinDeAnTDA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNgayBatDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ThemPhanCongTP_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox_MaNV();
            LoadDataToComboBox_MaDA();

        }

        private void comboBoxDeAn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand insertPhanCongCmd = new OracleCommand(userAdmin + ".USP_THEM_PHANCONG_TP", conn);
                insertPhanCongCmd.CommandType = CommandType.StoredProcedure;

                insertPhanCongCmd.Parameters.Add("p_manv", OracleDbType.Varchar2).Value = comboBoxNhanVien.SelectedItem.ToString();
                insertPhanCongCmd.Parameters.Add("p_mada", OracleDbType.Varchar2).Value = comboBoxDeAn.SelectedItem.ToString();
                insertPhanCongCmd.Parameters.Add("p_ngaybatdau", OracleDbType.Date).Value = dateTimePickerNgayBatDau.Value;

                OracleParameter outMessageParam = new OracleParameter("p_out_message", OracleDbType.NVarchar2, 500);
                outMessageParam.Direction = ParameterDirection.Output;
                insertPhanCongCmd.Parameters.Add(outMessageParam);

                insertPhanCongCmd.ExecuteNonQuery();
                string outMessage = outMessageParam.Value.ToString();
                MessageBox.Show(outMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
