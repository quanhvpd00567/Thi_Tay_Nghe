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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btn_spar_Click(object sender, EventArgs e)
        {
            from6 frm = new from6();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            form3 frm = new form3();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btn_ar_Click(object sender, EventArgs e)
        {
            form2 frm = new form2();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btn_omr_Click(object sender, EventArgs e)
        {
            from10 frm = new from10();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
