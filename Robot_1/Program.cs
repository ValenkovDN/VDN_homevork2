//Задача про робота без фунций
Console.Write("Сколько программистов видит робот? ");
int a = Convert.ToInt32(Console.ReadLine()); // вводим число программистов

if( a < 10)
    {
        if(a == 1)
            {
                Console.WriteLine($"Сегодня {a} программист");    
            }
        else if(a > 1 && a < 5)
            {
                Console.WriteLine($"Сегодня {a} программиста"); 
            }
        else
            {
                Console.WriteLine($"Сегодня {a} программистов");
            }
    }

else if(a > 9 && a < 20)
    {
        Console.WriteLine($"Сегодня {a} программистов");    
    }
else if(a < 100)
    {
        if(a % 10 == 1)
            {
                Console.WriteLine($"Сегодня {a} программист");    
            }
        else if(a % 10 > 1 && a % 10 < 5)
            {
                Console.WriteLine($"Сегодня {a} программиста"); 
            }
        else
            {
                Console.WriteLine($"Сегодня {a} программистов");
            }
    }
else
    {
        if( a % 100 < 10)
            {
                if(a % 100 == 1)
                    {
                        Console.WriteLine($"Сегодня {a} программист");    
                    }
                else if(a % 100 > 1 && a % 100 < 5)
                    {
                        Console.WriteLine($"Сегодня {a} программиста"); 
                    }
                else
                    {
                        Console.WriteLine($"Сегодня {a} программистов");
                    }
            }
        else if(a % 100 > 9 && a % 100 < 20)
            {
                Console.WriteLine($"Сегодня {a} программистов");    
            }
        else if(a % 100 < 100)
            {
                if(a % 10 == 1)
                    {
                        Console.WriteLine($"Сегодня {a} программист");    
                    }
                else if(a % 10 > 1 && a % 10 < 5)
                    {
                        Console.WriteLine($"Сегодня {a} программиста"); 
                    }
                else
                    {
                        Console.WriteLine($"Сегодня {a} программистов");
                    }
            }
    }