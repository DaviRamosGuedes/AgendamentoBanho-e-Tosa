using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        Agendamento.LerAgendamento();
      
        while (true)
        {
            Console.WriteLine("BEM VINDO!!! \nSe você veio fazer o agendamento de banho e tosa do seu gato ou cachorro veio no lugar certo!!");
            Console.WriteLine("===============================");
            Console.WriteLine("===============================");
            Console.WriteLine("======== 0 - Sair =============");
            Console.WriteLine("==== 1 - Agendamento ==========");
            Console.WriteLine("== 2 - Lista de Agendamentos ==");
            Console.WriteLine("===============================");
            Console.WriteLine("===============================");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "0":
                    break;

                case "1":
                    Console.WriteLine("Insira seu nome? ");
                    string nomeCliente = Console.ReadLine();
                    Cliente NomeDoCLiente = new Cliente(nomeCliente);

                    Console.WriteLine("Escolha o horário e o dia (dd/MM/yyyy - HH:mm)? ");
                    string horarioMarcado = (Console.ReadLine());

                    Console.WriteLine("Qual o nome do seu animal? ");
                    string NomeDoAnimal = Console.ReadLine();

                    Console.WriteLine("Qual a raça do animal? ");
                    string RacaDoAnimal = Console.ReadLine();

                    Console.WriteLine("Qual a idade do Animal?  ");
                    int IdadeDoAnimal = int.Parse(Console.ReadLine());

                    Animal animal = new Animal(NomeDoAnimal, RacaDoAnimal, IdadeDoAnimal);

                    Console.WriteLine("Escolha o serviço que você vai querer? \n 1 - Banho \n 2 - Tosa");
                    string OpcaoServico = Console.ReadLine();

                    if (OpcaoServico == "1")
                    {
                        Servico servicoAnimal = new Servico("Banho", 50f);
                        // Cria um novo agendamento
                        Agendamento agendamento = new Agendamento(NomeDoCLiente, horarioMarcado, animal, servicoAnimal);
                        Agendamento.listaAgendamentos.Add(agendamento);
                        Agendamento.SalvarAgendamento(agendamento);


                    }

                    else if (OpcaoServico == "2")
                    {
                        Servico servicoAnimal = new Servico("Tosa", 70f);
                        // Cria um novo agendamento
                        Agendamento agendamento = new Agendamento(NomeDoCLiente, horarioMarcado, animal, servicoAnimal);
                        Agendamento.listaAgendamentos.Add(agendamento);
                        Agendamento.SalvarAgendamento(agendamento);

                    }
                    else
                    {
                        Console.WriteLine("Opção inválida. Agendamento cancelado.");
                        return;
                    }
                    Console.WriteLine("Agendamento realizado com sucesso!");
                    Console.WriteLine($"Nome:{nomeCliente}");
                    Console.WriteLine($"Horário:{horarioMarcado}");
                    Console.WriteLine($"Animal:{NomeDoAnimal}");
                    Console.WriteLine($"Raça do animal:{RacaDoAnimal}");
                    Console.WriteLine($"Idade do Animal:{IdadeDoAnimal}");

                    if (OpcaoServico == "1")
                    {
                        Console.WriteLine($"Serviço: Banho");
                    }

                    else if (OpcaoServico == "2")
                    {
                        Console.WriteLine($"Serviço: Tosa");
                    }

                    Console.WriteLine("Deseja fazer mais algum agendamento? (S)im ou (N)ão");
                    string opcaoSimNao = Console.ReadLine();

                    if (opcaoSimNao.ToUpper() == "S")
                    {

                        break;
                    }
                    else if (opcaoSimNao.ToUpper() == "N")
                    {

                        return;
                    }
                    break;
              
                case "2":
                    Console.WriteLine("Relatório de agendamentos \n");
                    foreach (var agendamento in Agendamento.listaAgendamentos){
                        Console.WriteLine($"Nome:{agendamento.cliente.nome}");
                        Console.WriteLine($"Horário:{agendamento.horario}");
                        Console.WriteLine($"Nome do animal:{agendamento.animal.NomeAnimal}");
                        Console.WriteLine($"Raça do animal:{agendamento.animal.Raca}");
                        Console.WriteLine($"Idade do animal:{agendamento.animal.Idade}");
                        Console.WriteLine($"Serviço:{agendamento.servico.servico}");
                        Console.WriteLine($"Valor:{agendamento.servico.preco}\n");
                    }
                    break;
            }
        }
    }
}
