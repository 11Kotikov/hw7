//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"You typed {num1}");

while (current<=num1)

    if (num1%2==0)
{
    Console.WriteLine ($"{num1} is even!");
}
else 
{
    Console.WriteLine ("Plese, try again, this is odd");

}
//бесконечный цикл