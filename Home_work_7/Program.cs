// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите параметры матрицы");
void double_array(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //Math.Round(new Random().NextDouble() * 100, 2);
            array[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
            Console.Write($"{array[i, j]} \t");

        }
        Console.WriteLine();
    }
}

void normal_array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //Math.Round(new Random().NextDouble() * 100, 2);
            array[i, j] = new Random().Next(10, 100);
            Console.Write($"{array[i, j]} \t");

        }
        Console.WriteLine();
    }
}

void normal_array_2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //Math.Round(new Random().NextDouble() * 100, 2);
            array[i, j] = new Random().Next(1, 9);
            Console.Write($"{array[i, j]} \t");

        }
        Console.WriteLine();
    }
}

void search(int[,] array, int m, int n)
{
    if (m > array.GetLength(0) || n > array.GetLength(1))
    {
        Console.WriteLine("Данный элемент отсутсвует в матрице");
    }
    else
    {
        Console.WriteLine($"По координате {m}  и по Координате {n} равно {array[m - 1, n - 1]} ");
    }
}

void math(int[,] array)
{

    double average = 0;
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            //Math.Round(new Random().NextDouble() * 100, 2);
            sum = (sum + array[i, j]);
            average = Math.Round(sum / array.GetLength(1), 2);



        }

        Console.WriteLine($"{average}");


    }

}

int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[array[0], array[1]];
double_array(matrix);
Console.WriteLine("Введите параметры другой матрицы");
int[] array_2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix_2 = new int[array_2[0], array_2[1]];
normal_array(matrix_2);
Console.WriteLine(" Введите первую координату");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату");
int y = Convert.ToInt32(Console.ReadLine());
search(matrix_2, x, y);
Console.WriteLine("Введите размеры 3 матрицы");
int[] array_3 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix_3 = new int[array_3[0], array_3[1]];
normal_array(matrix_3);
math(matrix_3);


