using System; //o C# seja capaz de monitorar coisas (monitorar data, trabalhar com console, etc).
using System.Collections.Generic; //Estrutura de dados.
using System.Linq; //Trabalhar omn um volume grande de dados.
using System.Text; //Permite que manipule texto.
using System.Threading.Tasks; //Serve para criar um progama que roda em varios nucleos do pc ao mesmo tempo.

namespace helloWorld2
{
    internal class Program //inicio do programa
    {
        static void Main(string[] args)
        {
            Console.Write("Olá, Mundo!\n");
            Console.Write("Meu primeiro código em C#! :)");
            Console.ReadLine(); //Detectar o que o usuário escreveu
        }
    } //fim do programa
}

