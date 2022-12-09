namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         



            string fullname;
            do
            {
                Console.WriteLine("Please login");
                fullname = Console.ReadLine();
                User new_user = new User
                {
                    ID = 1,
                    FullName = fullname,
                    Balance = 0
                };
                BankService.CentralBank.Users.Add(new_user);
                //BankService bankService = new BankService();
                //bankService.CentralBank = new Bank();
                //bankService.CentralBank.Users.Add(new_user);
            } while (string.IsNullOrWhiteSpace(fullname));


            int selection;
            Console.WriteLine($"Welcome our Cinema {fullname}");
            do
            {
            start:
                Console.WriteLine("1.  Check Balance");
                Console.WriteLine("2. Top up balance");
                
                Console.WriteLine("0. Log out");
                bool result = int.TryParse(Console.ReadLine(), out selection);
                if (result)
                {
                    switch (selection)
                    {
                        
                    }
                }
                else
                {
                    Console.Clear();
                    goto start;
                }
            } while (selection != 0);
        }
    }
}