using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OnlineShoppingDAO
{
    public class TaiKhoanDAO : DBConnect
    {
        private static TaiKhoanDAO _instance = null;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TaiKhoanDAO();
                }

                return _instance;
            }
        }

        public DataTable CheckLogin(string username, string password)
        {
            DataTable db = new DataTable();

            string query = $"select count(*) as Amount from TaiKhoan where TenDangNhap = '{username}' and MatKhau = '{password}'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(db);

            return db;
        }

        public DataTable CheckUsername(string username)
        {
            DataTable db = new DataTable();

            string query = $"select count(*) as Amount from TaiKhoan where TenDangNhap = '{username}'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(db);

            return db;
        }

        public void AddAccount(string username, string password)
        {
            string query = $"insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTaiKhoan) values('{username}', {password}, 0)";

            _conn.Open();
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
