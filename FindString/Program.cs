Console.WriteLine("Digite alguma palavara: ");
string? String = Console.ReadLine();
char letra = 'a';
int Cont = 0;

if (String.ToLower().Contains(letra))
{
    foreach (var i in String)
    {
        if (i == letra)
        {
            Cont++;
        }
    }
    Console.WriteLine($"A letra 'a' aparece {Cont} vezes na string {String}.");
}
else
{
    Console.WriteLine($"A letra 'a' não aparece na string {String}");
}

