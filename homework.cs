//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input an even number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"You typed {num1}");
int current = 2;
while (current<=num1)

    {
    Console.Write ($"{current} ");
    current=current+2;
    }
    
   /*эта была последняя, но я сделал отдельную ветку (git checkout task4.b) с альтернативным решением, 
   но со вложенным циклом, работает не быстро, но понятнее для пользователя, не понимаю оптимальное
   ли это решение или сложность алгоритма высокая*/
   