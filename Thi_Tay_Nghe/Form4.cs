using BUL;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thi_Tay_Nghe
{
    
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           // MyImage m = new MyImage();
            // B1: Tat chuc nang tu dong tao cot cua ĐâtGridview
            dataGridView1.AutoGenerateColumns = false;

            // B2: Tu them cot bang tay, bao gom cot Image (quan trong)
            var colId = new DataGridViewTextBoxColumn();
            colId.HeaderText = "#Id";
            colId.Name = "Id";

            var colName = new DataGridViewTextBoxColumn();
            colName.HeaderText = "Teen";
            colName.Name = "Name";


            var colChecked = new DataGridViewTextBoxColumn();
            colChecked.HeaderText = "Checked";
            colChecked.Name = "Checked";
            var col5 = new DataGridViewImageColumn(); // Cot chua Image
            col5.HeaderText = "Colum 5";
            col5.Name = "FileUrl";
            col5.Width = 200;
            //col5.
           // sao k có chiều cao của dòng nhỉ 
           // là sao cho hình vừa vs cell. Tu code di, ve lai cai hinh khac
            // B4: Them cot vao dâtgrid
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colChecked, col5  });

            BL_Charity ch = new BL_Charity();
            Data_AseanDataContext db = new Data_AseanDataContext();

            // B5: Them du lieu vao datagrid (lay o dau thi tuy)
            foreach (var item in db.Charities)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Height = 150;
                row.Cells[0].Value = item.CharityId;
                row.Cells[1].Value = item.CharityName;
                row.Cells[2].Value = item.CharityDescription;
                string fileXX = Application.StartupPath + @"\images\" + item.CharityLogo;
                row.Cells[3].Value = ByteArrayToImage(fileXX);
                
                dataGridView1.Rows.Add(row);
            }
        }
        // Doc anh tu file
        public Image ByteArrayToImage(string filePath)
        {
            byte[] imageData = null;
            // Đọc file chuyển sang mảng
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                imageData = new Byte[fs.Length];
                fs.Read(imageData, 0, (int)fs.Length);
                fs.Flush();
                MemoryStream ms = new MemoryStream(imageData);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
    }
}
