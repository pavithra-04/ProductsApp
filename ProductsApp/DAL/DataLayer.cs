using ProductsApp.ModelClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApp.DAL
{
    internal class DataLayer
    {
        public List<Product> productList = new List<Product>();


        public void BinarySerialization(/*int id, string name, int quantity, double price, int rating*/)
        {
            try
            {
                //Product product = new Product(id, name, quantity, price, rating);
                FileStream fileStream = new FileStream(@"Product.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, productList);
                fileStream.Close();
                Console.WriteLine("Data Serialized");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("File Not Found");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //BinaryDeSerialization();

        }

        public List<Product> deserializeProductDetails()
        {
            try
            {
                FileStream fs = new FileStream(@"Product.txt", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                productList=bf.Deserialize(fs) as List<Product>;
                return productList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }



            //    try
            //    {

            //        FileStream fs = new FileStream(@"Product.txt", FileMode.Open, FileAccess.Read);
            //        if (fs.Length > 0)
            //        {
            //            BinaryFormatter bf = new BinaryFormatter();
            //            Object obj = bf.Deserialize(fs);
            //            Product product = (Product)obj;
            //            // productListDe.Add((Product)obj);
            //            // Console.WriteLine(productListDe.Count);
            //            fs.Close();
            //            Console.WriteLine(obj.ToString());
            //        }
            //        else
            //        {
            //            Console.WriteLine("No Data Avilable");

            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}
        }
    }
}
