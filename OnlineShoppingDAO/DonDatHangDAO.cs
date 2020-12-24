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

        public void AddNewOrder()
        {
            throw new NotImplementedException();
        }

        public DataTable GetAmountOfOrders()
        {
            DataTable db = new DataTable();

            string query = "select count(*) as Amount from DonDatHang";

            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(db);

            return db;
        }
    }
}
