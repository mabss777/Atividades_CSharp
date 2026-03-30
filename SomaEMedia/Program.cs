using static System.Console;
using System.Linq;

public class SomaEMedia
{
    
    public static double Soma(List<double> numeros)
    {
        double soma=0;
        foreach (double numero in numeros)
        {
           soma = soma + numero; 
          
        }
        return soma;

    }

    public static double Media(List<double> numeros){
        double soma=0;
        foreach (double numero in numeros)
        {
           soma = soma + numero; 
          
        }
        return soma/numeros.Count(); 
    }
    
    public static void Main(string[] args)
    {
        
        List<double> numeros = new();
        double quantidade = 0;
        
        Console.WriteLine("Qual será a quantidade de números a ser informada? (De 3 a 10 números)");
        quantidade = double.Parse(Console.ReadLine());

        for(int i = 0; i < quantidade; i++)
        {
            WriteLine($"Digite o {i+1}° número: ");
            numeros.Add(double.Parse(Console.ReadLine()));
        }


        Console.WriteLine("Soma: "+Soma(numeros));
        Console.WriteLine("Média: "+Media(numeros));

        
        /*static void Somar()
        {
            foreach (double numero in num)
            {
                double soma = num.Sum();
                return;
            }
        }

        Console.WriteLine("Qual será a quantidade de números a ser informada? (De 3 a 10 números)");
        int quantidade = int.Parse(ReadLine());

        double[] num = new double[quantidade];

        for(int i = 0; i < quantidade; i++)
        {
            WriteLine($"Digite o {i+1}° número: ");
            num[i] = double.Parse(ReadLine());
        }

        int soma = Somar();
        Console.WriteLine("O resultado da soma destes números é: ");
*/



    }
}