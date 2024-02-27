namespace DoAnNhomCSharp.GUI
{
    partial class frm_MatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MatHang));
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_Hinh = new System.Windows.Forms.TextBox();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.txt_tenHang = new System.Windows.Forms.TextBox();
            this.txt_maHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_loaiHang = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_nhaCungCap = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(815, 131);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(100, 22);
            this.txt_tim.TabIndex = 37;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(718, 131);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 23);
            this.btn_tim.TabIndex = 36;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(841, 497);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 35;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(882, 203);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 34;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(800, 203);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 33;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(718, 204);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 32;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_Hinh
            // 
            this.txt_Hinh.Location = new System.Drawing.Point(318, 208);
            this.txt_Hinh.Name = "txt_Hinh";
            this.txt_Hinh.Size = new System.Drawing.Size(183, 22);
            this.txt_Hinh.TabIndex = 31;
            this.txt_Hinh.Text = "... .png .jpg";
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Location = new System.Drawing.Point(147, 150);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(147, 22);
            this.txt_GiaBan.TabIndex = 28;
            // 
            // txt_tenHang
            // 
            this.txt_tenHang.Location = new System.Drawing.Point(147, 116);
            this.txt_tenHang.Name = "txt_tenHang";
            this.txt_tenHang.Size = new System.Drawing.Size(147, 22);
            this.txt_tenHang.TabIndex = 27;
            // 
            // txt_maHang
            // 
            this.txt_maHang.Location = new System.Drawing.Point(147, 75);
            this.txt_maHang.Name = "txt_maHang";
            this.txt_maHang.Size = new System.Drawing.Size(147, 22);
            this.txt_maHang.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên Hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã Hàng";
            // 
            // cbb_loaiHang
            // 
            this.cbb_loaiHang.FormattingEnabled = true;
            this.cbb_loaiHang.Location = new System.Drawing.Point(147, 30);
            this.cbb_loaiHang.Name = "cbb_loaiHang";
            this.cbb_loaiHang.Size = new System.Drawing.Size(147, 24);
            this.cbb_loaiHang.TabIndex = 20;
            this.cbb_loaiHang.SelectedIndexChanged += new System.EventHandler(this.cbb_loaiHang_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(945, 247);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(318, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(147, 184);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(147, 22);
            this.txt_soLuong.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Loại Hàng:";
            // 
            // lb_nhaCungCap
            // 
            this.lb_nhaCungCap.FormattingEnabled = true;
            this.lb_nhaCungCap.ItemHeight = 16;
            this.lb_nhaCungCap.Location = new System.Drawing.Point(518, 12);
            this.lb_nhaCungCap.Name = "lb_nhaCungCap";
            this.lb_nhaCungCap.Size = new System.Drawing.Size(138, 212);
            this.lb_nhaCungCap.TabIndex = 40;
            // 
            // frm_MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(969, 529);
            this.Controls.Add(this.lb_nhaCungCap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_soLuong);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Hinh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_GiaBan);
            this.Controls.Add(this.txt_tenHang);
            this.Controls.Add(this.txt_maHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_loaiHang);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_MatHang";
            this.Text = "frm_MatHang";
            this.Load += new System.EventHandler(this.frm_MatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_Them;
        public System.Windows.Forms.TextBox txt_Hinh;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txt_GiaBan;
        public System.Windows.Forms.TextBox txt_tenHang;
        public System.Windows.Forms.TextBox txt_maHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbb_loaiHang;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox lb_nhaCungCap;
    }
}