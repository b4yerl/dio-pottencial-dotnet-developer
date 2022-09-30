using IntroCSharpII.Models;
using IntroCSharpII.Models.Extensions;
using System.Globalization;
using Newtonsoft.Json;

Random numero = new Random();
bool ehPar = false;

int numeroTeste = numero.Next(10);
ehPar = numeroTeste.EhPar();

Console.WriteLine($"O número {numeroTeste} é " + (ehPar ? "par" : "ímpar"));




/*
MeuArray<int> array = new MeuArray<int>();

array.AdicionarElementoArray(30);
Console.WriteLine(array[0]);
*/






/*
dynamic variavelDinamica = 1;

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = "Cruzeiro";
Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = true;
Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
*/

/*
string conteudoArquivo = File.ReadAllText("./Files/vendas.json");
List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

var listaAnonimo = listaVenda.Select(x => new {x.Produto, x.Preco});

foreach(var venda in listaAnonimo) {
  Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
}
*/

/*

var tipoAnonimo = new { Nome = "Guilherme", Sobrenome = "Bayerl", Altura = 1.73};

Console.WriteLine(tipoAnonimo.Nome);
Console.WriteLine(tipoAnonimo.Sobrenome);
Console.WriteLine(tipoAnonimo.Altura);

*/


/*
string conteudoArquivo = File.ReadAllText("./Files/vendas.json");
List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda) {
  Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
                    $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd-MM-yyyy")}, " + 
                    $"Desconto: {(venda.Desconto.HasValue ? $"{venda.Desconto.Value}" : "Sem desconto")}");
}

*/

/*
bool? desejaReceberEmail = null;

if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)  {
  Console.WriteLine("O usuário optou por recebver e-mail");
}
else {
  Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail");
}


*/




/*
string jogos2019 = File.ReadAllText("./Files/brasileirao19.json");
List<JogoBrasileirao> rodadasBr19 = JsonConvert.DeserializeObject<List<JogoBrasileirao>>(jogos2019);
int pontos = 0;
int[] resultados = {0, 0, 0};

foreach(JogoBrasileirao jogo in rodadasBr19) {
  if(jogo.HomeTeam == "Cruzeiro MG") {
    //Console.WriteLine($"Na {jogo.Round} o Cruzeiro " + ((jogo.Score.FullTime[0] > jogo.Score.FullTime[1]) ? "ganhou" : "perdeu pontos") + $"em casa contra o {jogo.AwayTeam}");
    if(jogo.Score.FullTime[0] > jogo.Score.FullTime[1]) {
      pontos += 3;
      resultados[0]++;
    }
    else if(jogo.Score.FullTime[0] == jogo.Score.FullTime[1]) {
      pontos += 1;
      resultados[1]++;
    }
    else {
      resultados[2]++;
    }
  }
  else if(jogo.AwayTeam == "Cruzeiro MG") {
    //Console.WriteLine($"Jogando fora de BH pela {jogo.Round} o Cruzeiro " + ((jogo.Score.FullTime[1] > jogo.Score.FullTime[0]) ? "ganhou" : "perdeu pontos") + $" do {jogo.HomeTeam}");
    if(jogo.Score.FullTime[0] < jogo.Score.FullTime[1]) {
      pontos += 3;
      resultados[0]++;
    }
    else if(jogo.Score.FullTime[0] == jogo.Score.FullTime[1]) {
      pontos += 1;
      resultados[1]++;
    }
    else {
      resultados[2]++;
    }
  }
}
Console.WriteLine($"No campeonato brasileiro de 2019, o Cruzeiro somou {pontos} pontos, sendo {resultados[0]} vitórias, {resultados[1]} empates e {resultados[2]} derrotas");

*/





/*
string conteudoArquivo = File.ReadAllText("./Files/vendas.json");
List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda) {
  Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
                    $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd-MM-yyyy")}");
}

*/








/*
List<Venda> listaDeVendas = new List<Venda>();
DateTime dataAtual = DateTime.Now;

Venda v1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

listaDeVendas.Add(v1);
listaDeVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaDeVendas, Formatting.Indented);

File.WriteAllText("./Files/vendas.json", serializado);

Console.WriteLine(serializado);
*/






/*
Random numero = new Random();
bool ehPar = false;

int numeroTeste = numero.Next(10);
ehPar = numeroTeste % 2 == 0;

Console.WriteLine($"O número {numeroTeste} é " + (ehPar ? "par" : "ímpar"));

*/

