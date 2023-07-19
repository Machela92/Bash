// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите первую кординату х1");
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
Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2))));