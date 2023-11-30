using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

public class Advogado
{

    public Advogado(string _nome, DateTime _dataNasc, string _CPF, string _CNA)
    {
        Nome = _nome;
        DataNasc = _dataNasc;
        CPF = _CPF;
        CNA = _CNA;
    }

    public string Nome { get; set; }
    public DateTime DataNasc { get; set; }
    public string CPF { get; set; }
    public string CNA { get; set; }

}



namespace Application
{

    class Program
    {


        static void Main(string[] args)
        {
            DateTime birthDate = DateTime.Parse("17/07/1999");
            Advogado advogado1 = new Advogado("manoel", birthDate, "00000000001", "0938595");

            // Console.WriteLine($"{advogado1.Nome}, {advogado1.CPF},{advogado1.DataNasc},{advogado1.CNA}");
            Console.WriteLine("Modelo");

        }
    }
}

