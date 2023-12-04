using DuAn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DuAn
{
    public partial class MenuSV : Form
    {
        public MenuSV()
        {
            InitializeComponent();
        }

        private void MenuSV_Load(object sender, EventArgs e)
        {
            LoadDataSV();
        }
        QLDiemSVContext db = new QLDiemSVContext();

        public void LoadDataSV()
        {
            var resurl = from sv in db.SinhViens
                         join mh in db.MonHocs on sv.MaMh equals mh.MaMh
                         select new
                         {
                             ID = sv.MaSv,
                             sv.HoTen,
                             sv.NgaySinh,
                             sv.GioiTinh,
                             sv.Email,
                             sv.Lop,
                             mh.TenMh,
                             sv.DiemTa,
                             sv.DiemDuAn,
                             sv.DiemIt,
                             sv.DiemTb
                         };

            dgvDanhSachSV.DataSource = resurl.ToList();

            dgvDanhSachSV.Columns[0].HeaderText = "Mã Sv";
            dgvDanhSachSV.Columns[1].HeaderText = "Tên Sv";
            dgvDanhSachSV.Columns[2].HeaderText = "Ngày sinh";
            dgvDanhSachSV.Columns[3].HeaderText = "Giới tính";
            dgvDanhSachSV.Columns[4].HeaderText = "Email";
            dgvDanhSachSV.Columns[5].HeaderText = "Lớp";
            dgvDanhSachSV.Columns[6].HeaderText = "Môn học";
            dgvDanhSachSV.Columns[7].HeaderText = "Diểm TA";
            dgvDanhSachSV.Columns[8].HeaderText = "Điểm DuAN";
            dgvDanhSachSV.Columns[9].HeaderText = "Điểm IT";
            dgvDanhSachSV.Columns[10].HeaderText = "Điểm TB";

            dgvDanhSachSV.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
        }


        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text.Trim();

            if (!string.IsNullOrEmpty(timkiem))
            {
                var result = from sv in db.SinhViens
                             join mh in db.MonHocs on sv.MaMh equals mh.MaMh
                             where sv.MaSv.Contains(timkiem) ||
                                   sv.HoTen.ToLower().Contains(timkiem.ToLower())
                             select new
                             {
                                 ID = sv.MaSv,
                                 sv.HoTen,
                                 sv.NgaySinh,
                                 sv.GioiTinh,
                                 sv.Email,
                                 sv.Lop,
                                 mh.TenMh,
                                 sv.DiemTa,
                                 sv.DiemDuAn,
                                 sv.DiemIt,
                                 sv.DiemTb
                             };

                dgvDanhSachSV.DataSource = result.ToList();
            }
            else
            {
                MessageBox.Show("Mời nhập từ khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            var Thoat = MessageBox.Show("Bạn có chắc chắn muốn thoát không ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Thoat == DialogResult.Yes)
            {
                Close();
            }
        }

        private void tphotro_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check = true;
            string text = txtcauhoi.Text;
            string cbo = cbodanhmuc.Text;
            string filepath = "D:\\FPT polytechnic\\Quản lí dự án với agile\\DuAn (1)\\DuAn\\hotro.txt";
            if (text == "")
            {
                check = false;
                MessageBox.Show("Hãy điền câu hỏi hỗ trợ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbo == "")
            {
                check = false;
                MessageBox.Show("Hãy chọn danh mục", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                check = true;
                File.WriteAllText(filepath, text);
                MessageBox.Show("Đã gửi hỗ trợ");
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    { c.Text = ""; }
                }
                foreach (Control c in this.Controls)
                {
                    if (c is ComboBox)
                    {
                        c.Text = "";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Thoat = MessageBox.Show("Bạn có chắc chắn muốn thoát không ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Thoat == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Btn_hienthi(object sender, EventArgs e)
        {
            LoadDataSV();
            txttimkiem.Text = "";
        }
    }
}
