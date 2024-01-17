Console.WriteLine("Seja Bem vindo a Calculadora");
//Receber dois valores
//Solicitar dois valores para o usuario digitar
Console.WriteLine("Digite o primeiro valor: ");
string? primeiroValorString = Console.ReadLine();
double primeiroValor = Convert.ToDouble(primeiroValorString);
Console.WriteLine("Digite o segundo valor: ");
string? segundoValorString = Console.ReadLine();
double segundoValor = Convert.ToDouble(segundoValorString);

Console.WriteLine($"O valor digitado foi {primeiroValor} e o segundo foi {segundoValor}");


//Dar opções de calculo

Console.WriteLine("Selecione a operação");
Console.WriteLine("+");
Console.WriteLine("-");
Console.WriteLine("*");
Console.WriteLine("/");
var operacaoSelecionada = Console.ReadLine();

//Realizar o calculo

if(operacaoSelecionada == "+")
{
    var resultadoOperacao = primeiroValor + segundoValor;
    Console.WriteLine($"Resultado da operação é: {resultadoOperacao}");
}
else if(operacaoSelecionada == "-")
{
    var resultadoOperacao = primeiroValor - segundoValor;
    Console.WriteLine($"Resultado da operação é: {resultadoOperacao}");
}
else if(operacaoSelecionada == "*")
{
    var resultadoOperacao = primeiroValor * segundoValor;
    Console.WriteLine($"Resultado da operação é: {resultadoOperacao}");
}
else if(operacaoSelecionada == "/")
{
    var resultadoOperacao = primeiroValor / segundoValor;
    Console.WriteLine($"Resultado da operação é: {resultadoOperacao}");
}

//Exibir o resultado
//Finalizar a aplicação




Console.ReadKey();
