#region Example 01

string date = "25/10/2023";
string dia, mes, ano;
string[] subs = date.Split('/');
dia = subs[0];
mes = subs[1];
ano = subs[2];

Console.WriteLine("" + dia);
Console.WriteLine("" + mes);
Console.WriteLine("" + ano);

#endregion