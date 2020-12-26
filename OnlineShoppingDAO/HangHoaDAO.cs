using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OnlineShoppingDAO
{
    public class HangHoaDAO : DBConnect
    {
        private static HangHoaDAO _instance = null;

        public static HangHoaDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HangHoaDAO();
                }

                return _instance;
            }
        }

        public DataTable GetAll()
        {
            DataTable db = new DataTable();

            string query = "select * from HangHoa HH, LoaiHang LH, DanhMuc DM, ThongTinHangTon T where HH.MaLoaiHang = LH.MaLoaiHang " +
                "and LH.MaDanhMuc = DM.MaDanhMuc and T.MaHangHoa = HH.MaHangHoa";

            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(db);

            return db;
        }

        public DataTable GetNumberOfProducts()
        {
            DataTable db = new DataTable();

            string query = "select count(*) as Amount from HangHoa";

            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(db);           

            return db;
        }

        public DataTable GetBasketID()
        {
            DataTable result = new DataTable();

            string query = "select MaDon from DonDatHang where NgayLapDon = NULL";

            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(result);

            return result;
        }

        public DataTable GetProduct(int id)
        {
            DataTable db = new DataTable();

            string query = $"select * from HangHoa HH, LoaiHang LH, DanhMuc DM, ThongTinHangTon T where HH.MaLoaiHang = LH.MaLoaiHang " +
                $"and LH.MaDanhMuc = DM.MaDanhMuc and T.MaHangHoa = HH.MaHangHoa and HH.MaHangHoa = {id}";

            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(db);

            return db;
        }

        public DataTable GetProductOfSeller()
        {
            DataTable db = new DataTable();

            string query = $"select * from HangHoa HH, DanhMuc DM, LoaiHang LH, ThongTinCungCap CC where HH.MaHangHoa = CC.MaHangHoa " +
                $"and CC.MaDonVi = 1 and HH.MaLoaiHang = LH.MaLoaiHang and LH.MaDanhMuc = DM.MaDanhMuc";

            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(db);

            return db;
        }

        public void AddProductToStorage(int maHangHoa, int soLuong)
        {
            string query = $"insert into ThongTinHangTon(MaHangHoa, MaKho, SoLuongTonKho) values ({maHangHoa}, 1, {soLuong})";

            _conn.Open();
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public void AddProduct(int maHangHoa, string tenHangHoa, float giaHangHoa, int loaiHangHoa)
        {
            string query = $"insert into HangHoa(MaHangHoa, TenHangHoa, MaLoaiHang, DonGia) values ({maHangHoa}, N'{tenHangHoa}', {loaiHangHoa}, {giaHangHoa})";

            _conn.Open();
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
            
        }

        public void AddSupplyInfo(int maHangHoa)
        {
            string query = $"insert into ThongTinCungCap(MaDonVi, MaHangHoa) values (1, {maHangHoa})";

            _conn.Open();
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public DataTable SearchProduct(string input)
        {
            DataTable db = new DataTable();

            string query = "select * from HangHoa HH, LoaiHang LH, DanhMuc DM, ThongTinHangTon T " +
                $"where HH.MaLoaiHang = LH.MaLoaiHang and LH.MaDanhMuc = DM.MaDanhMuc and T.MaHangHoa = HH.MaHangHoa and HH.TenHangHoa like N'%{input}%'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(db);

            return db;
        }
    }
}
