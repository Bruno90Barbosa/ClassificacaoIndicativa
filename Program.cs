using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string filmeL = "Divertida Mente";
            string filme10 = "Extraordinário";
            string filme12 = "Nada a Perder";
            string filme14 = "Infinito";
            string filme16 = "O Filho Protegido";
            string filme18 = "DeadPool & Wolverine";

            Console.WriteLine("----------------------------------");
            Console.WriteLine("CLASSIFICAÇÃO INDICATIVA DE FILMES");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("");
            Console.WriteLine("Digite o seu nome completo: ");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (idade >= 0 && idade >= 18)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Nome: " + nomeCompleto);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("");
                Console.WriteLine("LISTA DE FILMES(s) PERMITIDO(s) CONFORME A SUA IDADE");
                Console.WriteLine(filmeL);
                Console.WriteLine(filme10);
                Console.WriteLine(filme12);
                Console.WriteLine(filme14);
                Console.WriteLine(filme16);
                Console.WriteLine(filme18);
            }
            else if (idade <= 9)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Nome: " + nomeCompleto);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("");
                Console.WriteLine("LISTA DE FILMES(s) PERMITIDO(s) CONFORME A SUA IDADE");
                Console.WriteLine(filmeL);
            }

            else if (idade <= 11)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Nome: " + nomeCompleto);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("");
                Console.WriteLine("LISTA DE FILMES(s) PERMITIDO(s) CONFORME A SUA IDADE");
                Console.WriteLine(filmeL);
                Console.WriteLine(filme10);
            }
            else if (idade <= 13)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Nome: " + nomeCompleto);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("");
                Console.WriteLine("LISTA DE FILMES(s) PERMITIDO(s) CONFORME A SUA IDADE");
                Console.WriteLine(filmeL);
                Console.WriteLine(filme10);
                Console.WriteLine(filme12);
            }
            else if (idade <= 15)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Nome: " + nomeCompleto);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("");
                Console.WriteLine("LISTA DE FILMES(s) PERMITIDO(s) CONFORME A SUA IDADE");
                Console.WriteLine(filmeL);
                Console.WriteLine(filme10);
                Console.WriteLine(filme12);
                Console.WriteLine(filme14);
            }
            else if (idade <= 17)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Nome: " + nomeCompleto);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("");
                Console.WriteLine("LISTA DE FILMES(s) PERMITIDO(s) CONFORME A SUA IDADE");
                Console.WriteLine(filmeL);
                Console.WriteLine(filme10);
                Console.WriteLine(filme12);
                Console.WriteLine(filme14);
                Console.WriteLine(filme16);
            }


            Console.ReadLine();
        }
    }
}
