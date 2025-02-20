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
