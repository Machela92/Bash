// See https://aka.ms/new-console-template for more information
int weekday = new Random().Next(1, 6);
Console.WriteLine(weekday);
if (weekday < 6)
    Console.WriteLine("Опять, работать?");
else
    Console.WriteLine("Ну все пора отсыпаться, выходные!");
