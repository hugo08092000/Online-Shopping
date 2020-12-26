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

        public List<Product> GetProductOfSeller()
        {
            DataTable db;
            db = OnlineShoppingDAO.HangHoaDAO.Instance.GetProductOfSeller();

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

        public int GetNumberOfProducts()
        {
            DataTable db = new DataTable();
            int result;

            db = OnlineShoppingDAO.HangHoaDAO.Instance.GetNumberOfProducts();

            DataRow row = db.Rows[0];

            string a = row["Amount"].ToString();

            result = int.Parse(a);

            return result;
        }

        public void AddProductToStorage(int maHangHoa, int soLuong)
        {
            OnlineShoppingDAO.HangHoaDAO.Instance.AddProductToStorage(maHangHoa, soLuong);
        }

        public void AddProduct(int maHangHoa, string tenHangHoa, float giaHangHoa, int loaiHangHoa)
        {
            OnlineShoppingDAO.HangHoaDAO.Instance.AddProduct(maHangHoa, tenHangHoa, giaHangHoa, loaiHangHoa);

            OnlineShoppingDAO.HangHoaDAO.Instance.AddSupplyInfo(maHangHoa);
        }

        public int GetBasketID()
        {
            int result = 0;
            DataTable db = OnlineShoppingDAO.HangHoaDAO.Instance.GetBasketID();
            DataRow row = db.Rows[0];

            string tmpID = row["MaDon"].ToString();
            if(tmpID == "")
            {
                return -1;
            }
            else
            {
                result = int.Parse(tmpID);
            }

            return result;
        }

        public List<Product> SearchProduct(string input)
        {
            DataTable db;
            db = OnlineShoppingDAO.HangHoaDAO.Instance.SearchProduct(input);

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

        public List<ProductInBasket> AddProductToBasket(int maHangHoa, int maDonHang, int soLuongDat)
        {
            List<ProductInBasket> result = new List<ProductInBasket>();

            return result;
        }

        public Product GetProduct(int id)
        {
            Product result = new Product();

            DataTable db;
            db = OnlineShoppingDAO.HangHoaDAO.Instance.GetProduct(id);

            DataRow row = db.Rows[0];

            result.MaHangHoa = int.Parse(row["MaHangHoa"].ToString());
            result.DonGia = float.Parse(row["DonGia"].ToString());
            result.TenLoaiHang = row["TenLoaiHang"].ToString();
            result.TenHangHoa = row["TenHangHoa"].ToString();
            result.TenDanhMuc = row["TenDanhMuc"].ToString();

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

    public class ProductInBasket
    {
        private int _maHangHoa;
        private float _donGia;
        private string _tenHangHoa;
        private int _maDonHang;
        private int _soLuongDat;
        private float _tongTien;

        public int MaHangHoa { set => _maHangHoa = value; get => _maHangHoa; }
        public float DonGia { set => _donGia = value; get => _donGia; }
        public int MaDonHang { get => _maDonHang; set => _maDonHang = value; }
        public string TenHangHoa { get => _tenHangHoa; set => _tenHangHoa = value; }
        public int SoLuongDat { get => _soLuongDat; set => _soLuongDat = value; }
        public float TongTien { get => _tongTien; set => _tongTien = value; }
    }
}
