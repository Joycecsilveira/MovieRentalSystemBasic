using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Olá! Pressione A para alugar um filme ou S para sair:");

                char option = Console.ReadKey(true).KeyChar;

                if (option == 'A' || option == 'a')
                {
                    //Alugar um filme
                    Console.WriteLine("Pressione 1 para alugar 'O Clube da Luta'");
                    Console.WriteLine("Pressione 2 para alugar 'A Origem'");
                    Console.WriteLine("Pressione 3 para alugar 'Pulp Fiction'");
                    Console.WriteLine("Pressione 4 para alugar 'O Grande Lebowski'");
                    Console.WriteLine("Pressione 5 para alugar 'Donnie Darko'");
                    Console.WriteLine("Pressione 6 para alugar 'Clube de Compras Dallas'");
                    Console.WriteLine("Pressione 7 para alugar 'Matrix'");
                    Console.WriteLine("Pressione 8 para alugar 'A Vida é Bela'");
                    Console.WriteLine("Pressione 9 para alugar 'Os Intocáveis'");
                    Console.WriteLine("Pressione 10 para alugar 'O Labirinto do Fauno'");

                    int optionSelected = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());
                    Console.WriteLine();

                    switch (optionSelected)
                    {
                        case 1:
                            Console.WriteLine("Você alugou O Clube da Luta ");
                            break;
                        case 2:
                            Console.WriteLine("Você alugou A Origem");
                            break;
                        case 3:
                            Console.WriteLine("Você alugou Pulp Fiction");
                            break;
                        case 4:
                            Console.WriteLine("Você alugou O Grande Lebowski");
                            break;
                        case 5:
                            Console.WriteLine("Você alugou Donnie Darko");
                            break;
                        case 6:
                            Console.WriteLine("Você alugou Clube de Compras Dallas");
                            break;
                        case 7:
                            Console.WriteLine("Você alugou Matrix");
                            break;
                        case 8:
                            Console.WriteLine("Você alugou A Vida é Bela");
                            break;
                        case 9:
                            Console.WriteLine("Você alugou Os Intocáveis");
                            break;
                        case 10:
                            Console.WriteLine("Você alugou O Labirinto do Fauno");
                            break;

                    }
                }
                else if (option == 'S' || option == 's')
                {
                    //Sair da locadora
                    Console.WriteLine();
                    Console.WriteLine("Obrigada pela visita. Até logo!");
                }
                else
                {
                    //Opção desconhecida
                    Console.WriteLine();
                    Console.WriteLine("Opção desconhecida");
                }
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para encerrar");
                Console.ReadKey();
            }

        }         
    }
}
