namespace DinhTrang_ADO
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_nam = new System.Windows.Forms.RadioButton();
            this.rdo_nu = new System.Windows.Forms.RadioButton();
            this.butThem = new System.Windows.Forms.Button();
            this.butProcedure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.Name = "MaSV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên";
            // 
            // txt_ma
            // 
            this.txt_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ma.Location = new System.Drawing.Point(340, 38);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(209, 23);
            this.txt_ma.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.Location = new System.Drawing.Point(340, 72);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(209, 23);
            this.txt_ten.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.CustomFormat = "dd-MM-yyyy";
            this.dtp_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(340, 104);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(200, 23);
            this.dtp_ngaysinh.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_nu);
            this.groupBox1.Controls.Add(this.rdo_nam);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(204, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rdo_nam
            // 
            this.rdo_nam.AutoSize = true;
            this.rdo_nam.Location = new System.Drawing.Point(136, 30);
            this.rdo_nam.Name = "rdo_nam";
            this.rdo_nam.Size = new System.Drawing.Size(55, 21);
            this.rdo_nam.TabIndex = 0;
            this.rdo_nam.TabStop = true;
            this.rdo_nam.Text = "Nam";
            this.rdo_nam.UseVisualStyleBackColor = true;
            // 
            // rdo_nu
            // 
            this.rdo_nu.AutoSize = true;
            this.rdo_nu.Location = new System.Drawing.Point(252, 30);
            this.rdo_nu.Name = "rdo_nu";
            this.rdo_nu.Size = new System.Drawing.Size(44, 21);
            this.rdo_nu.TabIndex = 1;
            this.rdo_nu.TabStop = true;
            this.rdo_nu.Text = "Nữ";
            this.rdo_nu.UseVisualStyleBackColor = true;
            // 
            // butThem
            // 
            this.butThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThem.Location = new System.Drawing.Point(645, 34);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(75, 36);
            this.butThem.TabIndex = 5;
            this.butThem.Text = "Thêm";
            this.butThem.UseVisualStyleBackColor = true;
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // butProcedure
            // 
            this.butProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butProcedure.Location = new System.Drawing.Point(645, 92);
            this.butProcedure.Name = "butProcedure";
            this.butProcedure.Size = new System.Drawing.Size(88, 35);
            this.butProcedure.TabIndex = 6;
            this.butProcedure.Text = "Procedure";
            this.butProcedure.UseVisualStyleBackColor = true;
            this.butProcedure.Click += new System.EventHandler(this.butProcedure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butProcedure);
            this.Controls.Add(this.butThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtp_ngaysinh);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_nu;
        private System.Windows.Forms.RadioButton rdo_nam;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.Button butProcedure;
    }
}

