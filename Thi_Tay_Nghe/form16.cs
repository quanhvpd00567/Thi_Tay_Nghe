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
using System.Globalization;

namespace Thi_Tay_Nghe
{
    public partial class form16 : Form
    {
        public form16()
        {
            InitializeComponent();
            Load += form16_Load;
        }
        user u = new user();
        BL_Gender sex = new BL_Gender();
        CheckEmail ck = new CheckEmail();
        //   public string email;
        Data_AseanDataContext db = new Data_AseanDataContext();
        private void form16_Load(object sender, EventArgs e)
        {
            load();
           
        }
      
        public void get_email(string emails)
        {
            Runner b = db.Runners.SingleOrDefault(x => x.Email == emails);
            User l = db.Users.SingleOrDefault(x => x.Email == emails);
            string a = b.DateOfBirth.ToString();
            DateTime MinDateTime = Convert.ToDateTime(a);
            string sn = MinDateTime.ToString("yyyy-MM-dd");
            email = b.Email;
            gender = b.Gender;
            country = b.Country.CountryName;
            txt_firstname.Text = l.FirstName;
            txt_lastname.Text = l.LastName;
            txt_birth_day.Text = sn;
        }
        public string email;
        public string gender;
        public string country;
        public void load()
        {
            lb_email.Text = email;
            //load danh sách giới tính
            cbb_gender.DataSource = sex.load_G();
            cbb_gender.ValueMember = "Gender1";
            cbb_gender.DisplayMember = "Gender1";
            cbb_gender.Text = gender;
            // load danh sách các nước
            cbb_country.DataSource = sex.load_C();
            cbb_country.ValueMember = "CountryCode";
            cbb_country.DisplayMember = "CountryName";
            cbb_country.Text = country;
        }

        private void lb_email_Click(object sender, EventArgs e)
        {
            
        }

        private void bnt_logout_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            int year_now = Int32.Parse(DateTime.Now.Year.ToString());
            int age = year_now - year;
            if (txt_pass.Text == string.Empty) // trường hợp pass mà vẫn còn trống tức là user k muốn thay đổi pass
            {
                // trường hợp nếu user không thay đổi mật khẩu
                if (age < 10)
                {
                    MessageBox.Show("chưa đủ tuổi");
                }
                else
                {
                    // update
                    u.update_no_pass(lb_email.Text, txt_lastname.Text, txt_firstname.Text, cbb_gender.Text, txt_birth_day.Text, cbb_country.SelectedValue.ToString());

                }
            }
            else
            {
                if (txt_pass.TextLength < 6)
                {
                    MessageBox.Show("Pass > 6");
                }
                else
                {
                    if ((ck.check_in_hoa(txt_pass.Text) == false) || (ck.check_num(txt_pass.Text) == false) || (ck.kytu(txt_pass.Text) == false))
                    {
                        MessageBox.Show("Pass 1 uppercase letter and 1 number");
                    }
                    else
                    {
                        if (txt_pass.Text != txt_pass_again.Text)
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
                                    u.update_pass(lb_email.Text, txt_lastname.Text, txt_firstname.Text, txt_pass.Text, cbb_gender.Text, txt_birth_day.Text, cbb_country.SelectedValue.ToString());
                                }
                            }

                        }

                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {

        }
        private void kiemtra()
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(groupBox1.Visible ==false)
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
            txt_birth_day.Text = monthCalendar1.SelectionStart.ToString("yyy-MM-dd");
            string[] Araynam = txt_birth_day.Text.Split('-');
            year = Int32.Parse(Araynam[0]);
        }

        //public void get_E(string email)
        //{
        //    User u = db.Users.FirstOrDefault(x => x.Email == email);
        //    email = u.Email;
        //}  

    }
}
