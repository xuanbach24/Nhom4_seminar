namespace QuanLyNhanSu
{
    partial class frm_ribbon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ribbon));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_phongban = new DevExpress.XtraBars.BarButtonItem();
            this.btn_nhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_duan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_phutrach = new DevExpress.XtraBars.BarButtonItem();
            this.btn_BieuMau = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xuatbieumau = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_phongban,
            this.btn_nhanvien,
            this.btn_duan,
            this.btn_phutrach,
            this.btn_BieuMau,
            this.btn_xuatbieumau});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1094, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_phongban
            // 
            this.btn_phongban.Caption = "Phòng Ban";
            this.btn_phongban.Id = 1;
            this.btn_phongban.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_phongban.ImageOptions.LargeImage")));
            this.btn_phongban.Name = "btn_phongban";
            this.btn_phongban.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_phongban_ItemClick);
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.Caption = "Nhân Viên";
            this.btn_nhanvien.Id = 2;
            this.btn_nhanvien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_nhanvien.ImageOptions.LargeImage")));
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_nhanvien_ItemClick);
            // 
            // btn_duan
            // 
            this.btn_duan.Caption = "Dự Án";
            this.btn_duan.Id = 3;
            this.btn_duan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_duan.ImageOptions.LargeImage")));
            this.btn_duan.Name = "btn_duan";
            this.btn_duan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_duan_ItemClick);
            // 
            // btn_phutrach
            // 
            this.btn_phutrach.Caption = "Phụ Trách Dự Án";
            this.btn_phutrach.Id = 4;
            this.btn_phutrach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_phutrach.ImageOptions.LargeImage")));
            this.btn_phutrach.Name = "btn_phutrach";
            this.btn_phutrach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_phutrach_ItemClick);
            // 
            // btn_BieuMau
            // 
            this.btn_BieuMau.ActAsDropDown = true;
            this.btn_BieuMau.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btn_BieuMau.Caption = "Biểu Mẫu";
            this.btn_BieuMau.Id = 5;
            this.btn_BieuMau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_BieuMau.ImageOptions.LargeImage")));
            this.btn_BieuMau.Name = "btn_BieuMau";
            this.btn_BieuMau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_BieuMau_ItemClick);
            // 
            // btn_xuatbieumau
            // 
            this.btn_xuatbieumau.Caption = "Xuất Biểu Mẫu";
            this.btn_xuatbieumau.Id = 6;
            this.btn_xuatbieumau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_xuatbieumau.ImageOptions.LargeImage")));
            this.btn_xuatbieumau.Name = "btn_xuatbieumau";
            this.btn_xuatbieumau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_xuatbieumau_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Danh Mục";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_phongban);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_nhanvien);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_duan);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_phutrach);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_BieuMau);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Danh Mục Quản Lý";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 775);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1094, 30);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // frm_ribbon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 805);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frm_ribbon";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frm_ribbon";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btn_phongban;
        private DevExpress.XtraBars.BarButtonItem btn_nhanvien;
        private DevExpress.XtraBars.BarButtonItem btn_duan;
        private DevExpress.XtraBars.BarButtonItem btn_phutrach;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btn_BieuMau;
        private DevExpress.XtraBars.BarButtonItem btn_xuatbieumau;
    }
}