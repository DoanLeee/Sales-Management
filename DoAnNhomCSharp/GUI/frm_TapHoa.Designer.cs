namespace DoAnNhomCSharp.GUI
{
    partial class frm_TapHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TapHoa));
            this.panel_trai = new System.Windows.Forms.Panel();
            this.btn_dangXuat = new System.Windows.Forms.Button();
            this.btn_banHang = new System.Windows.Forms.Button();
            this.btn_matHang = new System.Windows.Forms.Button();
            this.btn_nhanVien = new System.Windows.Forms.Button();
            this.panel_tren = new System.Windows.Forms.Panel();
            this.btn_troVeTrangChu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_giua = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_trai.SuspendLayout();
            this.panel_tren.SuspendLayout();
            this.panel_giua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_trai
            // 
            this.panel_trai.BackColor = System.Drawing.Color.LightPink;
            this.panel_trai.Controls.Add(this.btn_troVeTrangChu);
            this.panel_trai.Controls.Add(this.btn_dangXuat);
            this.panel_trai.Controls.Add(this.btn_banHang);
            this.panel_trai.Controls.Add(this.btn_matHang);
            this.panel_trai.Controls.Add(this.btn_nhanVien);
            this.panel_trai.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_trai.Location = new System.Drawing.Point(0, 0);
            this.panel_trai.Name = "panel_trai";
            this.panel_trai.Size = new System.Drawing.Size(266, 694);
            this.panel_trai.TabIndex = 0;
            // 
            // btn_dangXuat
            // 
            this.btn_dangXuat.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_dangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangXuat.Location = new System.Drawing.Point(63, 567);
            this.btn_dangXuat.Name = "btn_dangXuat";
            this.btn_dangXuat.Size = new System.Drawing.Size(123, 46);
            this.btn_dangXuat.TabIndex = 2;
            this.btn_dangXuat.Text = "Đăng Xuất";
            this.btn_dangXuat.UseVisualStyleBackColor = false;
            this.btn_dangXuat.Click += new System.EventHandler(this.btn_dangXuat_Click);
            // 
            // btn_banHang
            // 
            this.btn_banHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_banHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_banHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_banHang.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_banHang.ForeColor = System.Drawing.Color.White;
            this.btn_banHang.Location = new System.Drawing.Point(0, 94);
            this.btn_banHang.Name = "btn_banHang";
            this.btn_banHang.Size = new System.Drawing.Size(266, 47);
            this.btn_banHang.TabIndex = 3;
            this.btn_banHang.Text = "Bán Hàng";
            this.btn_banHang.UseVisualStyleBackColor = false;
            this.btn_banHang.Click += new System.EventHandler(this.btn_banHang_Click);
            // 
            // btn_matHang
            // 
            this.btn_matHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_matHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_matHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_matHang.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_matHang.ForeColor = System.Drawing.Color.White;
            this.btn_matHang.Location = new System.Drawing.Point(0, 47);
            this.btn_matHang.Name = "btn_matHang";
            this.btn_matHang.Size = new System.Drawing.Size(266, 47);
            this.btn_matHang.TabIndex = 2;
            this.btn_matHang.Text = "Mặt Hàng";
            this.btn_matHang.UseVisualStyleBackColor = false;
            this.btn_matHang.Click += new System.EventHandler(this.btn_matHang_Click);
            // 
            // btn_nhanVien
            // 
            this.btn_nhanVien.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_nhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhanVien.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_nhanVien.Location = new System.Drawing.Point(0, 0);
            this.btn_nhanVien.Name = "btn_nhanVien";
            this.btn_nhanVien.Size = new System.Drawing.Size(266, 47);
            this.btn_nhanVien.TabIndex = 1;
            this.btn_nhanVien.Text = "Nhân Viên";
            this.btn_nhanVien.UseVisualStyleBackColor = false;
            this.btn_nhanVien.Click += new System.EventHandler(this.btn_nhanVien_Click);
            // 
            // panel_tren
            // 
            this.panel_tren.BackColor = System.Drawing.Color.LightPink;
            this.panel_tren.Controls.Add(this.label1);
            this.panel_tren.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_tren.Location = new System.Drawing.Point(266, 0);
            this.panel_tren.Name = "panel_tren";
            this.panel_tren.Size = new System.Drawing.Size(986, 141);
            this.panel_tren.TabIndex = 1;
            // 
            // btn_troVeTrangChu
            // 
            this.btn_troVeTrangChu.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_troVeTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_troVeTrangChu.Location = new System.Drawing.Point(63, 472);
            this.btn_troVeTrangChu.Name = "btn_troVeTrangChu";
            this.btn_troVeTrangChu.Size = new System.Drawing.Size(123, 46);
            this.btn_troVeTrangChu.TabIndex = 1;
            this.btn_troVeTrangChu.Text = "Home";
            this.btn_troVeTrangChu.UseVisualStyleBackColor = false;
            this.btn_troVeTrangChu.Click += new System.EventHandler(this.btn_troVeTrangChu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(387, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_giua
            // 
            this.panel_giua.Controls.Add(this.pictureBox1);
            this.panel_giua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_giua.Location = new System.Drawing.Point(266, 141);
            this.panel_giua.Name = "panel_giua";
            this.panel_giua.Size = new System.Drawing.Size(986, 553);
            this.panel_giua.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(986, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_TapHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1252, 694);
            this.Controls.Add(this.panel_giua);
            this.Controls.Add(this.panel_tren);
            this.Controls.Add(this.panel_trai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_TapHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạp Hóa ";
            this.Load += new System.EventHandler(this.frm_TapHoa_Load);
            this.panel_trai.ResumeLayout(false);
            this.panel_tren.ResumeLayout(false);
            this.panel_tren.PerformLayout();
            this.panel_giua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_trai;
        private System.Windows.Forms.Panel panel_tren;
        private System.Windows.Forms.Panel panel_giua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nhanVien;
        private System.Windows.Forms.Button btn_banHang;
        private System.Windows.Forms.Button btn_matHang;
        private System.Windows.Forms.Button btn_troVeTrangChu;
        private System.Windows.Forms.Button btn_dangXuat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}