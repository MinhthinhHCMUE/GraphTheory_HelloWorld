using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DatabaseQuanLy
    {
        private static DataClasses1DataContext _instance;
        public static DataClasses1DataContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataClasses1DataContext();
                }
                return _instance;
            }
        }
    }
}
    