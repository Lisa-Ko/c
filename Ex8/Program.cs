int number = new Random().Next(10, 99);
Console.WriteLine(number);
int max = number % 10;
if (number / 10 > max) max = number / 10; 
Console.WriteLine(max);