using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.Linq;

namespace BUL
{
   public class BL_Sponsorship
    {
        Data_AseanDataContext db = new Data_AseanDataContext();
        public void addNew(int registerID, string Sname, decimal Amounts)
        {
            Sponsorship sp = new Sponsorship();
            sp.RegistrationId = registerID;
            sp.Amount = Amounts;
            sp.SponsorName = Sname;
            db.Sponsorships.InsertOnSubmit(sp);
            db.SubmitChanges();
        }
        public List<View_18> LoadSponsoship(string Email)
        {
            var load = db.View_18s.Where(x => x.Email == Email).ToList();
            
            return load;
        }

        public Charity getCharity(string Email)
        {
            var load = db.Runners.SingleOrDefault(x => x.Email == Email);
            var re = db.Registrations.SingleOrDefault(x => x.RunnerId == load.RunnerId);
            var cha = db.Charities.SingleOrDefault(x => x.CharityId == re.CharityId);
            return cha;
        }
    }
}
