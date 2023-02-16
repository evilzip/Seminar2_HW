// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int Value, Position;

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());      
}

bool Validator(int userValue, int digitPosition)
{
    if (userValue > (Convert.ToInt32(Math.Pow(10,(digitPosition-1))-1)))
    {
        return true;
    }
    System.Console.WriteLine($"no {digitPosition} digit in your value ");
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

int findDigit(int userValue, int digitPosition)
{
    int N = digitsAmount(userValue);
    return (userValue/Convert.ToInt32(Math.Pow(10,(N-digitPosition))))%10;
}

Value = Prompt("Enter your value");
Position = Prompt("Enetr digit position");


if  (Validator(Value, Position))
{
    System.Console.WriteLine($"{Position} digit in your value is {findDigit(Value, Position)}");       
}

