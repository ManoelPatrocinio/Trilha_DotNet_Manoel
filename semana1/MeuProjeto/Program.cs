// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World Manoel !");

#region Teste de tipo de dados
    int tipoInteiro;
    double tipoDouble;
    string tipoString;
    long tipoLong;

    tipoInteiro = int.MaxValue;
    tipoLong = long.MaxValue;

    // tipoInteiro = tipoLong;
    tipoLong = tipoInteiro ;

    tipoString = "100";
    tipoDouble = tipoInteiro;
    tipoInteiro = int.Parse(tipoString);

    Console.WriteLine("O maximo interio e:" + tipoInteiro);
    Console.WriteLine("O maximo long e:" + tipoLong);
    Console.WriteLine("O maximo double e:" + tipoDouble);
    Console.WriteLine("O tipo string e:" + tipoString);

#endregion

#region  operadores


#endregion