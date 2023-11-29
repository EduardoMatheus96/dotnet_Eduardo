namespace exercicio01.Aluno
{
    public class Aluno
{
    string Nome { get; set; }
    int Idade { get; set; }

    public void mostrarAluno(){
        Console.WriteLine($"{this.Nome}, {this.Idade}");
        
    }
    public Aluno(){
        this.Nome = "José";
        this.Idade = 18;
    }
}
}

