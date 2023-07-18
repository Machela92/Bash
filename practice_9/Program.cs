// See https://aka.ms/new-console-template for more information
//Console.Write("Введите число");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[n]; // Здесь мы прописываем длину массива
//for (int i = 0; i < array.Length; i++) // Пробигаемся по миссиву 
//   array[i] = new Random().Next(-10, 11); // Рандомно берет от - 10 до 10
//Console.WriteLine($"{String.Join(",", array)}");



int f(int b)
{
    int n1 = b / 10; // находит первое число 
    int n2 = b % 10; // находит второе число
    if (n1 > n2)
        return n1;
    return n2;
}
int b = new Random().Next(10, 100);// Генерирует цифру от с 10 до 99 
Console.WriteLine(b);
Console.WriteLine(f(b));

// Принимает рандомно 3х значное число и вывдит только первое и  последнее 
int c = new Random().Next(10, 1000); //10 999
Console.WriteLine(c);
int f2(int number)
{
    int c1 = c / 100;
    int c3 = c % 10;
    return
      c1 * 10 + c3; // Так мы обходим 2 число 
}
Console.WriteLine(f2(c));
// Определяем кратно ли первое число второму типа делаиться без остатка =) 

Console.WriteLine("Введите первое число!");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше первое число" + " " + first);
Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше второе число" + " " + second);
int result = first % second;
if (result == 0)

    Console.WriteLine("Делиться без остатка!" + "" + result);


else Console.WriteLine("Есть остатоК!" + " " + result);

Console.WriteLine("Проверяем кратное ли ваше число 7 и 23, введите его");
int sample = Convert.ToInt32(Console.ReadLine());
if (sample % 7 == 0 && sample % 23 == 0)
    Console.WriteLine("Делиться");
else Console.WriteLine("Есть остаток");


// Проверяем является ли число квадратом другого числа. 
Console.WriteLine("Проеверяем явдяется ли число квадротом другого числа");
Console.WriteLine("Введите первое число!");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше первое число" + " " + num1);
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше второе число" + " " + num2);
if (num1 * num1 == num2 || num2 * num2 == num1)

    Console.WriteLine("является");
else Console.WriteLine("не является");