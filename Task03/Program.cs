
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Напишите трехзначное число: ");

int number1 = Convert.ToInt32(Console.ReadLine()); 
int end = number1 % 10;
   
    if ( number1 % 10) 
{
Console.Write($"Последняя Число: {number1} ");
}
    else

{
Console.Write($" не трех значное число");    
}