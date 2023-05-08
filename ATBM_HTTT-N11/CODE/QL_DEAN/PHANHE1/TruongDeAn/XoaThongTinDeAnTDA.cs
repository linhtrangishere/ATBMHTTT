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

namespace PHANHE1.TruongDeAn
{
    public partial class XoaThongTinDeAnTDA : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public XoaThongTinDeAnTDA(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListThongTinDeAnTDA = conn.CreateCommand();
            getListThongTinDeAnTDA.CommandText = "SELECT * FROM " + userAdmin + " .DEAN";
            getListThongTinDeAnTDA.CommandType = CommandType.Text;
            OracleDataReader temp = getListThongTinDeAnTDA.ExecuteReader();
            DataTable table_DSDeAnTC = new DataTable();
            table_DSDeAnTC.Load(temp);
            dataGridViewXoaThongTinDeAnTDA.DataSource = table_DSDeAnTC;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand xoaPhanCongCmd = new OracleCommand(userAdmin + ".USP_XOA_DEAN", conn);
                xoaPhanCongCmd.CommandType = CommandType.StoredProcedure;

                xoaPhanCongCmd.Parameters.Add("p_mada", OracleDbType.Varchar2).Value = comboBoxDeAn.SelectedItem?.ToString() ?? (object)DBNull.Value;

                OracleParameter outMessageParam = new OracleParameter("p_out_message", OracleDbType.NVarchar2, 500);
                outMessageParam.Direction = ParameterDirection.Output;
                xoaPhanCongCmd.Parameters.Add(outMessageParam);

                xoaPhanCongCmd.ExecuteNonQuery();
                string outMessage = outMessageParam.Value.ToString();
                MessageBox.Show(outMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaThongTinDeAnTDA_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private void LoadDataToComboBox()
        {
            OracleCommand getMaDAData = conn.CreateCommand();
            getMaDAData.CommandText = "SELECT DISTINCT MADA FROM " + userAdmin + " .DEAN";
            getMaDAData.CommandType = CommandType.Text;
            OracleDataReader dataReader = getMaDAData.ExecuteReader();

            comboBoxDeAn.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxDeAn.Items.Add(dataReader["MADA"].ToString());
            }
        }
    }
}
