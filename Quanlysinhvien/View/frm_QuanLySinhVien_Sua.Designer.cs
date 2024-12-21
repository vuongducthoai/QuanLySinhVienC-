
namespace _LTNET.View
{
    partial class frm_QuanLySinhVien_Sua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLySinhVien_Sua));
            this.frmHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.nmdiemtb = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbogioitinh = new System.Windows.Forms.ComboBox();
            this.cbomalop = new System.Windows.Forms.ComboBox();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmahs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmdiemtb)).BeginInit();
            this.SuspendLayout();
            // 
            // frmHuy
            // 
            this.frmHuy.BackColor = System.Drawing.Color.Red;
            this.frmHuy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmHuy.ForeColor = System.Drawing.Color.White;
            this.frmHuy.Location = new System.Drawing.Point(279, 220);
            this.frmHuy.Margin = new System.Windows.Forms.Padding(4);
            this.frmHuy.Name = "frmHuy";
            this.frmHuy.Size = new System.Drawing.Size(229, 43);
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
            this.btnLuu.Location = new System.Drawing.Point(45, 220);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(236, 43);
            this.btnLuu.TabIndex = 199;
            this.btnLuu.Text = "Lưu dữ liệu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(207, 41);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(320, 22);
            this.txthoten.TabIndex = 203;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 204;
            this.label3.Text = "Họ tên sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 208;
            this.label4.Text = "Quê quán";
            // 
            // txtquequan
            // 
            this.txtquequan.Location = new System.Drawing.Point(207, 146);
            this.txtquequan.Margin = new System.Windows.Forms.Padding(4);
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(320, 22);
            this.txtquequan.TabIndex = 210;
            // 
            // nmdiemtb
            // 
            this.nmdiemtb.Location = new System.Drawing.Point(207, 172);
            this.nmdiemtb.Margin = new System.Windows.Forms.Padding(4);
            this.nmdiemtb.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmdiemtb.Name = "nmdiemtb";
            this.nmdiemtb.Size = new System.Drawing.Size(320, 22);
            this.nmdiemtb.TabIndex = 218;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 212;
            this.label7.Text = "Điểm trung bình";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 213;
            this.label8.Text = "Mã lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 207;
            this.label5.Text = "Giới tính";
            // 
            // cbogioitinh
            // 
            this.cbogioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogioitinh.FormattingEnabled = true;
            this.cbogioitinh.Location = new System.Drawing.Point(207, 119);
            this.cbogioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbogioitinh.Name = "cbogioitinh";
            this.cbogioitinh.Size = new System.Drawing.Size(320, 24);
            this.cbogioitinh.TabIndex = 216;
            // 
            // cbomalop
            // 
            this.cbomalop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomalop.FormattingEnabled = true;
            this.cbomalop.Location = new System.Drawing.Point(207, 92);
            this.cbomalop.Margin = new System.Windows.Forms.Padding(4);
            this.cbomalop.Name = "cbomalop";
            this.cbomalop.Size = new System.Drawing.Size(320, 24);
            this.cbomalop.TabIndex = 215;
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaysinh.Location = new System.Drawing.Point(207, 65);
            this.dtngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(320, 22);
            this.dtngaysinh.TabIndex = 217;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 206;
            this.label6.Text = "Ngày sinh";
            // 
            // txtmahs
            // 
            this.txtmahs.Location = new System.Drawing.Point(207, 15);
            this.txtmahs.Margin = new System.Windows.Forms.Padding(4);
            this.txtmahs.Name = "txtmahs";
            this.txtmahs.Size = new System.Drawing.Size(320, 22);
            this.txtmahs.TabIndex = 201;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 202;
            this.label1.Text = "Mã sinh viên";
            // 
            // frm_QuanLySinhVien_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(543, 267);
            this.Controls.Add(this.nmdiemtb);
            this.Controls.Add(this.dtngaysinh);
            this.Controls.Add(this.cbogioitinh);
            this.Controls.Add(this.cbomalop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtquequan);
            this.Controls.Add(this.txtmahs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.frmHuy);
            this.Controls.Add(this.btnLuu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_QuanLySinhVien_Sua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_QuanLyHocSinh_Sua";
            this.Load += new System.EventHandler(this.frm_QuanLySinhVien_Sua_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nmdiemtb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button frmHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.NumericUpDown nmdiemtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbogioitinh;
        private System.Windows.Forms.ComboBox cbomalop;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmahs;
        private System.Windows.Forms.Label label1;
    }
}