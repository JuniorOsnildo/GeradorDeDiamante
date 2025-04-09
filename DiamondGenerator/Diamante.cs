namespace DiamondGenerator;

public class Diamante
{
    
    //VALIDA O VALOR DE ENTRADA
    public static bool ValidarNumero(int numero)
    {
        return numero % 2 != 0;
    }
    
    
    //GERA O DIAMANTE
    public static void Diamond(int numero)
    {
        int medio = numero / 2;
        int branco = medio-1;
        String x = "x";
        
        for (int i = 0; i < numero; i++)
        {
            
            for (int j = 0; j <= branco; j++)
            {
                Console.Write(" ");
            }

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
            
            for (int j = 0; j <= branco; j++)
            {
                Console.Write(" ");
            }

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