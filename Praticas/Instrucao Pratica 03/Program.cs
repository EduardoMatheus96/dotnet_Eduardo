var estoque = new List<(int id, string name, int amount, decimal price)>{};

Dictionary<string, Action> menuSwitch = new Dictionary<string, Action> () {
    {"1", register},
    {"2", search},
    {"3", list},
    {"4", exit},
};

void register(){
    int id;
    int amount;
    string name;
    decimal price;

    try
    {
        Console.WriteLine("\n Cadastrar novo produto: ");
        Console.Write("ID: ");
        id = int.Parse(Console.ReadLine());

        Console.Write("Nome: ");
        name = Console.ReadLine();

        Console.Write("Quantidade: ");
        amount = int.Parse(Console.ReadLine());

        Console.Write("Preço: ");
        price = decimal.Parse(Console.ReadLine());

        estoque.Add((uuid, name, amount, price));
    }
    catch (FormatException)
        {
            Console.WriteLine("Erro: Entrada inválida. Certifique-se de inserir um valor numérico para aquantidade e preço.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    
};

void search(){
    Console.WriteLine("Informe o Codigo do produto que deseja encontrar: ");
    code = int.Parse(Console.ReadLine());
    
    try
    {
        var produto = estoque.Where(p => p.id == code).First();
    }
    
    catch (Exception ex)
    {        
        Console.Write("Codigo de produto nao encontrado!");
    }
    

    Console.WriteLine(produto);
}


void list(){
    foreach (var item in estoque)
    {
        Console.WriteLine(item);
    }
};

void exit(){
    Environment.Exit(0);
};

do
{
    Console.WriteLine("Selecione uma das seguintes opções: ");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Remover");
    Console.WriteLine("3 - Listar");
    Console.WriteLine("4 - Sair");

    var opcao = Console.ReadLine();

    try
    {
        menuSwitch[opcao]?.Invoke();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Opção Invalida. Digite um numero entre 1 e 4.");
    }

} while (true);

