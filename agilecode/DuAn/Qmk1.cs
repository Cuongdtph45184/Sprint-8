using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn
{
    public partial class Qmk1 : Form
    {
        public Qmk1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mail = mail1.Text;
            string passmew1 = txtmkmoi1.Text; string passnew2 = txtmkmoi2.Text;
            string filePath = "D:\\FPT polytechnic\\Quản lí dự án với agile\\DuAn (1)\\DuAn\\bin\\Debug\\net6.0-windows\\account.txt";
            int columindex = 1;
            string newcolum = passmew1;
            string emailToChange = mail;
            string[] lines = File.ReadAllLines(filePath);
            account account = Service.CheckMail(mail);
            if (account != null && passmew1.ToLower() != passmew1 && passmew1 == passnew2)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] columns = lines[i].Split('|');
                    if (columindex >= 0 && columindex < columns.Length && columns[1].Trim() == emailToChange)
                    {
                        columns[4] = newcolum;
                        columns[5] = newcolum;
                    }
                    lines[i] = string.Join("|", columns);
                }
                File.WriteAllLines(filePath, lines);


                MessageBox.Show("Đổi thành công", "thông báo", MessageBoxButtons.OK);
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            else MessageBox.Show("Xác nhận mật khẩu phải giống mật khẩu cũ và phải có 1 chữ in hoa");
        }
    }
}
