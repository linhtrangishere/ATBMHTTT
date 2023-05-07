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
    public partial class ThemNhanVienNS : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ThemNhanVienNS(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPhai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMaNQL_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMaPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewThemNhanVienNS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {

        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {

        }

        private void ThemNhanVienNS_Load(object sender, EventArgs e)
        {

        }
    }
}
