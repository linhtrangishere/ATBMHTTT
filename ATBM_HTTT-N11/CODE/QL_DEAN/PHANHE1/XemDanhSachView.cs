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

namespace PHANHE1
{
    public partial class XemDanhSachView : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);

        public XemDanhSachView()
        {
            InitializeComponent();
            conn.Open();
        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListView = conn.CreateCommand();
            getListView.CommandText = "SELECT VIEW_NAME, OWNER, TEXT_LENGTH FROM DBA_VIEWS";
            getListView.CommandType = CommandType.Text;
            OracleDataReader temp = getListView.ExecuteReader();
            DataTable table_DSView = new DataTable();
            table_DSView.Load(temp);
            dataGridViewXemDanhSachView.DataSource = table_DSView;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            OracleCommand getListView = conn.CreateCommand();
            getListView.CommandText = "SELECT VIEW_NAME, OWNER, TEXT_LENGTH FROM DBA_VIEWS " + " WHERE " + " VIEW_NAME like Upper('%" + textBoxTenView.Text + "%')";
            getListView.CommandType = CommandType.Text;
            OracleDataReader temp = getListView.ExecuteReader();
            DataTable table_DSTable = new DataTable();
            table_DSTable.Load(temp);
            dataGridViewXemDanhSachView.DataSource = table_DSTable;
        }

        private void dataGridViewXemDanhSachView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxTenView_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
