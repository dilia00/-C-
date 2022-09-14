
Console.Write("Введите свое имя ");
string username = Console.ReadLine();
if (username.ToLower() == "дина")
{
    Console.WriteLine("О! Да это же Дина!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.Write("!");
}