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
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            account account = Service.CheckMail(mail);
            if (account != null && mail != "")
            {
                MessageBox.Show("Nhấn Ok dể đổi mật khẩu", "thông báo", MessageBoxButtons.OK);
                Qmk1 qmk1 = new Qmk1();
                qmk1.ShowDialog();
            }
            else MessageBox.Show("Email không tồn tại");
        }
    }
}
