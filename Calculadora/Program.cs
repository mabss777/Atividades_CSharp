using static System.Console;

public class Calculadora
{
    public static void Main(string[] args)
    {
        int op = 0;
        int num1=0, num2=0;
        do
        {
            Console.WriteLine("\nDigite a operação desejada: \n=================\n 1- Somar\n 2- Subtrair\n 3- Multiplicar\n 4- Dividir\n 0- Sair");
            op = Convert.ToInt32(ReadLine());
            
            switch(op)
            {
                case 0:
                    return;
                    break;
                
                case 1:
                
            Console.WriteLine("Digite o 1° número: ");
             num1 = Convert.ToInt32(ReadLine());

            Console.WriteLine("Digite o 2° número: ");
             num2 = Convert.ToInt32(ReadLine());
                    int soma = Somar(num1, num2);
                    Console.WriteLine("O resultado da soma foi: "+soma);
                    break;
                
                case 2:
                
            Console.WriteLine("Digite o 1° número: ");
             num1 = Convert.ToInt32(ReadLine());

            Console.WriteLine("Digite o 2° número: ");
             num2 = Convert.ToInt32(ReadLine());
                    int subtrair = Subtrair(num1, num2);
                    Console.WriteLine("O resultado da subtração foi: "+subtrair);
                    break;
                
                case 3:
                
            Console.WriteLine("Digite o 1° número: ");
             num1 = Convert.ToInt32(ReadLine());

            Console.WriteLine("Digite o 2° número: ");
             num2 = Convert.ToInt32(ReadLine());
                    int multiplicar = Multiplicar(num1, num2);
                    Console.WriteLine("O resultado da multiplicação foi: "+multiplicar);
                    break;

                case 4:
                
            Console.WriteLine("Digite o 1° número: ");
             num1 = Convert.ToInt32(ReadLine());

            Console.WriteLine("Digite o 2° número: ");
             num2 = Convert.ToInt32(ReadLine());
                    int dividir = Dividir(num1, num2);
                    Console.WriteLine("O resultado da divisão foi: "+dividir);
                    break;
            }


            int Somar(int num1, int num2)
            {
                int soma = num1 + num2;
                return soma;
            }

            int Subtrair(int num1, int num2)
            {
                int subtrair = num1 - num2;
                return subtrair;
            }

            int Multiplicar(int num1, int num2)
            {
                int multiplicar = num1 * num2;
                return multiplicar;
            }

            int Dividir(int num1, int num2)
            {
                if (num2 == 0)
                {
                    WriteLine("Não é possível dividir por zero.");
                    return 0;
                }
                else
                { 
                    int dividir = num1 / num2;
                    return dividir;
                }
            }
        }
        while(op != 0);
    }
}