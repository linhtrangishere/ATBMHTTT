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
    public partial class ThongTinDeAnTC : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ThongTinDeAnTC(String usrAdmin)
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
            OracleCommand getListThongTinDeAnTC = conn.CreateCommand();
            getListThongTinDeAnTC.CommandText = "SELECT * FROM " + userAdmin + " .DEAN";
            getListThongTinDeAnTC.CommandType = CommandType.Text;
            OracleDataReader temp = getListThongTinDeAnTC.ExecuteReader();
            DataTable table_DSDeAnTC = new DataTable();
            table_DSDeAnTC.Load(temp);
            dataGridViewThongTinDeAnTC.DataSource = table_DSDeAnTC;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMaDeAn.Text))
            {
                MessageBox.Show("Vui lòng chọn đề án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OracleCommand getListPhongBanTC = conn.CreateCommand();
            getListPhongBanTC.CommandText = "SELECT * FROM " + userAdmin + " .DEAN " + " WHERE MADA LIKE UPPER('%" + comboBoxMaDeAn.Text.Trim() + "%')";
            getListPhongBanTC.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhongBanTC.ExecuteReader();
            DataTable table_DSPhongBanTC = new DataTable();
            table_DSPhongBanTC.Load(temp);
            dataGridViewThongTinDeAnTC.DataSource = table_DSPhongBanTC;
        }

        private void ThongTinDeAnTC_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private void LoadDataToComboBox()
        {
            OracleCommand getPhongBanDataTC = conn.CreateCommand();
            getPhongBanDataTC.CommandText = "SELECT MADA FROM " + userAdmin + " .DEAN";
            getPhongBanDataTC.CommandType = CommandType.Text;
            OracleDataReader dataReader = getPhongBanDataTC.ExecuteReader();

            comboBoxMaDeAn.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxMaDeAn.Items.Add(dataReader["MADA"].ToString());
            }
        }
    }
}
