using System.Globalization;

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
    public string CPF;

    public string _CPF
    {
        get { return CPF; }

        set
        {
            if (value.Length == 11)
            {
                bool isValid = value.All(Char.IsDigit);

                if (isValid)
                {
                    CPF = _CPF;

                }
                else
                {
                    throw new Exception("O CPF precisa ter exatamente 11 dígitos numéricos");
                    return;
                }

            }
            else
            {
                throw new Exception("O CPF precisa ter exatamente 11 dígitos");

            }
        }
    }



}


public class Advogado : Pessoa
{

    public Advogado(string _nome, DateTime _dataNasc, string _CPF, string _CNA) : base(_nome, _dataNasc, _CPF)
    {

        CNA = _CNA;
    }

    public string CNA { get; set; }

}
public class Cliente : Pessoa
{

    public Cliente(string _nome, DateTime _dataNasc, string _CPF, string _estadoCivil, string _profissao) : base(_nome, _dataNasc, _CPF)
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

            try
            {
                Advogado advogado1 = new Advogado("Manoel", DateTime.Parse("1999/07/19"), "00000000001", "0938595");
                Advogado advogado2 = new Advogado("Luiza", DateTime.Parse("1975/07/19"), "00000000002", "309430");

                Cliente cliente1 = new Cliente("Sandra", DateTime.Parse("2002/10/20"), "00000000003", "solteiro", "gamer");
                Cliente cliente2 = new Cliente("Pedro", DateTime.Parse("1972/10/20"), "00000000004", "casado", "reporter");

            }
            catch (System.Exception)
            {
                Console.WriteLine("\n\nVocê informou um valor  inválido !\n");
                return;
            }

            List<Advogado> listAdvogados;
            List<Cliente> listCliente;

            listAdvogados.Add(advogado1);
            listAdvogados.Add(advogado2);

            listCliente.Add(cliente1);
            listCliente.Add(cliente1);

            foreach (var advogado in listAdvogados)
            {

                ($"Nome: {advogado.Nome} \n tm: {advogado.CPF.Length}CPF: {advogado.CPF}\nCNA:{advogado.CNA}\n Data NAscimento:{advogado.DataNasc}");
            }
            foreach (var cliente in listClient){

                Console.WriteLine($"Nome: {cliente.Nome} \nCPF: {cliente.CPF}\n Data NAscimento:{cliente.DataNasc}\nEstado Civil:{cliente.EstadoCivil}\nProfissão:{cliente.Profissao}");
            }

        }
    }
}

