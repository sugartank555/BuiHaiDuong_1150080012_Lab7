using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BuiHaiDuong_1150080012_Lab7
{
    public partial class Form4 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;

        string strCon = @"Data Source=LAPTOP-1OLPGQ5K\SUGAR;
                          Initial Catalog=QLBanHang;
                          Integrated Security=True;
                          TrustServerCertificate=True";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strCon);
            LoadData();
        }

        // Hàm nạp dữ liệu lên DataGridView
        private void LoadData()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM tblMatHang";
                da = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                da.Fill(dt);
                dgvDanhSach.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Nút thêm dữ liệu
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO tblMatHang(MaSP, TenSP, NgaySX, NgayHH, DonVi, DonGia, GhiChu) " +
                             "VALUES('SP01', N'Sản phẩm A', GETDATE(), DATEADD(DAY, 30, GETDATE()), N'Cái', 10000, N'Hàng mới')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm dữ liệu thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Nút sửa dữ liệu
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!");
                return;
            }

            string ma = dgvDanhSach.CurrentRow.Cells["MaSP"].Value.ToString();

            try
            {
                conn.Open();
                string sql = $"UPDATE tblMatHang SET TenSP = N'Sản phẩm cập nhật', DonGia = DonGia + 5000 WHERE MaSP = '{ma}'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã cập nhật thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Nút xóa dữ liệu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
                return;
            }

            string ma = dgvDanhSach.CurrentRow.Cells["MaSP"].Value.ToString();

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {ma} không?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string sql = $"DELETE FROM tblMatHang WHERE MaSP = '{ma}'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa dữ liệu thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
