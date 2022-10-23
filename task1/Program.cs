// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());
Console.Write("Введите четвертое число: ");
int number4 = int.Parse(Console.ReadLine());
Console.Write("Введите четвертое число: ");
int number5 = int.Parse(Console.ReadLine());


void PositiveNumber(int number)
{
    int count = 0;
    if (number1 > 0)
    {
        count++;
    }
    else
        count = count + 0;
    if (number2 > 0)
    {
        count++;
    }
    else
        count = count + 0;
    if (number3 > 0)
    {
        count++;
    }
    else
        count = count + 0;
    if (number4 > 0)
    {
        count++;
    }
    else
        count = count + 0;
    if (number5 > 0)
    {
        count++;
    }
    else
        count = count + 0;
    Console.WriteLine($"{count}");
}
PositiveNumber(number1);
