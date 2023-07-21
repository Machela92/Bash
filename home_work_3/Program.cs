// See https://aka.ms/new-console-template for more information

/*Console.WriteLine("Введите первую кординату х1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("x1 =" + x1);
Console.WriteLine("Введите вторую кординату х2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("x2 =" + x2);
Console.WriteLine("Введите первую кординату у1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y1 =" + y1);
Console.WriteLine("Введите вторую кординату у2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("У2 =" + y2);
Console.WriteLine("Введите первую кординату z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z1 =" + z1);
Console.WriteLine("Введите вторую кординату z2");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z2 =" + z2);
Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2))));*/

Console.WriteLine("Введите число в пределах от 10к до 99к");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 10000 || number > 99999)
{
    Console.WriteLine("Введите число в пределах от 10к до 99к");// Здесь мы до талого заставлем ввести то число которое задумали.
    number = Convert.ToInt32(Console.ReadLine());
}
void find_number(int num)
{
    int n1 = Convert.ToInt32(num / 10000);

    int n2 = Convert.ToInt32(num / 1000 % 10);

    int n3 = Convert.ToInt32(num / 100 % 10);

    int n4 = Convert.ToInt32(num / 10 % 10);

    int n5 = Convert.ToInt32(num % 10);
    if (n1 == n5 || n2 == n4)
    {
        Console.WriteLine("Yes");

    }
    else Console.WriteLine("No");
}
find_number(number);







/*void reverser(int num)


{
    int n1 = num / 10000;
    int n2 = num % 1000;
    int n3 = num / 100 % 10;
    int n4 = num % 100;
    int n5 = num % 10;

    Console.WriteLine(n1, n2, n3, n4, n5);


}
reverser(number);

*/