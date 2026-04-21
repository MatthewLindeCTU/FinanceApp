namespace FinanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== LOAN PROGRAM ====");

            Console.Write("Loan Amount: ");
            double loanAmount = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Interest Rate: ");
            double interestRate = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Number of Years for Loans: ");
            double loanYears = double.Parse(Console.ReadLine() ?? "0");

            double numPayments = loanYears * 12;

            double term = Math.Pow((1 + interestRate / 12.0), numPayments);

            double paumentAmount = loanAmount * interestRate / 12 * term / (term - 1.0);

            double monthlyInterest = interestRate / 12 * ;
        }
    }
}
