using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thi_Tay_Nghe
{
    public partial class headerControl : UserControl
    {
        public headerControl()
        {
            InitializeComponent();
        }

        private void headerControl_Load(object sender, EventArgs e)
        {

        }
        public string Title
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
    }
}
