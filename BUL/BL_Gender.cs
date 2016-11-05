using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.Linq;
using System.Data;


namespace BUL
{
   public class BL_Gender
    {
        Data_AseanDataContext db = new Data_AseanDataContext();
        public List<Gender> load_G()
        {
            var ha = db.Genders.ToList();
            return ha;
        }
        public List<Country> load_C()
        {
            var gende = db.Countries.ToList();
            return gende;
        }
    }
}
