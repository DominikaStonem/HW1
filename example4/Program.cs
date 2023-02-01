// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число!");

int num = Convert.ToInt32(Console.ReadLine());

for (int Num1 = 1;Num1 <= num; Num1++)
if (Num1 % 2 == 0)
System.Console.Write( Num1 + " ");

