using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OnlineShoppingBUS
{
    public class DonDatHangBUS
    {
        private static DonDatHangBUS _instance = null;

        public static DonDatHangBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DonDatHangBUS();
                }

                return _instance;
            }
        }

        public void AddNewOrder(int maDon, int maKhachHang, string diaChi, string SDT, string pthuc, float ship, float tongTien)
        {
            OnlineShoppingDAO.DonDatHangDAO.Instance.AddNewOrder(maDon, maKhachHang, diaChi, SDT, pthuc, ship, tongTien);
        }

        public int GetAmountOfOrders()
        {
            int result = 0;
            DataTable db = OnlineShoppingDAO.DonDatHangDAO.Instance.GetAmountOfOrders();
            DataRow row = db.Rows[0];

            result = int.Parse(row["Amount"].ToString());

            return result;
        }

        public void AddProductToOrder(int maDon, int maHangHoa, int soLuongDat)
        {
            OnlineShoppingDAO.DonDatHangDAO.Instance.AddProductToOrder(maDon, maHangHoa, soLuongDat);
        }
        public DataTable GetHistoryOfOrder(string maKhachHang)
        {
            return OnlineShoppingDAO.DonDatHangDAO.Instance.GetHistoryOfOrder(maKhachHang);
        }
    }
}
