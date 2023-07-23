// See https://aka.ms/new-console-template for more information
// Программа  возводит А в степень B 
Console.WriteLine("Введите число А");
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

// Узнаем сумму введенного числа 
Console.WriteLine("Введите число  и мы узнаем сумму цифр числа");
int new_number = Convert.ToInt32(Console.ReadLine());

int sum_finder(int number)
{
    int sum = 0;


    while (number > 0)
    {
        sum = sum + number % 10; // я так понял здесь мы прибавляем остаток от деления 

        number = number / 10; // А это зачем делаем? Убиваем число что бы условие цикла было правильно?


    }
    return sum;

}
Console.WriteLine($"Сумма цифр числа {new_number} = {sum_finder(new_number)}");

// Пользователь создает массив из заданного числа элементов, вводит все в  режиме онлайн и вывод на экран.
int[] array = new int[8];
int array_number = 1; // счетчик элементов, да  начинается не с нуля это не правильно, но так понятнее=)
int counter = 8; // Счетчик  итерации.
for (int i = 0; i < array.Length; i++)

{
    Console.WriteLine($"Введите {array_number} элемент массива");
    array[i] = Convert.ToInt32(Console.ReadLine());//0
    array_number++;
    counter--;
    Console.WriteLine($"Осталось внести {counter}");
    Console.WriteLine($"[{string.Join(",", array)}]");


}