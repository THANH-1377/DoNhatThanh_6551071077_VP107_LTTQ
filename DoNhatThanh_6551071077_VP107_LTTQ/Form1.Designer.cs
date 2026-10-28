namespace DoNhatThanh_6551071077_VP107_LTTQ
{
    partial class frmMonHoc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpMonHoc = new GroupBox();
            txtSoTinChi = new TextBox();
            txtTenMonHoc = new TextBox();
            txtMaMonHoc = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            grpDSMonHoc = new GroupBox();
            dgvDS = new DataGridView();
            grpMonHoc.SuspendLayout();
            grpDSMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDS).BeginInit();
            SuspendLayout();
            // 
            // grpMonHoc
            // 
            grpMonHoc.Controls.Add(txtSoTinChi);
            grpMonHoc.Controls.Add(txtTenMonHoc);
            grpMonHoc.Controls.Add(txtMaMonHoc);
            grpMonHoc.Controls.Add(label3);
            grpMonHoc.Controls.Add(label2);
            grpMonHoc.Controls.Add(label1);
            grpMonHoc.Location = new Point(12, 12);
            grpMonHoc.Name = "grpMonHoc";
            grpMonHoc.Size = new Size(319, 377);
            grpMonHoc.TabIndex = 0;
            grpMonHoc.TabStop = false;
            grpMonHoc.Text = "Thông tin môn học";
            // 
            // txtSoTinChi
            // 
            txtSoTinChi.Location = new Point(21, 237);
            txtSoTinChi.Name = "txtSoTinChi";
            txtSoTinChi.Size = new Size(286, 27);
            txtSoTinChi.TabIndex = 5;
            txtSoTinChi.KeyPress += txtSoTinChi_KeyPress;
            // 
            // txtTenMonHoc
            // 
            txtTenMonHoc.Location = new Point(21, 157);
            txtTenMonHoc.Name = "txtTenMonHoc";
            txtTenMonHoc.Size = new Size(286, 27);
            txtTenMonHoc.TabIndex = 4;
            // 
            // txtMaMonHoc
            // 
            txtMaMonHoc.Location = new Point(21, 81);
            txtMaMonHoc.Name = "txtMaMonHoc";
            txtMaMonHoc.Size = new Size(286, 27);
            txtMaMonHoc.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 197);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Số tín chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 123);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên môn học:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 40);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã môn học:";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 403);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(116, 47);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(215, 403);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(116, 47);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(12, 483);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(116, 47);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(215, 483);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(116, 47);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // grpDSMonHoc
            // 
            grpDSMonHoc.Controls.Add(dgvDS);
            grpDSMonHoc.Location = new Point(356, 12);
            grpDSMonHoc.Name = "grpDSMonHoc";
            grpDSMonHoc.Size = new Size(593, 518);
            grpDSMonHoc.TabIndex = 5;
            grpDSMonHoc.TabStop = false;
            grpDSMonHoc.Text = "Danh sách môn học";
            // 
            // dgvDS
            // 
            dgvDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDS.Location = new Point(17, 26);
            dgvDS.Name = "dgvDS";
            dgvDS.RowHeadersWidth = 51;
            dgvDS.Size = new Size(558, 486);
            dgvDS.TabIndex = 0;
            dgvDS.SelectionChanged += dgvDS_SelectionChanged;
            // 
            // frmMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 543);
            Controls.Add(grpDSMonHoc);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(grpMonHoc);
            Name = "frmMonHoc";
            Text = "Quản lý Môn học / Học phần - VP107";
            Load += frmMonHoc_Load;
            grpMonHoc.ResumeLayout(false);
            grpMonHoc.PerformLayout();
            grpDSMonHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMonHoc;
        private TextBox txtSoTinChi;
        private TextBox txtTenMonHoc;
        private TextBox txtMaMonHoc;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private GroupBox grpDSMonHoc;
        private DataGridView dgvDS;
    }
}
