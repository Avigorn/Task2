// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int ReadInt(string message)

{
    Console.WriteLine($"Введите число: ", message); 
    int num = Convert.ToInt32(Console.ReadLine());
    return num; // Возврат целого числа
}
bool Validate3sign(int num)
{
    if (num < 100 || num >= 1000)
    {
        Console.WriteLine("Вы ввели неправильное число");
        return false;
    }
    return true;
}
int digit = ReadInt("Введите 3-хзначное число > ");
if (Validate3sign(digit))
{
    int midDigit = digit / 10 % 10;
    System.Console.WriteLine($"Второй цифрой числа {digit} является {midDigit}");
}