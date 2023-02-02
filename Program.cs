/* 11. Напишите программу, которая выводит случаное 3х значное число и удаляет вторую цифру из него 
456 -> 46 */
Console.WriteLine($"решение 1: ");
int num = new Random().Next(100, 1000);
Console.Write($"{num} - random");
Console.WriteLine();
string num_1 = num.ToString();
int a = int.Parse(num_1[0].ToString());
int c = int.Parse(num_1[2].ToString());
Console.WriteLine($"{num} -> {a}{c}");
Console.WriteLine($"решение 2: ");
int b = num % 10;
int d = num / 100;
int f = int.Parse($"{d}{b}");// обьеденили в единое число 
int g = d * 10 + b;
int q = num % 10 * 10 + num / 100; // это оптимизированная версия где переменные d и b не нужны 
Console.WriteLine($"{num}, int f -> {f}");
Console.WriteLine($"{num}, int g -> {g}");
Console.WriteLine($"{num}, int q -> {g}");