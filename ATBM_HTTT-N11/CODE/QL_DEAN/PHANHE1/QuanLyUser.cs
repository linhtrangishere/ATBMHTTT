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
    public partial class QuanLyUser : Form
    {
        public QuanLyUser()
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

        private void panelQuanLyUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTaoUser_Click(object sender, EventArgs e)
        {
            ThemUser adduser = new ThemUser();
            adduser.Show();
            SwitchColorMenu(sender, e);
        }

        private void buttonChinhSuaUser_Click(object sender, EventArgs e)
        {
            ChinhSuaUser chinhsuauser = new ChinhSuaUser();
            chinhsuauser.Show();
            SwitchColorMenu(sender, e);
        }
    }
}
