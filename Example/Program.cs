
void PrintText(string text)
{
    Console.WriteLine($"Goodbye, {text}");
    int c = 0;
    for (int i = 0; i < text.Length; i++)// текст. Ленс - это количество знаков в тексте длина текста! 
    {
        c++;
    }
    Console.WriteLine($"количество знаков в имени: {c}");
}
string name;
string name1 = "Dima";
string name2 = "Vanya";
Console.WriteLine($" Hello, whats your name? : ");
name = Console.ReadLine()!;
// мы сначала создаём функцию, наполняем её и потом просто вызываем , когда необходимо! 
PrintText(name);
PrintText(name1);
PrintText(name2);
Console.WriteLine("-----------");

