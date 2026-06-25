abstract class SanPham
{
    public string TenSanPham { get; set; }
    public string MaSanPham { get; set; }

    public double GiaGoc { get; set; }

    public abstract double TinhGiaBan();

    public SanPham(string tenSp, string maSp, double giaGoc)
    {
        TenSanPham = tenSp;
        MaSanPham = maSp;
        GiaGoc = giaGoc;
    }
    public virtual void HienThiThongTin()
    {
        Console.WriteLine($"Sản phẩm: {TenSanPham}");
        Console.WriteLine($"Mã sản phảm: {MaSanPham}");
        Console.WriteLine($"Giá gốc: {GiaGoc}");
    }

}

class DienTu : SanPham
{

    public double Thue { get; set; }
    public DienTu(string tenSp, string maSp, double giaGoc, double thue) : base(tenSp, maSp, giaGoc)
    {
        Thue = thue;
    }


    public override double TinhGiaBan()
    {
        return GiaGoc * (1 + Thue);
    }
    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Thuế: {Thue:P1}");
        Console.WriteLine($"Giá sau thuế {TinhGiaBan():N2}");
    }
}
class ThucPham : SanPham
{
    public int QuangDuongVanChuyen { get; set; }
    public ThucPham(string tenSp, string maSp, double giaGoc, int quangDuongVanChuyen) : base(tenSp, maSp, giaGoc)
    {
        QuangDuongVanChuyen = quangDuongVanChuyen;
    }

    public override double TinhGiaBan()
    {
        int PhiVanChuyen;

        switch (QuangDuongVanChuyen)
        {
            case int a when a > 0 && a <= 10:
                PhiVanChuyen = 10000;
                break;
            case int a when a > 10 && a <= 20:
                PhiVanChuyen = 15000;
                break;
            case int a when a > 20:
                PhiVanChuyen = 20000;
                break;
            default:
                PhiVanChuyen = 0;
                break;
        }
        return GiaGoc + PhiVanChuyen;
    }
    public override void HienThiThongTin()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        base.HienThiThongTin();
        System.Console.WriteLine($"Phí vận chuyển {QuangDuongVanChuyen}");
        System.Console.WriteLine($"Giá cuối: {TinhGiaBan():N0}");
        Console.ResetColor();
    }
}
//Thoi trang áp dụng giảm giá theo mùa
//mùa đông và mùa xuân cầu nhiều cung ít -> giảm giá 10%, mùa hè && mùa thu , cầu ít cung nhiều -> giảm giá 50% 
class ThoiTrang : SanPham
{
    public int Mua { get; set; }

    public ThoiTrang(string tenSp, string maSp, double giaGoc, int mua) : base(tenSp, maSp, giaGoc)
    {
        Mua = mua;
    }

    public override double TinhGiaBan()
    {
        // System.Console.WriteLine(@"Nhập vào số mùa bạn muốn
        // 1. Mùa xuân
        // 2. Mùa hạ
        // 3. Mùa thu
        // 4. Mùa đông");
        switch (Mua)
        {
            case 1:
            case 4:
                Console.WriteLine("Mã giảm giá: 10%");
                return GiaGoc * 0.9;

            case 2:
            case 3:
                Console.WriteLine("Mã giảm giá: 50%");
                return GiaGoc * 0.5;

            default:
                return GiaGoc;
        }
    }
    public override void HienThiThongTin()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        base.HienThiThongTin();
        System.Console.WriteLine($"Giá cuối: {TinhGiaBan():N0}");
        Console.ResetColor();
    }
}










