#region  List Examples

List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);

Console.WriteLine("List of Numbers: ");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}
Console.WriteLine($"Tamanho, {numbers.Count()}");

#endregion