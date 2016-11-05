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
    public partial class form_check : Form
    {
        public form_check()
        {
            InitializeComponent();
        }
        
        private void form_check_Load(object sender, EventArgs e)
        {
            
            string part_pic1 = Application.StartupPath + @"\images\map-icons\map-icon-drinks.png";
            string part_pic2 = Application.StartupPath + @"\images\map-icons\map-icon-energy-bars.png";
            string part_pic3 = Application.StartupPath + @"\images\map-icons\map-icon-toilets.png";
            string part_pic4 = Application.StartupPath + @"\images\map-icons\map-icon-information.png";
            string part_pic5 = Application.StartupPath + @"\images\map-icons\map-icon-medical.png";
            if (tukhoa== "Checkpoint1")
            {
                lb_chaekc.Text = "Checkpoint 1";
                lb_Landmark.Text = "Avenida Rudge";
                lb_Drinks.Text = "Drinks"; 
                lb_EnergyBars.Text="Energy Bars";
                pic_Drinks.Load(part_pic1);
                pic_EnergyBars.Load(part_pic2);
            }
            else if((tukhoa == "Checkpoint2") || (tukhoa == "Checkpoint7") || (tukhoa == "Checkpoint8"))
            {
                if(tukhoa == "Checkpoint2")
                {
                    lb_chaekc.Text = "Checkpoint 2";
                    lb_Landmark.Text = "Theatro Municipal";
                }
                else if(tukhoa == "Checkpoint7")
                {
                    lb_chaekc.Text = "Checkpoint 7";
                    lb_Landmark.Text = "Cemitério da Consolação";
                }
                else
                {
                    lb_chaekc.Text = "Checkpoint 8";
                    lb_Landmark.Text = "Cemitério da Consolação";
                }
                lb_Drinks.Text = "Drinks";
                lb_EnergyBars.Text = "Energy Bars";
                lb_Information.Text = "Information";
                lb_Medical.Text = "Medical";
                lb_Toilets.Text = "Toilets";
                pic_Drinks.Load(part_pic1);
                pic_EnergyBars.Load(part_pic2);
                pic_Medical.Load(part_pic5);
                pic_Toilets.Load(part_pic3);
                pic_Information.Load(part_pic4);
            }
            else if ((tukhoa == "Checkpoint3") || (tukhoa == "Checkpoint6"))
            {
                if(tukhoa == "Checkpoint3")
                {
                    lb_chaekc.Text = "Checkpoint 3";
                    lb_Landmark.Text = "Rua Lisboa";
                }
                else
                {
                    lb_chaekc.Text = "Checkpoint 6";
                    lb_Landmark.Text = "Parque do Ibirapuera";
                }

                lb_Drinks.Text = "Drinks";
                lb_EnergyBars.Text = "Energy Bars";
                lb_Toilets.Text = "Toilets";
                pic_Drinks.Load(part_pic1);
                pic_EnergyBars.Load(part_pic2);
                pic_Toilets.Load(part_pic3);
            }
            else if (tukhoa == "Checkpoint4")
            {
                lb_chaekc.Text = "Checkpoint 4";
                lb_Landmark.Text = "Jardim Luzitania";
                lb_Drinks.Text = "Drinks";
                lb_EnergyBars.Text = "Energy Bars";
                lb_Information.Text = "Medical";
                lb_Toilets.Text = "Toilets";
                pic_Drinks.Load(part_pic1);
                pic_EnergyBars.Load(part_pic2);
                pic_Toilets.Load(part_pic3);
                pic_Information.Load(part_pic5);
            }
            else if (tukhoa == "Checkpoint5")
            {
                lb_chaekc.Text = "Checkpoint 5";
                lb_Landmark.Text = "Iguatemi";
                lb_Drinks.Text = "Drinks";
                lb_EnergyBars.Text = "Energy Bars";
                lb_Information.Text = "Information";
                lb_Toilets.Text = "Toilets";
                pic_Drinks.Load(part_pic1);
                pic_EnergyBars.Load(part_pic2);
                pic_Toilets.Load(part_pic3);
                pic_Information.Load(part_pic4);
            }
        }
        public string tukhoa;
        public void key(string a)
        {
            tukhoa = a;
        }
    }
}
