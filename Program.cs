using ProvaNET.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProvaNET
{
    class Program
    {
        static List<Empresa> Empresas;
        static List<Pessoa> Pessoas;

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à prova de NET");

            Inicializar();

            Console.WriteLine("Pessoas existentes: ");
            ListarPessoas();

            Console.WriteLine("Clique para realizar o exercício número 1...");
            Console.ReadKey();
            Console.Clear();

            //Ordena as pessoas em ordem decrescente por sobrenome
            Exercicios.Um(ref Pessoas);
           
            Console.WriteLine("Pessoas em ordem decrescente por Sobrenome: ");
            ListarPessoas();

            Console.WriteLine("Clique para realizar o exercício número 2...");
            Console.ReadKey();
            Console.Clear();

            //Realiza uma iteração na lista de pessoas utilizando Loop Paralelo e exibindo o id e nome completo da pessoa
            Exercicios.Dois(Pessoas);

            Console.WriteLine("Clique para realizar o exercício número 3...");
            Console.ReadKey();
            Console.Clear();

            //Executa um teste para dois design patterns (Singleton e Factory)
            Exercicios.Tres();

            Console.WriteLine("Clique para realizar o exercício número 4...");
            Console.ReadKey();
            Console.Clear();

            //Método de extensão para uma string
            Exercicios.Quatro();

            Console.WriteLine("Clique para realizar o exercício número 10...");
            Console.ReadKey();
            Console.Clear();

            //Executa o algoritmo de fatorial de um número
            Exercicios.Dez();

            Console.WriteLine($"{Environment.NewLine}Clique para finalizar...");
            Console.ReadKey();
        }

        static void Inicializar()
        {
            //Cria uma lista de empresas adicionando dois registros, empresa 1 e 2
            Empresas = new List<Empresa>()
            {
                new Empresa() { Id = 1, Nome = "Empresa 1"},
                new Empresa() { Id = 2, Nome = "Empresa 2"}
            };

            //Cria uma lista de Pessoas
            Pessoas = new List<Pessoa>();
            //Loop para adicionar 20 pessoas à lista criada acima
            for (int i = 1; i <= 20; i++)
            {
                //representa o ano de nascimento da pessoa, sendo calculado conforme o número da iteração do loop
                //se o i for menor que 5 multiplica por 10, caso contrário, se o número for maior que 10, multiplica por 3, senão multiplica por 5
                var AnoNascimento = i < 5 ? i * 10 : (i > 10 ? i * 3 : i * 5);

                //adiciona uma nova pessoa à lista
                Pessoas.Add(new Pessoa()
                {
                    Id = i,
                    Nome = "Pessoa de ",
                    Sobrenome = $"{i:00} Sobrenome", //atribui ao sobrenome o número da iteração no formato de dois caracteres, ou seja, 1 será 01
                    DataNascimento = DateTime.Now.AddYears(-AnoNascimento), //adiciona os anos retroativos
                    Empresa = i % 2 == 0 ? Empresas.FirstOrDefault() : Empresas.LastOrDefault() //Caso número da iteração seja par, atribui a empresa 1, caso impar a empresa 2
                });
            }
        }

        static void ListarPessoas()
        {            
            //Percorre a lista de pessoas
            Pessoas.ForEach((pessoa) =>
            {
                //Imprime os dados da pessoa
                Console.WriteLine($"- Id: {pessoa.Id} | Nome completo: {pessoa.Nome + pessoa.Sobrenome} | Data Nascimento: {pessoa.DataNascimento.ToShortDateString()} | Empresa: {pessoa.Empresa.Nome} ");                
            });
            Console.WriteLine("-".PadLeft(100, '-'));
        }
    }
}
