//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
int day = new Random().Next(1, 8);
if(day == 6 || day == 7)
    Console.WriteLine($"{day} -> Да");
else
    Console.WriteLine($"{day} -> Нет");