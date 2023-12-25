using TestesUnitarios.Desafio.Console.Services;


ValidacoesLista validacoes = new ValidacoesLista();
ValidacoesString validacaoString = new ValidacoesString();

List<int> numeroLista = new List<int> { 2, 4, -6, 8 };
string palavras = "um texto especifico";
string especificoTexto = "texto";
string especifico2 = "especifico";
var oito = 8;

int quantidadeCaracters = validacaoString.RetornarQuantidadeCaracteres(palavras);

bool contemPalavra = validacaoString.ContemCaractere(palavras, especificoTexto);

var terminaComPalavra = validacaoString.TextoTerminaCom(palavras, especifico2);

int maiorNumero = validacoes.RetornarMaiorNumeroLista(numeroLista);

List<int> removerNegativos = validacoes.RemoverNumerosNegativos(numeroLista);

bool contemDeterminadoNumero = validacoes.ListaContemDeterminadoNumero(numeroLista, oito);

List<int> multiplicaLista = validacoes.MultiplicarNumerosLista(numeroLista,oito);

int menorNumero = validacoes.RetornarMenorNumeroLista(numeroLista);

// Displaying the results
Console.WriteLine($"O maior número na lista é: {maiorNumero}");
Console.WriteLine("Os número positivos são: " + string.Join(",", removerNegativos));
Console.WriteLine($"O número {oito} está na lista?: {contemDeterminadoNumero}");
Console.WriteLine("A lista foi multiplicada por {oito}, resultado é: "+ string.Join(",", multiplicaLista));
Console.WriteLine($"O menor número na lista é: {menorNumero}");
