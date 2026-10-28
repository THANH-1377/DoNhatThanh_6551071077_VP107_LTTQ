using DoNhatThanh_6551071077_VP107_LTTQ.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Text;
using System.Reflection.Metadata.Ecma335;

namespace DoNhatThanh_6551071077_VP107_LTTQ
{
    public partial class frmMonHoc : Form
    {
        private readonly DuLieuContext _context;
        public frmMonHoc()
        {
            InitializeComponent();
            _context = new DuLieuContext();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                dgvDS.DataSource = await _context.MonHoc.Select(ds => new
                {
                    ds.MaMonHoc,
                    ds.TenMonHoc,
                    ds.SoTinChi
                }).ToListAsync();

                dgvDS.ClearSelection();
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}");
                }
            }
        }

        private async void frmMonHoc_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void txtSoTinChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* if (!int.TryParse(txtSoTinChi.Text, out int stc))
             {
                 MessageBox.Show("Số tín chỉ phải là số thực hoặc số nguyên");
                 txtSoTinChi.Focus();
                 return;
             }*/
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                $"Bạn có chắc muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes) return;
            else
            {
                Application.Exit();
            }
        }

        private bool KiemTraDuLieu()
        {
            {
                if (string.IsNullOrWhiteSpace(txtMaMonHoc.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã môn học!");
                    txtMaMonHoc.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtTenMonHoc.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên môn học!");
                    txtMaMonHoc.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtSoTinChi.Text))
                {
                    MessageBox.Show("Vui lòng nhập số tín chỉ!");
                    txtMaMonHoc.Focus();
                    return false;
                }

                return true;
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;

            try
            {
                string ma = txtMaMonHoc.Text.Trim();
                string ten = txtTenMonHoc.Text.Trim();
                string stc = txtSoTinChi.Text.Trim();

                bool daTonTai = await _context.MonHoc.AnyAsync(ds => ds.MaMonHoc == ma);

                if (daTonTai)
                {
                    MessageBox.Show(
                        "Mã môn học đã tồn tại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtMaMonHoc.Focus();
                    return;
                }
                var mh = new MonHoc
                {
                    MaMonHoc = ma,
                    TenMonHoc = ten,
                    SoTinChi = stc
                };

                _context.MonHoc.Add(mh);
                await _context.SaveChangesAsync();
                MessageBox.Show("Thêm môn học thành công!");

                await LoadDataAsync();
                LamMoi();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(
                    "Không thể lưu dữ liệu. Hãy kiểm tra khóa ngoại, " +
                    "ràng buộc database và các trường bắt buộc.\n" +
                    ex.GetBaseException().Message,
                    "Lỗi database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void LamTrongCacTruong()
        {
            txtMaMonHoc.Clear();
            txtTenMonHoc.Clear();
            txtSoTinChi.Clear();
        }

        private void LamMoi()
        {
            LamTrongCacTruong();
            dgvDS.ClearSelection();
            dgvDS.CurrentCell = null;

            txtMaMonHoc.Focus();
        }

        private void dgvDS_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDS.CurrentRow == null ||
                dgvDS.CurrentRow.IsNewRow) return;

            var row = dgvDS.CurrentRow;

            txtMaMonHoc.Text = row.Cells["MaMonHoc"].Value?.ToString() ?? "";
            txtTenMonHoc.Text = row.Cells["TenMonHoc"].Value?.ToString() ?? "";
            txtSoTinChi.Text = row.Cells["SoTinChi"].Value?.ToString() ?? "";

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDS.CurrentRow == null ||
                dgvDS.CurrentRow.Cells["MaMonHoc"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa!");
                return;
            }

            string ma = dgvDS.CurrentRow.Cells["MaMonHoc"].Value.ToString()!;
            string ten = dgvDS.CurrentRow.Cells["TenMonHoc"].Value.ToString()!;
            string stc = dgvDS.CurrentRow.Cells["SoTinChi"].Value.ToString()!;

            DialogResult ketQua = MessageBox.Show(
                $"Bạn có chắc muốn xóa môn học {ma} - {ten} không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes) return;

            try
            {
                var ds = await _context.MonHoc.FirstOrDefaultAsync(x => x.MaMonHoc == ma);

                if (ds == null)
                {
                    MessageBox.Show("Môn học không còn tồn tại!");
                    await LoadDataAsync();
                    return;
                }

                _context.MonHoc.Remove(ds);
                await _context.SaveChangesAsync();

                MessageBox.Show("Xóa môn học thành công!");

                await LoadDataAsync();
                LamMoi();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Không thể xóa môn học. Có thể môn học đang " +
                    "được tham chiếu bởi dữ liệu khác.\n" +
                    ex.GetBaseException().Message,
                    "Lỗi database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa môn học: " + ex.Message);
            }

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            /*if (dgvDS.CurrentRow == null ||
                dgvDS.CurrentRow.Cells["MaMonHoc"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn môn học cần sửa!");
                return;
            }

            maMonHocDangSua = dgvDS.CurrentRow.Cells["MaMonHoc"].Value.ToString();

            txtMaMonHoc.ReadOnly = true;

            txtTenMonHoc.Focus();*/
        }
    }
}
