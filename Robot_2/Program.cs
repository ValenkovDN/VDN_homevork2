//Задача про робота с применением функции
Console.Write("Сколько программистов видит робот? ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;

void NumProgToday(int b)
{
    if(b == 1)
        {
            Console.WriteLine($"Сегодня {a} программист");    
        }
    else if(b > 1 && b < 5)
        {
            Console.WriteLine($"Сегодня {a} программиста"); 
        }
    else
        {
            Console.WriteLine($"Сегодня {a} программистов");
        }
}

if(a < 10)
    {
        NumProgToday(b);
    }
else if(a > 9 && a < 20)
    {
        Console.WriteLine($"Сегодня {a} программистов");    
    }
else if(a < 100)
    {
        b = a % 10;
        NumProgToday(b);
    }
else
    {
        b = a % 100;
        if( b < 10)
        {
            NumProgToday(b);
        }
        else if(b > 9 && b < 20)
        {
            Console.WriteLine($"Сегодня {a} программистов");    
        }
        else if(b < 100)
        {
            int c = b % 10;
            NumProgToday(c);
        }   
    }
