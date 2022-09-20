// int a = 2;
// int b = 3;
// int c = a + b;

// for(int i = 0; i < b; i++) {
//   Console.WriteLine(c *= a);
// }

//AULA 3

// A principal diferença entre Convert e Parse está
// na aceitação de valores nulos
// int a = Convert.ToInt32("5");
// int a = int.Parse("5");

// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);

// int a = 5;
// double b = a;
// Console.WriteLine(b);

/* 
---------------------------------------------
  OPERADORES CONDICIONAIS
---------------------------------------------
*/

/* int quantidadeEstoque = 10;
int quantidadeCompra = 4;

if (quantidadeEstoque >= quantidadeCompra) {
  Console.WriteLine("Compra realizada com sucesso");
  quantidadeEstoque -= quantidadeCompra;
}

else {
  Console.WriteLine("Desculpa, não temos essa quantidade disponível no estoque");
}

Console.WriteLine($"Restam ainda {quantidadeEstoque} unidades no estoque");

return 0; */
/*
Console.WriteLine("Você deseja calcular o seu IMC? (y/n)");
string escolha = Console.ReadLine();

if (escolha == "y") {
  double peso = 0;
  double altura = 0;
  double imc = 0;

  Console.WriteLine("Insira o seu peso: ");
  peso = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Insira a sua altura: ");
  altura = Convert.ToDouble(Console.ReadLine());

  imc = peso / (altura * altura);
  imc = Math.Round(imc, 2);
  Console.WriteLine($"O seu IMC é {imc}");
  return 0;
}
else {
  return 0;
}*/
/*
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
  case "a":
  case "e":
  case "i":
  case "o":
  case "u":
    Console.WriteLine("Vogal");
    break;
  default: 
    Console.WriteLine("Não é uma vogal");
    break;
}*/

