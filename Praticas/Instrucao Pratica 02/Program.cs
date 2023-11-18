using System.Collections.Generic;
using System.Linq;

List<dynamic> createTask(string titleTask, string infoTask, string check, DateTime date)
{
    List<dynamic> task = new List<dynamic>();
    task.Add(titleTask);
    task.Add(infoTask);
    task.Add(check);
    // tratamento da data ...
    task.Add(date);
    return task;
}


List<List<dynamic>> ListOfTasks(List<dynamic> task)
{
    List<List<dynamic>> listTasks = new List<List<dynamic>>();
    listTasks.Add(task);
    return listTasks;
}

void viewListOfTasks(List<List<dynamic>> listTasks)
{
    var enumerateTasks = listTasks.Select((listTasks, index) => $"{index + 1}. {listTasks[0]} - {listTasks[1]} - {listTasks[2]} - {listTasks[3]}");
    foreach (var item in enumerateTasks)
    {
        Console.WriteLine(item);
    }

}

void changeTask(List<List<dynamic>> listTasks, int index)
{
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

void removeTaskOfList(List<List<dynamic>> listTasks, int index){
    if (index >= 1 && index <= listTasks.Count)
    {
        Console.WriteLine($"Tarefa atual: {listTasks[index - 1][0]}");

        // Modificando a tarefa na lista
        listTasks.RemoveAt(index - 1);

        Console.WriteLine("Tarefa removida com sucesso!");
    }
    else
    {
        Console.WriteLine("Índice inválido. Tarefa não encontrada.");
    }
}


string taskText, _switch, titleTask, inputDate;
DateTime date;
List<dynamic> task;
List<List<dynamic>> listTasks = new List<List<dynamic>>();
do
{
    Console.WriteLine("Insira uma nova tarefa: ");
    Console.Write("Titulo: ");
    titleTask = Console.ReadLine();
    Console.Write("Descrição: ");
    taskText = Console.ReadLine();
    Console.Write("Data: (dd/mm/aaaa)");
    inputDate = Console.ReadLine();
    date = DateTime.Parse(inputDate);

    task = createTask(titleTask, taskText, "[_]", date);
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

do
{
    Console.WriteLine("Digite o índice da tarefa para removê-la ou digite (sair) para sair: ");
    _switch = Console.ReadLine();
    // index = Convert.ToInt32(Console.ReadLine());
    if (!_switch.Equals("sair", StringComparison.OrdinalIgnoreCase))
    {
        removeTaskOfList(listTasks, int.Parse(_switch));
    }

} while (!_switch.Equals("sair", StringComparison.OrdinalIgnoreCase));

viewListOfTasks(listTasks);