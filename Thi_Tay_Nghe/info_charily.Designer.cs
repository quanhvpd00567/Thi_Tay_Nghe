namespace Thi_Tay_Nghe
{
    partial class info_charily
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_name = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lb_de = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(164, 20);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(296, 46);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Name ";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_logo
            // 
            this.pic_logo.Location = new System.Drawing.Point(235, 79);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(178, 114);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 0;
            this.pic_logo.TabStop = false;
            // 
            // lb_de
            // 
            this.lb_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_de.Location = new System.Drawing.Point(2, 226);
            this.lb_de.Name = "lb_de";
            this.lb_de.Size = new System.Drawing.Size(677, 205);
            this.lb_de.TabIndex = 2;
            this.lb_de.Text = "Decription";
            this.lb_de.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // info_charily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 440);
            this.Controls.Add(this.lb_de);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pic_logo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "info_charily";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.info_charily_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_de;
    }
}