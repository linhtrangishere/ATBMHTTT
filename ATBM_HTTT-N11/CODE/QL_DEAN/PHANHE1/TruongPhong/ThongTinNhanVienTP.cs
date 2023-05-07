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
    public partial class ThongTinNhanVienTP : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ThongTinNhanVienTP(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void ThongTinNhanVienTP_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListNhanVien = conn.CreateCommand();
            getListNhanVien.CommandText = "SELECT * FROM " + userAdmin + " .UV_TRUONGPHONG_NHANVIEN ORDER BY MANV ASC";
            getListNhanVien.CommandType = CommandType.Text;
            OracleDataReader temp = getListNhanVien.ExecuteReader();
            DataTable table_DSNhanVien = new DataTable();
            table_DSNhanVien.Load(temp);
            dataGridViewThongTinNhanVienTP.DataSource = table_DSNhanVien;
        }
        private void LoadDataToComboBox()
        {
            OracleCommand getNhanVienData = conn.CreateCommand();
            getNhanVienData.CommandText = "SELECT MANV FROM " + userAdmin + " .UV_TRUONGPHONG_NHANVIEN";
            getNhanVienData.CommandType = CommandType.Text;
            OracleDataReader dataReader = getNhanVienData.ExecuteReader();

            comboBoxMaNhanVien.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxMaNhanVien.Items.Add(dataReader["MANV"].ToString());
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OracleCommand getListNhanVien = conn.CreateCommand();
            getListNhanVien.CommandText = "SELECT * FROM " + userAdmin + " .UV_TRUONGPHONG_NHANVIEN " + " WHERE MANV LIKE UPPER('%" + comboBoxMaNhanVien.Text.Trim() + "%')";
            getListNhanVien.CommandType = CommandType.Text;
            OracleDataReader temp = getListNhanVien.ExecuteReader();
            DataTable table_DSNhanVien = new DataTable();
            table_DSNhanVien.Load(temp);
            dataGridViewThongTinNhanVienTP.DataSource = table_DSNhanVien;
        }

        private void comboBoxMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewThongTinNhanVienTP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
