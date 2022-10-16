//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

   Console.WriteLine("Input a number bigger than 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int current = 2;
 Console.WriteLine ($"You typed {num1}");

 if (num1>=current)
 {
   while (current<=num1)
{
       {
        Console.Write ($"{current} ");
        current=current+2;
    }
} 
 }

 else 
  {
    Console.WriteLine("Please try again and input a number bigger than 1: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    while (current<=num1)
       {
        Console.Write ($"{current} ");
        current=current+2;
    }
  }

