using Oracle.ManagedDataAccess.Client;
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
        string connectionString = Login.connectionString;
        public QuanLyQuyenUser()
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
            panelQuanLyQuyenUser.Controls.Add(childForm);
            panelQuanLyQuyenUser.Tag = childForm;
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

        private void buttonCapQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CapQuyenChoUser());
            SwitchColorMenu(sender, e);
        }

        private void buttonGanRole_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GanRoleChoUser());
            SwitchColorMenu(sender, e);
        }

        private void buttonThuHoiQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThuHoiQuyenTuUser());
            SwitchColorMenu(sender, e);
        }

        private void buttonChinhSuaQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChinhSuaQuyenChoUser());
            SwitchColorMenu(sender, e);
        }

        private void dataGridViewQuanLyQuyenUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyQuyenUser_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            OracleCommand getData = conn.CreateCommand();
            getData.CommandText = "SELECT * FROM USER_TAB_PRIVS WHERE GRANTEE IN (SELECT USERNAME FROM DBA_USERS) AND GRANTEE != '" + Login.username + "'"; ;
            getData.CommandType = CommandType.Text;
            OracleDataReader data = getData.ExecuteReader();
            DataTable tempDT = new DataTable();
            tempDT.Load(data);
            dataGridViewQuanLyQuyenUser.DataSource = tempDT;
            conn.Close();
        }
    }
}
