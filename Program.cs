using helloworld.classes;

Console.WriteLine("Hello! Who are you?");

string user;
user = Console.ReadLine();

Console.WriteLine($"Hello, {user}");
Console.WriteLine("Thanks to my Dad for helping me write this!");
Console.WriteLine("Best Regards, author.");


MathCalc ourSuperCalc = new MathCalc();
int result = ourSuperCalc.add(9, 10);
Console.WriteLine($"Performing operation 'ourSuperCalc.add...' {result}");
Console.WriteLine("19 is supposed to appear above. If it doesn't, then something is wrong.");