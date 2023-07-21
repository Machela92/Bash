// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Введите число не менее 100");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ваше число : {Number}");


if (Number < 100)

    Console.WriteLine($"Число {Number} не содержит 3 числа");
else
{
    while (Number > 1000)
        Number = Number / 10;
    Console.WriteLine(Number % 10);
}
*/
// Пишем число и находим сумму  от 1 до а
Console.WriteLine("Введите число ");
double n = Convert.ToDouble(Console.ReadLine());

double f(double n)
{
    return (1 + n) / 2 * n; // Каим то образом считает = типа формула арфиметической прогрессии
}
Console.WriteLine(f(n));

Console.WriteLine("Введите число ");
int Num = Convert.ToInt32(Console.ReadLine());
int number_counter(int number)
{
    int count = 0;
    while (number > 0) // Пока число больше 10  
    {
        number /= 10; // Мы его делим  пока оно больше 0 
        count++; // Счетчик который считает кол-во цифр путем  пока число делиться 10
    }
    return count;
}
Console.WriteLine(number_counter(Num));
