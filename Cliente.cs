using System.IO;
using System.Collections.Generic;

class Cliente
{
    public string nome;

    public Cliente(string nome)
    {
        this.nome = nome;
    }
    public string getnome()
    {
        return nome;
    }
    public void setnome(string n)
    {
        nome = n.ToUpper();
    }
}