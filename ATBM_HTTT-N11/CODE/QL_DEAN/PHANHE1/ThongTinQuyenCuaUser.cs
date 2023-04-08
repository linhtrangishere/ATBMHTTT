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
    public partial class ThongTinQuyenCuaUser : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);

        public ThongTinQuyenCuaUser()
        {
            InitializeComponent();
            conn.Open();
        }

        private void ThongTinQuyenCuaUser_Load(object sender, EventArgs e)
        {

        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListPrivilegeUser = conn.CreateCommand();
            getListPrivilegeUser.CommandText = "SELECT GRANTEE, OWNER, TABLE_NAME, GRANTOR, PRIVILEGE FROM DBA_TAB_PRIVS";
            getListPrivilegeUser.CommandType = CommandType.Text;
            OracleDataReader temp = getListPrivilegeUser.ExecuteReader();
            DataTable table_DSQuyenCuaUser = new DataTable();
            table_DSQuyenCuaUser.Load(temp);
            dataGridViewThongTinQuyenCuaUser.DataSource = table_DSQuyenCuaUser;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            OracleCommand getListPrivilegeUser = conn.CreateCommand();
            getListPrivilegeUser.CommandText = "SELECT GRANTEE, OWNER, TABLE_NAME, GRANTOR, PRIVILEGE FROM DBA_TAB_PRIVS " + " WHERE " + " GRANTEE like Upper('%" + textBoxNhapTenUser.Text + "%')"; ;
            getListPrivilegeUser.CommandType = CommandType.Text;
            OracleDataReader temp = getListPrivilegeUser.ExecuteReader();
            DataTable table_DSUser = new DataTable();
            table_DSUser.Load(temp);
            dataGridViewThongTinQuyenCuaUser.DataSource = table_DSUser;
        }

        private void textBoxNhapTenUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewThongTinQuyenCuaUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
