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
    public partial class QuanLyPhanCongQLTT : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public QuanLyPhanCongQLTT(String usrAdmin)
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
            OracleCommand getListQuanLyPhanCongQLTT = conn.CreateCommand();
            getListQuanLyPhanCongQLTT.CommandText = "SELECT * FROM " + userAdmin + " .UV_QLTRUCTIEP_PHANCONG";
            getListQuanLyPhanCongQLTT.CommandType = CommandType.Text;
            OracleDataReader temp = getListQuanLyPhanCongQLTT.ExecuteReader();
            DataTable table_DSDeAnQLTT = new DataTable();
            table_DSDeAnQLTT.Load(temp);
            dataGridViewQuanLyPhanCongQLTT.DataSource = table_DSDeAnQLTT;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OracleCommand getListPhongBanQLTT = conn.CreateCommand();
            getListPhongBanQLTT.CommandText = "SELECT * FROM " + userAdmin + " .UV_QLTRUCTIEP_PHANCONG " + " WHERE MANV LIKE UPPER('%" + comboBoxMaNhanVien.Text.Trim() + "%')";
            getListPhongBanQLTT.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhongBanQLTT.ExecuteReader();
            DataTable table_DSPhongBanQLTT = new DataTable();
            table_DSPhongBanQLTT.Load(temp);
            dataGridViewQuanLyPhanCongQLTT.DataSource = table_DSPhongBanQLTT;
        }

        private void QuanLyPhanCongQLTT_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private void LoadDataToComboBox()
        {
            OracleCommand getPhongBanDataQLTT = conn.CreateCommand();
            getPhongBanDataQLTT.CommandText = "SELECT MANV FROM " + userAdmin + " .UV_QLTRUCTIEP_PHANCONG";
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
