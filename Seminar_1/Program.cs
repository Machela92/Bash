// See https://aka.ms/new-console-template for more information
// Написать программу где принимаются два числа и проверяется является ли второе число квадратом первого



/*Console.WriteLine("Для сравнение чисел введите первое число");
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

*/

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int i = -1 * n;
while (i <= n)
{
    Console.WriteLine("Дапозон чисел" + " " + i);
    i++;
}