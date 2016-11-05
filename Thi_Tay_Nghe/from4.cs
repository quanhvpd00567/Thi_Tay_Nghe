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
using System.Text.RegularExpressions;

namespace Thi_Tay_Nghe
{
    public partial class from4 : Form
    {
        public from4()
        {
            InitializeComponent();
        }
        BL_Gender G = new BL_Gender();
        CheckEmail ck = new CheckEmail();
        user u = new user();
        Data_AseanDataContext db = new Data_AseanDataContext();
        private void from4_Load(object sender, EventArgs e)
        {
            load_country();
            load_gender();
           
           
        }
        public void load_country()
        {
            cbb_country.DataSource = G.load_C();
            cbb_country.DisplayMember = "CountryName";
            cbb_country.ValueMember = "CountryCode";
        }
        public void load_gender()
        {

            cbb_gender.DataSource = db.Genders.ToList();
            cbb_gender.DisplayMember = "Gender1";
            cbb_gender.ValueMember = "Gender1";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
            if (groupBox1.Visible == false)
            {
                groupBox1.Show();
            }
            else
            {
                groupBox1.Visible = false;
            }
        }
        public int year;
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt_sn.Text = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string[] aray = txt_sn.Text.Split('-');
             year = Int32.Parse(aray[0]);
            //year = Int32.Parse(monthCalendar1.SelectionStart.ToString("yyyy"));
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            int year_now = Int32.Parse(DateTime.Now.Year.ToString());
            int age = year_now - year;
            if (ck.check(txt_email.Text) == false)
            {
                MessageBox.Show("Email Invalid");
            }
            else
            {
                if (txt_pass.TextLength < 6)
                {
                    MessageBox.Show("Pass > 6");
                }
                else
                {
                   if((ck.check_in_hoa(txt_pass.Text)==false) || (ck.check_num(txt_pass.Text)==false) || (ck.kytu(txt_pass.Text)==false) )
                    {
                        MessageBox.Show("Pass 1 uppercase letter and 1 number");
                    }
                    else
                    {
                        if(txt_pass.Text != txt_pass_again.Text)
                        {
                            MessageBox.Show("Pass # pass again");
                        }
                        else
                        {
                            if (year < 1900)
                            {
                                MessageBox.Show("năm sinh phải lớn hơn 1900");
                            }
                            else
                            {
                                if (age < 10)
                                {
                                    MessageBox.Show("chưa đầy tuổi tham gia");
                                }
                                else
                                {
                                    MessageBox.Show("Valid");
                                    u.add_user(txt_email.Text, txt_f_name.Text, txt_l_name.Text, txt_pass.Text, cbb_gender.Text, txt_sn.Text, cbb_country.SelectedValue.ToString());
                                    form5 frm = new form5();
                                    frm.getmai(txt_email.Text);
                                    this.Hide();
                                    frm.ShowDialog();
                                    this.Close();
                                }
                            }

                        }

                    }
                }
            }

        }
    }
   
}

