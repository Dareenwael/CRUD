using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class User
    {
        private string name;
        private string email;
        private string phonenumber;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phonenumber
        {
            get { return phonenumber; }

            set
            {
                phonenumber = value;
            }
        }

        public void AddUser(List<User> users)
        {
            Console.WriteLine($"============================Add User================================");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter PhoneNumber: ");
            string phonenumber = Console.ReadLine();

            User NewUser = new User()
            {
                Name = name,
                Email = email,
                Phonenumber = phonenumber
            };

            users.Add(NewUser);

            Console.WriteLine($"============================User Information you Enterd================================");
            Console.WriteLine($"Name: {NewUser.name}");
            Console.WriteLine($"Email: {NewUser.email}");
            Console.WriteLine($"Phone Number: {NewUser.phonenumber}");
        }

        public void UpdateUser(List<User> users)
        {
            Console.WriteLine($"============================Update Data of User================================");
            Console.Write("Enter User Phone Number you want to Edit: ");
            string phonenumber = Console.ReadLine();
            bool flag = false;
            User Foundeduser = users.FirstOrDefault(x => x.Phonenumber == phonenumber); //check if phonenumber enterd match phonenumber in userlist
            if (Foundeduser != null)
            {
                Console.Write("1-Edit Name: \n2-Edit Email: \n3-Edit PhoneNumber: \n");
                int choseToEdit = int.Parse(Console.ReadLine());
                if (choseToEdit == 1)
                {
                    Console.Write("Enter Edited Name: ");
                    string newName = Console.ReadLine();
                    Foundeduser.name = newName;
                    flag = true;
                }
                else if (choseToEdit == 2)
                {
                    Console.Write("Enter Edited Email: ");
                    string newEmail = Console.ReadLine();
                    Foundeduser.email = newEmail;
                    flag = true;

                }
                else if (choseToEdit == 3)
                {
                    Console.Write("Enter Edited Phone Number: ");
                    string newPhoneNumber = Console.ReadLine();
                    Foundeduser.Phonenumber = newPhoneNumber;
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Wrong Number Try Again From First"); ;
                }
                if (flag == true)
                {
                    Console.WriteLine($"============================New User Information you Edited================================");
                    Console.WriteLine($"Name: {Foundeduser.name}");
                    Console.WriteLine($"Email: {Foundeduser.email}");
                    Console.WriteLine($"Phone Number: {Foundeduser.phonenumber}");
                }

            }
            else
            {
                Console.WriteLine("No user Like this");
            }
        }
        public void DeleteUser(List<User> users)
        {
            Console.WriteLine($"============================Delete User================================");
            Console.Write("Enter User Phone Number you want to Delete: ");
            string phoneNumber = Console.ReadLine();
            User Foundeduser = users.FirstOrDefault(x => x.Phonenumber == phoneNumber);
            var name = Foundeduser.name;
            if (name != null)
            {
                users.Remove(Foundeduser);
                Console.WriteLine($"User Delteted {name}");
            }
            else
            {
                Console.WriteLine("User NOt Found");
            }

        }
        public void PrintAllUser(List<User> users)
        {
            int count = 1;
            if (users.Count == 0)
            {
                Console.WriteLine($"===================================================================");

                Console.WriteLine("No users to print");
            }
            else
            {
                Console.WriteLine($"============================Print All User================================");
            }

            foreach (var user in users)
            {
                Console.WriteLine($"User {count}");
                Console.WriteLine($"Name: {user.name}");
                Console.WriteLine($"Email: {user.email}");
                Console.WriteLine($"Phone Number: {user.phonenumber}");
                count++;
                if (count <= users.Count)
                {
                    Console.WriteLine("----------------");
                }
            }

        }
    }
}
    

