// Console.WriteLine("--POTÊNCIA--");
// Console.WriteLine("Digite um inteiro: ");
// int numeroBase = Convert.ToInt32(Console.ReadLine());

// for(int i = 0; i < 10; i++){
//   Console.WriteLine($"{numeroBase} elevado a {i+1} = {Math.Pow(numeroBase, (i + 1))}");
// }

// int i = 0;
// while (i < 10) {
//   Console.WriteLine($"{numeroBase} elevado a {i+1} = {Math.Pow(numeroBase, (i + 1))}");
//   i++;
// }

// int soma = 0;
// int novoNumero = 0;
// Console.WriteLine("Digite os inteiros a serem somados. Quando estiver pronto, digite 0.");
// do {
//   novoNumero = Convert.ToInt32(Console.ReadLine());
//   soma += novoNumero;
// } while(novoNumero != 0);
// Console.WriteLine($"A soma é {soma}");

string opcao;
bool condicaoSaida = true;

while (condicaoSaida)
{
  Console.WriteLine("Digite a sua opção: ");
  Console.WriteLine("1 - Cadastrar Cliente");
  Console.WriteLine("2 - Buscar Cliente");
  Console.WriteLine("3 - Apagar Cleinte");
  Console.WriteLine("4 - Encerrar\n");

  opcao = Console.ReadLine();

  switch (opcao)
  {
    case "1":
      Console.WriteLine("Cadastro de Cliente\n");
      break;
    case "2":
      Console.WriteLine("Busca de Cliente\n");
      break;
    case "3": 
      Console.WriteLine("Apagar Cliente\n");
      break;
    case "4":
      Console.WriteLine("Operação encerrada\n");
      condicaoSaida = false;
      break;
    default:
      Console.WriteLine("Opção Inválida\n");
      break;    
  }
}

Console.WriteLine("flwwww");