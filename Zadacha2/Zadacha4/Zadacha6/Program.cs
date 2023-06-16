// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

double mod = number % 2;



if ( mod == 0 )
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}




