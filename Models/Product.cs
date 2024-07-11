using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Models
{
    internal class Product
    {
        private int _id;
        private string _name;
        private int _price;
        private double _discount;

        //Get Methods
        public int GetId() { return _id; }
        public string GetName() { return _name; }
        public int GetPrice() { return _price; }
        public double GetDiscount() { return _discount; }

        //Set Methods
        public void SetId(int id) { _id = id; }
        public void SetName(string name) { _name = name; }
        public void SetPrice(int price) { _price = price; }
        public void SetDiscount(int discount) { _discount = discount; }
        

        public double CalculateDiscount()
        {
            double priceAfterDiscount = _price * (1 - (_discount / 100));
            return priceAfterDiscount;
        }

    }


}
