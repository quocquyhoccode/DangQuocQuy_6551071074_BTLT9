using FormChiTieu.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace FormChiTieu
{
    public partial class FormChiTieu : Form
    {
        private int? _selectedMaCT = null;
        private readonly string[] _loaiChiList = new[]
        {
            "Ăn uống",
            "Di chuyển",
            "Đi lại",
            "Học tập",
            "Giải trí",
            "Mua sắm",
            "Cá nhân",
            "Hóa đơn",
            "Khác"
        };

        public FormChiTieu()
        {
            InitializeComponent();
        }

        private void FormChiTieu_Load(object sender, EventArgs e)
        {
            InitControls();
            LoadData();
        }

        private void InitControls()
        {
            // Tắt tự động sinh cột để không sinh ra các cột thuộc tính thừa
            dgvChiTieu.AutoGenerateColumns = false;

            // Nạp danh sách Loại chi vào ComboBox nhập liệu
            cboLoaiChi.Items.Clear();
            foreach (var item in _loaiChiList)
            {
                cboLoaiChi.Items.Add(item);
            }
            cboLoaiChi.SelectedIndex = 0;

            // Nạp danh sách Loại chi vào ComboBox tìm kiếm (thêm tùy chọn "Tất cả")
            cboTimLoaiChi.Items.Clear();
            cboTimLoaiChi.Items.Add("Tất cả");
            foreach (var item in _loaiChiList)
            {
                cboTimLoaiChi.Items.Add(item);
            }
            cboTimLoaiChi.SelectedIndex = 0;

            // Thiết lập giá trị mặc định cho DateTimePickers
            dtpNgayChi.Value = DateTime.Today;
            dtpTuNgay.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpDenNgay.Value = DateTime.Today;

            nudSoTien.Value = 0;
            txtNoiDung.Clear();
            txtGhiChu.Clear();
            txtTimNoiDung.Clear();
            _selectedMaCT = null;
        }

        private void LoadData(string? filterNoiDung = null, string? filterLoaiChi = null, DateOnly? tuNgay = null, DateOnly? denNgay = null)
        {
            try
            {
                using var db = QL_ChiTieuContext.CreateContext();
                
                IQueryable<ChiTieu> query = db.ChiTieus.AsNoTracking();

                // Lọc theo nội dung
                if (!string.IsNullOrWhiteSpace(filterNoiDung))
                {
                    var keyword = filterNoiDung.Trim();
                    query = query.Where(ct => EF.Functions.Like(ct.NoiDung, $"%{keyword}%"));
                }

                // Lọc theo loại chi
                if (!string.IsNullOrWhiteSpace(filterLoaiChi) && !filterLoaiChi.Equals("Tất cả", StringComparison.OrdinalIgnoreCase))
                {
                    query = query.Where(ct => ct.LoaiChi == filterLoaiChi);
                }

                // Lọc theo khoảng thời gian
                if (tuNgay.HasValue)
                {
                    query = query.Where(ct => ct.NgayChi >= tuNgay.Value);
                }
                if (denNgay.HasValue)
                {
                    query = query.Where(ct => ct.NgayChi <= denNgay.Value);
                }

                var list = query
                    .OrderByDescending(ct => ct.NgayChi)
                    .ThenByDescending(ct => ct.MaCt)
                    .ToList();

                var viewModels = list.Select(ct => new ChiTieuViewModel
                {
                    MaCt = ct.MaCt,
                    NgayChi = ct.NgayChi,
                    NoiDung = ct.NoiDung,
                    LoaiChi = ct.LoaiChi,
                    SoTien = ct.SoTien,
                    GhiChu = ct.GhiChu
                }).ToList();

                dgvChiTieu.DataSource = viewModels;

                // Tính tổng chi và cập nhật lên Label
                decimal tongChi = viewModels.Sum(x => x.SoTien);
                lblTongChi.Text = $"Tổng chi: {tongChi:N0} đ";
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi tải danh sách chi tiêu từ CSDL: {Message}", ex.Message);
                MessageBox.Show(
                    $"Không thể tải dữ liệu từ cơ sở dữ liệu!\nChi tiết: {ex.Message}\n\nVui lòng kiểm tra chuỗi kết nối trong appsettings.json và đảm bảo SQL Server đang hoạt động.",
                    "Lỗi kết nối CSDL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private bool ValidateInput()
        {
            // Kiểm tra nội dung không rỗng
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung chi tiêu!", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiDung.Focus();
                return false;
            }

            // Kiểm tra số tiền > 0
            if (nudSoTien.Value <= 0)
            {
                MessageBox.Show("Số tiền chi tiêu phải lớn hơn 0 đ!", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudSoTien.Focus();
                return false;
            }

            // Kiểm tra ngày chi không lớn hơn hôm nay
            if (dtpNgayChi.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Ngày chi không được lớn hơn ngày hiện tại!", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayChi.Focus();
                return false;
            }

            // Kiểm tra loại chi được chọn
            if (cboLoaiChi.SelectedItem == null && string.IsNullOrWhiteSpace(cboLoaiChi.Text))
            {
                MessageBox.Show("Vui lòng chọn loại chi!", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiChi.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                using var db = QL_ChiTieuContext.CreateContext();

                var chiTieu = new ChiTieu
                {
                    NgayChi = DateOnly.FromDateTime(dtpNgayChi.Value.Date),
                    NoiDung = txtNoiDung.Text.Trim(),
                    LoaiChi = cboLoaiChi.SelectedItem?.ToString() ?? cboLoaiChi.Text.Trim(),
                    SoTien = nudSoTien.Value,
                    GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim()
                };

                db.ChiTieus.Add(chiTieu);
                db.SaveChanges();

                Log.Information(
                    "Thêm khoản chi thành công: MaCT={MaCT}, NgayChi={NgayChi:yyyy-MM-dd}, NoiDung='{NoiDung}', LoaiChi='{LoaiChi}', SoTien={SoTien:N0} đ",
                    chiTieu.MaCt, chiTieu.NgayChi.ToDateTime(TimeOnly.MinValue), chiTieu.NoiDung, chiTieu.LoaiChi, chiTieu.SoTien
                );

                MessageBox.Show("Thêm khoản chi mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetInputFields();
                ApplyFilter();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi thêm khoản chi: {Message}", ex.Message);
                MessageBox.Show($"Lỗi khi thêm khoản chi: {ex.Message}", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!_selectedMaCT.HasValue)
            {
                MessageBox.Show("Vui lòng chọn một dòng chi tiêu trong danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            try
            {
                using var db = QL_ChiTieuContext.CreateContext();
                var chiTieu = db.ChiTieus.FirstOrDefault(ct => ct.MaCt == _selectedMaCT.Value);

                if (chiTieu == null)
                {
                    MessageBox.Show("Không tìm thấy khoản chi cần sửa trong CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                chiTieu.NgayChi = DateOnly.FromDateTime(dtpNgayChi.Value.Date);
                chiTieu.NoiDung = txtNoiDung.Text.Trim();
                chiTieu.LoaiChi = cboLoaiChi.SelectedItem?.ToString() ?? cboLoaiChi.Text.Trim();
                chiTieu.SoTien = nudSoTien.Value;
                chiTieu.GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim();

                db.SaveChanges();

                Log.Information(
                    "Cập nhật khoản chi thành công: MaCT={MaCT}, NgayChi={NgayChi:yyyy-MM-dd}, NoiDung='{NoiDung}', LoaiChi='{LoaiChi}', SoTien={SoTien:N0} đ",
                    chiTieu.MaCt, chiTieu.NgayChi.ToDateTime(TimeOnly.MinValue), chiTieu.NoiDung, chiTieu.LoaiChi, chiTieu.SoTien
                );

                MessageBox.Show($"Cập nhật khoản chi [Mã: {chiTieu.MaCt:D3}] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetInputFields();
                ApplyFilter();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi sửa khoản chi MaCT={MaCT}: {Message}", _selectedMaCT.Value, ex.Message);
                MessageBox.Show($"Lỗi khi sửa khoản chi: {ex.Message}", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!_selectedMaCT.HasValue)
            {
                MessageBox.Show("Vui lòng chọn một dòng chi tiêu trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa khoản chi [Mã: {_selectedMaCT.Value:D3}] - \"{txtNoiDung.Text}\" không?",
                "Xác nhận xóa khoản chi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes) return;

            try
            {
                using var db = QL_ChiTieuContext.CreateContext();
                var chiTieu = db.ChiTieus.FirstOrDefault(ct => ct.MaCt == _selectedMaCT.Value);

                if (chiTieu != null)
                {
                    db.ChiTieus.Remove(chiTieu);
                    db.SaveChanges();

                    Log.Information("Xóa khoản chi thành công: MaCT={MaCT}, NoiDung='{NoiDung}', SoTien={SoTien:N0} đ", _selectedMaCT.Value, chiTieu.NoiDung, chiTieu.SoTien);
                    MessageBox.Show($"Đã xóa khoản chi [Mã: {_selectedMaCT.Value:D3}] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Khoản chi không còn tồn tại trong CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ResetInputFields();
                ApplyFilter();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi xóa khoản chi MaCT={MaCT}: {Message}", _selectedMaCT.Value, ex.Message);
                MessageBox.Show($"Lỗi khi xóa khoản chi: {ex.Message}", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetInputFields();

            // Đặt lại các điều kiện tìm kiếm
            txtTimNoiDung.Clear();
            cboTimLoaiChi.SelectedIndex = 0; // "Tất cả"
            dtpTuNgay.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpDenNgay.Value = DateTime.Today;

            // Nạp lại toàn bộ dữ liệu
            LoadData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Khoảng ngày lọc không hợp lệ: 'Từ ngày' phải nhỏ hơn hoặc bằng 'Đến ngày'!", "Lỗi bộ lọc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string? noiDung = string.IsNullOrWhiteSpace(txtTimNoiDung.Text) ? null : txtTimNoiDung.Text.Trim();
            string? loaiChi = cboTimLoaiChi.SelectedItem?.ToString();
            DateOnly tuNgay = DateOnly.FromDateTime(dtpTuNgay.Value.Date);
            DateOnly denNgay = DateOnly.FromDateTime(dtpDenNgay.Value.Date);

            LoadData(noiDung, loaiChi, tuNgay, denNgay);
        }

        private void dgvChiTieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvChiTieu.Rows.Count) return;

            var row = dgvChiTieu.Rows[e.RowIndex];
            if (row.DataBoundItem is ChiTieuViewModel vm)
            {
                _selectedMaCT = vm.MaCt;
                dtpNgayChi.Value = vm.NgayChi.ToDateTime(TimeOnly.MinValue);
                txtNoiDung.Text = vm.NoiDung;

                // Chọn đúng mục Loại chi
                if (cboLoaiChi.Items.Contains(vm.LoaiChi))
                {
                    cboLoaiChi.SelectedItem = vm.LoaiChi;
                }
                else
                {
                    cboLoaiChi.Text = vm.LoaiChi;
                }

                nudSoTien.Value = vm.SoTien;
                txtGhiChu.Text = vm.GhiChu ?? string.Empty;
            }
        }

        private void ResetInputFields()
        {
            _selectedMaCT = null;
            dtpNgayChi.Value = DateTime.Today;
            txtNoiDung.Clear();
            nudSoTien.Value = 0;
            txtGhiChu.Clear();
            if (cboLoaiChi.Items.Count > 0)
            {
                cboLoaiChi.SelectedIndex = 0;
            }
            dgvChiTieu.ClearSelection();
        }

        private void btnMoLogs_Click(object sender, EventArgs e)
        {
            try
            {
                var logsDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
                if (!System.IO.Directory.Exists(logsDirectory))
                {
                    System.IO.Directory.CreateDirectory(logsDirectory);
                }
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = logsDirectory,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể mở thư mục Logs: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
