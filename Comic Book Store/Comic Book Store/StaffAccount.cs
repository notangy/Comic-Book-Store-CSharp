using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comic_Book_Store
{
   class StaffAccount : Account
    {
        private static string auth;
        public static bool isStaff;

        static public string getAuth()
        {
            return auth;
        }

        static public void setAuth(string a)
        {
            auth = a;
        }
    }
}
