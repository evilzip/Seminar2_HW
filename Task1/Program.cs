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

bool Validator(int userValue)
{
    if(userValue>99 && userValue<1000)
    {
        return true;
    }
    System.Console.WriteLine("You number is not three didgital number");
    return false;    
}

int value = Prompt("Enter your value");

if (Validator(value)) 
    {
        System.Console.WriteLine($"2nd number in you value is {value/10 % 10}");
    }
