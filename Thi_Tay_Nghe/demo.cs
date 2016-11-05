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
using System.Text.RegularExpressions;
using DataAccess;



namespace Thi_Tay_Nghe
{
    public partial class demo : Form
    {
        public demo()
        {
            InitializeComponent();
        }
        CheckEmail ck = new CheckEmail();
        BUL.Demo d = new Demo();
        Data_AseanDataContext db = new Data_AseanDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private string iEmail;
        public void getEmail(string email)
        {
            iEmail = email;
        }
        private void demo_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            var gender = db.Runners.SingleOrDefault(x => x.Email == iEmail);
            Gender();
            lb_gender.Text = d.Gender;
            //  lb_gender.Text = gender.Gender;
            dataGridView1.DataSource = d.demolist(iEmail);
        }
        private void Gender()
        {
          d.G(iEmail);
        }
        
    }
}
