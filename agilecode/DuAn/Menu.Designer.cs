﻿namespace DuAn
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvDanhSachSV = new DataGridView();
            button3 = new Button();
            txtTimkiem = new TextBox();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            cboMonHoc = new ComboBox();
            btnThem = new Button();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            label11 = new Label();
            label10 = new Label();
            dtpNgaySinh = new DateTimePicker();
            txtDiemTB = new TextBox();
            txtDiemDuAn = new TextBox();
            txtDiemTiengAnh = new TextBox();
            txtDiemIT = new TextBox();
            txtEmail = new TextBox();
            txtLop = new TextBox();
            txtTenSv = new TextBox();
            txtMaSv = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            button4 = new Button();
            btnSapXep = new Button();
            rdoTb = new RadioButton();
            rdoKha = new RadioButton();
            rdoGioi = new RadioButton();
            rdoXuatSac = new RadioButton();
            rdoTruot = new RadioButton();
            dgvThongKe = new DataGridView();
            tabPage3 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            label13 = new Label();
            comboBox1 = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            tb_ch = new TextBox();
            label17 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSV).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(8, 11);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1308, 598);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvDanhSachSV);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(txtTimkiem);
            tabPage1.Controls.Add(btnTimKiem);
            tabPage1.Controls.Add(btnThoat);
            tabPage1.Controls.Add(btnXoa);
            tabPage1.Controls.Add(btnSua);
            tabPage1.Controls.Add(cboMonHoc);
            tabPage1.Controls.Add(btnThem);
            tabPage1.Controls.Add(rdoNu);
            tabPage1.Controls.Add(rdoNam);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(dtpNgaySinh);
            tabPage1.Controls.Add(txtDiemTB);
            tabPage1.Controls.Add(txtDiemDuAn);
            tabPage1.Controls.Add(txtDiemTiengAnh);
            tabPage1.Controls.Add(txtDiemIT);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtLop);
            tabPage1.Controls.Add(txtTenSv);
            tabPage1.Controls.Add(txtMaSv);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(1300, 560);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thông tin sinh viên";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachSV
            // 
            dgvDanhSachSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSV.Location = new Point(2, 6);
            dgvDanhSachSV.Margin = new Padding(2);
            dgvDanhSachSV.Name = "dgvDanhSachSV";
            dgvDanhSachSV.RowHeadersWidth = 62;
            dgvDanhSachSV.RowTemplate.Height = 33;
            dgvDanhSachSV.Size = new Size(1291, 215);
            dgvDanhSachSV.TabIndex = 71;
            dgvDanhSachSV.CellClick += dgvDanhSachSV_CellClick;
            // 
            // button3
            // 
            button3.Location = new Point(1050, 465);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 104;
            button3.Text = "reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(955, 248);
            txtTimkiem.Margin = new Padding(2);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(225, 31);
            txtTimkiem.TabIndex = 103;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1182, 245);
            btnTimKiem.Margin = new Padding(2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 34);
            btnTimKiem.TabIndex = 102;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1125, 408);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 101;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(955, 408);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 100;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(1125, 338);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 99;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // cboMonHoc
            // 
            cboMonHoc.FormattingEnabled = true;
            cboMonHoc.Location = new Point(642, 242);
            cboMonHoc.Margin = new Padding(2);
            cboMonHoc.Name = "cboMonHoc";
            cboMonHoc.Size = new Size(272, 33);
            cboMonHoc.TabIndex = 98;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(955, 338);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 97;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(294, 391);
            rdoNu.Margin = new Padding(2);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(61, 29);
            rdoNu.TabIndex = 96;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(148, 391);
            rdoNam.Margin = new Padding(2);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(75, 29);
            rdoNam.TabIndex = 95;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(502, 242);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(81, 25);
            label11.TabIndex = 93;
            label11.Text = "MonHoc";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(499, 455);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(73, 25);
            label10.TabIndex = 92;
            label10.Text = "DiemTB";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(145, 332);
            dtpNgaySinh.Margin = new Padding(2);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(246, 31);
            dtpNgaySinh.TabIndex = 91;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(642, 455);
            txtDiemTB.Margin = new Padding(2);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(272, 31);
            txtDiemTB.TabIndex = 89;
            txtDiemTB.TextChanged += txtDiemTB_TextChanged;
            // 
            // txtDiemDuAn
            // 
            txtDiemDuAn.Location = new Point(642, 396);
            txtDiemDuAn.Margin = new Padding(2);
            txtDiemDuAn.Name = "txtDiemDuAn";
            txtDiemDuAn.Size = new Size(272, 31);
            txtDiemDuAn.TabIndex = 88;
            txtDiemDuAn.TextChanged += txtDiemDuAn_TextChanged;
            // 
            // txtDiemTiengAnh
            // 
            txtDiemTiengAnh.Location = new Point(642, 340);
            txtDiemTiengAnh.Margin = new Padding(2);
            txtDiemTiengAnh.Name = "txtDiemTiengAnh";
            txtDiemTiengAnh.Size = new Size(272, 31);
            txtDiemTiengAnh.TabIndex = 87;
            txtDiemTiengAnh.TextChanged += txtDiemTiengAnh_TextChanged;
            // 
            // txtDiemIT
            // 
            txtDiemIT.Location = new Point(642, 291);
            txtDiemIT.Margin = new Padding(2);
            txtDiemIT.Name = "txtDiemIT";
            txtDiemIT.Size = new Size(272, 31);
            txtDiemIT.TabIndex = 86;
            txtDiemIT.TextChanged += txtDiemIT_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(145, 439);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(246, 31);
            txtEmail.TabIndex = 83;
            // 
            // txtLop
            // 
            txtLop.Location = new Point(144, 486);
            txtLop.Margin = new Padding(2);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(248, 31);
            txtLop.TabIndex = 82;
            // 
            // txtTenSv
            // 
            txtTenSv.Location = new Point(145, 284);
            txtTenSv.Margin = new Padding(2);
            txtTenSv.Name = "txtTenSv";
            txtTenSv.Size = new Size(246, 31);
            txtTenSv.TabIndex = 90;
            // 
            // txtMaSv
            // 
            txtMaSv.Location = new Point(145, 238);
            txtMaSv.Margin = new Padding(2);
            txtMaSv.Name = "txtMaSv";
            txtMaSv.Size = new Size(246, 31);
            txtMaSv.TabIndex = 81;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(499, 396);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(99, 25);
            label9.TabIndex = 79;
            label9.Text = "DiemDuAn";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(499, 346);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(129, 25);
            label8.TabIndex = 78;
            label8.Text = "DiemTiengAnh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(499, 298);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 25);
            label7.TabIndex = 77;
            label7.Text = "DiemIT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 486);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(42, 25);
            label6.TabIndex = 76;
            label6.Text = "Lop";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 438);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 75;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 388);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 74;
            label4.Text = "GioiTinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 336);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 73;
            label3.Text = "NgaySInh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 291);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 80;
            label2.Text = "TenSV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 241);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 72;
            label1.Text = "MaSV";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(btnSapXep);
            tabPage2.Controls.Add(rdoTb);
            tabPage2.Controls.Add(rdoKha);
            tabPage2.Controls.Add(rdoGioi);
            tabPage2.Controls.Add(rdoXuatSac);
            tabPage2.Controls.Add(rdoTruot);
            tabPage2.Controls.Add(dgvThongKe);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(1300, 560);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thống kê";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(562, 225);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 9;
            button4.Text = "Thống kê";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnSapXep
            // 
            btnSapXep.Location = new Point(665, 92);
            btnSapXep.Margin = new Padding(2);
            btnSapXep.Name = "btnSapXep";
            btnSapXep.Size = new Size(188, 34);
            btnSapXep.TabIndex = 8;
            btnSapXep.Text = "Sắp xếp theo điểm";
            btnSapXep.UseVisualStyleBackColor = true;
            btnSapXep.Click += btnSapXep_Click;
            // 
            // rdoTb
            // 
            rdoTb.AutoSize = true;
            rdoTb.Location = new Point(398, 52);
            rdoTb.Margin = new Padding(2);
            rdoTb.Name = "rdoTb";
            rdoTb.Size = new Size(196, 29);
            rdoTb.TabIndex = 3;
            rdoTb.TabStop = true;
            rdoTb.Text = "Sinh viên trung bình";
            rdoTb.UseVisualStyleBackColor = true;
            // 
            // rdoKha
            // 
            rdoKha.AutoSize = true;
            rdoKha.Location = new Point(132, 158);
            rdoKha.Margin = new Padding(2);
            rdoKha.Name = "rdoKha";
            rdoKha.Size = new Size(141, 29);
            rdoKha.TabIndex = 4;
            rdoKha.TabStop = true;
            rdoKha.Text = "Sinh viên khá";
            rdoKha.UseVisualStyleBackColor = true;
            // 
            // rdoGioi
            // 
            rdoGioi.AutoSize = true;
            rdoGioi.Location = new Point(130, 98);
            rdoGioi.Margin = new Padding(2);
            rdoGioi.Name = "rdoGioi";
            rdoGioi.Size = new Size(143, 29);
            rdoGioi.TabIndex = 5;
            rdoGioi.TabStop = true;
            rdoGioi.Text = "Sinh viên giỏi";
            rdoGioi.UseVisualStyleBackColor = true;
            // 
            // rdoXuatSac
            // 
            rdoXuatSac.AutoSize = true;
            rdoXuatSac.Location = new Point(130, 44);
            rdoXuatSac.Margin = new Padding(2);
            rdoXuatSac.Name = "rdoXuatSac";
            rdoXuatSac.Size = new Size(176, 29);
            rdoXuatSac.TabIndex = 6;
            rdoXuatSac.TabStop = true;
            rdoXuatSac.Text = "Sinh viên xuất sắc";
            rdoXuatSac.UseVisualStyleBackColor = true;
            // 
            // rdoTruot
            // 
            rdoTruot.AutoSize = true;
            rdoTruot.Location = new Point(398, 109);
            rdoTruot.Margin = new Padding(2);
            rdoTruot.Name = "rdoTruot";
            rdoTruot.Size = new Size(153, 29);
            rdoTruot.TabIndex = 7;
            rdoTruot.TabStop = true;
            rdoTruot.Text = "Sinh viên trượt";
            rdoTruot.UseVisualStyleBackColor = true;
            // 
            // dgvThongKe
            // 
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Location = new Point(6, 308);
            dgvThongKe.Margin = new Padding(2);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersWidth = 62;
            dgvThongKe.RowTemplate.Height = 33;
            dgvThongKe.Size = new Size(1288, 225);
            dgvThongKe.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(tb_ch);
            tabPage3.Controls.Add(label17);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1300, 560);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Hỗ Trợ ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(724, 130);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(108, 38);
            button2.TabIndex = 26;
            button2.Text = "Gửi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1068, 475);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(111, 42);
            button1.TabIndex = 25;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(558, 255);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(506, 184);
            label13.TabIndex = 24;
            label13.Text = resources.GetString("label13.Text");
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DvSV", "Khảo Thí", "Đào Tạo ", "Hành Chính", "IT" });
            comboBox1.Location = new Point(278, 231);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 33);
            comboBox1.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(708, 205);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(191, 26);
            label14.TabIndex = 20;
            label14.Text = "Thông tin liên hệ ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(272, 92);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(98, 26);
            label15.TabIndex = 21;
            label15.Text = "Câu Hỏi";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(272, 196);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(122, 26);
            label16.TabIndex = 22;
            label16.Text = "Danh mục ";
            // 
            // tb_ch
            // 
            tb_ch.Location = new Point(278, 134);
            tb_ch.Margin = new Padding(2);
            tb_ch.Name = "tb_ch";
            tb_ch.Size = new Size(400, 31);
            tb_ch.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(520, 15);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(93, 33);
            label17.TabIndex = 18;
            label17.Text = "Hỗ Trợ";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 572);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "Menu";
            Text = "Trang chủ";
            Load += Menu_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSV).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnThem;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private Label label11;
        private Label label10;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtDiemTB;
        private TextBox txtDiemDuAn;
        private TextBox txtDiemTiengAnh;
        private TextBox txtDiemIT;
        private TextBox txtEmail;
        private TextBox txtLop;
        private TextBox txtTenSv;
        private TextBox txtMaSv;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvDanhSachSV;
        private RadioButton rdoTb;
        private RadioButton rdoKha;
        private RadioButton rdoGioi;
        private RadioButton rdoXuatSac;
        private RadioButton rdoTruot;
        private DataGridView dgvThongKe;
        private ComboBox cboMonHoc;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private TextBox txtTimkiem;
        private Button btnTimKiem;
        private Button btnSapXep;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label13;
        private ComboBox comboBox1;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox tb_ch;
        private Label label17;
    }
}