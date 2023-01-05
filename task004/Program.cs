//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите ваше число от 1");
int number_a = int.Parse(Console.ReadLine());

if (number_a < 1)
{
    Console.WriteLine("Неправильно ввели число, надо положительное от единицы");
}
else
{
    Console.WriteLine("Выпешем ваши чётные числа от единицы ");
}
int even_number = 1;
int an_even_number = 0;
while (even_number <= number_a)
{
    an_even_number = even_number % 2;

    if (an_even_number == 0)
        Console.WriteLine(even_number);

    even_number = even_number + 1;
}


