// Метод поиска третьей цифры в числе

void createNumber( int number )
{
    if( number >= 0 & number < 100 )
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        if( number < 0 )
        {
            Console.WriteLine("Это отрицательное число!");
        }
        else
        {
            while( number >= 1000 )
            {
                number = number / 10;    
            }
            number = number % 10;
            Console.WriteLine("Третья цифра это - " + number);
                
            
        }
    }
}
Console.WriteLine("Введите число - ");
int requestedNumber = int.Parse(Console.ReadLine());
createNumber(requestedNumber);
