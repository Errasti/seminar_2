int a = new Random().Next(100, 1000);
Console.WriteLine(a);
int digitOne = a / 100;
int digitSecond = a % 10;
Console.WriteLine(digitOne*10 + digitSecond);

