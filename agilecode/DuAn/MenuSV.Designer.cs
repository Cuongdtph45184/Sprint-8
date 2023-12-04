namespace DuAn
{
    partial class MenuSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSV));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvDanhSachSV = new DataGridView();
            txttimkiem = new TextBox();
            button3 = new Button();
            btntimkiem = new Button();
            btnthoat = new Button();
            tphotro = new TabPage();
            button2 = new Button();
            button1 = new Button();
            label13 = new Label();
            cbodanhmuc = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            txtcauhoi = new TextBox();
            label17 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSV).BeginInit();
            tphotro.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tphotro);
            tabControl1.Location = new Point(14, 3);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1244, 783);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvDanhSachSV);
            tabPage1.Controls.Add(txttimkiem);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(btntimkiem);
            tabPage1.Controls.Add(btnthoat);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(1236, 745);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thông tin sinh viên";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachSV
            // 
            dgvDanhSachSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSV.Location = new Point(0, 85);
            dgvDanhSachSV.Name = "dgvDanhSachSV";
            dgvDanhSachSV.RowHeadersWidth = 62;
            dgvDanhSachSV.RowTemplate.Height = 33;
            dgvDanhSachSV.Size = new Size(1233, 427);
            dgvDanhSachSV.TabIndex = 72;
            // 
            // txttimkiem
            // 
            txttimkiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttimkiem.Location = new Point(674, 24);
            txttimkiem.Margin = new Padding(4, 3, 4, 3);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(365, 36);
            txttimkiem.TabIndex = 12;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Location = new Point(1047, 551);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(117, 45);
            button3.TabIndex = 10;
            button3.Text = "Hiển Thị";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Btn_hienthi;
            // 
            // btntimkiem
            // 
            btntimkiem.BackColor = SystemColors.ControlLight;
            btntimkiem.Location = new Point(1047, 21);
            btntimkiem.Margin = new Padding(4, 3, 4, 3);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(117, 45);
            btntimkiem.TabIndex = 10;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = false;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = SystemColors.ControlLight;
            btnthoat.Location = new Point(1047, 629);
            btnthoat.Margin = new Padding(4, 3, 4, 3);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(117, 62);
            btnthoat.TabIndex = 11;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click_1;
            // 
            // tphotro
            // 
            tphotro.Controls.Add(button2);
            tphotro.Controls.Add(button1);
            tphotro.Controls.Add(label13);
            tphotro.Controls.Add(cbodanhmuc);
            tphotro.Controls.Add(label14);
            tphotro.Controls.Add(label15);
            tphotro.Controls.Add(label16);
            tphotro.Controls.Add(txtcauhoi);
            tphotro.Controls.Add(label17);
            tphotro.Location = new Point(4, 34);
            tphotro.Margin = new Padding(4, 3, 4, 3);
            tphotro.Name = "tphotro";
            tphotro.Padding = new Padding(4, 3, 4, 3);
            tphotro.Size = new Size(1236, 745);
            tphotro.TabIndex = 1;
            tphotro.Text = "Hỗ trợ";
            tphotro.UseVisualStyleBackColor = true;
            tphotro.Click += tphotro_Click;
            // 
            // button2
            // 
            button2.Location = new Point(533, 235);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(107, 37);
            button2.TabIndex = 35;
            button2.Text = "Gửi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(876, 580);
            button1.Name = "button1";
            button1.Size = new Size(111, 43);
            button1.TabIndex = 34;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(366, 360);
            label13.Name = "label13";
            label13.Size = new Size(506, 184);
            label13.TabIndex = 33;
            label13.Text = resources.GetString("label13.Text");
            // 
            // cbodanhmuc
            // 
            cbodanhmuc.FormattingEnabled = true;
            cbodanhmuc.Items.AddRange(new object[] { "DvSV", "Khảo Thí", "Đào Tạo ", "Hành Chính", "IT" });
            cbodanhmuc.Location = new Point(86, 337);
            cbodanhmuc.Name = "cbodanhmuc";
            cbodanhmuc.Size = new Size(183, 33);
            cbodanhmuc.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(516, 310);
            label14.Name = "label14";
            label14.Size = new Size(191, 26);
            label14.TabIndex = 29;
            label14.Text = "Thông tin liên hệ ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(81, 197);
            label15.Name = "label15";
            label15.Size = new Size(98, 26);
            label15.TabIndex = 30;
            label15.Text = "Câu Hỏi";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(81, 302);
            label16.Name = "label16";
            label16.Size = new Size(122, 26);
            label16.TabIndex = 31;
            label16.Text = "Danh mục ";
            // 
            // txtcauhoi
            // 
            txtcauhoi.Location = new Point(86, 238);
            txtcauhoi.Name = "txtcauhoi";
            txtcauhoi.Size = new Size(400, 31);
            txtcauhoi.TabIndex = 28;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(474, 60);
            label17.Name = "label17";
            label17.Size = new Size(93, 33);
            label17.TabIndex = 27;
            label17.Text = "Hỗ Trợ";
            // 
            // MenuSV
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 803);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MenuSV";
            Text = "MenuSV";
            Load += MenuSV_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSV).EndInit();
            tphotro.ResumeLayout(false);
            tphotro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnthoat;
        private TabPage tphotro;
        private Button button2;
        private Button button1;
        private Label label13;
        private ComboBox cbodanhmuc;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox txtcauhoi;
        private Label label17;
        private TextBox txttimkiem;
        private Button btntimkiem;
        private DataGridView dgvDanhSachSV;
        private Button button3;
    }
}