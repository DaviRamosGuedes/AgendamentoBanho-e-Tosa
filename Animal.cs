using System.IO;
using System.Collections.Generic;

class Animal
{
    public string NomeAnimal = "";
    public string Raca = "";
    public int Idade = 0;

    public Animal(string NomeAnimal, string Raca, int Idade)
    {
        this.NomeAnimal = NomeAnimal;
        this.Raca = Raca;
        this.Idade = Idade;
    }

    public string getNomeAnimal()
    {
        return NomeAnimal;
    }
    public void setNomeAnimal(string na)
    {
        NomeAnimal = na;
    }
    public string getRaca()
    {
        return Raca;
    }
    public void setRaca(string r)
    {
        Raca = r;
    }
    public int getIdade()
    {
        return Idade;
    }
    public void setIdade(int i)
    {
        Idade = i;
    }
}
