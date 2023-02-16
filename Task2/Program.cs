// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int thirdDigit, userValue, N;

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());      
}

bool Validator(int userValue)
{
    if (userValue >99)
    {
        return true;
    } 
    System.Console.WriteLine("no 3rd digit in your value ");
    return false;
}

int digitsAmount(int userValue)
{
    int digitCounter = 0;
    while (userValue > 0)
        {
        digitCounter ++;
        userValue /= 10;
        }
    return digitCounter;    
}

userValue = Prompt("Enter your value");
N = digitsAmount(userValue);

if  (Validator(userValue))
{
    thirdDigit = (userValue/Convert.ToInt32(Math.Pow(10,(N-3))))%10;
    System.Console.WriteLine($"3rd digit in your value is {thirdDigit}");       
}

