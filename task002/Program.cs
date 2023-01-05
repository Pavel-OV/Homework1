/*Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите  числа Сравните их и напишите какое больше ");
Console.Write("Придумайте число а=");
int number_a = int.Parse(Console.ReadLine());
Console.Write("Ещё раз придумайте чилсо b=");  //Здесь можно придумать проверку, на одинаковые числа
int number_b = int.Parse(Console.ReadLine());
Console.Write("Придумайте число c=");
int number_c = int.Parse(Console.ReadLine());

if (number_a > number_b & number_a > number_c)
{
    Console.WriteLine("Число а больше вeх");
    Console.Write(number_a);
}
if (number_a < number_b & number_b > number_c)
{
    Console.WriteLine("Число b больше вeх");
    Console.Write(number_b);
}
if (number_c > number_a & number_b < number_c)
{
    Console.WriteLine("Число c больше вeх");
    Console.Write(number_c);
}