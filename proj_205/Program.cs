Console.WriteLine("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNum = int.Parse(Console.ReadLine());

if (isSqr(firstNum, secondNum))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}


bool isSqr(int num1, int num2)
{
    if (num1 * num1 == num2 || num2 * num2 == num1)
    {
        return true ;
    }
    else
    {
        return false;
    }

}

