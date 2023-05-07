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

namespace PHANHE1.NhanVien
{
    public partial class ThongTinPhongBanNV : Form
    {

        OracleConnection conn = new OracleConnection(Login.connectionString);

        String userAdmin = "";
        public ThongTinPhongBanNV(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void ThongTinPhongBanNV_Load(object sender, EventArgs e)
        {

        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListPhongBan = conn.CreateCommand();
            getListPhongBan.CommandText = "SELECT * FROM " + userAdmin + " .PHONGBAN";
            getListPhongBan.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhongBan.ExecuteReader();
            DataTable table_DSUser = new DataTable();
            table_DSUser.Load(temp);
            dataGridViewThongTinPhongBanNV.DataSource = table_DSUser;
        }

        private void dataGridViewThongTinPhongBanNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
