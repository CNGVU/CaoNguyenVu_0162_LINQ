using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoNguyenVu_0162_LINQ
{
    class Truck : Vehicle
    {
        private string parentCompany;
        public string ParentCompany
        {
            set { parentCompany = value; }
            get { return parentCompany; }
        }
        private double towingCapacity;
        public double TowingCapacity
        {
            set { towingCapacity = value; }
            get { return towingCapacity; }
        }
        private double payloadCapacity;
        public double PayloadCapacity
        {
            set { payloadCapacity = value; }
            get { return payloadCapacity; }
        }

        public Truck(string name, string manufacture, int madeIn,  string country, double price, string parentCompany, double towingCapacity, double payloadCapacity)
            :base(name, manufacture, madeIn, country, price)
        {
            this.parentCompany = parentCompany;
            this.towingCapacity = towingCapacity;
            this.payloadCapacity = payloadCapacity;
        }
        public override void printInf()
        {
            base.printInf(); 
            Console.WriteLine("Parent Company: " + parentCompany );
            Console.WriteLine("Towing Capacity: " + towingCapacity );
            Console.WriteLine("Payload Capacity: " + payloadCapacity);
            Console.WriteLine();
        }

    }
}
