//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.Write("Введите число номер дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 1)
{
    Console.Write($"{number} -> Понедельник");
}
if(number == 2)
{
    Console.Write($"{number} -> Вторник");
}
if(number == 3)
{
    Console.Write($"{number} -> Среда");
}
if(number == 4)
{
    Console.Write($"{number} -> Четверг");
}
if(number == 5)
{
    Console.Write($"{number} -> Пятница");
}
if(number == 6)
{
    Console.Write($"{number} -> Суббота");
}
if(number == 7)
{
    Console.Write($"{number} -> Воскресенье");
}

if(number > 7)
{
    Console.Write("Число должно быть от 1 до 7");
}
if(number < 1)
{
    Console.Write("Число должно быть от 1 до 7");
}