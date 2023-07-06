// See https://aka.ms/new-console-template for more information
Console.WriteLine("Кто там?");
string username = Console.ReadLine();
if (username.ToLower() == "герман")
{
    Console.WriteLine("О, Герман!");

}
else
{
    Console.WriteLine("Привет,я тебе не знаю,");
    Console.WriteLine(username);
}