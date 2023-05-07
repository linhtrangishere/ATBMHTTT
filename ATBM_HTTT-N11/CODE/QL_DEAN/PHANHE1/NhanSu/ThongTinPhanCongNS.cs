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
    public partial class ThongTinPhanCongNS : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);

        String userAdmin = "";
        public ThongTinPhanCongNS(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void ThongTinPhanCongNS_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListPhanCong = conn.CreateCommand();
            getListPhanCong.CommandText = "SELECT * FROM " + userAdmin + " .UV_NHANVIEN_PHANCONG";
            getListPhanCong.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhanCong.ExecuteReader();
            DataTable table_DSPhanCong = new DataTable();
            table_DSPhanCong.Load(temp);
            dataGridViewThongTinPhanCongNS.DataSource = table_DSPhanCong;
        }
        private void LoadDataToComboBox()
        {
            OracleCommand getDeAnData = conn.CreateCommand();
            getDeAnData.CommandText = "SELECT MADA FROM " + userAdmin + " .UV_NHANVIEN_PHANCONG";
            getDeAnData.CommandType = CommandType.Text;
            OracleDataReader dataReader = getDeAnData.ExecuteReader();

            comboBoxMaDeAn.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxMaDeAn.Items.Add(dataReader["MADA"].ToString());
            }
        }

        private void comboBoxMaDeAn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMaDeAn.Text))
            {
                MessageBox.Show("Vui lòng chọn đề án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OracleCommand getListPhanCong = conn.CreateCommand();
            //getListPhanCong.CommandText = "SELECT * FROM " + userAdmin + " .UV_NHANVIEN_PHANCONG";
            getListPhanCong.CommandText = "SELECT * FROM " + userAdmin + " .UV_NHANVIEN_PHANCONG " + " WHERE MADA LIKE UPPER('%" + comboBoxMaDeAn.Text.Trim() + "%')";
            getListPhanCong.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhanCong.ExecuteReader();
            DataTable table_DSPhanCong = new DataTable();
            table_DSPhanCong.Load(temp);
            dataGridViewThongTinPhanCongNS.DataSource = table_DSPhanCong;
        }

        private void dataGridViewThongTinPhanCongNS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
