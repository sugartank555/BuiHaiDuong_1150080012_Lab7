using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BuiHaiDuong_1150080012_Lab7
{
    public partial class Form1 : Form
    {
        // 🔹 Chuỗi kết nối tới SQL Server của bạn
        string strCon = @"Data Source=LAPTOP-1OLPGQ5K\SUGAR;
                          Initial Catalog=QuanLyBanSach;
                          Integrated Security=True;
                          TrustServerCertificate=True";

        // 🔹 Đối tượng kết nối
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        // 🟢 Hàm mở kết nối
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        // 🔴 Hàm đóng kết nối
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        // 🖱️ Xử lý sự kiện khi bấm nút Hiển thị danh sách
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();

                // Câu lệnh SQL hiển thị dữ liệu
                string sql = "SELECT * FROM NhaXuatBan";

                // SqlDataAdapter để lấy dữ liệu
                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);

                // Đổ dữ liệu vào DataSet
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblNhaXuatBan");

                // Gán nguồn dữ liệu cho DataGridView
                dgvDanhSach.DataSource = ds.Tables["tblNhaXuatBan"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }
    }
}
