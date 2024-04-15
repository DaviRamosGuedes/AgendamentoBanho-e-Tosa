using System;
using System.IO;
using System.Collections.Generic;

class Agendamento
{
    public Cliente cliente;
    public string horario;
    public Animal animal;
    public Servico servico;

    public static List<Agendamento> listaAgendamentos = new List<Agendamento>();

    public Agendamento(Cliente cliente, string horario, Animal animal, Servico servico)
    {
        this.cliente = cliente;
        this.horario = horario;
        this.animal = animal;
        this.servico = servico;

        List<Agendamento> listaAgendamentos = new List<Agendamento>();
    }

    public string getNome()
    {
        return cliente.nome;
    }

    public string getHorario()
    {
        return horario;
    }
    public void setHorario(string h)
    {
        horario = h;
    }

    public override string ToString()
    {
        return $"Cliente: {cliente.getnome()}, Horário: {horario}, Animal: {animal.getNomeAnimal()}, Raça: {animal.getRaca}, IdadeAnimal: {animal.getIdade}, Serviço: {servico.getservico()}, Valor: {servico.getpreco()}";
    }

    public static void GerarRelatorio()
    {
        Console.WriteLine("===== Relatório de Agendamentos =====");
        foreach (Agendamento agendamento in listaAgendamentos)
        {
            Console.WriteLine(agendamento.ToString());
        }
        Console.WriteLine("====================================");
    }
    public static void SalvarAgendamento(Agendamento agendamento)
    {
        // Abre o arquivo para gravação
        StreamWriter writer = new StreamWriter("agendamentos.txt", true);

        // Escreve os dados do agendamento no arquivo
        writer.WriteLine("{0},{1},{2},{3},{4},{5},{6}", agendamento.cliente.nome, agendamento.horario, agendamento.animal.NomeAnimal, agendamento.animal.Raca, agendamento.animal.Idade, agendamento.servico.servico, agendamento.servico.preco);

        // Fecha o arquivo
        writer.Close();
    }

  public static void LerAgendamento(){

    // Leitura de dados do arquivo, linha por linha.  
        string[] linhas = File.ReadAllLines("agendamentos.txt");

        foreach (string linha in linhas)
        {
            string[] dados = linha.Split(",");
            string NomeDoCLiente = dados[0];
            string horarioMarcado = dados[1];
            string NomeDoAnimal = dados[2];
            string RacaDoAnimal = dados[3];
            int IdadeDoAnimal = int.Parse(dados[4]);
            string OpcaoServico = dados[5];

            Cliente ClientedaLista = new Cliente(dados[0]);
            string horariodalista = new String(dados[1]);
            Animal AnimalDaLista = new Animal(dados[2],dados[3],int.Parse(dados[4]));
            Servico ServicoDaLista = new Servico(dados[5],float.Parse(dados[6]));
          
            Agendamento TodoAgendamento = new Agendamento(ClientedaLista , horariodalista, AnimalDaLista, ServicoDaLista);
            listaAgendamentos.Add(TodoAgendamento);

          }
        
        
    }

    
  

  }