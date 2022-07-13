// Создали программу для выявления выходного дня

Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
if( number >= 1 & number <= 5)
{
    Console.WriteLine("Сегодня рабочий день");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("Сегодня выходной день");
}
else
{
    Console.WriteLine("Вы ввели неверное число, перезапустите программу");
}

