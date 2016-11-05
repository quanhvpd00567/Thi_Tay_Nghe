using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.Linq;

namespace BUL
{
   public class BL_View1
    {
        Data_AseanDataContext db = new Data_AseanDataContext();
        public string charly_name;
        public void charly(int id, string name )
        {
            View1 V = db.View1s.Single(x=>x.RegistrationId == id && x.Runnerss == name );
            charly_name = V.CharityName;
        }
    }
}
