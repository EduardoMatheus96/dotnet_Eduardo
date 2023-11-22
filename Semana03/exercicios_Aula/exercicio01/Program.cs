#region Example 01

double numero;
Console.WriteLine("Insira um número");

try
{
    numero = Convert.ToDouble(Console.ReadLine());
}
catch (FormatException ex)
{
    Console.WriteLine("You need insert a number!!!");
}
catch (Exception ex){
    Console.WriteLine(ex.Message);
}
finally{
    Console.WriteLine("Finally block executed");
}

Console.WriteLine("Terminou");

#endregion