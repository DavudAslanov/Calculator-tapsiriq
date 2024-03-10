
/// Xetadan sonra yeniden davam
using Calculator_tapsiriq;

 try{
        while (true)
        {
            Console.WriteLine("Zehmet Olmasa Birinci reqemi girin:");
            decimal One = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Zehmet Olmasa Ikinci reqemi girin:");
            decimal Two = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa Hansi Emeliyati Secmek istediynizi Bildirin\n *,+,-,/");
            char Symbol = Convert.ToChar(Console.ReadLine());
            Calculator calculator = new Calculator(One, Two, Symbol);
            calculator.Calc();
        }
     }
catch(DivideByZeroException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Bolme xetasi");
    Console.ReadLine();
    Console.WriteLine("Bolme xetasi");
}
catch(FormatException e)
{
    Console.WriteLine(e.StackTrace);
    while (true)
    {
        Console.WriteLine("Zehmet Olmasa Birinci reqemi girin:");
        decimal One = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Zehmet Olmasa Ikinci reqemi girin:");
        decimal Two = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Zehmet olmasa Hansi Emeliyati Secmek istediynizi Bildirin\n *,+,-,/");
        char Symbol = Convert.ToChar(Console.ReadLine());
        Calculator calculator = new Calculator(One, Two, Symbol);
        calculator.Calc();
    }
    Console.ReadLine();
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
    Console.ReadLine();
}

