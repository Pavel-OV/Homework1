/*Напишите программу, которая на вход п
ринимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите два числа Сравните их и напишите какое больше ");
Console.Write("Придумайте число а=");
int number_a = int.Parse(Console.ReadLine());
Console.Write("Ещё раз придумайте чилсо b=");
int number_b = int.Parse(Console.ReadLine());

if (number_a > number_b){
Console.Write("Числo а больше b");
}
if (number_a< number_b){
    Console.Write("Число a меньше b");
}
if (number_a == number_b)
{Console.Write("Число а равен b");
}

