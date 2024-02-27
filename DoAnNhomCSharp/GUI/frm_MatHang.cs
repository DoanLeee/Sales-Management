using DoAnNhomCSharp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhomCSharp.GUI
{
    public partial class frm_MatHang : Form
    {
        public frm_MatHang()
        {
            InitializeComponent();
            lopChung = new LOPDUNGCHUNG();
            BllLH = new BLL.BLL_LOAIHANG(this);
            BllNCC = new BLL.BLL_NHACUNGCAP(this);
            BllMH = new BLL.BLL_MATHANG(this);
        }
        LOPDUNGCHUNG lopChung;
        BLL.BLL_LOAIHANG BllLH;
        BLL.BLL_NHACUNGCAP BllNCC;
        BLL.BLL_MATHANG BllMH;
        private void frm_MatHang_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadLisbox();
            LoadData();
        }
        public void LoadCombo()
        {
            BllLH.Bll_Data();
        }
        public void LoadLisbox()
        {
            BllNCC.Bll_Data();
        }
        public void LoadData()
        {
            BllMH.Bll_Data();
        }
        int chon = 0;
        private void cbb_loaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chon == 0)
            {
                string text = cbb_loaiHang.SelectedValue.ToString();
                string sqlLoadData = "select * from MATHANG where MaLoaiHang = '" + text + "'";
                dataGridView1.DataSource = lopChung.LoadDuLieu(sqlLoadData);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hãy Chọn file"; //tieude
            OFD.Filter = "Tất Cả Đuôi |*.*|Đuôi JPG|*.jpg|Đuôi PNG|*.png|Đuôi JPEG|*.jpeg";//loc duoi anh
            if (OFD.ShowDialog() == DialogResult.OK) pictureBox1.Image = Image.FromFile(OFD.FileName);

        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(duongdan + txt_Hinh.Text);
                BllMH.Bll_Them();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chua co ten hinh ");
            }
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maHang.Text = dataGridView1.CurrentRow.Cells["MaHang"].Value.ToString();
            txt_tenHang.Text = dataGridView1.CurrentRow.Cells["TenHang"].Value.ToString();
            txt_GiaBan.Text = dataGridView1.CurrentRow.Cells["Gia"].Value.ToString();
            txt_soLuong.Text = dataGridView1.CurrentRow.Cells["soLuong"].Value.ToString();
            txt_Hinh.Text = dataGridView1.CurrentRow.Cells["TenHinh"].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_Hinh.Text;
            lb_nhaCungCap.SelectedValue = dataGridView1.CurrentRow.Cells["MaNCC"].Value.ToString();
            chon = 1;
            cbb_loaiHang.SelectedValue = dataGridView1.CurrentRow.Cells["MaLoaiHang"].Value.ToString();
            chon = 0;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                BllMH.Bll_Sua();
                pictureBox1.Image.Save(duongdan + txt_Hinh.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chua co ten hinh ");
            }
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                BllMH.Bll_Xoa();
                File.Delete(duongdan + txt_Hinh.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa hình");
            }

            LoadData();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            BllMH.BLL_Tim();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
