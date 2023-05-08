using Oracle.ManagedDataAccess.Client;
using PHANHE1.TaiChinh;
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
    public partial class ThongTinDeAnTDA : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ThongTinDeAnTDA(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private Form formchild = null;
        private void OpenChildForm(Form childForm)
        {
            if (formchild != null)
            {
                formchild.Close();
            }
            formchild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFormTTDA.Controls.Add(childForm);
            panelChildFormTTDA.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void SwitchColorMenu(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.FromArgb(255, 212, 178))
            {
                btn.BackColor = Color.FromArgb(255, 246, 189);
            }
            else
            {
                foreach (Control prebtn in panelThemXoaSua.Controls)
                {
                    if (prebtn.GetType() == typeof(Button))
                    {
                        prebtn.BackColor = Color.FromArgb(255, 246, 189);
                        prebtn.ForeColor = Color.Black;
                    }
                }
                btn.BackColor = Color.FromArgb(255, 212, 178);
            }
        }

        private void textBoxMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelThongTinCaNhanQLTT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonThemDeAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThemThongTinDeAnTDA(userAdmin));
            SwitchColorMenu(sender, e);
        }

        private void buttonXoaDeAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XoaThongTinDeAnTDA(userAdmin));
            SwitchColorMenu(sender, e);
        }

        private void buttonChinhSuaDeAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChinhSuaThongTinDeAnTDA(userAdmin));
            SwitchColorMenu(sender, e);
        }

        private void ThongTinDeAnTDA_Load(object sender, EventArgs e)
        {
            OracleCommand getListThongTinDeAnTDA = conn.CreateCommand();
            getListThongTinDeAnTDA.CommandText = "SELECT * FROM " + userAdmin + " .DEAN ORDER BY MADA ASC";
            getListThongTinDeAnTDA.CommandType = CommandType.Text;
            OracleDataReader temp = getListThongTinDeAnTDA.ExecuteReader();
            DataTable table_DSDeAnTC = new DataTable();
            table_DSDeAnTC.Load(temp);
            dataGridViewTTDA.DataSource = table_DSDeAnTC;
        }
    }
}
