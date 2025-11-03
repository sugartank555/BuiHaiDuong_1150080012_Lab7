namespace BuiHaiDuong_1150080012_Lab7
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.TextBox txtMaXB;
        private System.Windows.Forms.TextBox txtTenXB;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMaXB;
        private System.Windows.Forms.Label lblTenXB;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Label lblNhapThongTin;
        private System.Windows.Forms.Label lblTieuDe;

        private void InitializeComponent()
        {
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMaXB = new System.Windows.Forms.Label();
            this.lblTenXB = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lblNhapThongTin = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();

            // lblTieuDe
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(270, 10);
            this.lblTieuDe.Text = "Xóa dữ liệu Nhà xuất bản";

            // lblDanhSach
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Location = new System.Drawing.Point(20, 50);
            this.lblDanhSach.Text = "Danh sách nhà xuất bản:";

            // dgvDanhSach
            this.dgvDanhSach.Location = new System.Drawing.Point(20, 70);
            this.dgvDanhSach.Size = new System.Drawing.Size(400, 300);
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);

            // lblNhapThongTin
            this.lblNhapThongTin.AutoSize = true;
            this.lblNhapThongTin.Location = new System.Drawing.Point(450, 50);
            this.lblNhapThongTin.Text = "Thông tin cần xóa:";

            // lblMaXB
            this.lblMaXB.AutoSize = true;
            this.lblMaXB.Location = new System.Drawing.Point(450, 90);
            this.lblMaXB.Text = "Mã NXB:";

            // txtMaXB
            this.txtMaXB.Location = new System.Drawing.Point(520, 85);
            this.txtMaXB.Width = 200;

            // lblTenXB
            this.lblTenXB.AutoSize = true;
            this.lblTenXB.Location = new System.Drawing.Point(450, 130);
            this.lblTenXB.Text = "Tên NXB:";

            // txtTenXB
            this.txtTenXB.Location = new System.Drawing.Point(520, 125);
            this.txtTenXB.Width = 200;

            // lblDiaChi
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(450, 170);
            this.lblDiaChi.Text = "Địa chỉ:";

            // txtDiaChi
            this.txtDiaChi.Location = new System.Drawing.Point(520, 165);
            this.txtDiaChi.Width = 200;

            // btnXoa
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnXoa.Location = new System.Drawing.Point(520, 210);
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // Form3
            this.ClientSize = new System.Drawing.Size(760, 400);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.lblNhapThongTin);
            this.Controls.Add(this.lblMaXB);
            this.Controls.Add(this.txtMaXB);
            this.Controls.Add(this.lblTenXB);
            this.Controls.Add(this.txtTenXB);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.btnXoa);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa dữ liệu - Lab 7 (Form3)";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
