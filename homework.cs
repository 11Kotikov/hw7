//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"You typed {num1}, {num2} and {num3}");

//while ()

 if (num1==num2 && num2==num3)
{
    Console.WriteLine ($"They are equal!");
}
else 
{
    if (num1>num2 && num1>num3) 
    {
        Console.WriteLine ($"{num1} is the biggest one!");
    }
    if (num2>num1 && num2>num3)
    {
        Console.WriteLine ($"{num2} is the biggest one!");
    }
    if (num3>num1 && num3>num1)
    {
        Console.WriteLine ($"{num3} is the biggest one!");
    }
}
