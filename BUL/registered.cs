using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data;
using DataAccess;

namespace BUL
{
    public class registered
    {
        Data_AseanDataContext db = new Data_AseanDataContext();
        public int rID;
        public string name;
        public List<View1> load_runner()
        {
            var list = db.View1s.ToList();
            return list;
        }
        public void single_charily(string rune)
        {
            View1 sg_charily = db.View1s.Where(x =>x.Runnerss == rune).SingleOrDefault();
            //rID = sg_charily.CharityId;
           // name = sg_charily.CharityName.ToString(); ;
        }
    }
}
