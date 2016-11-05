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
    public partial class form8 : Form
    {
        public form8()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            form9 frm = new form9();
            frm.getmais(email);
          //  frm.get_email(email);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void form8_Load(object sender, EventArgs e)
        {

        }
        public string email;
        public void getmai(string mail)
        {
            email = mail;
        }

        private void bnt_logout_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
