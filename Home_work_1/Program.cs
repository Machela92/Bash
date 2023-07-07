// See https://aka.ms/new-console-template for more information
Console.WriteLine("Для сравнение чисел введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше первое число" + " " + a);
Console.WriteLine("Для сравнение чисел введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше второе число" + " " + b);
int max = a;
if (a > max) max = a;

else if
    (b > max) max = b;
Console.WriteLine("Максимальное число " + max);


Console.WriteLine("Для сравнение чисел введите первое число");
int one = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше первое число" + " " + one);
Console.WriteLine("Для сравнение чисел введите второе число");
int two = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше второе число" + " " + two);
Console.WriteLine("Для сравнение чисел введите третье число");
int three = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше третье  число" + " " + three);
int maximus = one;
if (one > maximus) maximus = one;
if (two > maximus) maximus = two;
if (three > maximus) maximus = three;
Console.WriteLine("Максимальное число " + maximus);

Console.WriteLine("Определитель четности, приветствует вас, введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше число " + " " + number);
if (number % 2 == 0) Console.WriteLine("Четное");
else Console.WriteLine("Не четное");


Console.WriteLine("Введите число, а мы в свою очередь посчитаем сколько до него было четных чисел ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше введенное число" + " " + N);
int i = 0;
while (i <= N)
{
    if (i % 2 == 0) Console.WriteLine($"{i}");
    i++;
}