namespace DiamondGenerator;

public class Diamante
{
    
    //VALIDA O VALOR DE ENTRADA
    public static bool ValidarNumero(int numero)
    {
        return numero % 2 != 0;
    }
    
    
    //ADICIONA CHARACTERES BRANCOS
    private static void AddBrancos(int branco)
    {
        for (int j = 0; j <= branco; j++)
        {
            Console.Write(" ");
        }
    }
    
    
    //GERA O DIAMANTE
    public static void GerarDiamante(int numero)
    {
        int medio = numero / 2;
        int branco = medio-1;
        String x = "x";
        
        for (int i = 0; i < numero; i++)
        {
            
            AddBrancos(branco);

            if (i < medio)
            {
                Console.Write(x);
                x += "xx";
                
            }else if (i == medio)
            {
                Console.Write(x);
            }
            else
            {
                x = x.Remove(x.Length - 1);
                x = x.Remove(x.Length - 1);
                Console.Write(x);
            }
            
            AddBrancos(branco);

            if (i < medio)
            {
                branco--;
            }
            else if (i >= medio)
            {
                branco++;
            }
            
            Console.WriteLine();
            
        }
        
    }
}