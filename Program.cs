using System;

namespace Exercicio_CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {
            string omitida= "#@$%*!&,";
            string frasedigitada, frasecensurada;
              
            Console.Write("Digite uma frase: ");
            frasedigitada = Console.ReadLine();
            
            frasecensurada = frasedigitada
            .Replace("chato", omitida)
            .Replace("chata ", omitida)
            .Replace("bobo", omitida)
            .Replace("boba", omitida) 
            .Replace("feio", omitida)
            .Replace("feia", omitida)
            .Replace("boboca", omitida)
            .Replace("bocó", omitida)
            .Replace("tonto", omitida)
            .Replace("tonta", omitida)
            .Replace("palerma", omitida)
            .Replace("paspalho", omitida)
            .Replace("paspalha", omitida)
            .Replace("tantã", omitida)
            .Replace("panaca", omitida)
            .Replace("pentelho", omitida)
            .Replace("pentelha", omitida)
            .Replace("burro", omitida)
            .Replace("burra", omitida)
            .Replace("besta", omitida);
        
            Console.ForegroundColor= ConsoleColor. DarkBlue;
            Console.WriteLine(frasecensurada);  
            Console.ResetColor();
        }
    }
}
