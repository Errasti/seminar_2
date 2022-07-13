//Создали метод "вытягивания" второй цифры из трехзначного числа"
void getDigit( int num )
{
    int digit = num / 10;
    digit = digit % 10;
    Console.WriteLine("Вторая цифра в " + num + " это " + digit);
}
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
getDigit(number);



