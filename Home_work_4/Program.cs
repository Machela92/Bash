// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число А = {A}");
Console.WriteLine("Введите число B  оно возведет число А в ту степень которой Является B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число А возведется в степень = {B}");

int double_number(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++) // Это надо что бы программа поняла сколько раз делать
    {
        result *= a;

    }
    return result;
}

Console.WriteLine($"Число {A} в степени {B} будет равно {double_number(A, B)}");
*/

Console.WriteLine("Введите число  и мы узнаем сумму цифр числа");
int new_number = Convert.ToInt32(Console.ReadLine());

int sum_finder(int number)
{
    int sum = 0;

    while (number > 0) ;
    {
        sum = sum + number % 10;
        number = number / 10;

    }
    return sum;

}
Console.WriteLine($"Сумма цифр числа {new_number} = {sum_finder(new_number)}");