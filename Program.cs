using System;

Console.WriteLine("< Bu \"DOIRA PARAMETRLARI\" dasturi >");

Console.Write("Doira radiusini kiriting:\n>>> ");
double radius = Convert.ToDouble(Console.ReadLine());

// O'zgaruvchilar
const double PI = 3.14159265359;
double yuza = PI * radius * radius;
double uzunlik = 2 * PI * radius;

Console.WriteLine($"Doira yuzi: {yuza}.");
Console.WriteLine($"Aylanasi uzunligi: {uzunlik}.");

Console.WriteLine("< Bu \"VALYUTA KONVERTORI\" dasturi");

Console.Write("Xorijiy valyuta kursini kiriting (hozirgi MB bo'yicha):\n>>> ");
double kurs = Convert.ToDouble(Console.ReadLine());

Console.Write("Valyuta qiymatini kiriting:\n>>> ");
double qiymat = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"So'mdagi miqdori: {kurs * qiymat}.");

Console.WriteLine("< Bu \"YOSHNI HISOBLASH\" dasturi >");

Console.Write("Yoshingiz nechada?\n>>> ");
int yosh = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Siz tug'ilganingizga {yosh * 365} kun bo'ldi, {2025 - yosh}-yilda tug'ilgansiz.");
