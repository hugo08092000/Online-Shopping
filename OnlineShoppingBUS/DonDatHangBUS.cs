using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OnlineShoppingBUS
{
    class DonDatHangBUS
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

        public void AddNewOrder()
        {
            OnlineShoppingDAO.DonDatHangDAO.Instance.AddNewOrder();
        }

        public int GetAmountOfOrders()
        {
            int result = 0;
            DataTable db = OnlineShoppingDAO.DonDatHangDAO.Instance.GetAmountOfOrders();
            DataRow row = db.Rows[0];

            result = int.Parse(row["Amount"].ToString());

            return result;
        }
    }
}
