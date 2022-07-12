int a = new Random().Next(100, 1000);
Console.WriteLine(a);
int digitOne = a / 100;
int digitSecond = a % 10;
Console.WriteLine(digitOne*10 + digitSecond);

int result = getSecNum(a);
Console.WriteLine(result);
int getSecNum(int number)
{
    int digitOne = number / 100;
    int digitSecond = number % 10;
    int resultDouble = digitOne*10 + digitSecond;
    return resultDouble;
}

