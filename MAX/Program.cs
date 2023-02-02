int a = 5, b = 6, c = 7, g = 8;
void Max1(int a1, int b1) // создали метод по сравнению чисел и далее простовызываем Мах 
{
    if (a1 > b1)
        Console.WriteLine($"{a1} > {b1}");
    else
        Console.WriteLine($"{a1} < {b1}");
}
Max1(a, b);
Max1(c, g);
Max1(a, c);
Max1(g, b);
Console.WriteLine("-----------");
int A = Max2(a, b);
int B = Max2(c, g);
int C = Max2(a, c);
int D = Max2(g, b);
int Max2(int a2, int b2)
{
    if (a2 > b2)
        return a2;
    else return b2;
}
Console.WriteLine($"{Max2(a, b)}");
Console.WriteLine("-----------");
int Max3(int a3, int b3, int c3)
{
    return Max2(Max2(a3, b3), c3);
}
Console.WriteLine($"{Max3(a, b, c)}");
Console.WriteLine("-----------");
int Max4(int a3, int b3, int c3, int d3)
{
    return Max2(Max3(a3, b3, c3), d3);// Мах2 потому что мы отдаём два числа (a,b,c,) и d3
}
Console.WriteLine($"{Max4(a, b, c, g)}");
