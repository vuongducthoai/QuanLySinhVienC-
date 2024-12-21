
namespace _LTNET.View
{
    partial class frm_DoiMatKhau
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpassword_old = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassword_new = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassword_renew = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpassword_old);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtpassword_new);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtpassword_renew);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 100);
            this.groupBox1.TabIndex = 185;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtpassword_old
            // 
            this.txtpassword_old.Location = new System.Drawing.Point(176, 19);
            this.txtpassword_old.Name = "txtpassword_old";
            this.txtpassword_old.PasswordChar = '*';
            this.txtpassword_old.Size = new System.Drawing.Size(241, 20);
            this.txtpassword_old.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // txtpassword_new
            // 
            this.txtpassword_new.Location = new System.Drawing.Point(176, 40);
            this.txtpassword_new.Name = "txtpassword_new";
            this.txtpassword_new.PasswordChar = '*';
            this.txtpassword_new.Size = new System.Drawing.Size(241, 20);
            this.txtpassword_new.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Mật khẩu mới";
            // 
            // txtpassword_renew
            // 
            this.txtpassword_renew.Location = new System.Drawing.Point(176, 61);
            this.txtpassword_renew.Name = "txtpassword_renew";
            this.txtpassword_renew.PasswordChar = '*';
            this.txtpassword_renew.Size = new System.Drawing.Size(241, 20);
            this.txtpassword_renew.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Nhập lại mật khẩu mới";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(166, 109);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(177, 35);
            this.btnLuu.TabIndex = 186;
            this.btnLuu.Text = "Đổi mật khẩu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_DoiMatKhau";
            this.Size = new System.Drawing.Size(480, 156);
            this.Load += new System.EventHandler(this.frm_DoiMatKhau_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpassword_old;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassword_new;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassword_renew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
    }
}
