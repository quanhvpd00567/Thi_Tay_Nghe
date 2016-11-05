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
    public partial class form12cs : Form
    {
        public form12cs()
        {
            InitializeComponent();
        }

        private void form12cs_Load(object sender, EventArgs e)
        {
            
        }

        private void pic_1_Click(object sender, EventArgs e)
        {
            form_check frm = new form_check();
            string keys = "Checkpoint1";
            frm.key(keys);
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            form_check frm = new form_check();
            string keys = "Checkpoint2";
            frm.key(keys);
            frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            form_check frm = new form_check();
            string keys = "Checkpoint3";
            frm.key(keys);
            frm.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            form_check frm = new form_check();
            string keys = "Checkpoint4";
            frm.key(keys);
            frm.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            form_check frm = new form_check();
            string keys = "Checkpoint5";
            frm.key(keys);
            frm.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            form_check frm = new form_check();
            string keys = "Checkpoint6";
            frm.key(keys);
            frm.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            form_check frm = new form_check();
            string keys = "Checkpoint7";
            frm.key(keys);
            frm.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            form_check frm = new form_check();
            string keys = "Checkpoint8";
            frm.key(keys);
            frm.ShowDialog();
        }
    }
}
