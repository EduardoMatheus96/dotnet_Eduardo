#region ReadLine example

Console.WriteLine("Please enter your name:");
string? name = Console.ReadLine();
Console.WriteLine($"Hello {name}");

#endregion

#region foreach example
string [] colecao = {"item1", "item2", "item3", "item4"};

foreach (string item in colecao)
{
    // item = "alterando";
    Console.WriteLine(item);
}
#endregion

