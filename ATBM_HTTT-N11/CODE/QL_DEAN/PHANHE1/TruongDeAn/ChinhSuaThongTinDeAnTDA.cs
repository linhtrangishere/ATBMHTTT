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
    public partial class ChinhSuaThongTinDeAnTDA : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ChinhSuaThongTinDeAnTDA(String usrAdmin)
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
            dataGridViewChinhSuaThongTinDeAnTDA.DataSource = table_DSDeAnTC;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand updatePhanCongCmd = new OracleCommand(userAdmin + ".USP_UPDATE_DEAN", conn);
                updatePhanCongCmd.CommandType = CommandType.StoredProcedure;

                updatePhanCongCmd.Parameters.Add("p_mada", OracleDbType.Varchar2).Value = comboBoxDeAn.SelectedItem?.ToString() ?? (object)DBNull.Value;
                updatePhanCongCmd.Parameters.Add("p_tenda", OracleDbType.Varchar2).Value = textBoxTenDeAn.Text.Trim();
                updatePhanCongCmd.Parameters.Add("p_thoigian", OracleDbType.Date).Value = dateTimePickerNgayBatDau.Value;
                updatePhanCongCmd.Parameters.Add("p_phong", OracleDbType.Varchar2).Value = comboBoxPhongBan.SelectedItem?.ToString() ?? (object)DBNull.Value;

                OracleParameter outMessageParam = new OracleParameter("p_out_message", OracleDbType.NVarchar2, 500);
                outMessageParam.Direction = ParameterDirection.Output;
                updatePhanCongCmd.Parameters.Add(outMessageParam);

                updatePhanCongCmd.ExecuteNonQuery();
                string outMessage = outMessageParam.Value.ToString();
                MessageBox.Show(outMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //LoadData(); // Tải lại dữ liệu sau khi cập nhật (nếu cần)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChinhSuaThongTinDeAnTDA_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox_MaDA();
            LoadDataToComboBox_Phong();
            dataGridViewChinhSuaThongTinDeAnTDA.CellClick += dataGridViewChinhSuaThongTinDeAnTDA_CellClick;
        }

        private void dataGridViewChinhSuaThongTinDeAnTDA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewChinhSuaThongTinDeAnTDA.Rows[e.RowIndex];
                comboBoxDeAn.SelectedItem = row.Cells["MADA"].Value.ToString();
                textBoxTenDeAn.Text = row.Cells["TENDA"].Value.ToString();
                dateTimePickerNgayBatDau.Value = Convert.ToDateTime(row.Cells["NGAYBD"].Value);
                comboBoxPhongBan.SelectedItem = row.Cells["PHONG"].Value.ToString();
            }
        }

        private void LoadDataToComboBox_MaDA()
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

        private void LoadDataToComboBox_Phong()
        {
            OracleCommand getMaDAData = conn.CreateCommand();
            getMaDAData.CommandText = "SELECT DISTINCT MAPB FROM " + userAdmin + " .PHONGBAN";
            getMaDAData.CommandType = CommandType.Text;
            OracleDataReader dataReader = getMaDAData.ExecuteReader();

            comboBoxPhongBan.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxPhongBan.Items.Add(dataReader["MAPB"].ToString());
            }
        }
    }
}
