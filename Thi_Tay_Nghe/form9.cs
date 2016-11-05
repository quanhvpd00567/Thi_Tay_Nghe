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
    public partial class form9 : Form
    {
        public form9()
        {
            InitializeComponent();
        }

        private void btn_contact_Click(object sender, EventArgs e)
        {
            f_contact frm = new f_contact();
            frm.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            form16 frm = new form16();
            frm.get_email(email);
            frm.ShowDialog();
        }

        private void form9_Load(object sender, EventArgs e)
        {

        }
        public string email;
        public void getmais(string mail)
        {
            email = mail;
        }

        private void btn_my_rece_Click(object sender, EventArgs e)
        {
            demo frm = new demo();
            frm.getEmail(email);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void bnt_logout_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btn_my_sponsor_Click(object sender, EventArgs e)
        {
            MySponsorship frm = new MySponsorship();
            frm.getEmail(email);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
