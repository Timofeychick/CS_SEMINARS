﻿// 21. Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введите целое число и программа проверит его на палиндром:");

int us_number = Convert.ToInt32(Console.ReadLine());
if (us_number > 0) {
    string conv_s = us_number.ToString();
    char[] array = conv_s.ToCharArray();
    Array.Reverse(array);
    string conv_e = new String(array);
    int us_number_conv = Convert.ToInt32(conv_e);

    if (us_number == us_number_conv) {
        Console.WriteLine("Это число - палиндром");
    }
    else {
        Console.WriteLine("Это число - не палиндром");
    }
}
else {
    us_number = us_number * -1;
    string conv_s = us_number.ToString();
    char[] array = conv_s.ToCharArray();
    Array.Reverse(array);
    string conv_e = new String(array);
    int us_number_conv = Convert.ToInt32(conv_e);

    if (us_number == us_number_conv) {
        Console.WriteLine("Это число - палиндром");
    }
    else {
        Console.WriteLine("Это число - не палиндром");
    }
}



