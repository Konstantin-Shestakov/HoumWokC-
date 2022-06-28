/*  //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Input namber:  ");
int namber = Convert.ToInt32(Console.ReadLine());
if (namber <= 999 & namber >= 100) // int FirstInt = (namber / 100);Console.WriteLine(" Первая цbфра  " + FirstInt);
{
  int SecondInt = (namber / 10);
  SecondInt = SecondInt % 10;
  Console.WriteLine(namber + "  ->  " + SecondInt); // int ThirdInt = (namber % 10);  Console.WriteLine(" Третья цифра  " + ThirdInt);
 
 }
else
{
    Console.WriteLine("Введите трехзначное число");
}
*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

Console.WriteLine("Input namber:  ");
int Namber = Convert.ToInt32(Console.ReadLine());
if (Namber <= 99)
{
  Console.WriteLine(Namber + " ->  третьей цифры нет");  
}
else
{
int CorNamber = Namber;    
while (CorNamber >= 1000)
    CorNamber = CorNamber / 10;
int ThirdInt = (CorNamber % 10);  
    Console.WriteLine( Namber + " -> " + ThirdInt);
}



