namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();

            Console.WriteLine("How much money you you like to deposit?");
            var deposit = double.Parse(Console.ReadLine());

            myAccount.Deposit(deposit);

            Console.WriteLine("Your current balance is:");
            Console.WriteLine($"${myAccount.GetBalance()}");
        }
    }
}
