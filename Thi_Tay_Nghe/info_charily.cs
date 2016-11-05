using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using System.IO;
using DataAccess;

namespace Thi_Tay_Nghe
{
    public partial class info_charily : Form
    {
        public info_charily()
        {
            InitializeComponent();
        }
        BL_Charity ch = new BL_Charity();
        public int id_charily;
        public string name, Descriptionde, logo;
        public void getdata(int id)
        {
            ch.sigle_charile(id);
            logo = ch.logo;
            name = ch.name;
            Descriptionde = ch.Descriptionde;
        }
        public void getdata2(int id)
        {
            ch.get_idcharity(id);
            logo = ch.logo;
            name = ch.name;
            Descriptionde = ch.Descriptionde;
        }
        private void info_charily_Load(object sender, EventArgs e)
        {
            lb_name.Text = name;
            lb_de.Text = Descriptionde;
            string path = Application.StartupPath + @"\images\"+ logo;
            pic_logo.Load(path);
        }
      

       
    }
}
