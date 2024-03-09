using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoNguyenVu_0162_LINQ
{
    class Vehicle
    {
        protected string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        protected string manufacturer;

        public string Manufacturer
        {
            set { manufacturer = value; }
            get { return manufacturer; }
        }
        
        protected int madeIn;
        public int MadeIn
        {
            set { madeIn = value; }
            get { return madeIn; }
        }
        protected string country;
        
        public string Country
        {
            set { country = value; }
            get { return country; }
        }
        protected double price;
        public double Price
        {
            set { price = value; }
            get { return price; }
        }


        public Vehicle(string name, string manufacture, int madeIn, string country, double price)
        {
            this.name = name;
            this.manufacturer = manufacture;
            this.madeIn = madeIn;
            this.country = country;
            this.price = price;
        }
         
        public virtual void printInf()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Manufacturer: " + manufacturer);
            Console.WriteLine("Made in: " + madeIn);
            Console.WriteLine("Country: " + country);
            Console.WriteLine("Price: " + price);
        }
    }
}
