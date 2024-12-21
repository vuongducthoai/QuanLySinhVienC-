
namespace _LTNET.View
{
    partial class frm_TimKiemLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TimKiemLop));
            this.frmHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frmHuy
            // 
            this.frmHuy.BackColor = System.Drawing.Color.Red;
            this.frmHuy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmHuy.ForeColor = System.Drawing.Color.White;
            this.frmHuy.Location = new System.Drawing.Point(188, 45);
            this.frmHuy.Name = "frmHuy";
            this.frmHuy.Size = new System.Drawing.Size(172, 35);
            this.frmHuy.TabIndex = 214;
            this.frmHuy.Text = "Thoát chức năng";
            this.frmHuy.UseVisualStyleBackColor = false;
            this.frmHuy.Click += new System.EventHandler(this.frmHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(13, 45);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(177, 35);
            this.btnLuu.TabIndex = 213;
            this.btnLuu.Text = "Tìm kiếm";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(147, 12);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(241, 20);
            this.txttenlop.TabIndex = 225;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 226;
            this.label3.Text = "Tên lớp";
            // 
            // frm_TimKiemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(400, 82);
            this.Controls.Add(this.txttenlop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.frmHuy);
            this.Controls.Add(this.btnLuu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TimKiemLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm lớp";
            this.Load += new System.EventHandler(this.frm_TimKiemLop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frmHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.Label label3;
    }
}