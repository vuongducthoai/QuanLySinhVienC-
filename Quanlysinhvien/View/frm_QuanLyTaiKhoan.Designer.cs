
namespace _LTNET.View
{
    partial class frm_QuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyTaiKhoan));
            this.dtGVTK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmod = new System.Windows.Forms.TextBox();
            this.txtstate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVTK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGVTK
            // 
            this.dtGVTK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGVTK.BackgroundColor = System.Drawing.Color.White;
            this.dtGVTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVTK.Location = new System.Drawing.Point(3, 159);
            this.dtGVTK.Name = "dtGVTK";
            this.dtGVTK.Size = new System.Drawing.Size(781, 204);
            this.dtGVTK.TabIndex = 0;
            this.dtGVTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVTK_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(155, 19);
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = true;
            this.txtusername.Size = new System.Drawing.Size(241, 20);
            this.txtusername.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Họ tên người dùng";
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(155, 40);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.ReadOnly = true;
            this.txtfullname.Size = new System.Drawing.Size(241, 20);
            this.txtfullname.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Phân quyền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(155, 61);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(241, 20);
            this.txtemail.TabIndex = 43;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(263, 106);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 29);
            this.btnThem.TabIndex = 49;
            this.btnThem.Tag = "L006";
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(358, 106);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 29);
            this.btnSua.TabIndex = 52;
            this.btnSua.Tag = "L006";
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(453, 106);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 29);
            this.btnXoa.TabIndex = 53;
            this.btnXoa.Tag = "L006";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 183;
            this.label2.Text = "Danh sách tài khoản";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmod);
            this.groupBox1.Controls.Add(this.txtstate);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtfullname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 93);
            this.groupBox1.TabIndex = 184;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtmod
            // 
            this.txtmod.Location = new System.Drawing.Point(526, 19);
            this.txtmod.Name = "txtmod";
            this.txtmod.ReadOnly = true;
            this.txtmod.Size = new System.Drawing.Size(241, 20);
            this.txtmod.TabIndex = 49;
            // 
            // txtstate
            // 
            this.txtstate.Location = new System.Drawing.Point(526, 40);
            this.txtstate.Name = "txtstate";
            this.txtstate.ReadOnly = true;
            this.txtstate.Size = new System.Drawing.Size(241, 20);
            this.txtstate.TabIndex = 50;
            // 
            // frm_QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtGVTK);
            this.Name = "frm_QuanLyTaiKhoan";
            this.Size = new System.Drawing.Size(787, 366);
            this.Load += new System.EventHandler(this.frm_QuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVTK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGVTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtemail;
        internal System.Windows.Forms.Button btnThem;
        internal System.Windows.Forms.Button btnSua;
        internal System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmod;
        private System.Windows.Forms.TextBox txtstate;
    }
}
