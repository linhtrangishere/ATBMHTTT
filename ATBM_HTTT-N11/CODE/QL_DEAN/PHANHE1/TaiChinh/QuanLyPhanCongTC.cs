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

namespace PHANHE1.TaiChinh
{
    public partial class QuanLyPhanCongTC : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public QuanLyPhanCongTC(String usrAdmin)
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
            OracleCommand getListQuanLyPhanCongTC = conn.CreateCommand();
            getListQuanLyPhanCongTC.CommandText = "SELECT * FROM " + userAdmin + " .PHANCONG";
            getListQuanLyPhanCongTC.CommandType = CommandType.Text;
            OracleDataReader temp = getListQuanLyPhanCongTC.ExecuteReader();
            DataTable table_DSDeAnTC = new DataTable();
            table_DSDeAnTC.Load(temp);
            dataGridViewQuanLyPhanCongTC.DataSource = table_DSDeAnTC;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OracleCommand getListPhongBanTC = conn.CreateCommand();
            getListPhongBanTC.CommandText = "SELECT * FROM " + userAdmin + " .PHANCONG " + " WHERE MANV LIKE UPPER('%" + comboBoxMaNhanVien.Text.Trim() + "%')";
            getListPhongBanTC.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhongBanTC.ExecuteReader();
            DataTable table_DSPhongBanTC = new DataTable();
            table_DSPhongBanTC.Load(temp);
            dataGridViewQuanLyPhanCongTC.DataSource = table_DSPhongBanTC;
        }

        private void QuanLyPhanCongTC_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private void LoadDataToComboBox()
        {
            OracleCommand getPhongBanDataQLTT = conn.CreateCommand();
            getPhongBanDataQLTT.CommandText = "SELECT MANV FROM " + userAdmin + " .PHANCONG";
            getPhongBanDataQLTT.CommandType = CommandType.Text;
            OracleDataReader dataReader = getPhongBanDataQLTT.ExecuteReader();

            comboBoxMaNhanVien.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxMaNhanVien.Items.Add(dataReader["MANV"].ToString());
            }
        }
    }
}
