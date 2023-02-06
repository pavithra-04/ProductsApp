using ProductsApp.ModelClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsApp.DAL;
using ProductsApp.BLL;

namespace ProductsApp
{
    internal class Admin
    {
        //public DataLayer dAL = new DataLayer();
        BusinessLayer businessLayer = new BusinessLayer();
        public string productName;
        public int productId, productQuantity, productRating;
        public double productPrice;

        
        public void adminRole()
        {
            try
            {
                Console.WriteLine("**Admin Role**");
                bool condition = true;
                do
                {
                    Console.WriteLine("1.Add Product");
                    Console.WriteLine("2.Delete Product");
                    Console.WriteLine("3.Update Product");
                    Console.WriteLine("4.View all products");
                    Console.WriteLine("5.Search products");
                    Console.WriteLine("6.Exit\n");
                    Console.Write("Enter number to select your choice-");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Product Id");
                            productId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Product Name");
                            productName = Console.ReadLine();
                            Console.WriteLine("Enter Product Quantity");
                            productQuantity = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Product Price");
                            productPrice = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Product Ratings (In between 1 to 5)");
                            productRating = Convert.ToInt32(Console.ReadLine());
                            businessLayer.validateDetails(productId, productName, productQuantity, productPrice, productRating);
                            //businessLayer.addProductDetails(productId, productName,productQuantity,productPrice,productRating);
                            break;
                        case 2:
                            Console.WriteLine("Enter Product ID to delete: ");
                            int deletePID = int.Parse(Console.ReadLine());
                            businessLayer.deleteProduct(deletePID);
                            break;
                        case 3:
                            Console.WriteLine("Enter Product ID to update: ");
                            int updatePID = int.Parse(Console.ReadLine());
                            businessLayer.updateProduct(updatePID);
                            break;
                        case 4:
                            Console.WriteLine("PID\tPNAME\tPRICE\tQUANTITY\tRATING");
                            businessLayer.displayAllProduct();
                            break;
                        case 5:
                            businessLayer.searchProduct();
                            break;
                        case 6:
                            condition = false;
                            break;

                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }

                } while (condition);
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }
        
    }
}
