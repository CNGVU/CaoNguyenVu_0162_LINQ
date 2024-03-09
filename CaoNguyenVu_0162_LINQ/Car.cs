using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoNguyenVu_0162_LINQ
{
    class Car : Vehicle
    {
        private int seat;
        public int Seat
        {
            set { seat = value; }
            get { return seat; }
        }
        private int door;
        public int Door
        {
            set { door = value; }
            get { return door; }
        }
        public Car(string name, string manufacture, int madeIn, string country, double price, int seat, int door)
            : base(name, manufacture, madeIn, country, price)
        {
            this.seat = seat;
            this.door = door;
        }
        public override void printInf()
        {
            base.printInf();
            Console.WriteLine("Seat: " + seat);
            Console.WriteLine("Door: " + door);
            Console.WriteLine();
        }
    }
}
