Console.Write("Please enter your name: ");
string name = Console.ReadLine() ?? "Stranger";
Console.WriteLine($"Hello, {name}!");
Console.Write($"Please enter your age: ");
string ageInput = Console.ReadLine() ?? "";

try
{
    int age = int.Parse(ageInput);
    double marsAge = age / 1.88;
    Console.WriteLine($"You are {marsAge:F0} years old on Mars! How cool is that?");
}
catch (FormatException err)
{
    Console.WriteLine($"Please enter in a number: {err.Message}");
}