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
    public partial class form15 : Form
    {
        public form15()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pic_load.Load(Application.StartupPath + @"\images\how_long_images\worm.jpg");
        }

        private void pic_2_Click(object sender, EventArgs e)
        {
            pic_load.Load(Application.StartupPath + @"\images\how_long_images\airbus-a380.jpg");
        }

        private void pic_9_Click(object sender, EventArgs e)
        {
            pic_load.Load(Application.StartupPath + @"\images\how_long_images\pair-of-havaianas.jpg");
        }

        private void pic_7_Click(object sender, EventArgs e)
        {
            pic_load.Load(Application.StartupPath + @"\images\how_long_images\horse.png");
        }

        private void pic_8_Click(object sender, EventArgs e)
        {
            pic_load.Load(Application.StartupPath + @"\images\how_long_images\jaguar.jpg");
        }

        private void pic_10_Click(object sender, EventArgs e)
        {
            pic_load.Load(Application.StartupPath + @"\images\how_long_images\ronaldinho.jpg");
        }

        private void pic_11_Click(object sender, EventArgs e)
        {
            pic_load.Load(Application.StartupPath + @"\images\how_long_images\sloth.jpg");
        }

        private void pic_12_Click(object sender, EventArgs e)
        {
            pic_load.Load(Application.StartupPath + @"\images\how_long_images\slug.jpg");
        }

        private void pic_3_Click(object sender, EventArgs e)
        {
            pic_load.Load(Application.StartupPath + @"\images\how_long_images\bus.jpg");
        }

        private void pic_4_Click(object sender, EventArgs e)
        {
            pic_load.Load(Application.StartupPath + @"\images\how_long_images\capybara.jpg");
        }

        private void pic_5_Click(object sender, EventArgs e)
        {
            pic_load.Load(Application.StartupPath + @"\images\how_long_images\f1-car.jpg");
        }

        private void pic_6_Click(object sender, EventArgs e)
        {
            pic_load.Load(Application.StartupPath + @"\images\how_long_images\football-field.jpg");
        }
    }
}
