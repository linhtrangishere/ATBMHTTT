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
    public partial class QuanLyRole : Form
    {
        public QuanLyRole()
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

        private void buttonTaoRole_Click(object sender, EventArgs e)
        {
            ThemRole addrole = new ThemRole();
            addrole.Show();
            SwitchColorMenu(sender, e);
        }

        private void buttonChinhSuaRole_Click(object sender, EventArgs e)
        {
            ChinhSuaRole chinhsuarole = new ChinhSuaRole();
            chinhsuarole.Show();
            SwitchColorMenu(sender, e);
        }

        private void buttonXoaRole_Click(object sender, EventArgs e)
        {
            XoaRole xoarole = new XoaRole();
            xoarole.Show();
            SwitchColorMenu(sender, e);
        }
    }
}
