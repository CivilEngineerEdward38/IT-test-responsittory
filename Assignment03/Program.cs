#region Bài tập 6
/*
Đề bài: Viết một hàm nhận vào một chuỗi s, trả về từ dài nhất trong chuỗi đó. Nếu có nhiều từ có độ dài bằng
nhau, trả về từ đầu tiên tìm thấy.
Ví dụ:
Input: "I love programming"
Output: "programming"
*/
void BT6()
{
    string chuoi;
    do
    {
        System.Console.WriteLine($"Enter a string : ");
        chuoi = Console.ReadLine();
        if (chuoi.Length <= 0)
        {
            System.Console.WriteLine($"Invalid string");
        }
    } while (chuoi.Length <= 0);

    int doDai = chuoi.Length - 1;
    string tudainhat = "";  //dung bien ket qua de luu gia tri 
    string tuhientai = "";
    for (int i = 0; i <= doDai; i++)
    {
        char kiTu = chuoi[i]; // bien de nhan gia tri 
        if (chuoi[i] != ' ')
        {
            tuhientai = tuhientai + kiTu;

        }
        else if (chuoi[i] == ' ')
        {
            if (tuhientai.Length > tudainhat.Length)
            {
                tudainhat = tuhientai;
            }
            tuhientai = "";
        }

    }
    if (tuhientai.Length > tudainhat.Length)
    {
        tudainhat = tuhientai;
    }

    Console.WriteLine("Tu dai nhat: " + tudainhat);
}
BT6();
#endregion



#region Bài tập 7 

void BT7()
{
    string chuoi; //nhap chuoi ktra chuoi rong 
    do
    {
        System.Console.WriteLine($"Nhap vao chuoi");
        chuoi = Console.ReadLine();
        if (chuoi.Length <= 0)
        {
            System.Console.WriteLine($"Khong duoc de trong");
        }
    } while (chuoi.Length <= 0); //dieu kien dung quay lai
    string ketqua = " ";
    for (int i = 0; i < chuoi.Length; i++)
    {

        if (chuoi[i] > 'a' && chuoi[i] < 'z' || chuoi[i] > 'A' && chuoi[i] < 'Z' || chuoi[i] == ' ')
        {

            char kyTu = chuoi[i];
            ketqua += kyTu;
        }

    }
    System.Console.WriteLine($"Chuoi thu duoc la {ketqua}");
}
//BT7();
#endregion
//Bài 8 
void BT8()
{
    string chuoi = "";
    do
    {
        Console.WriteLine("Hay nhap vao mot chuoi");
        chuoi = Console.ReadLine() ?? "";

        if (chuoi.Length <= 0)
        {
            Console.WriteLine("Nhap lai chuoi");
        }

    } while (chuoi.Length <= 0);
    int dodai = chuoi.Length - 1;
    string tuhientai = "";
    string tuDaiNhat = "";

    for (int i = 0; i <= dodai; i++)
    {
        char kyTu = chuoi[i];
        //bool haveSo = false;
        if (kyTu != ' ')
        {
            tuhientai += kyTu;

        }
        else if (chuoi[i] == ' ')  //neu gap khoang trang bat dau so sánh chuoi 
        {
            bool checkNum = false;
            for (int j = 0; j <= tuhientai.Length - 1; j++)  //chay vong lap ktra tu 
            {
                if (tuhientai[j] >= '0' && tuhientai[j] <= '9')   //neu tu co number 
                {
                    checkNum = true;   //check flag 
                    break;
                }
            }
            if (checkNum && tuhientai.Length > tuDaiNhat.Length)
            {
                tuDaiNhat = tuhientai; //cap nhat tu dai nhat thanh tu hien tai 
            }
            tuhientai = "";            //reset tu hien tai 
        }
    }

    //kiem tra tu cuoi 
    bool checkNum2 = false;
    for (int j = 0; j < tuhientai.Length; j++)
    {
        if (tuhientai[j] >= '0' && tuhientai[j] <= '9')
        {
            checkNum2 = true;
            break;
        }
    }

    if (checkNum2 && tuhientai.Length > tuDaiNhat.Length)
    {
        tuDaiNhat = tuhientai;
    }

    Console.WriteLine($"Tu dai nhat co chua so la {tuDaiNhat}");

}
//BT8();
