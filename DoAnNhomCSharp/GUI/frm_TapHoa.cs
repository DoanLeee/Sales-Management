using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhomCSharp.GUI
{
    public partial class frm_TapHoa : Form
    {
        public frm_TapHoa()
        {
            InitializeComponent();
        }

        private void frm_TapHoa_Load(object sender, EventArgs e)
        {
            btn_troVeTrangChu.Hide();
        }
        private Form hienformCon;
        private void OpenFormCon( Form formCon)
        {
            if (hienformCon != null)
            {
                hienformCon.Close();
            }
            hienformCon = formCon;
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            panel_giua.Controls.Add(formCon);
            panel_giua.Tag = formCon;
            formCon.BringToFront();
            formCon.Show();
        }

        private void btn_nhanVien_Click(object sender, EventArgs e)
        {
            OpenFormCon(new frm_NhanVien());
            label1.Text = btn_nhanVien.Text;
            btn_troVeTrangChu.Show();
        }

        private void btn_troVeTrangChu_Click(object sender, EventArgs e)
        {
            if (hienformCon != null)
            {
                hienformCon.Close();
            }
            label1.Text = "Home";
            btn_troVeTrangChu.Hide();
        }

        private void btn_matHang_Click(object sender, EventArgs e)
        {
            OpenFormCon(new frm_MatHang());
            label1.Text = btn_matHang.Text;
            btn_troVeTrangChu.Show();
        }

        private void btn_banHang_Click(object sender, EventArgs e)
        {
            OpenFormCon(new frm_BanHang());
            label1.Text = btn_banHang.Text;
            btn_troVeTrangChu.Show();
        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_DangNhap dn = new frm_DangNhap();
            dn.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
