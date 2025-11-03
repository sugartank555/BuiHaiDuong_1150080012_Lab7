using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BuiHaiDuong_1150080012_Lab7
{
    public partial class Form3 : Form
    {
        string strCon = @"Data Source=LAPTOP-1OLPGQ5K\SUGAR;
                          Initial Catalog=QuanLyBanSach;
                          Integrated Security=True;
                          TrustServerCertificate=True";

        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        int vt = -1;

        public Form3()
        {
            InitializeComponent();
        }

        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        private void HienThiDuLieu()
        {
            MoKetNoi();
            string query = "SELECT * FROM NhaXuatBan";
            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "tblNhaXuatBan");
            dgvDanhSach.DataSource = ds.Tables["tblNhaXuatBan"];
            DongKetNoi();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;

            DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt];
            txtMaXB.Text = row["MaXB"].ToString().Trim();
            txtTenXB.Text = row["TenXB"].ToString().Trim();
            txtDiaChi.Text = row["DiaChi"].ToString().Trim();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa!");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa bản ghi này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt];
                    row.Delete();

                    int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]);
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                        HienThiDuLieu();
                        txtMaXB.Text = txtTenXB.Text = txtDiaChi.Text = "";
                    }
                    else
                        MessageBox.Show("Không thể xóa dữ liệu!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
