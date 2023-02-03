/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
int a;
Console.WriteLine($"Введите целое число: ");
int.TryParse(Console.ReadLine(), out a);

if (a > 99)
{
    string a1 = a.ToString();
    int b = int.Parse(a1[2].ToString());
    Console.WriteLine($"Третья цифра: {b}");
}
else
    Console.WriteLine($"Третьей цифры нет");