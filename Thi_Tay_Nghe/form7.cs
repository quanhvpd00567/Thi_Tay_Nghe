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
    public partial class form7 : Form
    {
        public form7()
        {
            InitializeComponent();
        }
        private string Runner;
        private string number;
        public void getdata(string a, string b)
        {
            Runner = a;
            number = b;
            return;
        }
        private void form7_Load(object sender, EventArgs e)
        {
            lb_so_luong.Text = "$"+number;
            lb_name.Text = Runner;
        }

        private void btn_back2_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
