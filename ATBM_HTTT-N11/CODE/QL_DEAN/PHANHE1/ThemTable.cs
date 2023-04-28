using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PHANHE1
{
    public partial class ThemTable : Form
    {
        public struct Table
        {
            public string columnName { get; set; }
            public string dataType { get; set; }
            public bool isKey { get; set; }

        }
        List<Table> Tab = new List<Table>();

        public ThemTable()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                foreach (Control prebtn in panelThemTable.Controls)
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

        //ADD PHAN TU VAO DATAGRID VA LIST<STRUCT>
        private void buttonThem_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(Login.connectionString);
            conn.Open();
            dataGridViewThemTable.Rows.Add(textBoxTenCot.Text, textBoxDataType.Text, checkBox.Checked);
            Tab.Add(new Table() { columnName = textBoxTenCot.Text, dataType = textBoxDataType.Text, isKey = checkBox.Checked });
            conn.Close();
            SwitchColorMenu(sender, e);
        }

        // TRUY VAN TAO BANG
        private void buttonTaoBang_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(Login.connectionString);
            conn.Open();
            try
            {
                string temp = "CREATE TABLE " + textBoxTenBang.Text + " ( ";
                string temp2 = null;
                string strKey = null;
                int l = Tab.Count;
                for (int i = 0; i < l; i++)
                {
                    temp2 = temp2 + Tab[i].columnName + " " + Tab[i].dataType + ", ";
                }
                temp2 = temp2.TrimEnd();
                temp = temp + temp2.Substring(0, temp2.Length - 1) + ")";
                OracleCommand cmd = new OracleCommand(temp, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                for (int i = 0; i < l; i++)
                {
                    if (Tab[i].isKey is true)
                    {
                        conn.Open();
                        strKey = "ALTER TABLE " + textBoxTenBang.Text + " ADD CONSTRAINT " + textBoxTenBang.Text + "_PK PRIMARY KEY (" + Tab[i].columnName + ")";
                        OracleCommand cmd2 = new OracleCommand(strKey, conn);
                        cmd2.ExecuteNonQuery();
                        conn.Close();

                    }
                }
                MessageBox.Show("Tao bang thanh cong");
            }
            catch
            {
                MessageBox.Show("Vui long thu lai!!!");
            }
            conn.Close();
            SwitchColorMenu(sender, e);
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

