using System.Runtime;

class Baitap
{
    static List<int> lstNumber = new List<int>() { 20, 81, 97, 63, 72, 11, 20, 15, 33, 41, 20 };
    static List<int> lstBT2 = new() { 2, 7, 1, 8, 4, 5, 6, 10 };
    static List<int> listBT3 = new List<int> { 3, 1, 4, 1, 5, 7, 4, 8, 10 };
    public static void Menu()
    {
        int chon = 0;
        System.Console.WriteLine(@"
        Danh sách các bài tập:
        1. Tính tổng của các số trong một mảng lstNumber = [20,81,97,63,72,11,20,15,33,41,20]
        2. Tìm hai số trong một danh sách số nguyên sao cho tổng của chúng bằng một giá trị target cho trước lstNumber = [2,7,11,15]
        3. Loại bỏ các phần tử trùng lặp từ một mảng đã sắp xếp và trả về chiều dài của mảng mới
        input nums = [1,1,2,2,3,3,4,4,5]
        output: 5 mảng mới là [1,2,3,,4,5]
        4. Cho một mảng số nguyên, tìm k phần tử xuất hiện nhiều lần nhất trong mảng và trả về chúng dưới dạng danh sách. Nếu có nhiều phần tử cùng tần số xuất hiện, trả về bất kỳ trong số chúng. lst = [,1,1,1,2,2,3] out put [1,2]
        5. Bài giá cỏ phiếu 
        ");
        while (true)
        {
            System.Console.WriteLine($"Vui long chon chuc nang: ");
            if (!int.TryParse(Console.ReadLine(), out chon))
            {
                System.Console.WriteLine($"Lua chon khong hop le, vui long nhap lai ");
                continue;
            }
            switch (chon)
            {
                case 1:
                    System.Console.WriteLine($"1. Tính tổng của các số trong một mảng lstNumber ");
                    int tong = TinhTong(lstNumber);
                    System.Console.WriteLine($"Tong cua cac so trong danh sach la: {tong}");
                    break;
                case 2:
                    System.Console.WriteLine($"2. Tìm hai số trong một danh sách số nguyên sao cho tổng của chúng bằng một giá trị target cho trước lstNumber");
                    //Baitap2_C1(lstBT2);
                    Baitap2_C2(lstBT2);
                    break;
                case 3:
                    System.Console.WriteLine("3. Loại bỏ các phần tử trùng lặp từ một mảng đã sắp xếp và trả về chiều dài của mảng mới");
                    Btap3SapXepPhanTu(listBT3);
                    break;
                case 4:
                    System.Console.WriteLine("4. Cho một mảng số nguyên, tìm k phần tử xuất hiện nhiều lần nhất trong mảng và trả về chúng dưới dạng danh sách. Nếu có nhiều phần tử cùng tần số xuất hiện, trả về bất kỳ trong số chúng.");
                    break;
                case 5:
                    System.Console.WriteLine("5. Bài giá cỏ phiếu");
                    break;
                case 6:
                    Console.WriteLine("Thoát chương trình.");
                    return; // kết thúc vòng lặp
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;

            }

        }

    }
    public static int TinhTong(List<int> lst)
    {
        return lst.Sum();
    }

    public static void Baitap2_C1(List<int> lst)
    {
        // do phuc tap n²
        int target = 9;
        for (int i = 0; i < lst.Count; i++)
        {
            for (int j = i + 1; j < lst.Count; j++)
            {
                if (lst[i] + lst[j] == target)
                {
                    System.Console.WriteLine($"index: {i}, {j}");
                    System.Console.WriteLine($"value: {lst[i]} , {lst[j]}");
                }
            }
        }
    }
    public static void Baitap2_C2(List<int> lst)
    {
        int target = 9;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < lst.Count; i++)
        {
            int tuhientai = lst[i];
            int tucantim = target - tuhientai;
            if (dict.ContainsKey(tucantim))
            {
                System.Console.WriteLine($"index: {dict[tucantim]}, {i}");
                System.Console.WriteLine($"value: {tucantim}, {tuhientai}");
                break;
            }
            dict[tuhientai] = i;
        }
    }
    public static void Btap3SapXepPhanTu(List<int> lst)   //độ phức tạp thuật toán O(n²)
    {
        int n = lst.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++) //
            {
                if (lst[j] > lst[j + 1])  //nếu index 0 > index 1
                {
                    int sohientai = lst[j];   //lưu index 0 vô biến tạm
                    lst[j] = lst[j + 1];   //đẩy index 0 ra index 1
                    lst[j + 1] = sohientai; // đưa biến tạm sang phải (vị trí j+1);  
                }
                //tăng j lên và so sánh lst[j + 1] với lst[j + 2]
            }
        }
        System.Console.WriteLine(" List được sắp xếp là : " + string.Join(",", lst));
        int k = 1;
        while (k < lst.Count) //dùng while vì kích thước đang thay đổi . Độ phức tạp thuật toán O(n²)
        {

            if (lst[k] == lst[k - 1]) //nếu không trùng với số trước thì add vào danh sách ketqua. 
            {
                lst.RemoveAt(k);
            }
            else k++;
        }
        System.Console.WriteLine("list sau khi loại bỏ trùng nhau là :" + string.Join(",", lst));
    }
}