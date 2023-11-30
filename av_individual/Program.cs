
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
            Advogado advogado1 = new Advogado("manoel", DateTime.Parse("1999/07/19"), "00000000001", "0938595");

            Console.WriteLine($"Nome: {advogado1.Nome} \nCPF: {advogado1.CPF}\nCNA:{advogado1.CNA}\n Data NAscimento:{advogado1.DataNasc}");

        }
    }
}

