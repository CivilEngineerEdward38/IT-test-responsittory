#region Bai tap ve nha 
/*
Bai 1: Tình huống: Bạn đang xây dựng một ứng dụng ghi lại nhiệt độ trong ngày để hỗ trợ cảnh báo thời tiết. Khi
người dùng nhập vào một con số biểu thị nhiệt độ (°C), hệ thống cần phải phản hồi:
Nếu nhiệt độ lớn hơn 0 → hiển thị “🌤️ Trời ấm”
Nếu nhiệt độ nhỏ hơn 0 → hiển thị “❄️ Trời lạnh, có thể có băng giá!”
Nếu nhiệt độ bằng 0 → hiển thị “🌫️ Trời rất lạnh, đúng 0°C!”*/


// System.Console.WriteLine($"Enter the temperature of your place: ");
// string inputTemperature = Console.ReadLine();
// if(int.TryParse(inputTemperature, out int nTemperature))
// {
//     System.Console.WriteLine(nTemperature switch{
//         int a when a > 0 => "🌤️ Trời ấm",
//         int a when a < 0 => "❄️ Trời lạnh, có thể có băng giá!",
//         _ => "🌫️ Trời rất lạnh, đúng 0°C!",
//     });

// }
// else
// {
//     System.Console.WriteLine($" Invalid character ");
// }


/* 
Bài 2:  Tình huống thực tế – "Tính thuế thu nhập cho người đi làm":
Bạn được giao xây dựng một phần mềm nhỏ để hỗ trợ kế toán công ty tính toán nhanh thuế thu nhập cá nhân
cho nhân viên mỗi tháng.
Kế toán chỉ cần nhập vào số tiền thu nhập hàng tháng, hệ thống sẽ tự động tính toán số thuế phải nộp theo
quy định sau:
Nếu thu nhập ≤ 5 triệu đồng → ✅ Miễn thuế
Nếu thu nhập > 5 triệu và ≤ 10 triệu đồng → 💰 Thuế 10%
Nếu thu nhập > 10 triệu đồng → 💸 Thuế 20%
*/

// System.Console.WriteLine($"Enter the personal income tax fee (tr VND):");
// string inputTax = Console.ReadLine();
// if (int.TryParse(inputTax, out int nTax))
// {
//     System.Console.WriteLine(nTax switch
//     {
//         int a when a <= 5 => "✅ Miễn thuế",
//         int a when a > 5 && a <= 10 => "💰 Thuế 10%",
//         _ => "💸 Thuế 20%",
//     });
// }
// else
// {
//     System.Console.WriteLine($"Invalid character");
// }



/*Bài 3: 🧭 Tình huống – “Xác định mùa trong năm từ số tháng”
Hãy xây dựng một chức năng cho ứng dụng lịch Việt Nam. Khi người dùng nhập vào số tháng (từ 1 đến 12),
chương trình cần xác định xem tháng đó thuộc mùa nào trong năm:
Xuân: Tháng 1, 2, 3
Hạ: Tháng 4, 5, 6
Thu: Tháng 7, 8, 9
Đông: Tháng 10, 11, 12
*/

// System.Console.WriteLine($"Enter during the season of the year");
// string inputSeason = Console.ReadLine();
// if (int.TryParse(inputSeason, out int nSeason))
// {
//     if (nSeason > 0 && nSeason <= 12)
//     {
//         System.Console.WriteLine(nSeason switch
//         {
//             1 or 2 or 3 => "Xuan",
//             4 or 5 or 6 => "Ha",
//             7 or 8 or 9 => "Thu",
//             10 or 11 or 12 => "Dong",
//         });
//     }
//     else
//     {
//         System.Console.WriteLine($"Enter only the month 1 to 12");
//     }
// }
// else
// {
//     System.Console.WriteLine($"Invalid character");
// }

/*Bài 4: 🪖 Tình huống – “Kiểm tra độ tuổi tham gia nghĩa vụ quân sự”
Bạn được giao xây dựng một chương trình hỗ trợ cho cán bộ xã trong việc rà soát danh sách thanh niên đủ điều
kiện tham gia nghĩa vụ quân sự.
Cán bộ sẽ nhập tuổi của công dân, và hệ thống sẽ phân loại kết quả như sau:
Nếu dưới 18 tuổi → ❌ Chưa đủ tuổi tham gia NVQS
Nếu từ 18 đến 27 tuổi → ✅ Đủ tuổi tham gia NVQS
Nếu trên 27 tuổi → ⛔ Quá tuổi tham gia NVQS
*/

