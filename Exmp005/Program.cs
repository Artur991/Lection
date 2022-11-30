Console.Write("User name:");
string username = Console.ReadLine();

if (username.ToLower() == "artur")
{ 
    Console.WriteLine("Yes? this is Artur");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}