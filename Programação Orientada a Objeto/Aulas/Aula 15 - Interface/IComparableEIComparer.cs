class Pessoa : IComparable
{
    private string nome;

    public Pessoa(string nome)
    {
        this.nome = nome;
    }

    public string GetNome() { return nome; }

    public int CompareTo(object obj)
    {
        Pessoa other = (Pessoa)obj;

        return this.nome.CompareTo(other.nome); // ordem alfabética ASC
    }
}

//ou

class Pessoa : IComparable<Pessoa>
{
    private string nome;

    public Pessoa(string nome)
    {
        this.nome = nome;
    }

    public string GetNome() { return nome; }

    public int CompareTo(Pessoa other)
    {
        return other.nome.CompareTo(this.nome); // ordem alfabética DESC
    }
}

//Exemplo de IComparer
class Pessoa : IComparable<Pessoa>
{
    private string nome;
    private int idade;

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public string GetNome() { return nome; }
    public int GetIdade() { return idade; }

    public int CompareTo(Pessoa other)
    {
        return this.nome.CompareTo(other.nome); // ordena por nome ASC
    }
}

class OrdenaPorIdadeAsc : IComparer<Pessoa> 
{ 

	public int Compare(Pessoa x, Pessoa y) 
	{ 
		if (x.GetIdade() < y.GetIdade()) 
		{ 
			return -1; 
		} 
		else if (x.GetIdade() > y.GetIdade()) 
		{ 
			return 1; 
		} else 
		{ 
			return 0; 
		} 
	}
 }