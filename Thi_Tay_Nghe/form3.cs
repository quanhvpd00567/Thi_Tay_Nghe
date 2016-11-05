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
using DataAccess;

namespace Thi_Tay_Nghe
{
    public partial class form3 : Form
    {
        public form3()
        {
            InitializeComponent();
        }
        user dn = new user();
        Data_AseanDataContext db = new Data_AseanDataContext();
        private void bnt_login_Click(object sender, EventArgs e)
        {
            var user_log = db.Users.Where(x => x.Email == txt_email.Text && x.Password == txt_pass.Text).SingleOrDefault();
            if (user_log==null)
            {
                MessageBox.Show("kHÔNG CÓ AI NHƯ VÂY");
            }
            else
            {
               /* string id = user_log.FirstOrDefault().RoleId.ToString()*/;
                string id = user_log.RoleId.ToString();
                f_chon_role frm = new f_chon_role();
                frm.getdata(id);
                frm.get_mail(txt_email.Text);
                frm.ShowDialog();
            }  
        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            frmMain fr = new frmMain();
            fr.ShowDialog();
        }
    }
}
