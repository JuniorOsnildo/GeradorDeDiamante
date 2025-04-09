
using DiamondGenerator;


var num = 0;
bool validar = true;

while (validar)
{
    Console.Clear();
    Console.WriteLine("Digite um valor ímpar");
    num = int.Parse(Console.ReadLine() ?? "3");

    if (Diamante.ValidarNumero(num)) validar = false;

}
Console.Clear();
Diamante.Diamond(num);