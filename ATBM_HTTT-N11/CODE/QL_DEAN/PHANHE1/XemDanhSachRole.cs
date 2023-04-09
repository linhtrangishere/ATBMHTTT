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
    public partial class XemDanhSachRole : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);

        public XemDanhSachRole()
        {
            InitializeComponent();
            conn.Open();
        }

        private void XemDanhSachRole_Load(object sender, EventArgs e)
        {

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            OracleCommand getListRole = conn.CreateCommand();
            getListRole.CommandText = "SELECT * FROM DBA_ROLES WHERE ROLE LIKE 'RL_%' AND ROLE like Upper('%" + textBoxTenRole.Text + "%')";
            getListRole.CommandType = CommandType.Text;
            OracleDataReader temp = getListRole.ExecuteReader();
            DataTable table_DSRole = new DataTable();
            table_DSRole.Load(temp);
            dataGridViewXemDanhSachRole.DataSource = table_DSRole;
        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListRole = conn.CreateCommand();
            getListRole.CommandText = "SELECT * FROM DBA_ROLES WHERE ROLE LIKE 'RL_%'";
            getListRole.CommandType = CommandType.Text;
            OracleDataReader temp = getListRole.ExecuteReader();
            DataTable table_DSRole = new DataTable();
            table_DSRole.Load(temp);
            dataGridViewXemDanhSachRole.DataSource = table_DSRole;
        }

        private void textBoxTenRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewXemDanhSachRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
