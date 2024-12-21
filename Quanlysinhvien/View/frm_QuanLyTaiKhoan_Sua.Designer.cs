
namespace _LTNET.View
{
    partial class frm_QuanLyTaiKhoan_Sua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyTaiKhoan_Sua));
            this.cbostate = new System.Windows.Forms.ComboBox();
            this.cbomod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.frmHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrepassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbostate
            // 
            this.cbostate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbostate.FormattingEnabled = true;
            this.cbostate.Location = new System.Drawing.Point(118, 140);
            this.cbostate.Name = "cbostate";
            this.cbostate.Size = new System.Drawing.Size(241, 21);
            this.cbostate.TabIndex = 6;
            // 
            // cbomod
            // 
            this.cbomod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomod.FormattingEnabled = true;
            this.cbomod.Location = new System.Drawing.Point(118, 118);
            this.cbomod.Name = "cbomod";
            this.cbomod.Size = new System.Drawing.Size(241, 21);
            this.cbomod.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Phân quyền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(118, 97);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(241, 20);
            this.txtemail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Họ tên người dùng";
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(118, 76);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(241, 20);
            this.txtfullname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Mật khẩu";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(118, 34);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(241, 20);
            this.txtpassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(118, 13);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(241, 20);
            this.txtusername.TabIndex = 0;
            // 
            // frmHuy
            // 
            this.frmHuy.BackColor = System.Drawing.Color.Red;
            this.frmHuy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmHuy.ForeColor = System.Drawing.Color.White;
            this.frmHuy.Location = new System.Drawing.Point(187, 175);
            this.frmHuy.Name = "frmHuy";
            this.frmHuy.Size = new System.Drawing.Size(172, 35);
            this.frmHuy.TabIndex = 8;
            this.frmHuy.Text = "Thoát chức năng";
            this.frmHuy.UseVisualStyleBackColor = false;
            this.frmHuy.Click += new System.EventHandler(this.frmHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(12, 175);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(177, 35);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu dữ liệu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 191;
            this.label7.Text = "Nhập lại mật khẩu";
            // 
            // txtrepassword
            // 
            this.txtrepassword.Location = new System.Drawing.Point(118, 55);
            this.txtrepassword.Name = "txtrepassword";
            this.txtrepassword.PasswordChar = '*';
            this.txtrepassword.Size = new System.Drawing.Size(241, 20);
            this.txtrepassword.TabIndex = 2;
            // 
            // frm_QuanLyTaiKhoan_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(375, 215);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtrepassword);
            this.Controls.Add(this.frmHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbostate);
            this.Controls.Add(this.cbomod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_QuanLyTaiKhoan_Sua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_QuanLyTaiKhoan_Sua";
            this.Load += new System.EventHandler(this.frm_QuanLyTaiKhoan_Sua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbostate;
        private System.Windows.Forms.ComboBox cbomod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button frmHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrepassword;
    }
}