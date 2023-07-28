

/*int[] array2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

Console.WriteLine($"[{string.Join(",", array2)}]");

array2 = array2.Select(x => x + 5).ToArray();


Console.WriteLine($"[{string.Join(",", array2)}]");
foreach (int i in array2) //  пробегаемся по массиву и  делаем с элементами всякое 
{
    Console.WriteLine(i + 1);
}

*/
/*void array_input(int[] array)
{

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);

}
void release_array(int[] array) // Развертывание массива 
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}
Console.WriteLine("Введите кол-во элементов в массиве");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr1 = new int[n];
array_input(arr1);
Console.WriteLine($"[{string.Join(",", arr1)}]");

release_array(arr1);
Console.WriteLine($"[{string.Join(",", arr1)}]");

Console.WriteLine("Введите строны треугольника, а мы проверим может ли таков существовать");
int[] array_r = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if (array_r[0] <= array_r[1] + array_r[2] &&
   array_r[1] <= array_r[0] + array_r[2] &&
   array_r[2] <= array_r[0] + array_r[1])
    Console.WriteLine(" Да, может существовать");
else
    Console.WriteLine("Нет, такой треугольник не существует");

*/
// задача на перевод числа в двичную систему 
Console.WriteLine("Введите число для преобразования его в  двоичную систему");
int new_number = Convert.ToInt32(Console.ReadLine());
String res = String.Empty;
while (new_number > 0)
{
    res = Convert.ToString(new_number % 2) + res; //  Почему сюда рес  прибалвляем 
    new_number /= 2;
}
Console.WriteLine(res);
// Введите число переведем Фибоначи 
Console.WriteLine("Введите число для перевода в Фибоначи");
int fib_number = Convert.ToInt32(Console.ReadLine());
int n0 = 0;
int n1 = 1;
int n2 = 1;
for (int i = 0; i < fib_number; i++)
{
    Console.Write($"{n0}");
    n2 = n0 + n1;
    n0 = n1;
    n1 = n2;

}// Идет копирование и дублирования  массива 
Console.Clear();
Console.WriteLine("Введите массив");

int[] new_array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"[{String.Join(",", new_array)}]");
int[] copy_new_array = new int[new_array.Length];

for (int i = 0; i < copy_new_array.Length; i++)
{
    copy_new_array[i] = new_array[i];

}
Console.WriteLine($"[{String.Join(",", copy_new_array)}]");