// System.Console.WriteLine($"Enter the age to military zone ");
// string inputAge = Console.ReadLine();
// if (int.TryParse(inputAge, out int nAge))
// {
//     System.Console.WriteLine(nAge switch
//     {
//         int a when a <18 =>"❌ Chưa đủ tuổi tham gia NVQS",
//         int a when a >=18 && a <=27 =>" ✅ Đủ tuổi tham gia NVQS",
//         int a when a >27 =>"⛔ Quá tuổi tham gia NVQS",
//     });
// }
// else
// {
//     System.Console.WriteLine($"Invalid character");
// }


/*
Bài 5: 🔍 Tình huống – “Lọc số đặc biệt cho hệ thống bảo mật”
Bạn đang phát triển một hệ thống tạo mật khẩu bảo mật, trong đó chỉ chấp nhận những con số “đặc biệt”
– tức
là số nguyên tố.
Để đảm bảo tính chính xác, bạn cần viết một chương trình giúp kiểm tra xem một số nguyên người dùng nhập
vào có phải là số nguyên tố hay không. */

// System.Console.WriteLine($"Enter the prime number");
// string inputNum = Console.ReadLine();
// if (int.TryParse(inputNum, out int nNum))
// {
//     int soUoc = 0;
//     for (int i = 1; i <= nNum; i++)
//     {
//         if (nNum % i == 0)
//         {
//             soUoc++;
//         }if(soUoc > 2) break;
//     }
//     if (soUoc == 2) System.Console.WriteLine($"This is a prime number");
//     else System.Console.WriteLine($"This is not a prime number");
// }
// else
// {
//     System.Console.WriteLine($"Invalid character");
// }




/*
Bài 6:💡 Tình huống – “Tính tiền điện cho hộ gia đình”
Bạn đang xây dựng một chương trình hỗ trợ tính tiền điện hàng tháng cho các hộ gia đình. Khi người dùng
nhập vào số điện tiêu thụ trong tháng (tính bằng kWh), chương trình sẽ tính tiền điện phải trả theo biểu giá đơn
giản hóa sau:
Mức tiêu thụ (kWh)
Đơn giá
(VND/kWh)
Dưới 100 kWh 1.500
Từ 100 đến 200
kWh
2.000
Trên 200 kWh 2.500*/

// System.Console.WriteLine($"Enter the electricity amount that you consume");
// string inputElectric = Console.ReadLine();
// if (int.TryParse(inputElectric, out int nElectric))
// {
//     System.Console.WriteLine($"Your electric bill this month will be: {nElectric  switch
//     {
//         int a when a < 100 => "1.500 VND/kWh",
//         int a when a >= 100 && a <= 200 => "2.500 VND/kWh",
//         int a when a > 200 => "2.500 VND/kWh",
//     }}");
// }
// else
// {
//     System.Console.WriteLine($"Invalid character");
// }
/*
Bài 7: 🎬 Tình huống – “Hệ thống đặt vé rạp chiếu phim”
Bạn đang phát triển một ứng dụng đặt vé xem phim online. Khi người dùng chọn hạng vé (Standard, Premium,
VIP), hệ thống sẽ hiển thị thông tin về tiện ích mà họ nhận được kèm theo vé.
Bài 8: 🚕 Tình huống – “Tính tiền taxi cho khách hàng”
Bạn đang viết một ứng dụng cho hãng taxi giúp tự động tính tiền cước dựa vào số km mà khách đã đi. Biểu giá
tính như sau:
Hạng vé Tiện ích kèm theo
Standard Ghế ngồi thường, không có đồ uống
Premium Ghế ngồi thoải mái, có đồ uống miễn phí
VIP Ghế ngồi hạng sang, có đồ uống và bỏng ngô miễn phí */

