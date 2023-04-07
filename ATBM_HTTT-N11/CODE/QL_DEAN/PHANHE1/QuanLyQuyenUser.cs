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
    public partial class QuanLyQuyenUser : Form
    {
        public QuanLyQuyenUser()
        {
            InitializeComponent();
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

        private void buttonCapQuyen_Click(object sender, EventArgs e)
        {
            CapQuyenChoUser capquyenuser = new CapQuyenChoUser();
            capquyenuser.Show();
            SwitchColorMenu(sender, e);
        }

        private void buttonGanRole_Click(object sender, EventArgs e)
        {
            GanRoleChoUser ganrole = new GanRoleChoUser();
            ganrole.Show();
            SwitchColorMenu(sender, e);
        }

        private void buttonThuHoiQuyen_Click(object sender, EventArgs e)
        {
            ThuHoiQuyenTuUser thuhoiquyenuser = new ThuHoiQuyenTuUser();
            thuhoiquyenuser.Show();
            SwitchColorMenu(sender, e);
        }

        private void buttonChinhSuaQuyen_Click(object sender, EventArgs e)
        {
            ChinhSuaQuyenChoUser chinhsuaquyenchouser = new ChinhSuaQuyenChoUser();
            chinhsuaquyenchouser.Show();
            SwitchColorMenu(sender, e);
        }
    }
}
