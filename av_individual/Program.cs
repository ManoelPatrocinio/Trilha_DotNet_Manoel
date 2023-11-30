
public class Pessoa
{

    public Pessoa(string _nome, DateTime _dataNasc, string _CPF)
    {
        Nome = _nome;
        DataNasc = _dataNasc;
        CPF = _CPF;
    }

    public string Nome { get; set; }
    public DateTime DataNasc { get; set; }
    private string CPF;

    public string _CPF{
        get {return _CPF }

        set{
            if(_CPF.Length < 11){
                throw new Exception("O CPF precisa ter no mínimo 11 dígitos");
            }
        }
    }



}


public class Advogado : Pessoa
{

    public Advogado(string _nome, DateTime _dataNasc, string _CPF,string _CNA):base (_nome,_dataNasc,_CPF)
    {
        
        CNA = _CNA;
    }

    public string CNA { get; set; }

}
public class Cliente : Pessoa
{

    public Cliente(string _nome, DateTime _dataNasc, string _CPF,string _estadoCivil, string _profissao):base (_nome,_dataNasc,_CPF)
    {
       
        EstadoCivil = _estadoCivil;
        Profissao = _profissao;
    }

    public string EstadoCivil { get; set; }
    public string Profissao { get; set; }

}


namespace Application
{

    class Program
    {
        static void Main(string[] args)
        {
            Advogado advogado1 = new Advogado("manoel", DateTime.Parse("1999/07/19"), "00000000001", "0938595");
            Console.WriteLine($"Nome: {advogado1.Nome} \nCPF: {advogado1.CPF}\nCNA:{advogado1.CNA}\n Data NAscimento:{advogado1.DataNasc}");

            Cliente cliente1 = new Cliente("Sandra", DateTime.Parse("2005/10/20"), "00000000002", "solteiro","gamer");
            Console.WriteLine($"Nome: {cliente1.Nome} \nCPF: {cliente1.CPF}\n Data NAscimento:{cliente1.DataNasc}\nEstado Civil:{cliente1.EstadoCivil}\nProfissão:{cliente1.Profissao}");

        }
    }
}

