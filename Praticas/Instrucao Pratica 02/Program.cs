using System.Collections.Generic;
using System.Linq;

List<dynamic> createTask(string titleTask, string infoTask, string check, DateTime date, DateTime now)
{
    List<dynamic> task = new List<dynamic>();
    task.Add(titleTask);
    task.Add(infoTask);
    task.Add(check);
    // tratamento da data ...
    task.Add(date);
    task.Add(now);
    return task;
}


List<List<dynamic>> ListOfTasks(List<dynamic> task)
{
    List<List<dynamic>> listTasks = new List<List<dynamic>>();
    listTasks.Add(task);
    return listTasks;
}

void viewAllListOfTasks(List<List<dynamic>> listTasks)
{
    var enumerateTasks = listTasks.Select((listTasks, index) => $"{index + 1}. {listTasks[0]} - {listTasks[1]} - {listTasks[2]} - {listTasks[3]}");
    foreach (var item in enumerateTasks)
    {
        Console.WriteLine(item);
    }
}

void viewOnlyTaksNotFinished(List<List<dynamic>> listTasks)
{
    var filteredTasks = listTasks
        .Where(task => task.Count >= 3 && task[2].Equals("[_]", StringComparison.OrdinalIgnoreCase))
        .Select((task, index) => $"{index + 1}. {task[0]} - {task[1]} - {task[2]} - {task[3]}");

    foreach (var item in filteredTasks)
    {
        Console.WriteLine(item);
    }
}

void viewOnlyTaksFinished(List<List<dynamic>> listTasks)
{
    var filteredTasks = listTasks
        .Where(task => task.Count >= 3 && task[2].Equals("[X]", StringComparison.OrdinalIgnoreCase))
        .Select((task, index) => $"{index + 1}. {task[0]} - {task[1]} - {task[2]} - {task[3]}");

    foreach (var item in filteredTasks)
    {
        Console.WriteLine(item);
    }
}

void viewSearchTasks(List<List<dynamic>> listTasks, string search)
{
    var filteredTasks = listTasks
        .Where(task => task.Count >= 3 && task[1].Contains(search))
        .Select((task, index) => $"{index + 1}. {task[0]} - {task[1]} - {task[2]} - {task[3]}");

    foreach (var item in filteredTasks)
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
        listTasks[index - 1][2] = "[X]";

        Console.WriteLine("Tarefa modificada com sucesso!");
    }
    else
    {
        Console.WriteLine("Índice inválido. Tarefa não encontrada.");
    }
}

void removeTaskOfList(List<List<dynamic>> listTasks, int index)
{
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

void DisplayTaskStatistics(List<List<dynamic>> listTasks)
    {
        // Número de tarefas concluídas e pendentes
        int completedTasks = listTasks.Count(task => task[2] == "[X]");
        int pendingTasks = listTasks.Count(task => task[2] == "[_]");

        // Tarefa mais antiga e tarefa mais recente
        var oldestTask = listTasks.OrderBy(task => task[4]).FirstOrDefault();
        var newestTask = listTasks.OrderByDescending(task => task[4]).FirstOrDefault();

        // Exibição das estatísticas
        Console.WriteLine($"Número de Tarefas Concluídas: {completedTasks}");
        Console.WriteLine($"Número de Tarefas Pendentes: {pendingTasks}");

        if (oldestTask != null)
        {
            Console.WriteLine($"Tarefa Mais Antiga: {oldestTask[0]} - {oldestTask[4]}");
        }

        if (newestTask != null)
        {
            Console.WriteLine($"Tarefa Mais Recente: {newestTask[0]} - {newestTask[4]}");
        }
    }


void menu(){
    string taskText, _switch, titleTask, inputDate;
    DateTime date, now;
    List<dynamic> task;
    List<List<dynamic>> listTasks = new List<List<dynamic>>();
    string choice;
    do
    {
        Console.WriteLine("Menu da Lista de Tarefas: ");
        Console.WriteLine("1) Criar a lista de Tarefas: ");
        Console.WriteLine("2) Listas todas las tarefas: ");
        Console.WriteLine("3) Marcar tarefa como concluida pelo Index: ");
        Console.WriteLine("4) Listar tarefas pendentes: ");
        Console.WriteLine("5) Listar tarefas concluidas: ");
        Console.WriteLine("6) Excluir tarefa: ");
        Console.WriteLine("7) Procurar tarefa por palavra chave: ");
        Console.WriteLine("8) Mostrar estatisticas: ");
        Console.WriteLine("De um ENTER para SAIR do Programa !!!");
        choice = Console.ReadLine();

        switch (choice)
            {
                case "1":
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

                            now = DateTime.Now;
                            task = createTask(titleTask, taskText, "[_]", date, now);
                            listTasks.AddRange(ListOfTasks(task));

                            Console.WriteLine("Se voce nao deseja adicionar mais tarefa digite (sair): ");
                            _switch = Console.ReadLine();

                        } while (!_switch.Equals("sair", StringComparison.OrdinalIgnoreCase));
                    break;
                case "2":
                    viewAllListOfTasks(listTasks);
                    break;
                case "3":
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
                    break;
                case "4":
                    Console.WriteLine("Tarefas nao terminadas !!!:");
                    viewOnlyTaksNotFinished(listTasks);
                    break;
                case "5":
                    Console.WriteLine("Tarefas terminadas !!!:");
                    viewOnlyTaksFinished(listTasks);
                    break;
                case "6":
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
                    break;
                case "7":
                    Console.Write("Faça uma busca personalizada com palavra chaves nas listas: ");
                    string search = Console.ReadLine();
                    viewSearchTasks(listTasks, search);
                    break;
                case "8":
                    DisplayTaskStatistics(listTasks);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

    } while (choice != string.Empty);
}



menu();
