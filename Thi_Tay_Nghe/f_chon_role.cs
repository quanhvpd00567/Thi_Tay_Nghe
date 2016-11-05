using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thi_Tay_Nghe
{
    public partial class f_chon_role : Form
    {
        public f_chon_role()
        {
            InitializeComponent();
        }

        private void f_chon_role_Load(object sender, EventArgs e)
        {

        }
        public string id_user;
        public void getdata(string id)
        {
            id_user = id;
        }

        private void btn_runner_Click(object sender, EventArgs e)
        {
            if(id_user =="R")
            {
                form9 frm = new form9();
                frm.getmais(email);
                frm.ShowDialog();
            }
        }

        private void btn_Coordeinator_Click(object sender, EventArgs e)
        {
            if (id_user == "C")
            {
                form19 frm = new form19();
                frm.ShowDialog();
            }
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            if (id_user == "A")
            {
                form20 frm = new form20();
                frm.ShowDialog();
            }
        }
        public string email;
        public void get_mail(string mail_get)
        {
            email = mail_get;
        }
    }
}
