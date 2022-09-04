// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void PrintToDigit()
{
    Console.Write("Введите трехзначное число ");
    int a = Convert.ToInt32(Console.ReadLine());
    
    int b = (a % 100)/10;
    Console.WriteLine($"Вторая цифра числа {a} это {b}");
}

PrintToDigit();
PrintToDigit();
PrintToDigit();