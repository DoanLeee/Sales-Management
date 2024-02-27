using DoAnNhomCSharp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhomCSharp.GUI
{
    public partial class frm_BanHang : Form
    {
        public frm_BanHang()
        {
            InitializeComponent();
            lopChung = new LOPDUNGCHUNG();
            BllNVBH = new BLL.BLL_NHANVIENBH(this);
            BllMHBH = new BLL.BLL_MATHANGBH(this);
            BllBH = new BLL.BLL_BANHANG(this);
        }
        LOPDUNGCHUNG lopChung;
        BLL.BLL_NHANVIENBH BllNVBH;
        BLL.BLL_MATHANGBH BllMHBH;
        BLL.BLL_BANHANG BllBH;
        public void LoadCombo()
        {
            BllNVBH.Bll_Data();
            BllMHBH.Bll_Data();
        }
        private void frm_BanHang_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadData();
        }
        public void LoadData()
        {
            BllBH.Bll_Data();
        }
        private void cbb_tenHang_SelectedIndexChanged(object sender, EventArgs e)
        {     
            string sql = "SELECT SOLUONG FROM MATHANG WHERE MAHANG = '"+cbb_tenHang.SelectedValue+"'";
            int dem = (int)lopChung.LaySoLuongMatHang(sql);
            txt_soLuongTon.Text = dem.ToString();
        }

        private void txt_soLuong_TextChanged(object sender, EventArgs e)
        {
            float soLuong, giaBan;
            if (float.TryParse(txt_soLuong.Text, out soLuong) && float.TryParse(txt_giaBan.Text, out giaBan))
            {
                float thanhTien = soLuong * giaBan;
                txt_thanhTien.Text = thanhTien.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            BllBH.Bll_Them();
            LoadData();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            BllBH.BLL_Tim();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maHoaDon.Text = dataGridView1.CurrentRow.Cells["MaHoaDon"].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["NgayBan"].Value.ToString());
            cbb_nhanVien.SelectedValue = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            cbb_tenHang.SelectedValue = dataGridView1.CurrentRow.Cells["MaHang"].Value.ToString();
            txt_giaBan.Text = dataGridView1.CurrentRow.Cells["GiaBan"].Value.ToString();
            txt_soLuong.Text = dataGridView1.CurrentRow.Cells["SoLuong"].Value.ToString();
            txt_thanhTien.Text = dataGridView1.CurrentRow.Cells["ThanhTien"].Value.ToString();

        }
    }
}
