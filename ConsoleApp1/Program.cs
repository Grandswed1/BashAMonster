//Questionable Good Guy
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;

Zero man = new Zero() 
{
    Name = "Rocker",
    Hitpoints = 100
};

Console.WriteLine("You stand infront of Charles, you have a secret weapon to defeat him. USE IT! (Press eny key to use it)");
Console.ReadLine();

//Bad Guy
BadGuy bad = new BadGuy()
{
    Name = "Charles",
    Hitpoints = 500
};


Console.WriteLine("I COMMAND YOU TO DIE!");
bad.Hitpoints -= 499;
Console.WriteLine("Press any key to advance");
Console.ReadLine();

Console.WriteLine($"{bad.Name} now has {bad.Hitpoints} health remaining");
Console.WriteLine("Oops it seems he was immortal. You will have to find another way to end his life");
Console.WriteLine("He has regained his health");
bad.Hitpoints += 499;
Console.WriteLine($"{bad.Name} now has {bad.Hitpoints} health remaining");
Console.ReadLine();




