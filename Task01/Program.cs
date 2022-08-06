/*
Console.Write("Введите целое число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите целое число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine()); 

int square = number2 * number2;

    if ( number1 == square) 
{
Console.Write($"Число {number1} является квадратом числа: " +number2);
}
    else

{
Console.Write($"Число {number1} не является квадратом числа: " +number2);    
}
*/

Console.WriteLine("Введите целое число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
string day = "" ;
if (number >= && number<=7)
    {
        switch(number)

        {
        case 1:
            day= "Понедельник";
            break;
        case 2:
            day= "Вторник";
            break;
        case 3:
            day= "среда";
            break;
        case 4:
            day= "Четверг";
            break;
        case 5:
            day= "Пятница";
            break;
        case 6:
            day= "Суббота";
            break;
        case 7:
            day= "Воскресенье";
            break;
           
        default:
            console.WriteLine("Вы ввели некорректное число");
            break;

        }
        console.WriteLine("День недели:"+day);

    }
   
        
    