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

namespace PHANHE1.TruongDeAn
{
    public partial class ChinhSuaThongTinDeAnTDA : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ChinhSuaThongTinDeAnTDA(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListThongTinDeAnTDA = conn.CreateCommand();
            getListThongTinDeAnTDA.CommandText = "SELECT * FROM " + userAdmin + " .DEAN";
            getListThongTinDeAnTDA.CommandType = CommandType.Text;
            OracleDataReader temp = getListThongTinDeAnTDA.ExecuteReader();
            DataTable table_DSDeAnTC = new DataTable();
            table_DSDeAnTC.Load(temp);
            dataGridViewChinhSuaThongTinDeAnTDA.DataSource = table_DSDeAnTC;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