// System.Console.WriteLine($"Chose your movie ticket type: 'Standard','Premium', 'VIP'");
// string inputTicket = Console.ReadLine();
// if(inputTicket == "Standard") System.Console.WriteLine($"Standard seating, no drinks included");
// else if(inputTicket == "Premium") System.Console.WriteLine($"Comfortable seating, free drinks included");
// else if(inputTicket == "VJP")Console.WriteLine($"Premium seating, free drinks and popcorn included");
// else System.Console.WriteLine($"Invalid character ");

/*Bài 8: 🚕 Tình huống – “Tính tiền taxi cho khách hàng”
Bạn đang viết một ứng dụng cho hãng taxi giúp tự động tính tiền cước dựa vào số km mà khách đã đi. Biểu giá
tính như sau:
Hạng vé Tiện ích kèm theo
Standard Ghế ngồi thường, không có đồ uống
Premium Ghế ngồi thoải mái, có đồ uống miễn phí
VIP Ghế ngồi hạng sang, có đồ uống và bỏng ngô miễn phí
Quãng đường Đơn giá (VND/km)
1 km đầu tiên 10.000 VND
Từ km thứ 2 đến km thứ 5 8.000 VND/km
Từ km thứ 6 trở đi 6.000 VND/km*/

// System.Console.WriteLine($"Enter the number of kilometers that you drive");
// string inputKm = Console.ReadLine();
// if (int.TryParse(inputKm, out int nKm))
// {
//     if(nKm == 1)
//     {
//         int a = nKm * 10000;
//         System.Console.WriteLine($"The cost for a distance of 2 to 5 km is: 10.000VNĐ * {nKm}  = {a:N0} VND");
//     }else if (nKm >= 2 && nKm <= 5)
//     {
//         int b = nKm * 8000;
//         System.Console.WriteLine($"The cost for a distance of 2 to 5 km is: 8.000VNĐ * {nKm}  = {b:N0}VND");
//     }else if (nKm > 6)
//     {   
//         int c = nKm * 6000;
//         System.Console.WriteLine($"The cost for a distance from the 6th km onwards is: 6.000VNĐ * {nKm}  = {c:N0}VND ");
//     }
// }
// else
// {
//     System.Console.WriteLine($"Invalid character");
// }

/*
Bài 9: 🔤 Tình huống – “Phân loại chữ cái: nguyên âm hay phụ âm”
Bạn đang phát triển một trò chơi học chữ cái tiếng Anh cho trẻ em. Khi người dùng nhập vào một ký tự, chương
trình sẽ tự động phân loại:
Nếu ký tự là nguyên âm (a, e, i, o, u – không phân biệt hoa/thường) → in ra “✅ Là nguyên âm”
Ngược lại → in “🔠 Là phụ âm”*/
/*  Nháp 
string inputChar;
do
{
    System.Console.WriteLine($"Enter a character");
    inputChar = Console.ReadLine();
    System.Console.WriteLine($"Nhap lai");
}
while (inputChar.Length != 1);
    System.Console.WriteLine($"✅ Là nguyên âm");*/



// System.Console.WriteLine($"Enter a character");
// char inputChar = char.Parse(Console.ReadLine().ToLower());
// System.Console.WriteLine(inputChar switch
// {
//     'a' or 'e' or 'i' or 'e' or 'u'=> "✅ Là nguyên âm",
//     _ => "🔠 Là phụ âm",
// });



/*
Bài 10: ✈️ Tình huống – “Xác định tiện ích theo loại vé máy bay”
Bạn đang xây dựng một hệ thống đặt vé máy bay online. Khi hành khách chọn loại vé (Economy, Business hoặc
First Class), hệ thống cần hiển thị tiện ích tương ứng như sau:
Loại vé Tiện ích đi kèm
Economy Ghế thường
Business Ghế rộng
First Class Ghế sang trọng*/

// System.Console.WriteLine($"Book your flight ticket online type: 'Economy','Business', 'First Class'");
// string inputTicket = Console.ReadLine();
// if(inputTicket == "Economy") System.Console.WriteLine($"Standard seat");
// else if(inputTicket == "Business") System.Console.WriteLine($"Extra seat ");
// else if(inputTicket == "First Class")Console.WriteLine($"Luxury seat");
// else System.Console.WriteLine($"Invalid character ");


#endregion