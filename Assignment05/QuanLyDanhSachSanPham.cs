using System;
using System.Collections.Generic;

class QuanLyDanhSachSanPham
{
    private List<SanPham> ds = new List<SanPham>();

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("\n--- QUẢN LÝ DANH SÁCH SẢN PHẨM ---");
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("3. Tính doanh thu dự kiến");
            Console.WriteLine("4. Xóa sản phẩm theo mã");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn từ 1 đến 5: ");
            var chon = Console.ReadLine();

            switch (chon)
            {
                case "1": ThemSanPham(); break;
                case "2": HienThiDanhSachSanPham(); break;
                case "3": TinhDoanhThuDuKienSanPham(); break;
                case "4": XoaSanPhamTheoMa(); break;
                case "5": return;
                default: Console.WriteLine("Lựa chọn không hợp lệ."); break;
            }
        }
    }

    private void ThemSanPham()
    {
        Console.WriteLine("Chọn loại sản phẩm: 1=DienTu 2=ThucPham 3=ThoiTrang");
        Console.Write("Loại: ");
        var loai = Console.ReadLine();
        Console.Write("Tên sản phẩm: ");
        var ten = Console.ReadLine();
        Console.Write("Mã sản phẩm: ");
        var ma = Console.ReadLine();
        Console.Write("Giá gốc: ");
        if (!double.TryParse(Console.ReadLine(), out double giaGoc)) giaGoc = 0;

        switch (loai)
        {
            case "1":
                Console.Write("Thuế (ví dụ 0.1 = 10%): ");
                if (!double.TryParse(Console.ReadLine(), out double thue)) thue = 0;
                ds.Add(new DienTu(ten, ma, giaGoc, thue));
                break;
            case "2":
                Console.Write("Quãng đường vận chuyển (km): ");
                if (!int.TryParse(Console.ReadLine(), out int qd)) qd = 0;
                ds.Add(new ThucPham(ten, ma, giaGoc, qd));
                break;
            case "3":
                Console.Write("Mùa (1=Xuân,2=Hạ,3=Thu,4=Đông): ");
                if (!int.TryParse(Console.ReadLine(), out int mua)) mua = 1;
                ds.Add(new ThoiTrang(ten, ma, giaGoc, mua));
                break;
            default:
                Console.WriteLine("Loại không hợp lệ.");
                return;
        }
        Console.WriteLine("Đã thêm sản phẩm.");
    }

    private void HienThiDanhSachSanPham()
    {
        if (ds.Count == 0)
        {
            Console.WriteLine("Danh sách rỗng.");
            return;
        }
        Console.WriteLine("\n--- DANH SÁCH SẢN PHẨM ---");
        foreach (var sp in ds)
        {
            sp.HienThiThongTin();
            Console.WriteLine(new string('-', 30));
        }
    }

    private void TinhDoanhThuDuKienSanPham()
    {
        double tong = 0;
        foreach (var sp in ds) tong += sp.TinhGiaBan();
        Console.WriteLine($"Tổng doanh thu dự kiến: {tong:N2}");
    }

    private void XoaSanPhamTheoMa()
    {
        Console.Write("Nhập mã sản phẩm cần xóa: ");
        var ma = Console.ReadLine();
        var sp = ds.Find(p => string.Equals(p.MaSanPham, ma, StringComparison.OrdinalIgnoreCase));
        if (sp == null)
        {
            Console.WriteLine("Không tìm thấy sản phẩm với mã đó.");
            return;
        }
        ds.Remove(sp);
        Console.WriteLine("Đã xóa sản phẩm.");
    }
}