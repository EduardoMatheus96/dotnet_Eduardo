// #region Manipulação classe veiculo

// Veiculo gol = new Veiculo();

// gol.Modelo = "Gol";
// gol.Ano = "1993";
// gol.Cor = "Verde-Limao";

// Console.WriteLine($"{gol.Modelo}, {gol.Ano}, {gol.Cor}, Idade do Veiculo: {gol.IdadeVeiculo} anos");

// #endregion

// #region Exercicio 03

// ContaBancaria conta = new ContaBancaria();

// conta.Saldo = -20;
// #endregion

#region Exercicio 04
using exercicio01.Aluno;
using System.Globalization;
class Program{
    static void Main(string[] args){
        CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");
        Aluno aluno = new Aluno();
        aluno.mostrarAluno();
        
    }
}

#endregion