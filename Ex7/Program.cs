﻿Console.WriteLine("Введите трех значное число "); 
int number = int.Parse(Console.ReadLine()); 
number = ((number / 10) % 10); 
Console.WriteLine(number);