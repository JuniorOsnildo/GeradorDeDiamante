
using DiamondGenerator;

bool run = true;

while (run)
{
    bool validar = true;

    while (validar)
    {
        Console.Clear();
        Console.WriteLine("Digite um valor ímpar");
        var num = int.Parse(Console.ReadLine() ?? "3");

        if (Diamante.ValidarNumero(num)) validar = false;

    }

}