
namespace _LTNET.View
{
    partial class frm_QuanLyLop_Sua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyLop_Sua));
            this.frmHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txthotenlt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frmHuy
            // 
            this.frmHuy.BackColor = System.Drawing.Color.Red;
            this.frmHuy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmHuy.ForeColor = System.Drawing.Color.White;
            this.frmHuy.Location = new System.Drawing.Point(207, 107);
            this.frmHuy.Name = "frmHuy";
            this.frmHuy.Size = new System.Drawing.Size(172, 35);
            this.frmHuy.TabIndex = 220;
            this.frmHuy.Text = "Thoát chức năng";
            this.frmHuy.UseVisualStyleBackColor = false;
            this.frmHuy.Click += new System.EventHandler(this.frmHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(32, 107);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(177, 35);
            this.btnLuu.TabIndex = 219;
            this.btnLuu.Text = "Lưu dữ liệu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(154, 12);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(241, 20);
            this.txtmalop.TabIndex = 221;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 222;
            this.label1.Text = "Mã lớp";
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(154, 33);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(241, 20);
            this.txttenlop.TabIndex = 223;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 224;
            this.label3.Text = "Tên lớp";
            // 
            // txtemail
            // 
            this.txtemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemail.Location = new System.Drawing.Point(154, 54);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(241, 20);
            this.txtemail.TabIndex = 227;
            // 
            // txthotenlt
            // 
            this.txthotenlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txthotenlt.Location = new System.Drawing.Point(154, 75);
            this.txthotenlt.Name = "txthotenlt";
            this.txthotenlt.Size = new System.Drawing.Size(241, 20);
            this.txthotenlt.TabIndex = 228;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 225;
            this.label5.Text = "Email lớp";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 226;
            this.label4.Text = "Họ tên lớp trưởng";
            // 
            // frm_QuanLyLop_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(407, 145);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txthotenlt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmalop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttenlop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.frmHuy);
            this.Controls.Add(this.btnLuu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_QuanLyLop_Sua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_QuanLyLop_Sua";
            this.Load += new System.EventHandler(this.frm_QuanLyLop_Sua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frmHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txthotenlt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}