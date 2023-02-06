using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApp
{
    internal class User
    {
        public void userRole()
        {
            try
            {
                Console.WriteLine("**User Role**");
                bool condition = true;
                do
                {
                    Console.WriteLine("1.View All Products");
                    Console.WriteLine("2.Search Product");
                    Console.WriteLine("3.Rate Product");
                    Console.WriteLine("4.Exit\n");
                    Console.Write("Enter number to select your choice-");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("All Products");
                            break;
                        case 2:
                            Console.WriteLine("Search Products");
                            break;
                        case 3:
                            Console.WriteLine("Rate Product");
                            break;
                        case 4:
                            condition = false;
                            break;

                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                } while (condition);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