/*
if(numeroTeste % 2 == 0) {
  Console.WriteLine($"{numeroTeste} é par");
}
else {
  Console.WriteLine($"{numeroTeste} é ímpar");
}
*/






/*
Person p1 = new Person("Guilherme", "Bayerl");

(string nome, string sobrenome) = p1;

Console.Write($"{nome} {sobrenome}");
*/



/*
LeituraArquivo retornaTupla = new LeituraArquivo();
// (bool Resultado, string[] LinhasLidas, int NumeroLinhas) retornoDoMetodo = retornaTupla.LerArquivo("./Files/arquivoLeitura.txt");

// foreach(string linha in retornoDoMetodo.LinhasLidas) {
//   Console.WriteLine(linha);
// }
// Console.WriteLine($"Foram lidas e contabilizadas {retornoDoMetodo.NumeroLinhas} linhas");

var (sucesso, linhasArquivo, _) = retornaTupla.LerArquivo("./Files/arquivoLeitura.txt");
if (sucesso) {
  // Console.WriteLine($"Número de linhas lidas: {quantidadeDeLinhas}");
  foreach(string linha in linhasArquivo) {
    Console.WriteLine(linha);
  }
}
else {
  Console.WriteLine("Não foi possível realizar a operação");
}
*/



/*
(int Id, string Nome, string Sobrenome) tupla = (1, "Guilherme", "Bayerl");
ValueTuple<int, string, string> tnotb = (1982, "Iron Maiden", "The Number of the Beast");
var outroExemplo = Tuple.Create(2003, "Cruzeiro", "Triplice Coroa");

Console.WriteLine($"{tupla.Id}, {tupla.Nome} {tupla.Sobrenome.ToUpper()}");
*/



/*
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");
estados.Add("PR", "Paraná");

foreach(KeyValuePair<string, string> item in estados) {
  Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

*/



/*
//STACK
Stack<int> pilha = new Stack<int>();
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha) {
  Console.WriteLine(item);
}

Console.WriteLine($"--Removendo o elemento {pilha.Pop()}--");

pilha.Push(12);

foreach(int item in pilha) {
  Console.WriteLine(item);
}
*/

/*
//QUEUE
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila) {
  Console.WriteLine(item);
}

Console.WriteLine($"--Removendo o elemento {fila.Dequeue()}--");

foreach (int item in fila)
{
  Console.WriteLine(item);
}
*/


//new ExemploExcecao().Metodo1();



/*
try {
  string[] linhas = File.ReadAllLines("./Files/arquivoLeitura.txt");

foreach(string linha in linhas){
  Console.WriteLine(linha);
}
} catch(FileNotFoundException ex){
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo {ex.Message}");
}
catch(DirectoryNotFoundException ex){
    Console.WriteLine($"Caminho da pasta não encontrado {ex.Message}");
}
catch(Exception ex){
    Console.WriteLine($"Ocorreu uma exceção genérica {ex.Message}");
}

finally {
  Console.WriteLine("Chegou aqui");
}
*/



/*
//DateTime data = DateTime.Now;
string dataString = "27/10/1998 16:00";

if(DateTime.TryParseExact(dataString, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data)) {
  Console.WriteLine(data);
}
else {
  Console.WriteLine("Não foi possível realizar a conversão");
}
// DateTime data = DateTime.Parse(dataString);
//Console.WriteLine(data);
*/




/*
//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 8205.40M;

//Console.WriteLine(valorMonetario.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(valorMonetario.ToString("C2"));
Console.WriteLine(valorMonetario.ToString("N4"));

double porcentagem = .1921;
Console.WriteLine(porcentagem.ToString("P"));

double testeTelefone = 12349876;
Console.WriteLine(testeTelefone.ToString("####-####"));
*/

/*
int valor1 = 10;
int valor2 = 20;
string valor3 = "30";

string valorFinal = valor1 + (valor2 + valor3);

Console.WriteLine(valorFinal);
*/


/*
Person pessoa1 = new Person("Guilherme", "Bayerl");

Person pessoa2 = new Person("Eduardo", "Bayerl");

Course cursoCSharp = new Course();
cursoCSharp.Name = "C#";
cursoCSharp.AllStudents = new List<Person>();

cursoCSharp.AddStudent(pessoa1);
cursoCSharp.AddStudent(pessoa2);

//Console.WriteLine(cursoCSharp.CountStudents());

cursoCSharp.ListStudents();
// cursoCSharp.RemoveStudent(pessoa1);
// cursoCSharp.ListStudents();

// Console.WriteLine("Pressione uma tecla para encerrar o programa");
// Console.ReadLine();

*/