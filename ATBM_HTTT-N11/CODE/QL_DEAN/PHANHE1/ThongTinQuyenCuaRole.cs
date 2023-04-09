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
    public partial class ThongTinQuyenCuaRole : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);

        public ThongTinQuyenCuaRole()
        {
            InitializeComponent();
            conn.Open();
        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListPrivilegeRole = conn.CreateCommand();
            getListPrivilegeRole.CommandText = "SELECT ROLE, OWNER, TABLE_NAME, COLUMN_NAME, PRIVILEGE, GRANTABLE FROM ROLE_TAB_PRIVS WHERE ROLE LIKE 'RL_%'";
            getListPrivilegeRole.CommandType = CommandType.Text;
            OracleDataReader temp = getListPrivilegeRole.ExecuteReader();
            DataTable table_DSQuyenCuaRole = new DataTable();
            table_DSQuyenCuaRole.Load(temp);
            dataGridViewThongTinQuyenCuaRole.DataSource = table_DSQuyenCuaRole;
        }

        private void dataGridViewThongTinQuyenCuaRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            OracleCommand getListPrivilegeRole = conn.CreateCommand();
            getListPrivilegeRole.CommandText = "SELECT ROLE, OWNER, TABLE_NAME, COLUMN_NAME, PRIVILEGE, GRANTABLE FROM ROLE_TAB_PRIVS " + " WHERE " + "  ROLE LIKE 'RL_%' AND ROLE like Upper('%" + textBoxNhapTenRole.Text + "%')"; ;
            getListPrivilegeRole.CommandType = CommandType.Text;
            OracleDataReader temp = getListPrivilegeRole.ExecuteReader();
            DataTable table_DSQuyenCuaRole = new DataTable();
            table_DSQuyenCuaRole.Load(temp);
            dataGridViewThongTinQuyenCuaRole.DataSource = table_DSQuyenCuaRole;
        }

        private void textBoxNhapTenRole_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
