using System.Linq;
using System.Xml;

Console.WriteLine("Digite um inteiro: ");
int Inteiro = Convert.ToInt32(Console.ReadLine());

List<int> sequencia = new List<int> { 0, 1 };

bool Continua = true;

while (Continua)
{
    if (sequencia.Contains(Inteiro))
    {
        Console.WriteLine($"O valor {Inteiro} faz parte da sequencia de Fibonacci.");
        Continua = false;
    }

    int UltimoValorDaLista = sequencia.Last(); 
    int PenultimoValor = sequencia[sequencia.Count - 2];
    var NovoValor = UltimoValorDaLista + PenultimoValor;

    if (NovoValor == Inteiro)
    {
        Console.WriteLine($"O valor {NovoValor} faz parte da sequencia de Fibonacci.");
        Continua = false;
    }else if (NovoValor < Inteiro)
    {
        sequencia.Add(NovoValor);
    }
    else
    {
        Console.WriteLine($"O valor {Inteiro} não faz parte da sequencia de Fibonacci.");
        Continua = false;
    }
}


