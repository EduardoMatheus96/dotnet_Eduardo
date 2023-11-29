public class Relatorio
{
    List<Paciente> pacientes;
    List<Medico> medicos;

    public Relatorio(List<Paciente> pacientes, List<Medico> medicos)
    {
        this.pacientes = pacientes;
        this.medicos = medicos;
    }

    public void mostrarMedicosPorIdade(int idadeMinima, int idadeMaxima)
    {
        // Obtém o ano atual
        int anoAtual = DateTime.Now.Year;

        // Filtra os médicos com base na idade
        var medicosFiltrados = this.medicos.Where(medico =>
        {
            int anoNascimento = int.Parse(medico.DataDeNascimento.Split('/')[2]);
            int idade = anoAtual - anoNascimento;
            return idade >= idadeMinima && idade <= idadeMaxima;
        }).ToList();

        // Exibe os médicos filtrados
        Console.WriteLine($"Médicos com idade entre {idadeMinima} e {idadeMaxima} anos:");
        foreach (var medico in medicosFiltrados)
        {
            Console.WriteLine($"Nome: {medico.Nome}, Idade: {anoAtual - int.Parse(medico.DataDeNascimento)} anos, CPF: {medico.Cpf}, CRM: {medico.Crm}");
        }
    }

}
