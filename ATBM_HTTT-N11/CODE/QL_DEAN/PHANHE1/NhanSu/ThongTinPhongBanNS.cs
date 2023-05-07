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
    public partial class ThongTinPhongBanNS : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);

        String userAdmin = "";
        public ThongTinPhongBanNS(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void ThongTinPhongBanNS_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewThongTinPhongBanNS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListPhongBan = conn.CreateCommand();
            getListPhongBan.CommandText = "SELECT * FROM " + userAdmin + " .PHONGBAN";
            getListPhongBan.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhongBan.ExecuteReader();
            DataTable table_DSPhongBan = new DataTable();
            table_DSPhongBan.Load(temp);
            dataGridViewThongTinPhongBanNS.DataSource = table_DSPhongBan;
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
            dataGridViewThongTinPhongBanNS.DataSource = table_DSPhongBan;
        }
    }
}
