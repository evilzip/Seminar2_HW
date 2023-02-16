// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
int value;

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());      
}

bool validator(int userValue)
{
    if(userValue>0 && userValue < 8)
    {
        return true;
    }
    System.Console.WriteLine("You entered incorrect day number");
    return false; 
}

bool weekend(int userValue)
{
    if (userValue == 6 || userValue == 7)
    {
        System.Console.WriteLine("This is weekend");
        return true;
    }
    System.Console.WriteLine("This is not a weekend");
    return false;
}

value = Prompt("Enter number of a day");

if (validator(value)) 
{
    weekend(value);
}
