using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn
{
    public partial class DangKy2 : Form
    {
        public DangKy2()
        {
            InitializeComponent();
        }

        private bool emailcheck(string email)
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@gmail\.com$";
            Regex rg = new Regex(pattern);
            return rg.IsMatch(email);
        }
        private bool phonenumbervali(string phonenumber)
        {
            string patten = @"^0\d{9}$";
            Regex rg = new Regex(patten);
            return rg.IsMatch(phonenumber);
        }
        private void btndangky_Click(object sender, EventArgs e)
        {
          
            bool check = true; // tạo 1 biến check để validate dữ liệu
            if (string.IsNullOrEmpty(txthotengv.Text))
            {
                check = false;
                MessageBox.Show("không được để trống tên nhân viên", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtemail.Text))
            {
                check = false;
                MessageBox.Show("không được để trống email", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!emailcheck(txtemail.Text))
            {
                check = false;
                MessageBox.Show("Email không đúng định dạng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtphone.Text))
            {
                check = false;
                MessageBox.Show("không được để trống số điện thoại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!phonenumbervali(txtphone.Text))
            {
                check = false;
                MessageBox.Show("Số điện thoại không hợp lệ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txttaikhoan.Text))
            {
                check = false;
                MessageBox.Show("không được để trống tài khoản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtmatkhau.Text))
            {
                check = false;
                MessageBox.Show("không được để trống mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtxacnhanmk.Text))
            {
                check = false;
                MessageBox.Show("Vui lòng xác nhận mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtmatkhau.Text != txtxacnhanmk.Text)
            {
                check = false;
                MessageBox.Show("Xác nhận mật khẩu phải trùng với mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (check)
            {
                DialogResult result = MessageBox.Show("Do you want to save ?", "", MessageBoxButtons.YesNoCancel);
                if (check && result == DialogResult.Yes)
                {
                    string name = txthotengv.Text;
                    string address = txtemail.Text;
                    string username = txttaikhoan.Text;
                    string password = txtmatkhau.Text;
                    string phone = txtphone.Text;
                    string xnmk = txtxacnhanmk.Text;

                    account ac = new account(name, address, phone, username, password, xnmk);
                    string accountFile = ac.CreateAccount();
                    File.AppendAllText("account.txt", accountFile);

                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                        { c.Text = ""; }
                    }
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
            }
        }
        //
        //
        //
        private void btndangkysv_Click(object sender, EventArgs e)
        {
            
            bool checkk = true; // tạo 1 biến check để validate dữ liệu
            if (string.IsNullOrEmpty(txthotensV.Text))
            {
                checkk = false;
                MessageBox.Show("không được để trống tên nhân viên", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtemailsV.Text))
            {
                checkk = false;
                MessageBox.Show("không được để trống email", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!emailcheck(txtemailsV.Text))
            {
                checkk = false;
                MessageBox.Show("Email không đúng định dạng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!phonenumbervali(txtphoneE.Text))
            {
                checkk = false;
                MessageBox.Show("Số điện thoại không hợp lệ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtphoneE.Text))
            {
                checkk = false;
                MessageBox.Show("không được để trống số điện thoại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txttaikhoansV.Text))
            {
                checkk = false;
                MessageBox.Show("không được để trống tài khoản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtmatkausV.Text))
            {
                checkk = false;
                MessageBox.Show("không được để trống mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtxacnhanmksV.Text))
            {
                checkk = false;
                MessageBox.Show("Vui lòng xác nhận mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtmatkausV.Text != txtxacnhanmksV.Text)
            {
                checkk = false;
                MessageBox.Show("Xác nhận mật khẩu phải trùng với mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (checkk)
            {
                DialogResult result = MessageBox.Show("Do you want to save ?", "", MessageBoxButtons.YesNoCancel);
                if (checkk && result == DialogResult.Yes)
                {
                    string name = txthotensV.Text;
                    string address = txtemailsV.Text;
                    string phonee = txtphoneE.Text;
                    string username = txttaikhoansV.Text;
                    string password = txtmatkausV.Text;
                    string xnmk = txtxacnhanmksV.Text;

                    accountSV ac = new accountSV(name, address, phonee, username, password, xnmk);
                    string accountFile = ac.CreateAccount();

                    // Thay đổi path để bao gồm tên tập tin hoặc thay đổi tên tập tin trong File.AppendAllText
                    File.AppendAllText("danhchosv.txt", accountFile);

                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }

                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
            }
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

