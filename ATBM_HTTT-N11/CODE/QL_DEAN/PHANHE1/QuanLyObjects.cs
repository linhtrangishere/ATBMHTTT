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
    public partial class QuanLyObjects : Form
    {
        public QuanLyObjects()
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
            panelChildForm.Controls.Add(childForm);
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
                foreach (Control prebtn in panelUserRole.Controls)
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

        private void buttonUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyUser());
            SwitchColorMenu(sender, e);
        }

        private void buttonRole_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyRole());
            SwitchColorMenu(sender, e);
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyTable());
            SwitchColorMenu(sender, e);
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyView());
            SwitchColorMenu(sender, e);
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuanLyObjects_Load(object sender, EventArgs e)
        {

        }
    }
}
