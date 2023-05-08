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
    public partial class XemThongTinNhanVienTC : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public XemThongTinNhanVienTC(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XemThongTinNhanVienTC_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private void LoadDataToComboBox()
        {
            OracleCommand getPhongBanDataTC = conn.CreateCommand();
            getPhongBanDataTC.CommandText = "SELECT MANV FROM " + userAdmin + " .NHANVIEN";
            getPhongBanDataTC.CommandType = CommandType.Text;
            OracleDataReader dataReader = getPhongBanDataTC.ExecuteReader();

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
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OracleCommand getListPhongBanTC = conn.CreateCommand();
            getListPhongBanTC.CommandText = "SELECT * FROM " + userAdmin + " .NHANVIEN " + " WHERE MANV LIKE UPPER('%" + comboBoxMaNhanVien.Text.Trim() + "%')";
            getListPhongBanTC.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhongBanTC.ExecuteReader();
            DataTable table_DSPhongBanTC = new DataTable();
            table_DSPhongBanTC.Load(temp);
            dataGridViewThongTinNhanVienTC.DataSource = table_DSPhongBanTC;
        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListThongTinNhanVienTC = conn.CreateCommand();
            getListThongTinNhanVienTC.CommandText = "SELECT * FROM " + userAdmin + " .NHANVIEN";
            getListThongTinNhanVienTC.CommandType = CommandType.Text;
            OracleDataReader temp = getListThongTinNhanVienTC.ExecuteReader();
            DataTable table_DSDeAnTC = new DataTable();
            table_DSDeAnTC.Load(temp);
            dataGridViewThongTinNhanVienTC.DataSource = table_DSDeAnTC;
        }
    }
}
