
// #region Bai 1
// // Bài tập 1: Tính số ngày trong tuần và số ngày lẻ
// // Yêu cầu người dùng nhập số ngày và tính toán bao nhiêu tuần và bao nhiêu ngày lẻ còn lại. Ví dụ, nếu người dùng nhập vào 10 ngày, kết quả sẽ là 1 tuần và 3 ngày
// System.Console.WriteLine($"Enter the number of days");
// string inputDays = Console.ReadLine();
// bool checkDays = int.TryParse(inputDays, out int nDays);
// double outputDays = nDays / 7; 
// double daysRemainder = nDays % 7;
// System.Console.WriteLine($"The number of week is {outputDays}");
// System.Console.WriteLine($"The number of daysRemainder is {daysRemainder}");
// #endregion

// // Bài tập 2 : Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
// // Yêu cầu người dùng nhập vào giá trị của một đơn hàng và phần trăm giảm giá. Tính toán số tiền giảm giá và tổng số tiền phải thanh toán sau khi áp dụng giảm giá.
// System.Console.WriteLine($"Enter the discount number");
// string inputDiscount = Console.ReadLine();
// System.Console.WriteLine($"Enter the price of the item ");
// string inputPrice = Console.ReadLine();
// bool checkDiscount = int.TryParse(inputDiscount, out int discount);
// bool checkPrice = int.TryParse(inputPrice, out int price);
// double totalMomeny = price - price*discount/100;
// System.Console.WriteLine($"The amount of money paid for the item is {totalMomeny}");

// /*Bài tập 3: Chuyển đổi thời gian từ phút sang giờ và phút
// Yêu cầu người dùng nhập vào một số phút và chuyển đổi số phút này thành giờ và phút. Ví dụ, nếu người dùng nhập vào 130 phút, kết quả sẽ là 2 giờ và 10 phút.*/
// System.Console.WriteLine($"Enter the number of minutes to transfer hour");
// string inputMinutes = Console.ReadLine();
// bool checkMi = int.TryParse(inputMinutes, out int nMinutes);
// double hour = nMinutes/60;
// double minutes = nMinutes%60;
// System.Console.WriteLine($"The number of minutes is {minutes} and hour is {hour} ");

// /*Bài tập 4: Tính tổng số tiền sau khi cộng thêm thuế VAT
// Yêu cầu người dùng nhập vào số tiền gốc và tỷ lệ thuế VAT (ví dụ: 10%). Tính và in ra tổng số tiền sau khi đã cộng thêm thuế.*/
// System.Console.WriteLine($"Enter the price that you paid for items $: ");
// string inputPriceVAT = Console.ReadLine();
// bool checkPriceVAT = int.TryParse(inputPriceVAT, out int nPricebeforVAT);
// System.Console.WriteLine($"Enter the VAT %");
// string inputVAT = Console.ReadLine();
// bool checkVat = int.TryParse(inputVAT, out int nVAT);
// double outputPriceVAT = nVAT * nPricebeforVAT / 100 + nPricebeforVAT;
// System.Console.WriteLine($"The price that you paid for items after VAT is {outputPriceVAT} $");


// /*Bài tập 5: Chuyển đổi đơn vị tiền tệ
// Yêu cầu người dùng nhập vào một số tiền bằng USD và tỷ giá chuyển đổi từ USD sang VND. Tính và in ra số tiền tương ứng bằng VND.*/

// System.Console.WriteLine($"Enter the price in USD");
// string inputTienUSD = Console.ReadLine();
// bool isTien = int.TryParse(inputTienUSD, out int tienUSD);
// double tienVND = tienUSD * 26000; 
// System.Console.WriteLine($"The equivalent amount from USD to VNĐ is: {tienVND:N0} VNĐ");

// /*Bài tập 6: Tính số dư sau khi rút tiền từ tài khoản
// Yêu cầu người dùng nhập vào số dư tài khoản hiện tại và số tiền muốn rút. Tính và in ra số dư còn lại sau khi rút tiền (lưu ý không kiểm tra số dư âm ở bài này).*/

