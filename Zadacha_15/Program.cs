// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void LoDayWeek()
{
    Console.Write("Введите номер дня недели ");
    int a = Convert.ToInt32(Console.ReadLine()); 

    if(a > 7)
        {
            Console.WriteLine("Введите число от 1 до 7.");
        }
    else if(a > 5)
        {
            Console.WriteLine("Поздравляю! Сегодня выходной!");
        }
    else
        {
            Console.WriteLine("Увы, кому-то пора на работу. Сегодне не выходной.");
        }
}

LoDayWeek();
LoDayWeek();
LoDayWeek();