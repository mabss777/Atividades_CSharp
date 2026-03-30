using static System.Console;

        Console.WriteLine("Sejam bem vindos ao jogo!");

        Console.WriteLine("Digite o nome do 1° jogador: ");
        string Jogador1 = (Console.ReadLine());

        Console.WriteLine("Digite o nome do 2° jogador: ");
        string Jogador2 = (Console.ReadLine());

        Random numeroDado = new Random();

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{i+1}° JOGADA!");
        }

public class Jogador
{
   public string Nome;
   public int pontuacao;
   

} 