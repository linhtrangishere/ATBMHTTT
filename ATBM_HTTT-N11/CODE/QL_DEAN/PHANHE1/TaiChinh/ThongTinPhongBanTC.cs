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
    public partial class ThongTinPhongBanTC : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ThongTinPhongBanTC(String usrAdmin)
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
            OracleCommand getListThongTinPhongBanTC = conn.CreateCommand();
            getListThongTinPhongBanTC.CommandText = "SELECT * FROM " + userAdmin + " .PHONGBAN";
            getListThongTinPhongBanTC.CommandType = CommandType.Text;
            OracleDataReader temp = getListThongTinPhongBanTC.ExecuteReader();
            DataTable table_DSDeAnTC = new DataTable();
            table_DSDeAnTC.Load(temp);
            dataGridViewThongTinPhongBanTC.DataSource = table_DSDeAnTC;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMaPhongBan.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OracleCommand getListPhongBanTC = conn.CreateCommand();
            getListPhongBanTC.CommandText = "SELECT * FROM " + userAdmin + " .PHONGBAN " + " WHERE MAPB LIKE UPPER('%" + comboBoxMaPhongBan.Text.Trim() + "%')";
            getListPhongBanTC.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhongBanTC.ExecuteReader();
            DataTable table_DSPhongBanTC = new DataTable();
            table_DSPhongBanTC.Load(temp);
            dataGridViewThongTinPhongBanTC.DataSource = table_DSPhongBanTC;
        }

        private void ThongTinPhongBanTC_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private void LoadDataToComboBox()
        {
            OracleCommand getPhongBanDataTC = conn.CreateCommand();
            getPhongBanDataTC.CommandText = "SELECT MAPB FROM " + userAdmin + " .PHONGBAN";
            getPhongBanDataTC.CommandType = CommandType.Text;
            OracleDataReader dataReader = getPhongBanDataTC.ExecuteReader();

            comboBoxMaPhongBan.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxMaPhongBan.Items.Add(dataReader["MAPB"].ToString());
            }
        }
    }
}
