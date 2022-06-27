// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет
//Console.WriteLine("Hello, 45 World!");
Console.WriteLine("input a  ");
       int namberA = Convert.ToInt32(Console.ReadLine());
       if (namberA % 2==0)
       {
       Console.Write(namberA + "  -> " + "да")
       
       }
       else{
       Console.Write(namberA + "  -> " + "нет");}
       