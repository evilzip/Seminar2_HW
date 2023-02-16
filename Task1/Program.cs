// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());  
    
}

int value = Prompt("Enter your value");

if (value/1000 == 0 && value/100!= 0) 
    {
        System.Console.WriteLine($"2nd number in you value is {value/10 % 10}");
    }
else
    {
        System.Console.WriteLine("You number is not three didgit number");        
    }   
 