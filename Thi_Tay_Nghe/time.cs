using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;
using System.IO;
namespace Thi_Tay_Nghe
{
    
    public class time
    {
        
         DateTime endtime = new DateTime(2016, 03, 11, 23, 4, 00);
        Timer t = new Timer();
        public string tich_tac()
        {
            t.Interval = 500;
            string a;
            TimeSpan ts = endtime.Subtract(DateTime.Now);
            a = ts.ToString("dd' days 'hh' hours and 'mm' minutes unti the rece starts! 'ss'giây'");
            t.Start();
            return a;
        }
        public string caaa()
        {
            string a;
            TimeSpan ts = endtime.Subtract(DateTime.Now);
            a = ts.ToString("dd' days 'hh' hours and 'mm' minutes unti the rece starts! 'ss'giây'");
            if (ts.TotalSeconds <= 0)
            {
                t.Stop();
            }
            return a;
        }
    }

    
}
