using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.Linq;

namespace BUL
{
   public class Demo
    {
        Data_AseanDataContext db = new Data_AseanDataContext();
        public string Gender;
        public List<View_1> demolist( string email)
        {
           
            List<View_1> a = db.View_1s.Where(x => x.Email == email).ToList();
            return a;
        }
        public void G(string email)
        {
            var gender = db.Runners.SingleOrDefault(x => x.Email == email);
            Gender = gender.Gender;
        }
    }
}
