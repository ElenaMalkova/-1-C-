// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите целое число a");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число b");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число c");
int numberC = int.Parse(Console.ReadLine());
int max = numberA;
if (numberB > max)
{
   max = numberB; 
}
if (numberC > max)
{
    max = numberC;
}
Console.WriteLine("max = " + max);