// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello,53 World!");
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Write("Input, a  ");
int namberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input, b  ");
int namberB = Convert.ToInt32(Console.ReadLine());
int max = 0;
if( namberA >  namberB);
  {
    max = namberA;
 };

max = namberB;

Console.Write(" a=" + namberA +" ;" + " b=" + namberB + "  ->  " + max);
