using System.Collections.Generic;

string nome;
int opcao;

List<string> clientes = new List<string> { "Hugo", "Carlos", "Claudia" };

Console.Write("Bem vindo ao Banco! Por favor, informe seu nome: ");
nome = Console.ReadLine() ?? "";

do 
{
    opcao = ExibirMenu();
    CanalSelecionado(opcao, nome, clientes); 
}
while (opcao != 4);

// ----------------------------------------------------

static int ExibirMenu()
{   
    int opcaoLocal;
    Console.Clear();
    // ... (Seu código visual do menu está perfeito, mantive oculto pra economizar espaço)
    Console.WriteLine("======= MENU =======");
    Console.WriteLine("1-Plano, 2-Suporte, 3-Financeiro, 4-Sair, 5-Listar, 6-Cadastrar, 7-Remover");
    Console.Write("Opção: ");

    while(!int.TryParse(Console.ReadLine(), out opcaoLocal) || opcaoLocal < 0)
    {
        Console.WriteLine("Inválido.");
        Console.Write("Opção: ");
    }
    return opcaoLocal;
}

static void CanalSelecionado(int opcao, string nome, List<string> clientes)
{
    switch(opcao)
    {
        case 1:
            ContratarPlano(); // <--- Sintaxe correta: NomeDoMetodo();
            break;
        case 2:
            SuporteTecnico();
            break;
        case 3:
            Financeiro();
            break;
        case 4:
            Sair(nome);
            break; 
        case 5:
            ListarClientes(clientes); // Passamos a lista pro especialista
            break;
        case 6:
            CadastrarNovo(clientes); // Passamos a lista pro especialista
            break;
        case 7:
            RemoverCliente(clientes); // Passamos a lista pro especialista
            break;
        default:
            Console.WriteLine("Opção não disponível.");
            break;
    }

    if (opcao != 4)
    {
        Console.WriteLine("\nPressione qualquer tecla para voltar...");
        Console.ReadKey();
    }
}

// CORREÇÃO 1: Nada de 'function'. É 'static void'.
static void ContratarPlano()
{
    Console.WriteLine("Redirecionando para setor de vendas...");
}

static void SuporteTecnico()
{
    Console.WriteLine("Enviando e-mail para suporte@dev.com...");
}

static void Financeiro()
{
    Console.WriteLine("Consultando faturas em aberto...");
}

static void Sair(string nome)
{
    Console.WriteLine($"Encerrando aplicação. Tchau! [{nome}]");
}

// CORREÇÃO 2: Recebe a lista e faz o trabalho todo
static void ListarClientes(List<string> lista)
{
    Console.WriteLine("=== LISTA DE CLIENTES ===");     
    if (lista.Count == 0)
    {
        Console.WriteLine("Nenhum cliente cadastrado.");
    }
    else
    {
        int contador = 1;
        foreach (string cliente in lista)
        {
            Console.WriteLine($"Cliente nº {contador}: {cliente}");
            contador++;
        }
    }
}

// CORREÇÃO 3: Void. Ele não retorna o nome pro chefe. Ele mesmo salva na lista.
static void CadastrarNovo(List<string> lista)
{
    Console.WriteLine("=== CADASTRO DE CLIENTE ===");
    Console.Write("Digite o nome do novo cliente: ");
    string inputNome = Console.ReadLine() ?? "";
    
    if (inputNome.Trim() != "") 
    {
        lista.Add(inputNome); // O método adiciona diretamente
        Console.WriteLine("Cliente cadastrado com sucesso!");
    }
    else
    {
        Console.WriteLine("Erro: Nome não pode ser vazio. Nada foi feito.");
    }
}

// CORREÇÃO 4: Void. Ele mesmo remove e avisa.
static void RemoverCliente(List<string> lista)
{
    Console.WriteLine("=== REMOVER CLIENTE ===");
    Console.Write("Informe o nome exato para remover: ");
    string inputNome = Console.ReadLine() ?? "";

    bool removeu = lista.Remove(inputNome);

    if (removeu)
    {
        Console.WriteLine($"Sucesso! '{inputNome}' foi removido.");
        Console.WriteLine($"Restam {lista.Count} clientes.");
    }
    else
    {
        Console.WriteLine($"ERRO: Cliente '{inputNome}' não encontrado.");
    }
}