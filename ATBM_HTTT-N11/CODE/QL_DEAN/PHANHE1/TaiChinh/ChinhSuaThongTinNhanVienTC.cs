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

namespace PHANHE1.TaiChinh
{
    public partial class ChinhSuaThongTinNhanVienTC : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ChinhSuaThongTinNhanVienTC(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand updatePhanCongCmd = new OracleCommand(userAdmin + ".USP_UPDATE_LUONG_PHUCAP_NHANVIEN", conn);
                updatePhanCongCmd.CommandType = CommandType.StoredProcedure;

                updatePhanCongCmd.Parameters.Add("p_manv", OracleDbType.Varchar2).Value = comboBoxMaNhanVien.SelectedItem?.ToString() ?? (object)DBNull.Value;
                updatePhanCongCmd.Parameters.Add("p_luong", OracleDbType.Varchar2).Value = textBoxLuong.Text.Trim();
                updatePhanCongCmd.Parameters.Add("p_phucap", OracleDbType.Varchar2).Value = textBoxPhuCap.Text.Trim();

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

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListThongTinNhanVienQLTT = conn.CreateCommand();
            getListThongTinNhanVienQLTT.CommandText = "SELECT * FROM " + userAdmin + " .NHANVIEN";
            getListThongTinNhanVienQLTT.CommandType = CommandType.Text;
            OracleDataReader temp = getListThongTinNhanVienQLTT.ExecuteReader();
            DataTable table_DSDeAn = new DataTable();
            table_DSDeAn.Load(temp);
            dataGridViewChinhSuaThongTinNhanVienTC.DataSource = table_DSDeAn;
        }

        private void ChinhSuaThongTinNhanVienTC_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
            dataGridViewChinhSuaThongTinNhanVienTC.CellClick += dataGridViewChinhSuaThongTinNhanVienTC_CellClick;
        }

        private void LoadDataToComboBox()
        {
            OracleCommand getMaDAData = conn.CreateCommand();
            getMaDAData.CommandText = "SELECT DISTINCT MANV FROM " + userAdmin + " .NHANVIEN";
            getMaDAData.CommandType = CommandType.Text;
            OracleDataReader dataReader = getMaDAData.ExecuteReader();

            comboBoxMaNhanVien.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxMaNhanVien.Items.Add(dataReader["MANV"].ToString());
            }
        }

        private void dataGridViewChinhSuaThongTinNhanVienTC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewChinhSuaThongTinNhanVienTC.Rows[e.RowIndex];
                comboBoxMaNhanVien.SelectedItem = row.Cells["MANV"].Value.ToString();
                textBoxLuong.Text = row.Cells["LUONG"].Value.ToString();
                textBoxPhuCap.Text = row.Cells["PHUCAP"].Value.ToString();
            }
        }
    }
}
