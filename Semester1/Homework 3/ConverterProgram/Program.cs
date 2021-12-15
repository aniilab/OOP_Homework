using System;
class Converter
{
    public Converter() {  }
    public Converter(double usd, double eur)
    {
        
        USD = usd;
        EUR = eur;
    }

    public double ConvertUAHtoUSD(double uah)
    {
        return uah / USD;
    }

    public double ConvertUAHtoEUR(double uah)
    {
        return uah / EUR;
    }
    public double ConvertUSDtoUAH(double usd)
    {
        return usd * USD;
    }

    public double ConvertEURtoUAH(double eur)
    {
        return eur * EUR;
    }
    public double USD = 26.4;
    public double EUR = 30.6;

}


namespace ConverterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter check = new Converter();
            Console.WriteLine("USD: " + check.USD + "\nEUR: " + check.EUR + "\nIf you need to change it enter 1; else enter 0.");
            string os = Console.ReadLine();
            int o = Convert.ToInt16(os);
            if (o == 1)
            {
                Console.WriteLine("Enter info for USD");
                string USDs = Console.ReadLine();
                double USD = Convert.ToDouble(USDs);
                Console.WriteLine("Enter info for EUR");
                string EURs = Console.ReadLine();
                double EUR = Convert.ToDouble(EURs);
                Converter c = new Converter(USD, EUR);
                check = c;
            }

            Console.WriteLine("Enter amount of UAH you need to convert");
            string astr = Console.ReadLine();
            double a = Convert.ToDouble(astr);

            Console.WriteLine("What would you convert UAH to? Enter d - for USD or e - for EUR");
            string cur = Console.ReadLine();
            if (cur == "d")
            {
                Console.WriteLine(a+" UAH in USD: "+check.ConvertUAHtoUSD(a));
            }
            else if (cur == "e")
            {
                Console.WriteLine(a + " UAH in EUR: " + check.ConvertUAHtoEUR(a));
            }
            else
            {
                Console.WriteLine("Wrong command");
            }
            

        }
    }
}
