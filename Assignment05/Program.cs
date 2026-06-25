class Program
{
    public static void Main(string[] args)
    {
        // DienTu laptop = new DienTu("Laptop Dell","Precision7560",1000,0.5);
        // laptop.HienThiThongTin();

        // ThucPham banhSanke = new ThucPham("Snake","Snake Bò Nướng Mật Ong",6000,46);
        // banhSanke.HienThiThongTin();

        // ThoiTrang aoLen = new ThoiTrang("Áo Len","AL001",1200,4);
        // aoLen.HienThiThongTin();

        var manager = new QuanLyDanhSachSanPham();
        manager.Run();

    }
}