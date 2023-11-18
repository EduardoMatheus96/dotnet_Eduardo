using System.Collections.Generic;
using System.Linq;

List<string> createTask(string infoTask, string check)
{
    List<string> task = new List<string>();
    task.Add(infoTask);
    task.Add(check);
    return task;
}

List<List<string>> ListOfTasks(List<string> task)
{
    List<List<string>> listTasks = new List<List<string>>();
    listTasks.Add(task);
    return listTasks;
}

void viewListOfTasks(List<List<string>> listTasks)
{
    var enumerateTasks = listTasks.Select((listTasks, index) => $"{index + 1}. {listTasks[0]} - {listTasks[1]}");
    foreach (var item in enumerateTasks)
    {
        Console.WriteLine(item);
    }

}

static void changeTask(List<List<string>> listTasks, int index)
{
    int choice;
    Console.WriteLine("Digite 1 para alterar o texto e 0 para marcar como concluida a tarefa: ");
    choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        if (index >= 1 && index <= listTasks.Count)
        {
            Console.WriteLine($"Tarefa atual: {listTasks[index - 1][0]}");

            Console.WriteLine("Digite o novo texto da tarefa: ");
            string novoTexto = Console.ReadLine();

            // Modificando a tarefa na lista
            listTasks[index - 1][0] = novoTexto;

            Console.WriteLine("Tarefa modificada com sucesso!");
        }
        else
        {
            Console.WriteLine("Índice inválido. Tarefa não encontrada.");
        }
    } else {
        if (index >= 1 && index <= listTasks.Count)
        {
            Console.WriteLine($"Tarefa atual: {listTasks[index - 1][0]}");

            // Modificando a tarefa na lista
            listTasks[index - 1][1] = "[X]";

            Console.WriteLine("Tarefa modificada com sucesso!");
        }
        else
        {
            Console.WriteLine("Índice inválido. Tarefa não encontrada.");
        }
    }
}

string taskText, _switch;
List<string> task;
List<List<string>> listTasks = new List<List<string>>();
do
{
    Console.WriteLine("Insira uma nova tarefa: ");
    taskText = Console.ReadLine();
    task = createTask(taskText, "[_]");
    listTasks.AddRange(ListOfTasks(task));

    Console.WriteLine("Se voce nao deseja adicionar mais tarefa digite (sair): ");
    _switch = Console.ReadLine();


} while (!_switch.Equals("sair", StringComparison.OrdinalIgnoreCase));

viewListOfTasks(listTasks);
_switch = "";
int index;
do
{
    Console.WriteLine("Digite o indice da tarefa para altera-la ou digite (sair) para sair: ");
    _switch = Console.ReadLine();
    // index = Convert.ToInt32(Console.ReadLine());
    if (!_switch.Equals("sair", StringComparison.OrdinalIgnoreCase))
    {
        changeTask(listTasks, int.Parse(_switch));
    }

} while (!_switch.Equals("sair", StringComparison.OrdinalIgnoreCase));

viewListOfTasks(listTasks);