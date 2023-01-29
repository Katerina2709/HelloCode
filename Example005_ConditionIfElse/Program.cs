Console.Write("Enter username: ");
string username = Console.ReadLine();

if(username.ToLower() == "mary")
{
   Console.WriteLine("Hi, Mary");
}
else
{
   Console.Write("Hello, ");
   Console.WriteLine(username);
}

