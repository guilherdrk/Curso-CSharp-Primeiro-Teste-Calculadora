Console.WriteLine("Seja Bem vindo a Calculadora");

do
{
    Console.WriteLine(" ");
    Console.WriteLine("Digite o primeiro valor: ");
    string? primeiroValorString = Console.ReadLine();
    double primeiroValor = Convert.ToDouble(primeiroValorString);
    Console.WriteLine("Digite o segundo valor: ");
    string? segundoValorString = Console.ReadLine();
    double segundoValor = Convert.ToDouble(segundoValorString);

    Console.WriteLine($"O valor digitado foi {primeiroValor} e o segundo foi {segundoValor}");




    Console.WriteLine("Selecione a operação");
    Console.WriteLine("+");
    Console.WriteLine("-");
    Console.WriteLine("*");
    Console.WriteLine("/");
    var operacaoSelecionada = Console.ReadLine();


    double? resultadoOperacao;
    switch (operacaoSelecionada)
    {   
        case "+":
            resultadoOperacao = primeiroValor + segundoValor;
            
            break;    
        case "-":
            resultadoOperacao = primeiroValor - segundoValor;
            
            break;
        case "*":
            resultadoOperacao = primeiroValor * segundoValor;
            
            break;
        case "/":
            resultadoOperacao = primeiroValor / segundoValor;
            
            break;
        default:
            resultadoOperacao = null;
            break;
 
    }
    Console.WriteLine(" ");
    // if(resultadoOperacao is null)
    //     Console.WriteLine($"Resultado da operação é: {resultadoOperacao}");
    // else
    //     Console.WriteLine("Operação invalida!");
    
    var mensagem = resultadoOperacao.HasValue ? $"Resultado da operação é: {resultadoOperacao}" :  "Operação invalida!";
    Console.WriteLine(mensagem);
    
    Console.WriteLine();
    Console.WriteLine("Deseja fazer outra ligação(S/N): ");
}while(Console.ReadKey().Key == ConsoleKey.S);

Console.WriteLine();
Console.WriteLine("Até logo!!");





Console.ReadKey();
