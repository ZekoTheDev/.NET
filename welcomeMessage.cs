Console.WriteLine("Hi, What is your name?");
string name = Console.ReadLine();
Console.WriteLine("And how old are you ?");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Hello {name} you will be turning {age + 1} soon!");