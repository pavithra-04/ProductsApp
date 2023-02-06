using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApp.ModelClasses
{
    [Serializable]
    internal class Product
    {
        public int productId;
        public string productName;
        public int productQuantity;
        public double productPrice;
        public int productRating;
        public List<Product> list;

        public Product()
        {
            //pId= 0;
            //pName= string.Empty;
            //pQuantity= 0;
            //pPrice= 0.00;
            //pRating = 0;
        }
        public Product(int productId, string productName, int productQuantity, double productPrice, int productRating)
        {
            this.productId = productId;
            this.productName = productName;
            this.productQuantity = productQuantity;
            this.productPrice = productPrice;
            this.productRating = productRating;
        }

        public int pId
        {
            get
            {
                return productId;
            }

            set
            {
                productId = value;
            }
        }
        public string pName { 
            get
            {
                return productName;
            }

            set 
            {
                productName = value;
            }
        }
        public int pQuantity { 
            get
            {
                return productQuantity;
            }
             set
            {
                productQuantity = value;
            }
                }
        public double pPrice { 
            
            get
            {
                return productPrice;
            }
            set
            {
                productPrice = value;
            }
        }
        public int pRating
        {
            get
            {
                return productRating;
            }
            set
            {
                productRating = value;
            }
        }
        public override string ToString()
        {
            return productId + " " + productName + " " + productQuantity + " " + productPrice + " " + productRating;
        }

        //public Product()//default 
        //{

        //}
       

        public Product(List<Product> products)
        {
            this.list= products;
        }
       
    }
}
