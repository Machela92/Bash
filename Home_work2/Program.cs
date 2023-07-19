// See https://aka.ms/new-console-template for more information
/*int weekday = new Random().Next(1, 6);
Console.WriteLine(weekday);
if (weekday < 6)
    Console.WriteLine("Опять, работать?");
else
    Console.WriteLine("Ну все пора отсыпаться, выходные!");

*/
// Поиск второго числа и проверка на трехзначность, повторение вывод функции 
Console.WriteLine("Введите трехзначное число");
int sample_number = Convert.ToInt32(Console.ReadLine());
bool checking_number(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Вы ввели не трехзначное число");
        return false;
    }
    return true;
}

int look_for_third_number(int num)
{
    int third = num / 10 % 10;
    return third;
}
if (checking_number(sample_number))
    Console.WriteLine(look_for_third_number(sample_number));