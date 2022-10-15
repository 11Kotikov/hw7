//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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
//добавьте в коммент на GB пожалуйта - плохо, что вложил ветвление в ветвление?    

}