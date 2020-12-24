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
    }
}
