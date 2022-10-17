//Задача 1 (2): Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/* начало Задачи 1

Console.WriteLine("Input number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"You typed {num1} and {num2}");

if (num1==num2)
{
    Console.WriteLine ($"They are equal!");
}
else 
{
    if (num1>num2) 
    {
        Console.WriteLine ($"{num1} is bigger than {num2}");
    }
    else
    {
        Console.WriteLine ($"{num2} is bigger than {num1}");
    }
} 
//добавьте в коммент на GB пожалуйта - плохо, что вложил ветвление в ветвление?
//Или лучше сделать надо было:

//if (num1==num2) Console.WriteLine("");
//if (num1>num2) Console.WriteLine("") ;
//if (num1<num2)Console.WriteLine("");

//или это не имеет значения?
конец Задачи 1 */

//Задача 2 (4): Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/* начало Задачи 2
Console.WriteLine("Input number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"You typed {num1}, {num2} and {num3}");

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
    if (num3>num1 && num3>num2)
    {
        Console.WriteLine ($"{num3} is the biggest one!");
    }
}
конец Задачи 2 */ 

// Задача 3 (6): Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/* начало задачи 3
Console.WriteLine("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"You typed {num1}");


if (num1%2==0)
{
    Console.WriteLine ($"{num1} is even!");
}
else 
{
    Console.WriteLine ($"{num1} is odd!");

}
конец Задачи 3 */ 

//Задача 4(8): Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/* начало Задачи 4
Console.WriteLine("Input an even number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"You typed {num1}");
int current = 2;
while (current<=num1)

    {
    Console.Write ($"{current} ");
    current=current+2;
    }

конец Задачи 4 */ 

//Альтернативное решение Задачи 4, с доп. проверками

/* начало доп. решения Задачи 4
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
конец альт решения задачи 4 */