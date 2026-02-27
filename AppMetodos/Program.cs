//Aula 3

//Método Sem Retorno (void)
void ExibirMensagem()
{
    Console.WriteLine("Olá! Seja bem-vindo ao programa.");
}
ExibirMensagem(); // Chamando o método




//Método com Retorno (int)
//int Somar(int a, int b)
//{
//    return a + b;
//}
//int resultado = Somar(5, 7);
//Console.WriteLine("A soma é: " + resultado);




////Método com Parâmetros (string)
//void Saudacao(string nome)
//{
//    Console.WriteLine($"Olá, {nome}! Como você está?");
//}
//Saudacao("Ana"); // Chamando o método e passando um nome




////Função que Retorna um Valor Booleano (bool)
//bool EhPar(int numero)
//{
//    return numero % 2 == 0;
//}
//int num = 8;
//if (EhPar(num))
//{
//    Console.WriteLine($"{num} é um número par.");
//}
//else
//{
//    Console.WriteLine($"{num} é um número ímpar.");
//}




////Método Usando Estrutura de Repetição (for)
//void ExibirTabuada(int numero)
//{
//    Console.WriteLine($"Tabuada do {numero}:");
//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine($"{numero} x {i} = {numero * i}");
//    }
//}

//ExibirTabuada(5); // Chamando o método para mostrar a tabuada do 5




////Método Usando Estrutura de Controle (if/else)
//void VerificarNumero(int numero)
//{
//    if (numero > 0)
//    {
//        Console.WriteLine("O número é positivo.");
//    }
//    else if (numero < 0)
//    {
//        Console.WriteLine("O número é negativo.");
//    }
//    else
//    {
//        Console.WriteLine("O número é zero.");
//    }
//}

//VerificarNumero(-3); // Testando com um número negativo






////lsita de Tarefas - Usando while e List<>
//List<string> tarefas = new List<string>();
//string tarefa;
//string continuar = "s";

//while (continuar.ToLower() == "s")
//{
//    Console.Write("Digite uma tarefa para adicionar à lista: ");
//    tarefa = Console.ReadLine();
//    tarefas.Add(tarefa); // Adiciona a tarefa na lista

//    Console.Write("Deseja adicionar outra tarefa? (s/n): ");
//    continuar = Console.ReadLine();
//}

//ExibirTarefas(tarefas);

//static void ExibirTarefas(List<string> lista)
//{
//    Console.WriteLine("\nLista de Tarefas:");
//    foreach (var tarefa in lista)
//    {
//        Console.WriteLine($"- {tarefa}");
//    }
//}





////solicita ao usuários varios números para realizar a soma
//List<int> numeros = new List<int>();
//int numero;
//do
//{
//    Console.Write("Digite um número para a soma (0 para sair): ");
//    numero = int.Parse(Console.ReadLine());

//    if (numero != 0)
//    {
//        numeros.Add(numero);
//    }

//} while (numero != 0);

//Console.WriteLine("Total é: " + ExibirNumerosESoma(numeros));

//int ExibirNumerosESoma(List<int> lista)
//{
//    int soma = 0;
//    Console.WriteLine("\nNúmeros digitados:");

//    foreach (var num in lista)
//    {
//        Console.WriteLine(num);
//        soma += num;
//    }

//    return soma;
//}

