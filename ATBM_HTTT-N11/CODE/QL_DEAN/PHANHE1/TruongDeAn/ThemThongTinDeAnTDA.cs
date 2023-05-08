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
    public partial class ThemThongTinDeAnTDA : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ThemThongTinDeAnTDA(String usrAdmin)
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
            getListThongTinDeAnTDA.CommandText = "SELECT * FROM " + userAdmin + " .DEAN ORDER BY MADA ASC";
            getListThongTinDeAnTDA.CommandType = CommandType.Text;
            OracleDataReader temp = getListThongTinDeAnTDA.ExecuteReader();
            DataTable table_DSDeAnTC = new DataTable();
            table_DSDeAnTC.Load(temp);
            dataGridViewThemThongTinDeAnTDA.DataSource = table_DSDeAnTC;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand themNhanVienTDA = new OracleCommand(userAdmin + ".USP_THEM_DEAN", conn);
                themNhanVienTDA.CommandType = CommandType.StoredProcedure;

                themNhanVienTDA.Parameters.Add("p_mada", OracleDbType.Varchar2).Value = textBoxMaDeAn.Text.Trim();
                themNhanVienTDA.Parameters.Add("p_tenda", OracleDbType.Varchar2).Value = textBoxTenDeAn.Text.Trim();
                themNhanVienTDA.Parameters.Add("p_ngaybatdau", OracleDbType.Date).Value = dateTimePickerNgayBatDau.Value;
                themNhanVienTDA.Parameters.Add("p_phong", OracleDbType.Varchar2).Value = comboBoxPhongBan.SelectedItem?.ToString() ?? (object)DBNull.Value;

                OracleParameter outMessageParam = new OracleParameter("p_out_message", OracleDbType.NVarchar2, 500);
                outMessageParam.Direction = ParameterDirection.Output;
                themNhanVienTDA.Parameters.Add(outMessageParam);

                themNhanVienTDA.ExecuteNonQuery();
                string outMessage = outMessageParam.Value.ToString();
                MessageBox.Show(outMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThemThongTinDeAnTDA_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private void LoadDataToComboBox()
        {
            OracleCommand getPhongBanDataTDA = conn.CreateCommand();
            getPhongBanDataTDA.CommandText = "SELECT MAPB FROM " + userAdmin + " .PHONGBAN";
            getPhongBanDataTDA.CommandType = CommandType.Text;
            OracleDataReader dataReader = getPhongBanDataTDA.ExecuteReader();

            comboBoxPhongBan.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxPhongBan.Items.Add(dataReader["MAPB"].ToString());
            }
        }
    }
}
