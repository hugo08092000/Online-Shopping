using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShoppingDAO
{
    public class DonDatHangDAO : DBConnect
    {
        private static DonDatHangDAO _instance = null;

        public static DonDatHangDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DonDatHangDAO();
                }

                return _instance;
            }
        }

        public void AddNewOrder(int maDon, int maKhachHang, string diaChi, string SDT, string pthuc, float ship, float tongTien)
        {
            string query = $"insert into DonDatHang(MaDon, MaKhachHang, DiaChi_KH, SDT_KH, PhuongThucThanhToan, TinhTrangDonHang, TienShip, TongTien) " +
                           $"values ({maDon}, {maKhachHang}, N'{diaChi}', '{SDT}', 'COD', 'W', {ship}, {tongTien})";

            _conn.Open();
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public DataTable GetAmountOfOrders()
        {
            DataTable db = new DataTable();

            string query = "select count(*) as Amount from DonDatHang";

            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(db);

            return db;
        }

        public void AddProductToOrder(int maDon, int maHangHoa, int soLuongDat)
        {
            string query = $"insert into ThongTinDatHang(MaHangHoa, MaDon, SoLuongDat) values({maHangHoa}, {maDon}, {soLuongDat})";

            _conn.Open();
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public DataTable GetHistoryOfOrder(string maKhachHang)
        {
            string query = "SELECT * FROM DonDatHang";
            if (!string.IsNullOrEmpty(maKhachHang.Trim()))
            {
                query += " WHERE MaKhachHang= " + maKhachHang;
            }
            DataTable db = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(db);
            return db;
        }

    }
}
