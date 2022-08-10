// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
int num = new Random().Next(1, 10);
Console.WriteLine(num);
string str_num = num.ToString();
if(str_num.Length > 2)
    Console.WriteLine("Третья цифра ->" + str_num[2]);
else
    Console.WriteLine("Третьей цифры нет");

