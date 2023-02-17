Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (первое число > Второе число)
{
 if (первое число > третье число)
    {
 Console.WriteLine("Максимальное число: " + firstNumber);
    }
 else
    {
 Console.WriteLine("Максимальное число: " + thirdNumber);
    }
}

иначе, если (второе число > третье число)
{
 Console.WriteLine("Максимальное число: " + secondNumber);
}
else
{
 Console.WriteLine("Максимальное число: " + thirdNumber);
}
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число: ");
number int = Convert.ToInt32(Console.ReadLine());
if (число % 2 == 0)
    {
 Console.WriteLine(number + " - Четное число: ");
    }
 else
    {
 Console.WriteLine(number + " - Нечетное число");
    }
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Clear();
Console.WriteLine("Введите число: ");
number int = Convert.ToInt32(Console.ReadLine());
int startNumber = 1;

While (startNumber <= number)
    {
 if (startNumber % 2 ==0)
 Console.WriteLine (startNumber + ", ");
 startNumber ++;
    }