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
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
            lopChung = new DAL.LOPDUNGCHUNG();
            BllCV = new BLL.BLL_CONGVIEC(this);
            BllNV = new BLL.BLL_NHANVIEN(this);
            BllTT = new BLL.BLL_TINHTHANH(this);
            

        }
        DAL.LOPDUNGCHUNG lopChung;
        BLL.BLL_CONGVIEC BllCV;
        BLL.BLL_NHANVIEN BllNV;
        BLL.BLL_TINHTHANH BllTT;
        int chon = 0;
        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadData();
            LoadLisBox();
        }
        public void LoadData()
        {
            BllNV.Bll_Data();
        }
        public void LoadCombo()
        {
            BllCV.Bll_Data();
        }
        public void LoadLisBox()
        {
            BllTT.Bll_Data();
        }
        private void cbb_congViec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chon == 0)
            {

                string text = cbb_congViec.SelectedValue.ToString();
                string sqlLoadData = "select * from NHANVIEN where MaCV = '" + text + "'";

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
                BllNV.Bll_Them();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chua co ten hinh ");
            }


            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                BllNV.Bll_Sua();
                pictureBox1.Image.Save(duongdan + txt_Hinh.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chua co ten hinh ");
            }

            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maNhanVien.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            txt_tenNhanVien.Text = dataGridView1.CurrentRow.Cells["TenNV"].Value.ToString();
            txt_mucLuong.Text = dataGridView1.CurrentRow.Cells["MucLuong"].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["NgayVaoLam"].Value.ToString());
            txt_Hinh.Text = dataGridView1.CurrentRow.Cells["TenHinh"].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_Hinh.Text;
            lb_tinhThanh.SelectedValue = dataGridView1.CurrentRow.Cells["MaTT"].Value.ToString();
            chon = 1;
            cbb_congViec.SelectedValue = dataGridView1.CurrentRow.Cells["MaCV"].Value.ToString();
            chon = 0;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                BllNV.Bll_Xoa();
                File.Delete(duongdan + txt_Hinh.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa hình");
            }

            LoadData();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            BllNV.Bll_Tim();
        }

       
    }
}
