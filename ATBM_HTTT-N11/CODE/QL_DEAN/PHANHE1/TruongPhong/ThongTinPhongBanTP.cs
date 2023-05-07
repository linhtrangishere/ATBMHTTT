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
    public partial class ThongTinPhongBanTP : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);

        String userAdmin = "";
        public ThongTinPhongBanTP(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void ThongTinPhongBanTP_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListPhongBan = conn.CreateCommand();
            getListPhongBan.CommandText = "SELECT * FROM " + userAdmin + " .PHONGBAN";
            getListPhongBan.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhongBan.ExecuteReader();
            DataTable table_DSPhongBan = new DataTable();
            table_DSPhongBan.Load(temp);
            dataGridViewThongTinPhongBanTP.DataSource = table_DSPhongBan;
        }
        private void LoadDataToComboBox()
        {
            OracleCommand getPhongBanData = conn.CreateCommand();
            getPhongBanData.CommandText = "SELECT MAPB FROM " + userAdmin + " .PHONGBAN";
            getPhongBanData.CommandType = CommandType.Text;
            OracleDataReader dataReader = getPhongBanData.ExecuteReader();

            comboBoxMaPhongBan.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxMaPhongBan.Items.Add(dataReader["MAPB"].ToString());
            }
        }

        private void comboBoxMaPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMaPhongBan.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OracleCommand getListPhongBan = conn.CreateCommand();
            getListPhongBan.CommandText = "SELECT * FROM " + userAdmin + " .PHONGBAN " + " WHERE MAPB LIKE UPPER('%" + comboBoxMaPhongBan.Text.Trim() + "%')";
            getListPhongBan.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhongBan.ExecuteReader();
            DataTable table_DSPhongBan = new DataTable();
            table_DSPhongBan.Load(temp);
            dataGridViewThongTinPhongBanTP.DataSource = table_DSPhongBan;
        }

        private void dataGridViewThongTinPhongBanTP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
