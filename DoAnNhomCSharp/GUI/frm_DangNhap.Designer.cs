namespace DoAnNhomCSharp
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.txt_tenDangNhap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_dangNhap.Image")));
            this.btn_dangNhap.Location = new System.Drawing.Point(101, 519);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(182, 50);
            this.btn_dangNhap.TabIndex = 9;
            this.btn_dangNhap.UseVisualStyleBackColor = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click_1);
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.BackColor = System.Drawing.Color.LightGray;
            this.txt_matKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matKhau.Location = new System.Drawing.Point(84, 411);
            this.txt_matKhau.Multiline = true;
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(267, 32);
            this.txt_matKhau.TabIndex = 8;
            this.txt_matKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.BackColor = System.Drawing.Color.LightGray;
            this.txt_tenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenDangNhap.Location = new System.Drawing.Point(84, 349);
            this.txt_tenDangNhap.Multiline = true;
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Size = new System.Drawing.Size(267, 32);
            this.txt_tenDangNhap.TabIndex = 7;
            this.txt_tenDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tenDangNhap.TextChanged += new System.EventHandler(this.txt_tenDangNhap_TextChanged);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(383, 647);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.txt_matKhau);
            this.Controls.Add(this.txt_tenDangNhap);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_dangNhap;
        public System.Windows.Forms.TextBox txt_matKhau;
        public System.Windows.Forms.TextBox txt_tenDangNhap;
    }
}