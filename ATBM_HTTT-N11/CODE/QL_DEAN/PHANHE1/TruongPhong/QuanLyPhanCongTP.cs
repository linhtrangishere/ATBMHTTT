using Oracle.ManagedDataAccess.Client;
using PHANHE1.TruongDeAn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE1.TruongPhong
{
    public partial class QuanLyPhanCongTP : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public QuanLyPhanCongTP(String usrAdmin)
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
            panelChildFormQuanLyPhanCong.Controls.Add(childForm);
            panelChildFormQuanLyPhanCong.Tag = childForm;
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

       

        private void QuanLyPhanCongTP_Load(object sender, EventArgs e)
        {

        }

        private void buttonThemPhanCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThemPhanCongTP(userAdmin));
            SwitchColorMenu(sender, e);
        }

        private void buttonXoaPhanCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XoaPhanCongTP(userAdmin));
            SwitchColorMenu(sender, e);
        }

        private void buttonChinhSuaPhanCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChinhSuaPhanCongTP(userAdmin));
            SwitchColorMenu(sender, e);
        }
    }
}
