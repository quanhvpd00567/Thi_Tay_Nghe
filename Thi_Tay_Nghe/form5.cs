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

namespace Thi_Tay_Nghe
{
    public partial class form5 : Form
    {
        public form5()
        {
            InitializeComponent();
        }
        BL_Charity ch = new BL_Charity();
        public int race;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            race = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            race = 20;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            race = 45;
        }
        public int a,b,c ;
        private void ck_half_CheckedChanged(object sender, EventArgs e)
        {
            b = 75;
        }
        private void ck_full_CheckedChanged(object sender, EventArgs e)
        {
            a = 145;
        }
        private void ck_fun_CheckedChanged(object sender, EventArgs e)
        {
            c = 20;
        }
        public string charilyID;
        public int charilyIDs;
        private void form5_Load(object sender, EventArgs e)
        {
            load_charily();
        }
       
        public void load_charily()
        {
            txt_taget.Text = "500";
            cbb_charily.DataSource = ch.load_charily();
            cbb_charily.ValueMember = "CharityId";
            cbb_charily.DisplayMember = "CharityName";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            info_charily frm = new info_charily();
            frm.getdata(Int32.Parse(charilyID));
            frm.ShowDialog();
        }

        private void cbb_charily_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void cbb_charily_SelectedValueChanged(object sender, EventArgs e)
        {
             charilyID = cbb_charily.SelectedValue.ToString();
        }

        private void txt_taget_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbb_charily_ValueMemberChanged(object sender, EventArgs e)
        {
          
        }

        private void cbb_charily_DisplayMemberChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tong();
            // form16 frm = new form16();
            form8 frm = new form8();
            frm.getmai(email);
            frm.ShowDialog();
        }
        // Tổng Check vs Radioo
        public void tong()
        {
            if ((ck_full.Checked == true) && (ck_half.Checked == false) && (ck_fun.Checked == false))
            {
                label14.Text = "$" + (race + a).ToString();
            }
            else if ((ck_full.Checked == false) && (ck_fun.Checked == true) && (ck_half.Checked == true))
            {
                label14.Text = "$" + (race + b + c).ToString();
            }
            else if ((ck_full.Checked == true) && (ck_fun.Checked == true) && (ck_half.Checked == false))
            {
                label14.Text = "$" + (race + a + c).ToString();
            }
            else if ((ck_full.Checked == true) && (ck_half.Checked = true) && (ck_fun.Checked == false))
            {
                label14.Text = "$" + (race + a + b).ToString();
            }
            else if ((ck_full.Checked == false) && (ck_half.Checked == true) && (ck_fun.Checked == true))
            {
                label14.Text = "$" + (race + b).ToString();
            }
            else if ((ck_fun.Checked == false) && (ck_half.Checked == true) && (ck_full.Checked == false))
            {
                label14.Text = "$" + (race + b).ToString();
            }
            else if ((ck_fun.Checked == true) && (ck_half.Checked == false) && (ck_full.Checked == false))
            {
                label14.Text = "$" + (race + c).ToString();
            }
            else if ((ck_fun.Checked == true) && (ck_half.Checked == true) && (ck_full.Checked == true))
            {
                label14.Text = "$" + (race + a + b + c).ToString();
            }
            else if ((ck_fun.Checked == false) && (ck_half.Checked == false) && (ck_full.Checked == false))
            {
                label14.Text = "$" + race.ToString();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void bnt_logout_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
            this.Close();

        }

        public string email;
        public void getmai(string mail)
        {
            email = mail;
        }
       
    }
}
