using ProvaNET.Classes;
using ProvaNET.DesignPatterns;
using ProvaNET.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProvaNET.DesignPatterns.Classes;

namespace ProvaNET
{
    /// <summary>
    /// Classe estática que representa os exercícios
    /// </summary>
    public static class Exercicios
    {
        /// <summary>
        /// Realiza uma ordenação descendente por sobrenome da lista de Pessoas
        /// </summary>
        /// <param name="Pessoas"></param>
        public static void Um(ref List<Pessoa> Pessoas)
        {
            Pessoas = Pessoas.OrderByDescending(o => o.Sobrenome).ToList();
        }

        /// <summary>
        /// Realiza uma iteração paralela na lista de Pessoas
        /// </summary>
        /// <param name="Pessoas"></param>
        public static void Dois(List<Pessoa> Pessoas)
        {
            if (Pessoas?.Count > 0)
            {
                Parallel.ForEach(Pessoas, (pessoa) =>
                {
                    Console.WriteLine($"Listando pessoa de Id {pessoa.Id}, nome completo '{pessoa.Nome + pessoa.Sobrenome}'.");
                });
                Console.WriteLine("-".PadLeft(100, '-'));
            }
        }

        /// <summary>
        /// Implementação de dois Design Patterns
        /// Singleton e Factory
        /// </summary>
        public static void Tres()
        {
            //Singleton: é um padrão de projeto que garante que apenas um objeto de um determinado tipo exista e forneça um único ponto de acesso simples a ele para qualquer outro código.
            var oSingleton1 = Singleton.Instance;
            oSingleton1.Identificador = 1;

            var oSingleton2 = Singleton.Instance;
            oSingleton2.Identificador = 2;

            //Imprime o valor do identificador das duas variáveis criadas para o objeto Singleton
            Console.WriteLine("Design Pattern - Singleton");
            Console.WriteLine("-".PadLeft(100, '-'));
            Console.WriteLine($"{Environment.NewLine}Valor do objeto 1: {oSingleton1.Identificador}");
            Console.WriteLine($"Valor do objeto 2: {oSingleton2.Identificador}");
            Console.WriteLine("-".PadLeft(100, '-'));
            Console.WriteLine(string.Empty);

            //Factory: define uma interface ou classe abstrata para criar um objeto em tempo de execução, deixando o cliente isento de instanciar a classe ganhando dinamismo para a aplicação. 
            var Factories = new Factory[2];
            Factories[0] = new Psitacideos();
            Factories[1] = new Passeriformes();

            Console.WriteLine("Design Pattern - Factory");
            Console.WriteLine("-".PadLeft(100, '-'));
            foreach (var factory in Factories)
            {
                Console.WriteLine($"{Environment.NewLine}- {factory.GetType().Name}");
                factory.Passaros.ForEach((passaro) =>
                {
                    Console.WriteLine($" {passaro.GetType().Name}");
                });
            }
            Console.WriteLine("-".PadLeft(100, '-'));
            Console.WriteLine(string.Empty);
        }

        /// <summary>
        /// Utiliza um método de extensão para uma string e imprime a mesma
        /// </summary>
        public static void Quatro()
        {
            var NomeUsuario = "jorge";
            Console.WriteLine($"Nome do usuário utilizado: {NomeUsuario}");
            Console.WriteLine($"Nome do usuário utilizando o método de extensão: {NomeUsuario.CaixaAltaPrimeiraLetra()}");
        }

        /// <summary>
        /// Função recursiva para calcular um fatorial
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        static int CalculaFatorial (int numero)
        {
            if (numero == 1)
                return 1;

            return numero * CalculaFatorial(numero - 1);
        }

        /// <summary>
        /// Algoritmo de fatorial de um número
        /// </summary>
        public static void Dez()
        {
            Console.Write("Digite um número inteiro: ");
            int Numero = 0;
            if (int.TryParse(Console.ReadLine(), out Numero))
            {
                Console.WriteLine($"Fatorial de {Numero} é igual a {CalculaFatorial(Numero)}.");
            }
            else
                Console.WriteLine("Valor digitado não é um número inteiro.");
        }
    }
}
