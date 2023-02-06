using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApp
{
    internal class Program
    {
       // C:\Users\patil\Desktop\training data\Project\HM\ProductsApp\ProductsApp\
        static void Main(string[] args)
        {
            
            bool condition = true;
            Console.WriteLine("***************************************");

            do
            {
                Console.WriteLine("\nSelect Your Choice to Proceed Further");
                Console.WriteLine("->Admin");
                Console.WriteLine("->User");
                Console.WriteLine("->Exit");
                Console.WriteLine("\nEnter your choice");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "Admin":
                    case "admin":
                        {
                            Admin admin= new Admin();
                            admin.adminRole();
                        }
                        break;
                    case "User":
                    case "user":
                        {
                            User user = new User();    
                            user.userRole();
                        }
                        break;
                    case "Exit":
                    case "exit":

                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            } while(condition);
        }

    }
}




