namespace DuAn
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            btnDangnhap = new Button();
            okcontextMenuStrip1 = new ContextMenuStrip(components);
            đăngNhậpGVToolStripMenuItem = new ToolStripMenuItem();
            đăngNhậpSVToolStripMenuItem = new ToolStripMenuItem();
            txtpassword = new TextBox();
            txtname = new TextBox();
            lbpassword = new Label();
            lbname = new Label();
            okcontextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(404, 262);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(103, 54);
            button1.TabIndex = 29;
            button1.Text = "Đăng Ký";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(404, 201);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(111, 20);
            linkLabel1.TabIndex = 28;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên Mật Khẩu";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(220, 199);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 24);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "Hiện mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = SystemColors.ControlLight;
            btnDangnhap.ContextMenuStrip = okcontextMenuStrip1;
            btnDangnhap.Location = new Point(220, 262);
            btnDangnhap.Margin = new Padding(3, 2, 3, 2);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(105, 54);
            btnDangnhap.TabIndex = 26;
            btnDangnhap.Text = "Đăng Nhập";
            btnDangnhap.UseVisualStyleBackColor = false;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // okcontextMenuStrip1
            // 
            okcontextMenuStrip1.ImageScalingSize = new Size(20, 20);
            okcontextMenuStrip1.Items.AddRange(new ToolStripItem[] { đăngNhậpGVToolStripMenuItem, đăngNhậpSVToolStripMenuItem });
            okcontextMenuStrip1.Name = "contextMenuStrip1";
            okcontextMenuStrip1.Size = new Size(211, 80);
            okcontextMenuStrip1.Click += btnDangnhap_Click;
            // 
            // đăngNhậpGVToolStripMenuItem
            // 
            đăngNhậpGVToolStripMenuItem.Name = "đăngNhậpGVToolStripMenuItem";
            đăngNhậpGVToolStripMenuItem.Size = new Size(210, 24);
            đăngNhậpGVToolStripMenuItem.Text = "Đăng Nhập GV";
            đăngNhậpGVToolStripMenuItem.Click += đăngNhậpGVToolStripMenuItem_Click;
            // 
            // đăngNhậpSVToolStripMenuItem
            // 
            đăngNhậpSVToolStripMenuItem.Name = "đăngNhậpSVToolStripMenuItem";
            đăngNhậpSVToolStripMenuItem.Size = new Size(210, 24);
            đăngNhậpSVToolStripMenuItem.Text = "Đăng nhập SV";
            đăngNhậpSVToolStripMenuItem.Click += đăngNhậpSVToolStripMenuItem_Click;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.Location = new Point(220, 125);
            txtpassword.Margin = new Padding(3, 2, 3, 2);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(329, 31);
            txtpassword.TabIndex = 24;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtname.Location = new Point(220, 45);
            txtname.Margin = new Padding(3, 2, 3, 2);
            txtname.Name = "txtname";
            txtname.Size = new Size(329, 31);
            txtname.TabIndex = 25;
            // 
            // lbpassword
            // 
            lbpassword.AutoSize = true;
            lbpassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbpassword.Location = new Point(93, 126);
            lbpassword.Name = "lbpassword";
            lbpassword.Size = new Size(97, 28);
            lbpassword.TabIndex = 22;
            lbpassword.Text = "Password";
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbname.Location = new Point(93, 46);
            lbname.Name = "lbname";
            lbname.Size = new Size(107, 28);
            lbname.TabIndex = 23;
            lbname.Text = "UserName";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(btnDangnhap);
            Controls.Add(txtpassword);
            Controls.Add(txtname);
            Controls.Add(lbpassword);
            Controls.Add(lbname);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            okcontextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private Button btnDangnhap;
        private TextBox txtpassword;
        private TextBox txtname;
        private Label lbpassword;
        private Label lbname;
        private ContextMenuStrip okcontextMenuStrip1;
        private ToolStripMenuItem đăngNhậpGVToolStripMenuItem;
        private ToolStripMenuItem đăngNhậpSVToolStripMenuItem;
    }
}