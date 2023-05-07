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
    public partial class ThongTinPhanCongTDA : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ThongTinPhanCongTDA(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void textBoxMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelThongTinCaNhanQLTT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMaDeAn.Text))
            {
                MessageBox.Show("Vui lòng chọn đề án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OracleCommand getListPhongBanTDA = conn.CreateCommand();
            getListPhongBanTDA.CommandText = "SELECT * FROM " + userAdmin + " .UV_NHANVIEN_PHANCONG " + " WHERE MADA LIKE UPPER('%" + comboBoxMaDeAn.Text.Trim() + "%')";
            getListPhongBanTDA.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhongBanTDA.ExecuteReader();
            DataTable table_DSPhongBanTDA = new DataTable();
            table_DSPhongBanTDA.Load(temp);
            dataGridViewThongTinPhanCongTDA.DataSource = table_DSPhongBanTDA;
        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListThongTinPhanCongTDA = conn.CreateCommand();
            getListThongTinPhanCongTDA.CommandText = "SELECT * FROM " + userAdmin + " .UV_NHANVIEN_PHANCONG";
            getListThongTinPhanCongTDA.CommandType = CommandType.Text;
            OracleDataReader temp = getListThongTinPhanCongTDA.ExecuteReader();
            DataTable table_DSDeAnTDA = new DataTable();
            table_DSDeAnTDA.Load(temp);
            dataGridViewThongTinPhanCongTDA.DataSource = table_DSDeAnTDA;
        }

        private void ThongTinPhanCongTDA_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private void LoadDataToComboBox()
        {
            OracleCommand getPhongBanDataTDA = conn.CreateCommand();
            getPhongBanDataTDA.CommandText = "SELECT MADA FROM " + userAdmin + " .UV_NHANVIEN_PHANCONG";
            getPhongBanDataTDA.CommandType = CommandType.Text;
            OracleDataReader dataReader = getPhongBanDataTDA.ExecuteReader();

            comboBoxMaDeAn.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxMaDeAn.Items.Add(dataReader["MADA"].ToString());
            }
        }
    }
}
