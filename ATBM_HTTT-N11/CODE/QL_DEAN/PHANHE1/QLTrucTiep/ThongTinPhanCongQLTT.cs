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
    public partial class ThongTinPhanCongQLTT : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ThongTinPhanCongQLTT(String usrAdmin)
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

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListThongTinPhanCongQLTT = conn.CreateCommand();
            getListThongTinPhanCongQLTT.CommandText = "SELECT * FROM " + userAdmin + " .UV_NHANVIEN_PHANCONG";
            getListThongTinPhanCongQLTT.CommandType = CommandType.Text;
            OracleDataReader temp = getListThongTinPhanCongQLTT.ExecuteReader();
            DataTable table_DSDeAnQLTT = new DataTable();
            table_DSDeAnQLTT.Load(temp);
            dataGridViewThongTinPhanCongQLTT.DataSource = table_DSDeAnQLTT;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMaDeAn.Text))
            {
                MessageBox.Show("Vui lòng chọn đề án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OracleCommand getListPhongBanQLTT = conn.CreateCommand();
            getListPhongBanQLTT.CommandText = "SELECT * FROM " + userAdmin + " .UV_NHANVIEN_PHANCONG " + " WHERE MADA LIKE UPPER('%" + comboBoxMaDeAn.Text.Trim() + "%')";
            getListPhongBanQLTT.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhongBanQLTT.ExecuteReader();
            DataTable table_DSPhongBanQLTT = new DataTable();
            table_DSPhongBanQLTT.Load(temp);
            dataGridViewThongTinPhanCongQLTT.DataSource = table_DSPhongBanQLTT;
        }

        private void ThongTinPhanCongQLTT_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private void LoadDataToComboBox()
        {
            OracleCommand getPhongBanDataQLTT = conn.CreateCommand();
            getPhongBanDataQLTT.CommandText = "SELECT MADA FROM " + userAdmin + " .UV_NHANVIEN_PHANCONG";
            getPhongBanDataQLTT.CommandType = CommandType.Text;
            OracleDataReader dataReader = getPhongBanDataQLTT.ExecuteReader();

            comboBoxMaDeAn.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxMaDeAn.Items.Add(dataReader["MADA"].ToString());
            }
        }
    }
}
