﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE1.QLTrucTiep
{
    public partial class Main_QLTrucTiep : Form
    {
        public Main_QLTrucTiep()
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
            panelChildFormQLTT.Controls.Add(childForm);
            panelChildFormQLTT.Tag = childForm;
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
                foreach (Control prebtn in panelMenuQLTT.Controls)
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
            OpenChildForm(new ThongTinCaNhanQLTT());
            SwitchColorMenu(sender, e);
        }

        private void buttonThongTinPhanCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinPhanCongQLTT());
            SwitchColorMenu(sender, e);
        }

        private void buttonThongTinPhongBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinPhongBanQLTT());
            SwitchColorMenu(sender, e);
        }

        private void buttonThongTinDeAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinDeAnQLTT());
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

        private void buttonThongTinNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinNhanVienQLTT());
            SwitchColorMenu(sender, e);
        }

        private void buttonQuanLyPhanCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyPhanCongQLTT());
            SwitchColorMenu(sender, e);
        }
    }
}
