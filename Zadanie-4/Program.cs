// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

        //2, 3, 7 -> 7
        //44 5 78 -> 78
        //22 3 9 -> 22
        //Console.WriteLine("Hello, 66World!");
        int max = 0;
        Console.WriteLine("input a  ");
        int namberA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("input b  ");
        int namberB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("input c  ");
        int namberC = Convert.ToInt32(Console.ReadLine());
        if (namberA > namberB)
        { 
            max = namberA;
        }     
        else 
        {max = namberB;}      
        if(max < namberC)  
           max = namberC;
        
        
        Console.WriteLine(namberA + ", " + namberB + ", " + namberC + "  ->  " + max);
       
    
