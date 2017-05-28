Gerente
programador
programador
programador
Vendedor
faxineiroDiurno
FaxineiroNoturno

classe funcionario

funcionario(string nome){
	this.nome = nome;	
}

--------------------------------------------------------------------------------------
Classe FuncionarioPorHora

protected valor
FuncionarioPorHora(string nome, double horas, double valor) : base(nome){
this.horas
this.valor
}

GetSalario()
Convert.ToDecimal(horas) * valor

--------------------------------------------------------------------------------------
Classe Programador : FuncionarioPorHora

nivel

Programador(string nome, nivel, horas): base(nome, horas, 0)
nivel = nivel
valor = GetValor(nivel)



private decimal GetValor(nivel)

switch(nivel)

case "JR" : return 30;
case "PL" : return 45;
case "SR" : return 80;

default : return 0;
 
--------------------------------------------------------------------------------------
Classe Gerente : FuncionarioPorHora
 
 bonus
 
 Gerente(nome, bonus, horas) : base(nome, horas, 100)
 
 
 public new decimal GetSalario()
 return base.GetSalario() + bonus;

--------------------------------------------------------------------------------------

FuncionarioValorFixo : Funcionario

valor

FuncionarioValorFixo(nome, valor) : base(nome)

GetSalario()
return valor;


--------------------------------------------------------------------------------------

Vendedor : FuncionarioValorFixo



Vendedor(nome, vendas) : base(nome, 2000)


public new GetSalario
comissao = 0.2M * vendas
return base.GetSalario() + GetComissao()

GetComissao()
return 0.2M * vendas

--------------------------------------------------------------------------------------

faxineiroDiurno : FuncionarioValorFixo 

faxineiroDiurno(nome, valor) : base(nome, valor)

--------------------------------------------------------------------------------------

FaxineiroNoturno : FuncionarioValorFixo

faxineiroDiurno(nome, valor) : base(nome, valor)

public new GetSalario

return base.GetSalario() + GetAdicionalNoturno()


GetAdicionalNoturno()
return 0.5M * GetSalario();

--------------------------------------------------------------------------------------
POLIMORFISMO

list<Funcionario> funcionarios = new List<Funcionario>();
funcionarios.Add(new Gerente("Maria", 1000, 160))


decimal total = 0;

foreach(Funcionario f in funcionarios)
{
	Console.WriteLine("Funcionario {0} ira receber {1}, GetNome(), f.GetSalario(), total+= f.GetSalario();"
	
}


NA CLASSE  BASE (Funcionario)

public virtual decimal GetSalario()
return 0;


em todas as classes que tem o metodo deve colocar override.

public override decimal GetSalario

return base.GetSalario() + GetAdicionalNoturno()

--------------------------------------------------------------------------------------
ABSTRAÇÂO

Classe abstrata é usada quando se quer herdar sem criar objeto.
Ela não pode ser estanciada.

Metodo obstrato não possui codigo.

Toda clase que tem metodo abstrato tem que ser abstrata.
abstract antes da classe

public abstract decimal GetSalario()
return 0;



