using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BUL
{
   public class CheckEmail
    {
        public bool check( string value)
        {
            //  return Regex r = new Regex(@"^([a-zA-Z0-9]+)@([a-zA-Z0-9]+)((\.(\w){2,3})+)­$");
            return Regex.IsMatch(value, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
        // kiểm tra có ít nhất 1 chứ in hoa và ký tự đặng biệt
        public bool ckeck_a1(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z]+$");
        }
        public bool check_number(string value)
        {
            return Regex.IsMatch(value, @"^[0-9]+$");
        }

        // Kiểm tra có ít nhất 1 ký tự In hoa 
        // Cách 1:
        public bool in_hoa(string value)
        {
            return value.Any(c => char.IsUpper(c));
        }
        // cách 2
        public bool check_in_hoa(string value)
        {
            return Regex.IsMatch(value, @"^(?=.*[A-Z]).+$");
        }
        // kiểm tra có ít nhất 1 số
        public bool check_num(string value)
        {
            return Regex.IsMatch(value, @"^(?=.*[0-9]).+$");
        }
        // kiêm tra có ít nhất 1 ký tự đặc biệt !@#$%^
        public bool kytu(string value)
        {
            return Regex.IsMatch(value, @"^(?=.*[!@#$%^]).+$");
        }
    }
}
