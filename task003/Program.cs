/* Напишите программу, которая на вход принимает число и выдаёт,
 является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Прверка числа на чётность");
Console.Write("Ваше число a=");
//int number_a = int.Parse(Console.ReadLine());
int number_c = int.Parse(Console.ReadLine());
int number_b =  number_c % 2;


if (number_b == 0 ){
Console.WriteLine("Вашее число чётное");
}
else
{
    Console.WriteLine("Ваше число нечётное");
}
