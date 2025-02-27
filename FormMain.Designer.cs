﻿namespace Project
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHSBN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhieu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhieuKhamBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToaThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuDanhMuc,
            this.menuPhieu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.menuExit.Size = new System.Drawing.Size(180, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // menuDanhMuc
            // 
            this.menuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThuoc,
            this.menuHSBN,
            this.menuUser});
            this.menuDanhMuc.Name = "menuDanhMuc";
            this.menuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.menuDanhMuc.Text = "Danh Mục";
            // 
            // menuThuoc
            // 
            this.menuThuoc.Name = "menuThuoc";
            this.menuThuoc.Size = new System.Drawing.Size(180, 22);
            this.menuThuoc.Text = "Thuốc";
            this.menuThuoc.Click += new System.EventHandler(this.menuThuoc_Click);
            // 
            // menuHSBN
            // 
            this.menuHSBN.Name = "menuHSBN";
            this.menuHSBN.Size = new System.Drawing.Size(180, 22);
            this.menuHSBN.Text = "Hồ sơ bệnh nhân";
            this.menuHSBN.Click += new System.EventHandler(this.menuHSBN_Click);
            // 
            // menuPhieu
            // 
            this.menuPhieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPhieuKhamBenh,
            this.menuToaThuoc});
            this.menuPhieu.Name = "menuPhieu";
            this.menuPhieu.Size = new System.Drawing.Size(49, 20);
            this.menuPhieu.Text = "Phiếu";
            // 
            // menuPhieuKhamBenh
            // 
            this.menuPhieuKhamBenh.Name = "menuPhieuKhamBenh";
            this.menuPhieuKhamBenh.Size = new System.Drawing.Size(167, 22);
            this.menuPhieuKhamBenh.Text = "Phiếu khám bệnh";
            this.menuPhieuKhamBenh.Click += new System.EventHandler(this.menuPhieuKhamBenh_Click);
            // 
            // menuToaThuoc
            // 
            this.menuToaThuoc.Name = "menuToaThuoc";
            this.menuToaThuoc.Size = new System.Drawing.Size(167, 22);
            this.menuToaThuoc.Text = "Toa thuốc";
            this.menuToaThuoc.Click += new System.EventHandler(this.menuToaThuoc_Click);
            // 
            // menuUser
            // 
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(180, 22);
            this.menuUser.Text = "User";
            this.menuUser.Click += new System.EventHandler(this.menuUser_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng khám Tư Nhân";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem menuThuoc;
        private System.Windows.Forms.ToolStripMenuItem menuHSBN;
        private System.Windows.Forms.ToolStripMenuItem menuPhieu;
        private System.Windows.Forms.ToolStripMenuItem menuPhieuKhamBenh;
        private System.Windows.Forms.ToolStripMenuItem menuToaThuoc;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuUser;
    }
}

