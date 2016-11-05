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
using System.IO;
using DataAccess;
using System.Data.Linq;


namespace Thi_Tay_Nghe
{
    
    public partial class form13 : Form
    {
        public form13()
        {
            InitializeComponent();
        }
        BL_Charity ch = new BL_Charity();
        Data_AseanDataContext db = new Data_AseanDataContext();
        private void form13_Load(object sender, EventArgs e)
        {

            

            //DataSet ds = new DataSet();
            //var query = from p in db.Charities.AsEnumerable() select p;
            //  DataTable dt = query.CopyToDataTable();
            //  ds.Tables.Add(dt);
            // dataGridView1.DataSource = query.ToList();

        }
        public string m;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
