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
    public partial class XemDanhSachUser : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);

        public XemDanhSachUser()
        {
            InitializeComponent();
            conn.Open();
        }

        private void XemDanhSachUser_Load(object sender, EventArgs e)
        {

        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListUser = conn.CreateCommand();
            getListUser.CommandText = "SELECT USERNAME, USER_ID, ACCOUNT_STATUS, LOCK_DATE, CREATED FROM DBA_USERS";
            getListUser.CommandType = CommandType.Text;
            OracleDataReader temp = getListUser.ExecuteReader();
            DataTable table_DSUser = new DataTable();
            table_DSUser.Load(temp);
            dataGridViewXemDanhSachUser.DataSource = table_DSUser;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            OracleCommand getListUser = conn.CreateCommand();
            getListUser.CommandText = "SELECT USERNAME, USER_ID, ACCOUNT_STATUS, LOCK_DATE, CREATED FROM DBA_USERS " + " WHERE " + " USERNAME like Upper('" + textBoxUsername.Text + "')"; ;
            getListUser.CommandType = CommandType.Text;
            OracleDataReader temp = getListUser.ExecuteReader();
            DataTable table_DSUser = new DataTable();
            table_DSUser.Load(temp);
            dataGridViewXemDanhSachUser.DataSource = table_DSUser;
        }

        private void dataGridViewXemDanhSachUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
