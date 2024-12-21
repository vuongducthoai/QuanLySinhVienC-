
namespace _LTNET.View
{
    partial class frm_TimKiemSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TimKiemSinhVien));
            this.frmHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frmHuy
            // 
            this.frmHuy.BackColor = System.Drawing.Color.Red;
            this.frmHuy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmHuy.ForeColor = System.Drawing.Color.White;
            this.frmHuy.Location = new System.Drawing.Point(189, 71);
            this.frmHuy.Name = "frmHuy";
            this.frmHuy.Size = new System.Drawing.Size(172, 35);
            this.frmHuy.TabIndex = 200;
            this.frmHuy.Text = "Thoát chức năng";
            this.frmHuy.UseVisualStyleBackColor = false;
            this.frmHuy.Click += new System.EventHandler(this.frmHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(14, 71);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(177, 35);
            this.btnLuu.TabIndex = 199;
            this.btnLuu.Text = "Tìm kiếm";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(151, 12);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(241, 20);
            this.txthoten.TabIndex = 205;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 206;
            this.label3.Text = "Họ tên sinh viên";
            // 
            // txtquequan
            // 
            this.txtquequan.Location = new System.Drawing.Point(151, 34);
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(241, 20);
            this.txtquequan.TabIndex = 212;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 211;
            this.label4.Text = "Quê quán";
            // 
            // frm_TimKiemHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(400, 109);
            this.Controls.Add(this.txtquequan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.frmHuy);
            this.Controls.Add(this.btnLuu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TimKiemHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.frm_TimKiemHocSinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frmHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.Label label4;
    }
}