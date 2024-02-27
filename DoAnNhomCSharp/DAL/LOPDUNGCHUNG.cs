using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhomCSharp.DAL
{
    class LOPDUNGCHUNG
    {
        string chuoiKetNoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.NET\DoAnNhomCSharp\DoAnNhomCSharp\DoAnNhom.mdf;Integrated Security=True";
        SqlConnection conn;
        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection(chuoiKetNoi);
        }
        public DataTable LoadDuLieu(string sqlLoadCombo)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlLoadCombo, conn); 
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            return dt;
        }
        public void Nonquery(string sqlNon)
        {
            SqlCommand comm = new SqlCommand(sqlNon, conn);
            conn.Open();
            try
            {
                int ketqua = comm.ExecuteNonQuery();
                if (ketqua >= 1) MessageBox.Show("Thành công");
                else MessageBox.Show("Lỗi TRY, .....");
            }
            catch
            {
                MessageBox.Show("Lỗi Catch, Lỗi trùng mã, Lỗi SQL ....." 
                    +"Hoặc Tên Hình Không Đúng Kiểu");

            }
            finally
            {
                conn.Close();
            }
        }
        public void CapNhat(string sqlNon)
        {
            SqlCommand comm = new SqlCommand(sqlNon, conn);
            conn.Open();
            try
            {
                int ketqua = comm.ExecuteNonQuery();
                if (ketqua >= 1) { }
                else MessageBox.Show("Lỗi TRY, .....");
            }
            catch
            {
                MessageBox.Show("Lỗi Catch, Lỗi trùng mã, Lỗi SQL ....."
                    + "Hoặc Tên Hình Không Đúng Kiểu");

            }
            finally
            {
                conn.Close();
            }
        }
        public int ThemTraVe(string sqlNon)
        {
            int rowsAffected = 0;
            SqlCommand comm = new SqlCommand(sqlNon, conn);
            conn.Open();
            try
            {
                rowsAffected = comm.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Lỗi Catch, Lỗi trùng mã, Lỗi SQL ....."
                    + "Hoặc Tên Hình Không Đúng Kiểu");
            }
            finally
            {
                conn.Close();
            }
            return rowsAffected;
        }
        public object Scalar(string sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, conn);
            conn.Open();
            int dem = (int)comm.ExecuteScalar();
            conn.Close();
            return dem;
        }
        public int LaySoLuongMatHang(string sql)
        {
            int soLuong = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                soLuong = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return soLuong;
        }
    }
}
