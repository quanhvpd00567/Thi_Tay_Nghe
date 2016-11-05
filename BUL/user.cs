using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.Linq;


namespace BUL
{
   public class user
    {
        Data_AseanDataContext db = new Data_AseanDataContext();
        public void login_user(string email, string password)
        {
            var user_log = db.Users.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
            int id = user_log.RoleId;
        }
        public void add_user(string email,string FName, string LName,string Pass, string Sex,string BirthDay,string CountryID )
        {
            // Save first table User
            User userr = new User();
            userr.Email = email;
            userr.LastName = LName;
            userr.FirstName = FName;
            userr.Password = Pass;
            userr.RoleId = Char.Parse("R");
            db.Users.InsertOnSubmit(userr);
            db.SubmitChanges();
            //Next Save  table User
            Runner run = new Runner();
            DateTime dt = DateTime.Parse(BirthDay);
            run.Email = email;
            run.Gender = Sex;
            run.DateOfBirth = dt;
            run.CountryCode = CountryID;
            db.Runners.InsertOnSubmit(run);
            db.SubmitChanges();
        }
        public string emails;
        public void get_E(string email)
        {
            User u = db.Users.First(x => x.Email == email);
            emails = u.Email;
        }
        // thay đổi thông tin nhưng k đổi mật khẩu
        public void update_no_pass(string e_mail,string LName,string FName,string Gender, string BirtDay, string countryCode)
        {
            User us = db.Users.SingleOrDefault(x => x.Email == e_mail);
            Runner Ru = db.Runners.SingleOrDefault(x => x.Email == e_mail);
            us.FirstName = FName;
            us.LastName = LName;
            Ru.Gender = Gender;
            DateTime dt = DateTime.Parse(BirtDay);
            Ru.DateOfBirth = dt;
            Ru.CountryCode = countryCode;
            db.SubmitChanges();
        }
        // thay đổi thông tin nhưng k đổi mật khẩu
        public void update_pass(string e_mail, string LName, string FName,string pass, string Gender, string BirtDay, string countryCode)
        {
            User us = db.Users.SingleOrDefault(x => x.Email == e_mail);
            Runner Ru = db.Runners.SingleOrDefault(x => x.Email == e_mail);
            us.FirstName = FName;
            us.LastName = LName;
            us.Password = pass;
            Ru.Gender = Gender;
            DateTime dt = DateTime.Parse(BirtDay);
            Ru.DateOfBirth = dt;
            Ru.CountryCode = countryCode;
            db.SubmitChanges();
        }
    }
}
