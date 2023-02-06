using ProductsApp.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ProductsApp.DAL;
using System.IO;

namespace ProductsApp.BLL
{
    internal class BusinessLayer
    {
        
        Product product=new Product();
        public DataLayer dataLayer=new DataLayer();
        public List<Product> productList = new List<Product>();
        //private List<Product> productList = new List<Product>();    

        //public void getProducts()
        //{
        //    List<Product> products = admin.getProducts();
        //    //Console.WriteLine();
        //}
        //public void validateProductDetails(  /*int Id,string name,int quanitity,double price,int rating*/)
        //{
        //    Admin admin=new Admin();



        //    Console.WriteLine(product.pId);
            
        //        //if (Id<=0)
        //        //{
        //        //    Console.WriteLine("Product ID Should be greater than zero");
        //        //    admin.addProductDetails();
        //        //}
        //        //else if (!Regex.IsMatch(name, @"[a-zA-Z0-9]+$"))
        //        //{
        //        //    Console.WriteLine("Special characters not allowed please enter valid Product name");
        //        //    admin.addProductDetails();
        //        //}
        //        //else if(price<0 && price%1!=0) 
        //        //{
        //        //    Console.WriteLine("Enter valid price");
        //        //    admin.addProductDetails();

        //        //}
        //        //else if(rating<1 || rating > 5)
        //        //{
        //        //    Console.WriteLine("Please give valid ratings");
        //        //    admin.addProductDetails();

        //        //}
        //        //else
        //        //{
        //        //    Console.WriteLine("Valid");
        //        //   // dataLayer.BinarySerialization(Id,name,quanitity,price,rating);
        //        //}
            
        //    //Console.WriteLine("Count:",admin.productList.Count);
        //}


        public void validateDetails(int productId, string productName, int productQuantity, double productPrice, int productRating)
        {
            if (productId <= 0)
            {
                Console.WriteLine("Product ID Should be greater than zero");
            }
            else if (!Regex.IsMatch(productName, @"[a-zA-Z0-9]+$"))
            {
                Console.WriteLine("Special characters not allowed please enter valid Product name");
            }
            else if (productPrice < 0 && productPrice % 1 != 0)
            {
                Console.WriteLine("Enter valid price");
            }
            else if (productRating < 1 || productRating > 5)
            {
                Console.WriteLine("Please give valid ratings");
            }
            else
            {
                //productList.Add(product);
                addProductDetails(productId, productName, productQuantity, productPrice, productRating);
                //int count = productList.Count;
                //Console.WriteLine("Valid");
            }
        }
        public void addProductDetails(int productId,string productName,int productQuantity, double productPrice,int productRating)
        {
            try
            {

                Product product = new Product
                {
                    productId = productId,
                    productName = productName,
                    productQuantity = productQuantity,
                    productPrice = productPrice,
                    productRating = productRating
                };
                //dataLayer.BinarySerialization(productId, productName, productQuantity, productPrice, productRating);

            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        public void deleteProduct(int id)
        {
            //dataLayer.BinaryDeSerialization();
            try
            {
                Product productToDelete = productList.Find(p => p.pId == id);

                if (productToDelete == null)
                {
                    Console.WriteLine("Product not found.");
                }
                else
                {
                    productList.Remove(productToDelete);
                    Console.WriteLine("Product deleted successfully.");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }


        }

        public void updateProduct(int id)
        {
            try
            {
                Product productToUpdate = productList.Find(p => p.pId == id);

                if (productToUpdate == null)
                {
                    Console.WriteLine("Product not found.");
                }
                else
                {
                    Console.WriteLine("Enter New Price: ");
                    productToUpdate.pPrice = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter New Quantity: ");
                    productToUpdate.pQuantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter New Rating: ");
                    productToUpdate.pRating = int.Parse(Console.ReadLine());
                    Console.WriteLine("Product updated successfully.");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        public void searchProduct()
        {
            Console.WriteLine("Enter PID to Search: ");
            int searchPid = int.Parse(Console.ReadLine());
            Product prodcutToSearch = productList.Find(p => p.pId == searchPid);

            if (prodcutToSearch == null)
            {
                Console.WriteLine("Product not found.");
            }
            else
            {
                //Product p=new Product();
                //Console.WriteLine("PID\tPNAME\tPRICE\tQUANTITY\tRATING");
                //Console.WriteLine("",p.pId,p.pName,p.pQuantity,);

            }
        }

        public void displayAllProduct()
        {
            try
            {
                foreach (Product p in productList)
                {
                    Console.WriteLine("\t", p);

                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

        }

        public List<Product> deserializeProductDetails()
        {
            try
            {
                if (File.Exists(Directory.GetCurrentDirectory() + @"\Product.txt"))
                {
                    return dataLayer.deserializeProductDetails();
                    //return null;
                }
                return null;

                
            }
            catch(Exception e) { //Console.WriteLine(e.Message);
            return null;
            }
        }

    }
}
