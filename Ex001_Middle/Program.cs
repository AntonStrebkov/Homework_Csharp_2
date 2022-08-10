//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int digit1 = num % 100;
int digit2 = digit1 / 10;
Console.WriteLine(digit2);

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int digit1 = number / 10;
// int digit2 = digit1 % 10;
// Console.WriteLine(digit2);