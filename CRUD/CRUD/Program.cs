using CRUD;

internal class Program
{
    static bool stopLoop = false;
    private static void Main(string[] args)
    {
        List<User> users = new List<User>();
        int choice;

        while (stopLoop != true)
        {
            Console.WriteLine($"1-Add User \n2- Update Data Of User \n3- Delet User \n4- Print All Users");
            string input = Console.ReadLine();

            User user = new User();
            if (int.TryParse(input, out choice))
            {
                if (choice == 1)
                {
                    user.AddUser(users);

                }
                else if (choice == 2)
                {
                    user.UpdateUser(users);

                }
                else if (choice == 3)
                {
                    user.DeleteUser(users);

                }
                else if (choice == 4)
                {

                    user.PrintAllUser(users);
                }
                else 
                {
                    Console.WriteLine("No Such a Number");
                }
                TryAgain();
            }
            else
            {
                Console.WriteLine("Invalid Not A Number");
            }

        }


        static void TryAgain()
        {
            Console.WriteLine($"===================================================================");

            Console.WriteLine("Do you want to try anything else ? \n Y for yes || N for no");
            char tryAgain = char.Parse(Console.ReadLine());
            if (tryAgain == 'Y' || tryAgain == 'y')
            {
                Console.WriteLine($"===================================================================");
            }
            else if (tryAgain == 'N' || tryAgain == 'n')
            {
                stopLoop = true;
            }
        }
    }
}