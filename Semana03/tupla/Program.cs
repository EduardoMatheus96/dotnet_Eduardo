#region 

using System.Globalization;
CultureInfo CultureInfo = CultureInfo.CreateSpecificCulture("pt-BR");

var tuple = (id: 1, name: "Eduardo", born: new DateTime(1996,05,08));
List<(int id, string name, DateTime born)> list = new();
list.Add(tuple);
list.Add((2, "Matheus", new DateTime(1990,04,27)));
list.ForEach(
    x => Console.WriteLine($"Tuple: {x.id}, {x.name}, {x.born.ToShortDateString()}")
    );

#endregion