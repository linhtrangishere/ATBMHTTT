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

namespace PHANHE1.NhanSu
{
    public partial class ChinhSuaPhongBanNS : Form
    {
        OracleConnection conn = new OracleConnection(Login.connectionString);
        String userAdmin = "";
        public ChinhSuaPhongBanNS(String usrAdmin)
        {
            InitializeComponent();
            conn.Open();
            this.userAdmin = usrAdmin;
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadDataToComboBox_MaPB()
        {
            OracleCommand getMaNVData = conn.CreateCommand();
            getMaNVData.CommandText = "SELECT MAPB FROM " + userAdmin + " .PHONGBAN";
            getMaNVData.CommandType = CommandType.Text;
            OracleDataReader dataReader = getMaNVData.ExecuteReader();

            comboBoxMaPhongBan.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxMaPhongBan.Items.Add(dataReader["MAPB"].ToString());
            }
        }
        private void LoadDataToComboBox_MATP()
        {
            OracleCommand getMaNVData = conn.CreateCommand();
            getMaNVData.CommandText = "SELECT MANV FROM " + userAdmin + " .UV_NHANSU_NHANVIEN";
            getMaNVData.CommandType = CommandType.Text;
            OracleDataReader dataReader = getMaNVData.ExecuteReader();

            comboBoxTruongPhong.Items.Clear();
            while (dataReader.Read())
            {
                comboBoxTruongPhong.Items.Add(dataReader["MANV"].ToString());
            }
        }
        private void dataGridViewThemPhongBanNS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewThemPhongBanNS.Rows[e.RowIndex];
                comboBoxMaPhongBan.SelectedItem = row.Cells["MAPB"].Value.ToString();
                textBoxTenPhongBan.Text = row.Cells["TENPB"].Value.ToString();
                comboBoxTruongPhong.SelectedItem = row.Cells["TRPHG"].Value != DBNull.Value ? row.Cells["TRPHG"].Value.ToString() : null;
            }
        }

        private void ChinhSuaPhongBanNS_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox_MaPB();
            LoadDataToComboBox_MATP();
            dataGridViewThemPhongBanNS.CellClick += dataGridViewThemPhongBanNS_CellClick;
        }

        private void comboBoxMaPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTenPhongBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTruongPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand capNhatPhongBanCmd = new OracleCommand(userAdmin + ".USP_CAPNHAT_PHONGBAN_NS", conn);
                capNhatPhongBanCmd.CommandType = CommandType.StoredProcedure;

                capNhatPhongBanCmd.Parameters.Add("p_mapb", OracleDbType.Varchar2).Value = comboBoxMaPhongBan.SelectedItem?.ToString() ?? (object)DBNull.Value;
                capNhatPhongBanCmd.Parameters.Add("p_tenpb", OracleDbType.Varchar2).Value = textBoxTenPhongBan.Text;
                capNhatPhongBanCmd.Parameters.Add("p_trphg", OracleDbType.Varchar2).Value = comboBoxTruongPhong.SelectedItem?.ToString() ?? (object)DBNull.Value;

                OracleParameter outMessageParam = new OracleParameter("p_out_message", OracleDbType.NVarchar2, 500);
                outMessageParam.Direction = ParameterDirection.Output;
                capNhatPhongBanCmd.Parameters.Add(outMessageParam);

                capNhatPhongBanCmd.ExecuteNonQuery();
                string outMessage = outMessageParam.Value.ToString();
                MessageBox.Show(outMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXemTatCa_Click(object sender, EventArgs e)
        {
            OracleCommand getListPhongBan = conn.CreateCommand();
            getListPhongBan.CommandText = "SELECT * FROM " + userAdmin + " .PHONGBAN ORDER BY MAPB ASC";
            getListPhongBan.CommandType = CommandType.Text;
            OracleDataReader temp = getListPhongBan.ExecuteReader();
            DataTable table_DSPhongBan = new DataTable();
            table_DSPhongBan.Load(temp);
            dataGridViewThemPhongBanNS.DataSource = table_DSPhongBan;
        }

        private void dataGridViewThemPhongBanNS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
