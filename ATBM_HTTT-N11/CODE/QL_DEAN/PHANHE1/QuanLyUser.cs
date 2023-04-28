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
            panelQuanLyUser.Controls.Add(childForm);
            panelQuanLyUser.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelQuanLyUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuanLyUser_Load(object sender, EventArgs e)
        {
            
        }

        private void panelThemXoaSua_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTaoUser_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ThemUser());
            SwitchColorMenu(sender, e);
        }

        private void buttonXoaUser_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new XoaUser());
            SwitchColorMenu(sender, e);
        }

        private void buttonChinhSuaUser_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ChinhSuaUser());
            SwitchColorMenu(sender, e);
        }
    }
}
