using TestesUnitarios.Desafio.Console.Services;


ValidacoesLista validacoes = new ValidacoesLista();

List<int> numeroLista = new List<int> { 2, 4, -6, 8 };

int oito = 8;

int maiorNumero = validacoes.RetornarMaiorNumeroLista(numeroLista);

List<int> removerNegativos = validacoes.RemoverNumerosNegativos(numeroLista);

bool contemDeterminadoNumero = validacoes.ListaContemDeterminadoNumero(numeroLista, oito);

List<int> multiplicaLista = validacoes.MultiplicarNumerosLista(numeroLista,oito);

int menorNumero = validacoes.RetornarMenorNumeroLista(numeroLista);

// Displaying the results
Console.WriteLine($"O maior número na lista é: {maiorNumero}");
Console.WriteLine("Os número positivos são: " + string.Join(",", removerNegativos));
Console.WriteLine($"O número {oito} está na lista?: {contemDeterminadoNumero}");
Console.WriteLine($"A lista foi multiplicada por {oito}, resultado é: "+ string.Join(",", multiplicaLista));
Console.WriteLine($"O menor número na lista é: {menorNumero}");
