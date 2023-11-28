#region Funções Lambda

string[] people = { "Helder", "Eduardo", "Matheus", "Clara", "Naldo" };
char letter = 'a';
Console.WriteLine($"People with name contains with '{letter}': {string.Join(", ", people.Where(x => x.Contains(letter)))}");

#endregion