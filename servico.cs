using System.IO;
using System.Collections.Generic;

class Servico
{
    public string servico;
    public float preco;

    public Servico(string servico, float preco)
    {
        this.servico = servico;
        this.preco = preco;
    }

    public string getservico()
    {
        return servico;
    }
    public void setservico(string s)
    {
        servico = s;
    }

    public float getpreco()
    {
        return preco;
    }
    public void setpreco(float p)
    {
        preco = p;
    }
}