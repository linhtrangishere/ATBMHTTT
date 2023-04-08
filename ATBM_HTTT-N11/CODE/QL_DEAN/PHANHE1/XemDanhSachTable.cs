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
    public partial class XemDanhSachTable : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);

        public XemDanhSachTable()
        {
            InitializeComponent();
            conn.Open();
        }

        private void XemDanhSachTable_Load(object sender, EventArgs e)
        {

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            OracleCommand getListTable = conn.CreateCommand();
            getListTable.CommandText = "SELECT TABLE_NAME, OWNER, TABLESPACE_NAME, STATUS, TABLE_LOCK FROM DBA_TABLES " + " WHERE " + " TABLE_NAME like Upper('%" + textBoxTenTable.Text + "%')";
            getListTable.CommandType = CommandType.Text;
            OracleDataReader temp = getListTable.ExecuteReader();
            DataTable table_DSTable = new DataTable();
            table_DSTable.Load(temp);
            dataGridViewXemDanhSachTable.DataSource = table_DSTable;
        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListTable = conn.CreateCommand();
            getListTable.CommandText = "SELECT TABLE_NAME, OWNER, TABLESPACE_NAME, STATUS, TABLE_LOCK FROM DBA_TABLES";
            getListTable.CommandType = CommandType.Text;
            OracleDataReader temp = getListTable.ExecuteReader();
            DataTable table_DSTable = new DataTable();
            table_DSTable.Load(temp);
            dataGridViewXemDanhSachTable.DataSource = table_DSTable;
        }

        private void dataGridViewXemDanhSachTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxTenTable_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
