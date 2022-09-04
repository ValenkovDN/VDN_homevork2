// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void OutThreeNum()
{
    Console.Write("Введите целое число ");
    int a = Convert.ToInt32(Console.ReadLine());   
        
    if(a < 100)
        {
            Console.WriteLine("Третьего числа нет");
        }
    else if(a < 1000) 
        {
            int b = a % 10;
            Console.WriteLine(b);
        }
    else
        {
            while(a > 999)
            {
                a = a / 10;
            }
            int b = a % 10;
            Console.WriteLine(b);
        }
}

OutThreeNum();
OutThreeNum();
OutThreeNum();