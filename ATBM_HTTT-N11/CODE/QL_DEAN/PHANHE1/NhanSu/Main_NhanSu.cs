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
    public partial class Main_NhanSu : Form
    {
        public Main_NhanSu()
        {
            InitializeComponent();
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
            panelChildFormNS.Controls.Add(childForm);
            panelChildFormNS.Tag = childForm;
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
                foreach (Control prebtn in panelMenuNS.Controls)
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

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void buttonThongTinCaNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinCaNhanNS());
            SwitchColorMenu(sender, e);
        }

        private void buttonThongTinPhanCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinPhanCongNS());
            SwitchColorMenu(sender, e);
        }

        private void buttonThongTinPhongBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyPhongBanNS());
            SwitchColorMenu(sender, e);
        }

        private void buttonThongTinDeAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinDeAnNS());
            SwitchColorMenu(sender, e);
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelUsername_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelAdmin_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelNguyenVanA_Click(object sender, EventArgs e)
        {

        }

        private void panelChildFormNV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyNhanVienNS());
            SwitchColorMenu(sender, e);
        }
    }
}
