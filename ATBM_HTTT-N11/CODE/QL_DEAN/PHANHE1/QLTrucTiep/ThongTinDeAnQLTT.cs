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
    public partial class ThongTinDeAnQLTT : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        public ThongTinDeAnQLTT()
        {
            InitializeComponent();
            conn.Open();
        }

        private void textBoxMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelThongTinCaNhanQLTT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListThongTinDeAn = conn.CreateCommand();
            getListThongTinDeAn.CommandText = "SELECT * FROM NHOM11.DEAN";
            getListThongTinDeAn.CommandType = CommandType.Text;
            OracleDataReader temp = getListThongTinDeAn.ExecuteReader();
            DataTable table_DSDeAn = new DataTable();
            table_DSDeAn.Load(temp);
            dataGridViewThongTinDeAnQLTT.DataSource = table_DSDeAn;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            OracleCommand getListThongTinDeAn = conn.CreateCommand();
            getListThongTinDeAn.CommandText = "SELECT * FROM NHOM11.DEAN " + " WHERE " + " DEAN like Upper('%" + textBoxNhapMaDeAn.Text + "%')"; ;
            getListThongTinDeAn.CommandType = CommandType.Text;
            OracleDataReader temp = getListThongTinDeAn.ExecuteReader();
            DataTable table_DSDeAnTimKiem = new DataTable();
            table_DSDeAnTimKiem.Load(temp);
            dataGridViewThongTinDeAnQLTT.DataSource = table_DSDeAnTimKiem;
        }
    }
}
