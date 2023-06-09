﻿using Oracle.ManagedDataAccess.Client;
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
    public partial class QuanLyQuyenRole : Form
    {
        string connectionString = Login.connectionString;
        public QuanLyQuyenRole()
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
            panelQuanLyQuyenRole.Controls.Add(childForm);
            panelQuanLyQuyenRole.Tag = childForm;
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
            OpenChildForm(new CapQuyenChoRole());
            SwitchColorMenu(sender, e);
        }

        private void buttonThuHoiQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThuHoiQuyenTuRole());
            SwitchColorMenu(sender, e);
        }

        private void buttonChinhSuaQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChinhSuaQuyenChoRole());
            SwitchColorMenu(sender, e);
        }

        private void dataGridViewQuanLyQuyenRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelQuanLyQuyenRole_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuanLyQuyenRole_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            OracleCommand getData = conn.CreateCommand();
            getData.CommandText = "SELECT ROLE, OWNER, TABLE_NAME, COLUMN_NAME, PRIVILEGE, GRANTABLE FROM ROLE_TAB_PRIVS WHERE ROLE LIKE 'RL_%'";
            getData.CommandType = CommandType.Text;
            OracleDataReader data = getData.ExecuteReader();
            DataTable tempDT = new DataTable();
            tempDT.Load(data);
            dataGridViewQuanLyQuyenRole.DataSource = tempDT;
            conn.Close();
        }
    }
}
