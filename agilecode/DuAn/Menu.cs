using DuAn.Models;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check = true;
            string text = tb_ch.Text;
            string cbo = comboBox1.Text;
            string filepath = "D:\\FPT polytechnic\\Quản lí dự án với agile\\DuAn (1)\\DuAn\\hotro.txt";
            if (text == "")
            {
                check = false;
                MessageBox.Show("Hãy điền hỗ trợ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Close();
        }
        QLDiemSVContext db = new QLDiemSVContext();
        private void Menu_Load(object sender, EventArgs e)
        {
            LoadData();
            loadMonHoc();
        }
        public void LoadData()
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
        public void loadMonHoc()
        {
            cboMonHoc.DataSource = db.MonHocs.ToList();
            cboMonHoc.DisplayMember = "TenMh";
            cboMonHoc.ValueMember = "MaMh";
        }
        private void dgvDanhSachSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaSv.Text = dgvDanhSachSV.Rows[d].Cells[0].Value.ToString();
            txtTenSv.Text = dgvDanhSachSV.Rows[d].Cells[1].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dgvDanhSachSV.Rows[d].Cells[2].Value.ToString());
            if (dgvDanhSachSV.Rows[d].Cells[3].Value.ToString().Equals("Nam"))
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;
            txtEmail.Text = dgvDanhSachSV.Rows[d].Cells[4].Value.ToString();
            txtLop.Text = dgvDanhSachSV.Rows[d].Cells[5].Value.ToString();
            cboMonHoc.Text = dgvDanhSachSV.Rows[d].Cells[6].Value.ToString();
            txtDiemTiengAnh.Text = dgvDanhSachSV.Rows[d].Cells[7].Value.ToString();
            txtDiemDuAn.Text = dgvDanhSachSV.Rows[d].Cells[8].Value.ToString();
            txtDiemIT.Text = dgvDanhSachSV.Rows[d].Cells[9].Value.ToString();
            txtDiemTB.Text = dgvDanhSachSV.Rows[d].Cells[10].Value.ToString();
        }

        //private bool chechnhapdiem(string message)
        //{
        //   if(float.TryParse(message, out float result))
        //   {
        //     return result >= 0 && result <= 10;
        //   }
        //   return false;
        //} 

        public bool chech(string mess)
        {
            return Regex.IsMatch(mess, @"^(10|[0-9])$");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSv.Text))
            {
                MessageBox.Show("không được để trống mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtTenSv.Text))
            {
                MessageBox.Show("không được để trống tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpNgaySinh.Value.Year >= 2005)
            {
                MessageBox.Show("Sinh viên phải >= 2005", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(rdoGioi.Text))
            {
                MessageBox.Show("Không được để trống giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Không được để trống email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtLop.Text))
            {
                MessageBox.Show("Không được để trống lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(cboMonHoc.Text))
            {
                MessageBox.Show("Hãy chọn môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SinhVien nvThem = db.SinhViens.SingleOrDefault(nv => nv.MaSv == txtMaSv.Text);

            if (nvThem != null)
            {
                MessageBox.Show("Mã Sinh viên đã tồn rại ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string gt = "";
                if (rdoNam.Checked == true)
                {
                    gt = "Nam";
                }
                else
                {
                    gt = "Nữ";
                }
                if (!chech(txtDiemIT.Text) || !chech(txtDiemTiengAnh.Text) || !chech(txtDiemDuAn.Text))
                {
                    MessageBox.Show("Điểm nhập không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SinhVien sv = new SinhVien()
                {
                    MaSv = txtMaSv.Text,
                    HoTen = txtTenSv.Text,
                    NgaySinh = DateTime.ParseExact(dtpNgaySinh.Text.Trim(), "dd-MM-yyyy", null),
                    GioiTinh = gt,
                    Email = txtEmail.Text,
                    Lop = txtLop.Text,
                    MaMh = cboMonHoc.SelectedValue.ToString(),
                    DiemTa = float.Parse(txtDiemIT.Text),
                    DiemDuAn = float.Parse(txtDiemTiengAnh.Text),
                    DiemIt = float.Parse(txtDiemDuAn.Text),
                    DiemTb = float.Parse(txtDiemTB.Text)
                };

                db.SinhViens.Add(sv);
                db.SaveChanges();

                LoadData();
            }
        }

        private void txtDiemTB_TextChanged(object sender, EventArgs e)
        {
        }
        void TinhTB()
        {
            if (txtDiemDuAn.Text != "" && txtDiemIT.Text != "" && txtDiemTiengAnh.Text != "")
            {
                double ta = Convert.ToDouble(txtDiemTiengAnh.Text);
                double da = Convert.ToDouble(txtDiemDuAn.Text);
                double it = Convert.ToDouble(txtDiemIT.Text);
                txtDiemTB.Text = (ta + da + it) / 3 + "";
            }
        }
        private void txtDiemIT_TextChanged(object sender, EventArgs e)
        {
            TinhTB();

        }

        private void txtDiemTiengAnh_TextChanged(object sender, EventArgs e)
        {
            TinhTB();

        }

        private void txtDiemDuAn_TextChanged(object sender, EventArgs e)
        {
            TinhTB();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSv.Text))
            {
                MessageBox.Show("không được để trống mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtTenSv.Text))
            {
                MessageBox.Show("không được để trống tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpNgaySinh.Value.Year >= 2005)
            {
                MessageBox.Show("Sinh viên phải >= 2005", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(rdoGioi.Text))
            {
                MessageBox.Show("Không được để trống giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Không được để trống email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtLop.Text))
            {
                MessageBox.Show("Không được để trống lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(cboMonHoc.Text))
            {
                MessageBox.Show("Hãy chọn môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SinhVien sua = db.SinhViens.Find(txtMaSv.Text);

            if (!chech(txtDiemIT.Text) || !chech(txtDiemTiengAnh.Text) || !chech(txtDiemDuAn.Text))
            {
                MessageBox.Show("Điểm nhập không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sua != null)
            {
                sua.DiemTa = float.Parse(txtDiemTiengAnh.Text);
                sua.DiemDuAn = float.Parse(txtDiemDuAn.Text);
                sua.DiemIt = float.Parse(txtDiemIT.Text);
                sua.DiemTb = float.Parse(txtDiemTB.Text);

                db.SaveChanges();
                LoadData();
            }
            else
            {
                MessageBox.Show("Mã Sinh viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SinhVien XoaSv = db.SinhViens.Find(txtMaSv.Text);
            if (XoaSv != null)
            {
                var xoa = MessageBox.Show("Bạn có chắc chắn muốn xóa không ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xoa == DialogResult.Yes)
                {
                    db.SinhViens.Remove(XoaSv);
                    db.SaveChanges();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Mã Sinh viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var Thoat = MessageBox.Show("Bạn có chắc chắn muốn thoát không ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Thoat == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tukhoa = txtTimkiem.Text.Trim();

            if (!string.IsNullOrEmpty(tukhoa))
            {
                var timkiem = from sv in db.SinhViens
                              join mh in db.MonHocs on sv.MaMh equals mh.MaMh
                              where sv.HoTen.Contains(tukhoa) || sv.MaSv.Contains(tukhoa)
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
                dgvDanhSachSV.DataSource = timkiem.ToList();
            }
            else
            {
                MessageBox.Show("Mời nhập từ khóa ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMaSv.Text = "";
            txtTenSv.Text = "";
            dtpNgaySinh.ResetText();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            txtEmail.Text = "";
            txtLop.Text = "";
            cboMonHoc.Text = "";
            txtDiemTiengAnh.Text = "";
            txtDiemDuAn.Text = "";
            txtDiemIT.Text = "";
            txtDiemTB.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
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

            if (rdoXuatSac.Checked)
            {
                resurl = resurl.Where(sv => sv.DiemTb >= 9);
                dgvThongKe.DataSource = resurl.ToList();
            }
            else if (rdoGioi.Checked)
            {
                resurl = resurl.Where(sv => sv.DiemTb >= 8 && sv.DiemTb < 9);
                dgvThongKe.DataSource = resurl.ToList();
            }
            else if (rdoKha.Checked)
            {
                resurl = resurl.Where(sv => sv.DiemTb >= 6.5 && sv.DiemTb < 8);
                dgvThongKe.DataSource = resurl.ToList();
            }
            else if (rdoTb.Checked)
            {
                resurl = resurl.Where(sv => sv.DiemTb >= 5 && sv.DiemTb < 6.5);
                dgvThongKe.DataSource = resurl.ToList();
            }
            else if (rdoTruot.Checked)
            {
                resurl = resurl.Where(sv => sv.DiemTb < 5);
                dgvThongKe.DataSource = resurl.ToList();
            }
            else
            {
                MessageBox.Show("Chọn loại bạn muốn thống kê", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            var result = from sv in db.SinhViens
                         join mh in db.MonHocs on sv.MaMh equals mh.MaMh
                         orderby sv.DiemTb descending
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
            dgvThongKe.DataSource = result.ToList();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtMaSv.Text = "";
            txtTenSv.Text = "";
            dtpNgaySinh.ResetText();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            txtEmail.Text = "";
            txtLop.Text = "";
            cboMonHoc.Text = "";
            txtDiemTiengAnh.Text = "";
            txtDiemDuAn.Text = "";
            txtDiemIT.Text = "";
            txtDiemTB.ResetText();
        }
    }
}
