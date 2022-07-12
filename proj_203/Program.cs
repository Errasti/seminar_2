Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());


if (b % a == 0)
{
    Console.WriteLine("Числа кратны!");
}
else
{
    int c = b % a;
    Console.WriteLine(c);
}
