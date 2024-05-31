using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.Class;
namespace QLBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.mnuTeptin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoatF = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHangH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCHangT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDoanhT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroG = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHienTroG = new System.Windows.Forms.ToolStripMenuItem();
            this.mnnuVaiN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip3.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // menuStrip3
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTeptin,
            this.mnuDanhMuc,
            this.mnuHD,
            this.mnuTimK,
            this.mnuBaoC,
            this.mnuTroG});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(786, 28);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            this.menuStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip3_ItemClicked);
            // mnuTeptin
            this.mnuTeptin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoatF});
            this.mnuTeptin.Name = "mnuTeptin";
            this.mnuTeptin.Size = new System.Drawing.Size(69, 24);
            this.mnuTeptin.Text = "&Tệp tin";
            // mnuThoatF            this.mnuThoatF.Name = "mnuThoatF";
            this.mnuThoatF.Size = new System.Drawing.Size(130, 26);
            this.mnuThoatF.Text = "&Thoát";
            this.mnuThoatF.Click += new System.EventHandler(this.mnuThoatF_Click);
            // mnuDanhMuc
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSP,
            this.mnuHangH,
            this.mnuNV,
            this.mnuKhachH});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(94, 24);
            this.mnuDanhMuc.Text = "&Danh mục ";
            // mnuSP
            this.mnuSP.Name = "mnuSP";
            this.mnuSP.Size = new System.Drawing.Size(224, 26);
            this.mnuSP.Text = "&Sản phẩm";
            this.mnuSP.Click += new System.EventHandler(this.mnuSP_Click); 
            // mnuHangH 
            this.mnuHangH.Name = "mnuHangH";
            this.mnuHangH.Size = new System.Drawing.Size(224, 26);
            this.mnuHangH.Text = "&Hàng hóa";
            this.mnuHangH.Click += new System.EventHandler(this.mnuHangH_Click);
            // mnuNV
            this.mnuNV.Name = "mnuNV";
            this.mnuNV.Size = new System.Drawing.Size(224, 26);
            this.mnuNV.Text = "&Nhân Viên";
            this.mnuNV.Click += new System.EventHandler(this.mnuNV_Click);
            // mnuKhachH
            this.mnuKhachH.Name = "mnuKhachH";
            this.mnuKhachH.Size = new System.Drawing.Size(224, 26);
            this.mnuKhachH.Text = "&Khách hàng";
            this.mnuKhachH.Click += new System.EventHandler(this.mnuKhachH_Click);
            // mnuHD
            this.mnuHD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHDBan});
            this.mnuHD.Name = "mnuHD";
            this.mnuHD.Size = new System.Drawing.Size(81, 24);
            this.mnuHD.Text = "&Hóa đơn";
            // mnuHDBan
            this.mnuHDBan.Name = "mnuHDBan";
            this.mnuHDBan.Size = new System.Drawing.Size(179, 26);
            this.mnuHDBan.Text = "&Hóa đơn bán";
            // mnuTimK
            this.mnuTimK.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTimHD,
            this.mnuTimH,
            this.mnuTimKH});
            this.mnuTimK.Name = "mnuTimK";
            this.mnuTimK.Size = new System.Drawing.Size(84, 24);
            this.mnuTimK.Text = "&Tìm kiếm";
            // mnuTimHD 
            this.mnuTimHD.Name = "mnuTimHD";
            this.mnuTimHD.Size = new System.Drawing.Size(169, 26);
            this.mnuTimHD.Text = "&Hóa đơn";
            // mnuTimH
            this.mnuTimH.Name = "mnuTimH";
            this.mnuTimH.Size = new System.Drawing.Size(169, 26);
            this.mnuTimH.Text = "&Hàng";
            // mnuTimKH 
            this.mnuTimKH.Name = "mnuTimKH";
            this.mnuTimKH.Size = new System.Drawing.Size(169, 26);
            this.mnuTimKH.Text = "&Khách hàng";
            // mnuBaoC
            this.mnuBaoC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBCHangT,
            this.mnuBCDoanhT});
            this.mnuBaoC.Name = "mnuBaoC";
            this.mnuBaoC.Size = new System.Drawing.Size(77, 24);
            this.mnuBaoC.Text = "&Báo cáo";
            // mnuBCHangT
            this.mnuBCHangT.Name = "mnuBCHangT";
            this.mnuBCHangT.Size = new System.Drawing.Size(161, 26);
            this.mnuBCHangT.Text = "&Hàng tồn";
            // mnuBCDoanhT
            this.mnuBCDoanhT.Name = "mnuBCDoanhT";
            this.mnuBCDoanhT.Size = new System.Drawing.Size(161, 26);
            this.mnuBCDoanhT.Text = "&Doanh thu";
            // mnuTroG
            this.mnuTroG.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHienTroG,
            this.mnnuVaiN});
            this.mnuTroG.Name = "mnuTroG";
            this.mnuTroG.Size = new System.Drawing.Size(78, 24);
            this.mnuTroG.Text = "&Trợ giúp";
            // mnuHienTroG
            this.mnuHienTroG.Name = "mnuHienTroG";
            this.mnuHienTroG.Size = new System.Drawing.Size(147, 26);
            this.mnuHienTroG.Text = "&Trợ giúp"; 
            // mnnuVaiN 
            this.mnnuVaiN.Name = "mnnuVaiN";
            this.mnnuVaiN.Size = new System.Drawing.Size(147, 26);
            this.mnnuVaiN.Text = "&Vài nét"; 
            // toolStrip3
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripLabel1});
            this.toolStrip3.Location = new System.Drawing.Point(0, 28);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(786, 27);
            this.toolStrip3.TabIndex = 3;
            this.toolStrip3.Text = "toolStrip3";
            // toolStripButton3
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // toolStripLabel1
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 24);
            // frmMain
            this.ClientSize = new System.Drawing.Size(786, 594);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.menuStrip3);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip3;
            this.Name = "frmMain";
            this.Text = "Quản lý bán Mỹ Phẩm";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect(); //Mở kết nối
        }

        private void mnuThoatF_Click(object sender, EventArgs e)
        {
            Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void mnuSP_Click(object sender, EventArgs e)
        {
            frmDMSanPham frm = new frmDMSanPham();//Khởi tạo đối tượng
            frm.ShowDialog(); //Hiển thị
        }
        private void mnuNV_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.MdiParent = this;// form con nằm trong frm cha
            frm.Show();
        }
        private void mnuKhachH_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frm = new frmDMKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }
        private void mnuHangH_Click(object sender, EventArgs e)
        {
            frmDMHang frm = new frmDMHang();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
