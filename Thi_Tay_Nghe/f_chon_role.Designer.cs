namespace Thi_Tay_Nghe
{
    partial class f_chon_role
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
            this.btn_runner = new System.Windows.Forms.Button();
            this.btn_Coordeinator = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_runner
            // 
            this.btn_runner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_runner.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_runner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_runner.Location = new System.Drawing.Point(125, 208);
            this.btn_runner.Name = "btn_runner";
            this.btn_runner.Size = new System.Drawing.Size(226, 41);
            this.btn_runner.TabIndex = 1;
            this.btn_runner.Text = "Runner";
            this.btn_runner.UseVisualStyleBackColor = true;
            this.btn_runner.Click += new System.EventHandler(this.btn_runner_Click);
            // 
            // btn_Coordeinator
            // 
            this.btn_Coordeinator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Coordeinator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Coordeinator.Location = new System.Drawing.Point(125, 270);
            this.btn_Coordeinator.Name = "btn_Coordeinator";
            this.btn_Coordeinator.Size = new System.Drawing.Size(226, 41);
            this.btn_Coordeinator.TabIndex = 2;
            this.btn_Coordeinator.Text = "Coordeinator";
            this.btn_Coordeinator.UseVisualStyleBackColor = true;
            this.btn_Coordeinator.Click += new System.EventHandler(this.btn_Coordeinator_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.Location = new System.Drawing.Point(125, 332);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(226, 41);
            this.btn_admin.TabIndex = 3;
            this.btn_admin.Text = "Admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Which type of user would you like to log in \r\nto the system as";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro Semibold", 23F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(102, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "FOR TESTING ONLY!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f_chon_role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_Coordeinator);
            this.Controls.Add(this.btn_runner);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f_chon_role";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.f_chon_role_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_runner;
        private System.Windows.Forms.Button btn_Coordeinator;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}