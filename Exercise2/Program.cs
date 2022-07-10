// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите целое число a");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число b");
int numberB = int.Parse(Console.ReadLine());

if (numberB > numberA)
{
    Console.WriteLine("max = " + numberB + " min = " + numberA);  
}
if (numberA > numberB)
{
    Console.WriteLine("max = " + numberA + " min = " + numberB);
}
if (numberB == numberA)
{
    Console.WriteLine("числа равны");  
}