// System.Console.WriteLine($"Enter your account balance");
// string inputAccountBalance = Console.ReadLine();
// bool isAccountBalance = int.TryParse(inputAccountBalance, out int nBalance);
// System.Console.WriteLine($"Enter the money you wish rút ");
// string inputRut = Console.ReadLine();
// bool isRuttien = int.TryParse(inputRut, out int nRuttien);
// double sodu = nBalance - nRuttien;
// System.Console.WriteLine($"Your account balance after withdraw {sodu:N0}$");

// /*Bài tập 7: Tính tốc độ trung bình
// Yêu cầu người dùng nhập vào quãng đường đã đi (km) và thời gian đã đi (giờ). Tính và in ra tốc độ trung bình (km/h).*/
// System.Console.WriteLine($"Enter the distance you travel (km)");
// string inputDistance = Console.ReadLine();
// bool isDistance = int.TryParse(inputDistance, out int nDistance);
// System.Console.WriteLine($"Enter the time you travel (h)");
// string inputTime = Console.ReadLine();
// bool isTime = int.TryParse(inputTime, out int nTime);
// double averageSpeed = nDistance/nTime;
// System.Console.WriteLine($"Your average speed is {averageSpeed} km/h");

// /*Bài tập 8: Tính tỷ lệ phần trăm
// Yêu cầu người dùng nhập vào một số và một tổng số, sau đó tính và in ra tỷ lệ phần trăm của số đó trong tổng số.*/
// System.Console.WriteLine($"Enter the number");
// string inputNum = Console.ReadLine();
// bool isNum = double.TryParse(inputNum, out double nNum);
// System.Console.WriteLine($"Enter the total number");
// string inputTotal = Console.ReadLine();
// bool isTotal = double.TryParse(inputTotal, out double nTotal);
// double percentrage = nNum/nTotal*100;
// System.Console.WriteLine($"number total is {percentrage} %");


// /*
// Bài tập 9: Chuyển đổi từ km/h sang m/s
// Yêu cầu người dùng nhập vào vận tốc bằng km/h và chuyển đổi nó sang m/s theo công thức: m/s = km/h ÷ 3.6. In ra kết quả sau khi chuyển đổi.
// */
// System.Console.WriteLine($"Enter the speed that you want transfer ");
// string inputSpeed = Console.ReadLine();
// bool isSpeed = int.TryParse(inputSpeed, out int nSpeed);
// double converSpeed = nSpeed/(3.6d);
// System.Console.WriteLine($"The speed that conver is {converSpeed:f2}km/h");



// /*Bài tập 10: Tính lượng calo tiêu thụ
// Yêu cầu người dùng nhập vào số phút đã tập thể dục và loại hình tập thể dục (chọn từ các giá trị đã định trước như chạy, đạp xe, bơi lội). Tính và in ra lượng calo tiêu thụ
// dựa trên số phút và loại hình tập thể dục (sử dụng hệ số calo tiêu thụ giả định cho mỗi loại hình).
// */

// System.Console.WriteLine($"So phut ma nguoi do da tap the duc");
// string inputMinutes = Console.ReadLine();
// bool isMinutes = int.TryParse(inputMinutes, out int nMinutes);
// double carloDapXe = 10, carloChay = 20, carloBoiLoi = 30;
// double carloTieuThuDapXe = nMinutes*carloDapXe;
// double carloTieuThuChay = nMinutes*carloChay;
// double carloTieuThuBoiLoi = nMinutes*carloBoiLoi;
// System.Console.WriteLine($"Carlo tieu thu do dap xe la {carloTieuThuDapXe}");
// System.Console.WriteLine($"Carlo tieu thu do chay bo la {carloTieuThuChay}");
// System.Console.WriteLine($"Carlo tieu thu do boi loi la {carloTieuThuBoiLoi}");