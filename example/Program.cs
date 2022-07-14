void Ex_001()
{
    //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

    Console.WriteLine ("Введите число a: ");
    int number_a = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine ("Введите число b: ");
    int number_b = Convert.ToInt32 (Console.ReadLine());
    if (number_a > number_b)
        {
            Console.WriteLine ("max=" + number_a);
        }
    else
        {
            Console.WriteLine ("max=" + number_b);
        }

}

//Ex_001();

void Ex_002()

{
    //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

    Console.WriteLine ("Введите число a: ");
    int number_a = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine ("Введите число b: ");
    int number_b = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine ("Введите число с: ");
    int number_с = Convert.ToInt32 (Console.ReadLine());
    int max=number_a;

    
    if (number_b>max) 
    {
        max=number_b;
    }

    if (number_с>max) 
    {
        max=number_с;
    }

    Console.Write ("max=");
    Console.WriteLine (max);
}

//Ex_002();

void Ex_003()

{
    //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

    Console.WriteLine ("Введите число: ");
    int number = Convert.ToInt32 (Console.ReadLine());

    if (number%2==0)
        {
            Console.WriteLine ("Да");
        }
    else 
        {
            Console.WriteLine ("Нет");
        }
}

//Ex_003();

void Ex_004()
{
    //Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

    Console.WriteLine ("Введите число: ");
    int number = Convert.ToInt32 (Console.ReadLine());
    int i = 1;

    while (i <= number)
    {
        int result = i % 2;
        
            if (result != 1)
                {
                    Console.WriteLine("четное " + i);
                    i++;
                }
                else
                {
                    i++;
                }
        }
        

}

Ex_004();