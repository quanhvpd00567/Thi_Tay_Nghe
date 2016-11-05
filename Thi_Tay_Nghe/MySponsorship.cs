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
    public partial class MySponsorship : Form
    {
        public MySponsorship()
        {
            InitializeComponent();
        }
        BL_Sponsorship sp = new BL_Sponsorship();
        private void MySponsorship_Load(object sender, EventArgs e)
        {
            GrdSponsoship.AutoGenerateColumns = false;
            GrdSponsoship.DataSource = sp.LoadSponsoship(Email);
            int dong = GrdSponsoship.Rows.Count;
            if(dong ==0)
            {
                MessageBox.Show("chua co nha tai tro");
            }
            else {  
            float thanhtien = 0;
            for (int i = 0; i < dong; i++)
            {
                thanhtien += float.Parse(GrdSponsoship.Rows[i].Cells["Amount"].Value.ToString());
            }
            lbTotal.Text ="Total $"+ thanhtien.ToString();
            loadChar();
            }
        }
        void loadChar()
        {
          var charity =  sp.getCharity(Email);

            lbName.Text = charity.CharityName;
            string path = Application.StartupPath + @"\images\" + charity.CharityLogo;
            picLogo.Load(path);
            lbDec.Text = charity.CharityDescription;
        }
        string Email;
        public void getEmail(string email)
        {
            Email = email;
        }
    }
}
