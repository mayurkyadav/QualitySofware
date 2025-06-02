using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp
{
    public class Product
    {
        private int prodID;
        private string prodName;
        private double itemPrice;
        private int stockAmount;

        public int ProdID
        {
            get { return prodID; }
            set { prodID = value; }
        }

        public string ProdName
        {
            get { return prodName; }
            set { prodName = value; }
        }

        public double ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }

        public int StockAmount
        {
            get { return stockAmount; }
            set { stockAmount = value; }
        }


        public Product(int prodID, string prodName, double itemPrice, int stockAmount)
        {

            this.ProdID = prodID;
            this.ProdName = prodName;
            this.ItemPrice = itemPrice;
            this.StockAmount = stockAmount;
        }

        public void IncreaseStock(int amount)
        {

            if (amount > 0)
            {
                StockAmount = StockAmount + amount;
            }
        }

        public void DecreaseStock(int amount)
        {

            if (amount > 0 && amount <= StockAmount)
            {
                StockAmount = StockAmount - amount;
            }
        }


    }
}

