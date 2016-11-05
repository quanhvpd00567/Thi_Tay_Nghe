using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.Linq;

namespace BUL
{
   public class BL_Charity
    {
        Data_AseanDataContext db = new Data_AseanDataContext();
        public List<Charity> load_charily()
        {
            var charily = db.Charities.ToList();
            return charily;
        }
        public string name, logo, Descriptionde;
        public int idch;

        public void sigle_charile(int id)
        {
            Charity charily = db.Charities.First(x=>x.CharityId==id) ;
            name = charily.CharityName.ToString();
            logo = charily.CharityLogo.ToString();
            Descriptionde = charily.CharityDescription.ToString();
        }
        public void get_idcharity(int idRs)
        {
            Registration reg = db.Registrations.First(x => x.RegistrationId == idRs);
            idch = reg.CharityId;
            sigle_charile(idch);
        }
    }
}
