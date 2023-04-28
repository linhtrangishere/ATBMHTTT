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
            panelQuanLyRole.Controls.Add(childForm);
            panelQuanLyRole.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void QuanLyRole_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewQuanLyRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelQuanLyRole_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTaoRole_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThemRole());
            SwitchColorMenu(sender, e);
        }

        private void buttonXoaRole_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XoaRole());
            SwitchColorMenu(sender, e);
        }

        private void buttonChinhSuaRole_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChinhSuaRole());
            SwitchColorMenu(sender, e);
        }
    }
}
