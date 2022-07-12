Console.WriteLine("Введите первое число: ");

void divNum ( int number )
{
    if (number % 7 == 0 && number % 23 == 0 )
    {
        Console.WriteLine("Число " + number + " является кратным 7 и 23");
    }
    else
    {
        Console.WriteLine("Не кратно!");
    }
}


int a = int.Parse(Console.ReadLine());

if (a % 7 == 0 && a % 23 == 0 )
{
    Console.WriteLine("Число " + a + " является кратным 7 и 23");
}
else
{
    Console.WriteLine("Не кратно!");
}

