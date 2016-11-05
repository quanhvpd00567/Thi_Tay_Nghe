using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Linq;
using DataAccess;
using BUL;

namespace Thi_Tay_Nghe
{
    public partial class from6 : Form
    {
        public from6()
        {
            InitializeComponent();
          //  Load += from6_Load;
        }
        Data_AseanDataContext db = new Data_AseanDataContext();
        registered dk = new registered();
        BL_Sponsorship Spon = new BL_Sponsorship();
        BL_View1 V = new BL_View1();
        CheckEmail ck = new CheckEmail();
        private void btn_thap_dan_Click(object sender, EventArgs e)
        {
             
            if(Int32.Parse(txt_so_luong.Text) <= 0)
            {
                MessageBox.Show("số lượng không được nhỏ hơn 10");
            }
            else
            {
                if(Int32.Parse(txt_so_luong.Text) <=9)
                {
                    MessageBox.Show("nhỏ hơn 10 sao trù cho 10 được");
                }
                else
                {
                    int x = Int32.Parse(txt_so_luong.Text) - 10;
                    
                    txt_so_luong.Text = x.ToString();
                    lb_amount.Text ="$" + txt_so_luong.Text;
                }
                
            }
           
        }

        private void btn_tang_dan_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(txt_so_luong.Text) + 10;
            txt_so_luong.Text = x.ToString();
            lb_amount.Text = "$" + txt_so_luong.Text;
        }

        private void txt_credit_card_TextChanged(object sender, EventArgs e)
        {
             txt_credit_card.MaxLength = 16;
            //if (txt_credit_card.TextLength >= 16)
            //{
            //    MessageBox.Show("lớn hơn 16 ký tự");
            //}
        }

        private void txt_cvc_TextChanged(object sender, EventArgs e)
        {
            txt_cvc.MaxLength = 3;
        }

        private void txt_nam_TextChanged(object sender, EventArgs e)
        {
            txt_nam.MaxLength = 4;
            //DateTime today =  DateTime.Now;
            //int nam = today.Year;
            //txt_nam.Text = nam.ToString();
        }
        private void txt_thang_KeyUp(object sender, KeyEventArgs e)
        {
            if (Int32.Parse(txt_thang.Text) > 12)
            {
                txt_thang.Text = "12";
                MessageBox.Show("làm gì có tháng thứ 13");
            }
        }
        private void txt_thang_TextChanged(object sender, EventArgs e)
        {
            txt_thang.MaxLength = 2;
        }

        private void btn_pay_now_Click(object sender, EventArgs e)
        {
            add();
            
        }
        public void add()
        {
            int year = DateTime.Now.Year;
            int Month = DateTime.Now.Month;
            if (txt_your_name.Text == "")
            {
                MessageBox.Show("Please enter your name.");
            }
            else
            {
                if (txt_credit_card.TextLength < 16)
                {
                    MessageBox.Show("Credit card # has to be 16 digits.");
                }
                else
                {
                    if (ck.check_number(txt_credit_card.Text) == false)
                    {
                        MessageBox.Show("Credit card # is number");
                    }
                    else
                    {
                       
                        if (Int32.Parse(txt_nam.Text) > year)
                        {
                            Spon.addNew(Int32.Parse(RegistrationIDs), txt_your_name.Text, Convert.ToDecimal(txt_so_luong.Text));
                            string a = txt_your_name.Text;
                            string b = txt_so_luong.Text;
                            form7 frm = new form7();
                            frm.getdata(a, b);
                            this.Hide();
                            frm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            if ( (Int32.Parse(txt_nam.Text) == year) && (Int32.Parse(txt_thang.Text) > Month) )
                            {
                                Spon.addNew(Int32.Parse(RegistrationIDs), txt_your_name.Text, Convert.ToDecimal(txt_so_luong.Text));
                                string a = txt_your_name.Text;
                                string b = txt_so_luong.Text;
                                form7 frm = new form7();
                                frm.getdata(a, b);
                                this.Hide();
                                frm.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("no");
                            }
                        }
                    }

                }
            }


            //else
            //{
            // //   Spon.addNew(Int32.Parse(RegistrationIDs), txt_your_name.Text, Convert.ToDecimal(txt_so_luong.Text));
            //    string a = txt_your_name.Text;
            //    string b = txt_so_luong.Text;
            //    form7 frm = new form7();
            //    frm.getdata(a, b);
            //    frm.ShowDialog();
            //}

        }
        //sssssssssssssssssssssssssssssssssssssss
        Timer t;
        DateTime endtime = new DateTime(2016, 04, 05, 23, 22, 00);
        private void from6_Load(object sender, EventArgs e)
        {
            load_r();
            V.charly(Int32.Parse(RegistrationIDs), runes);
            t = new Timer();
            t.Interval = 500;
            t.Tick += t_Tick;
            TimeSpan ts = endtime.Subtract(DateTime.Now);
            label3.Text = ts.ToString("dd' days 'hh' hours and 'mm' minutes until the race starts '"); 
            t.Start();
        }
        
        public void load_r()
        {
            cbb_runner.DataSource = dk.load_runner();
            cbb_runner.DisplayMember = "Runnerss";
            cbb_runner.ValueMember = "RegistrationId";

        }
        
        void t_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = endtime.Subtract(DateTime.Now);
            if (ts.TotalSeconds <= 0)
            {
                t.Stop(); //Đến Têt thì dừng lại
                label3.Text = "00 days  00 hours and 00 minutes until the race starts ";
            }


        }
        public string RegistrationIDs;
        public string runes;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           info_charily frm = new info_charily();
            frm.getdata2(Int32.Parse(RegistrationIDs));
            frm.ShowDialog();

        }
        public string name;
        private void cbb_runner_SelectedValueChanged(object sender, EventArgs e)
        {
            View1 ga = new View1();
            RegistrationIDs = cbb_runner.SelectedValue.ToString();
            runes = cbb_runner.Text.ToString();
             ga = db.View1s.SingleOrDefault(x => x.Runnerss == runes);
            if(ga==null)
            {
            }
            else
            {
                lb_name.Text = ga.CharityName.ToString();
            }
        }
        private void cbb_runner_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cbb_runner_Click(object sender, EventArgs e)
        {

        }

        private void cbb_runner_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_so_luong_TextChanged(object sender, EventArgs e)
        {
            lb_amount.Text = "$" + txt_so_luong.Text;
        }
        //private bool check_year()
        //{
        //    int year = DateTime.Now.Year;
        //    int Month = DateTime.Now.Month;
        //    if(Int32.Parse(txt_nam.Text) > year)
        //    {
        //        MessageBox.Show("ok1");
        //    }
        //    else
        //    {
        //        if (Int32.Parse(txt_thang.Text) > Month)
        //        {
        //            MessageBox.Show("ok");
        //        }
        //        else
        //        {
        //            MessageBox.Show("no");
        //        }
        //    }
        //}
    }
}
