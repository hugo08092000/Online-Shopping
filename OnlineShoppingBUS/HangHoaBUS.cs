using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OnlineShoppingBUS
{
    public class HangHoaBUS
    {
        private static HangHoaBUS _instance = null;

        public static HangHoaBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HangHoaBUS();
                }

                return _instance;
            }
        }

        public List<Product> GetAll()
        {
            DataTable db;
            db = OnlineShoppingDAO.HangHoaDAO.Instance.GetAll();

            List<Product> result = new List<Product>();

            foreach (DataRow row in db.Rows)
            {
                Product tmpProduct = new Product();
                tmpProduct.MaHangHoa = int.Parse(row["MaHangHoa"].ToString());
                tmpProduct.DonGia = float.Parse(row["DonGia"].ToString());
                tmpProduct.TenLoaiHang = row["TenLoaiHang"].ToString();
                tmpProduct.TenHangHoa = row["TenHangHoa"].ToString();
                tmpProduct.TenDanhMuc = row["TenDanhMuc"].ToString();

                result.Add(tmpProduct);
            }

            return result;
        }
    }


    public class Product
    {
        private int _maHangHoa;
        private string _tenHangHoa;
        private float _donGia;
        private string _tenLoaiHang;
        private string _tenDanhMuc;
        private int _soLuongTon;

        public int MaHangHoa { get => _maHangHoa; set => _maHangHoa = value; }
        public string TenHangHoa { get => _tenHangHoa; set => _tenHangHoa = value; }
        public float DonGia { get => _donGia; set => _donGia = value; }
        public string TenLoaiHang { get => _tenLoaiHang; set => _tenLoaiHang = value; }
        public string TenDanhMuc { get => _tenDanhMuc; set => _tenDanhMuc = value; }
        public int SoLuongTon { get => _soLuongTon; set => _soLuongTon = value; }
    }
}
