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
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            form3 frm = new form3();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            form3 frm = new form3();
            frm.ShowDialog();
        }

        private void btn_create_new_Click(object sender, EventArgs e)
        {
            from4 frm = new from4();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
