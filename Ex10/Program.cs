Console.WriteLine("Введите число "); //заданное число 17
int number = int.Parse(Console.ReadLine());
if (number % 17 == 0) Console.WriteLine("Число кратно 17");
else Console.Write("Число не кратно 17, а остаток равен " + number % 17);