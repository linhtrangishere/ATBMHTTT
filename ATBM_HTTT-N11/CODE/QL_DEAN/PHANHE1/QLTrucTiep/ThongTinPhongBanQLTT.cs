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
    public partial class ThongTinPhongBanQLTT : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ThongTinPhongBanQLTT(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void panelThongTinCaNhanQLTT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListThongTinPhongBanQLTT = conn.CreateCommand();
            getListThongTinPhongBanQLTT.CommandText = "SELECT * FROM " + userAdmin + " .PHONGBAN";
            getListThongTinPhongBanQLTT.CommandType = CommandType.Text;
            OracleDataReader temp = getListThongTinPhongBanQLTT.ExecuteReader();
            DataTable table_DSDeAnQLTT = new DataTable();
            table_DSDeAnQLTT.Load(temp);
            dataGridViewThongTinPhongBanQLTT.DataSource = table_DSDeAnQLTT;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMaPhongBan.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OracleCommand getListPhongBanQLTT = conn.CreateCommand();
            getListPhongBanQLTT.CommandText = "SELECT * FROM " + userAdmin + " .PHONGBAN " + " WHERE MAPB LIKE UPPER('%" + comboBoxMaPhongBan.Text.Trim() + "%')";
            getListPhongBanQLTT.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhongBanQLTT.ExecuteReader();
            DataTable table_DSPhongBanQLTT = new DataTable();
            table_DSPhongBanQLTT.Load(temp);
            dataGridViewThongTinPhongBanQLTT.DataSource = table_DSPhongBanQLTT;
        }

        private void LoadDataToComboBox()
        {
            OracleCommand getPhongBanDataQLTT = conn.CreateCommand();
            getPhongBanDataQLTT.CommandText = "SELECT MAPB FROM " + userAdmin + " .PHONGBAN";
            getPhongBanDataQLTT.CommandType = CommandType.Text;
            OracleDataReader dataReader = getPhongBanDataQLTT.ExecuteReader();

            comboBoxMaPhongBan.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxMaPhongBan.Items.Add(dataReader["MAPB"].ToString());
            }
        }

        private void ThongTinPhongBanQLTT_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }
    }
}
