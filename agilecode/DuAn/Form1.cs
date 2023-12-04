using System.Text.RegularExpressions;

namespace DuAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangKy2 dk = new DangKy2();
            dk.ShowDialog();

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMK quenMK = new QuenMK();
            quenMK.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else txtpassword.PasswordChar = '*';
        }
        public bool CheckCount(string message) // check m?t kh?u và tài kho?n
        {
            return Regex.IsMatch(message, @"^[A-Za-z0-9]{8,24}$");
        }

        private void đăngNhậpGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string username = txtname.Text; string password = txtpassword.Text;
            account account = Service.CheckLogin(username, password);
            if (username.Length > 8 && password.ToLower() != password && account != null)
            {
                MessageBox.Show("Đăng nhập thành công", "thông báo", MessageBoxButtons.OK);
                Menu menu = new Menu();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void đăngNhậpSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string username = txtname.Text; string password = txtpassword.Text;
            accountSV accounts = serviceSV.CheckLogin(username, password);
            if (username.Length > 8 && password.ToLower() != password && accounts != null)
            {
                MessageBox.Show("Đăng nhập thành công", "thông báo", MessageBoxButtons.OK);
                MenuSV menu = new MenuSV();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}