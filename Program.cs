// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Say Something: ");
string? input = Console.ReadLine();

if(input == null) {
    Console.WriteLine("You didn't say anything");
}
else {
    Console.WriteLine($"You said: {input}");
}

