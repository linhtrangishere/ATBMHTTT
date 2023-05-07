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
    public partial class ThongTinDeAnNS : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ThongTinDeAnNS(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }
        private void LoadDataToComboBox()
        {
            OracleCommand getDeAnData = conn.CreateCommand();
            getDeAnData.CommandText = "SELECT MADA FROM " + userAdmin + " .DEAN";
            getDeAnData.CommandType = CommandType.Text;
            OracleDataReader dataReader = getDeAnData.ExecuteReader();

            comboBoxMaDeAn.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxMaDeAn.Items.Add(dataReader["MADA"].ToString());
            }
        }
        private void ThongTinDeAnNS_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListDeAn = conn.CreateCommand();
            getListDeAn.CommandText = "SELECT * FROM " + userAdmin + " .DEAN";
            getListDeAn.CommandType = CommandType.Text;
            OracleDataReader temp = getListDeAn.ExecuteReader();
            DataTable table_DSDeAn = new DataTable();
            table_DSDeAn.Load(temp);
            dataGridViewThongTinDeAnNS.DataSource = table_DSDeAn;
        }

        private void comboBoxMaDeAn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMaDeAn.Text))
            {
                MessageBox.Show("Vui lòng chọn đề án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OracleCommand getListDeAn = conn.CreateCommand();
            getListDeAn.CommandText = "SELECT * FROM " + userAdmin + " .DEAN " + " WHERE MADA LIKE UPPER('%" + comboBoxMaDeAn.Text.Trim() + "%')";
            getListDeAn.CommandType = CommandType.Text;
            OracleDataReader temp = getListDeAn.ExecuteReader();
            DataTable table_DSDeAn = new DataTable();
            table_DSDeAn.Load(temp);
            dataGridViewThongTinDeAnNS.DataSource = table_DSDeAn;
        }

        private void dataGridViewThongTinDeAnNS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
