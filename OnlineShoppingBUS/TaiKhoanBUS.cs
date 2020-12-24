using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OnlineShoppingDAO;

namespace OnlineShoppingBUS
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS _instance = null;

        public static TaiKhoanBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TaiKhoanBUS();
                }

                return _instance;
            }
        }

        public bool CheckLogin(string username, string password)
        {
            bool result = true;

            DataTable db;
            db = TaiKhoanDAO.Instance.CheckLogin(username, password);
            DataRow row = db.Rows[0];

            int amount = int.Parse(row["Amount"].ToString());

            if (amount == 0)
            {
                result = false;
            }

            return result;
        }

        public bool CheckUsername(string username)
        {
            bool result = true;

            DataTable db;
            db = TaiKhoanDAO.Instance.CheckUsername(username);
            DataRow row = db.Rows[0];

            int amount = int.Parse(row["Amount"].ToString());

            if (amount != 0)
            {
                result = false;
            }

            return result;
        }

        public void AddAccount(string username, string password)
        {
            TaiKhoanDAO.Instance.AddAccount(username, password);
        }
    }
}
