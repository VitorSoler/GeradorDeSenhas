using System;
using System.Text;

namespace GeradorDeSenhas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char Resposta;
                do
                {
                    string Caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower() + "1234567890" + "!@#$%¨&*()_+-=§/?°´`''|₢<>,.;:~^{}[]ªº£";

                    Console.Write("Digite a quantidade de caracteres que a sua senha terá: ");
                    int Quantidade = int.Parse(Console.ReadLine());

                    Random Sorteio = new Random();
                    int CaracteresSorteados = 0;

                    StringBuilder SenhaFinal = new StringBuilder();
                    for (int i = 0; i < Quantidade; i++)
                    {
                        CaracteresSorteados = Sorteio.Next(0, Caracteres.Length);
                        SenhaFinal.Append(Caracteres[CaracteresSorteados]);
                    }
                    Console.WriteLine(SenhaFinal);

                    Console.WriteLine();
                    Console.Write("Deseja fazer uma nova senha(s/n)? ");
                    Resposta = char.Parse(Console.ReadLine());
                    Console.Clear();
                }
                while (Resposta == 's' || Resposta == 'S');
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }

            Console.ReadLine();
        }
    }
}
