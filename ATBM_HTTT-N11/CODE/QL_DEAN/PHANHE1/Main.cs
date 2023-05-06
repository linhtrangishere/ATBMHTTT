using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PHANHE1
{
    public partial class Main : Form
    {
        public Main()
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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
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
                foreach (Control prebtn in panelMenu.Controls)
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

        private void buttonThongTinObjects_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinObjects());
            SwitchColorMenu(sender, e);
        }

        private void buttonThongTinQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinQuyen());
            SwitchColorMenu(sender, e);
        }

        private void buttonQuanLyObjects_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyObjects());
            SwitchColorMenu(sender, e);
        }

        private void buttonQuanLyQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyQuyen());
            SwitchColorMenu(sender, e);
        }

        
        private void ResetConnectionString()
        {
            Login.connectionString = "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)" + "(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));";
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            ResetConnectionString();
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
    }
}
