using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoNguyenVu_0162_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> listCar = new List<Car>
                {
                    new Car ("Honda Brio", "Honda", 2019, "Japan", 120000, 4,4),
                    new Car ("Honda Civic ", "Honda", 1980, "US", 230000, 4,4),
                    new Car ("Hyundai", "Hyundai", 1999, "South Korea", 350000, 4,4),
                    new Car ("Audi", "Audi", 1888, "Germany", 180000, 4,4),
                    new Car ("Honda Accord", "Honda", 1986, "Japan", 520000, 4,4),
                    new Car ("VinFast", " Vingroup", 2021, "Viet Nam", 260000, 4,4) 

                     
                };
            List<Truck> listTruck = new List<Truck>
                {
                    new Truck ("Iveco", "Iveco", 2012, "Italy", 120000,"Iveco Company", 4,4),
                    new Truck ("Mercedes-Benz Trucks", "Mercedes-Benz Trucks", 2019, "Germany", 120000,"Mercedes-Benz Trucks Company", 4,4),
                    new Truck ("MAN Truck & Bus", "MAN Truck & Bus", 2014, "Germany", 120000,"MAN Truck & Bus Company", 4,4),
                    new Truck ("Scania AB", "Scania AB", 2011, "Sweden", 120000,"Scania AB Company", 4,4),
                    new Truck ("Hino Motors", "Hino Motors", 2016, "Japan", 120000,"Hino Motors Company", 4,4),
                    new Truck ("Fuso", "Fuso", 2015, "Japan", 120000,"Fuso Company", 4,4), 
                };
 
            var carsWithPrice = listCar
                .OfType<Car>()  
                .Where( car => car.Price > 100000 &&  car.Price < 250000 )  
                .Select(car => car)  
                .ToList();
            
            var carsWithMadeIn = listCar
                .OfType<Car>()
                .Where(car => car.MadeIn > 1990)
                .Select(car => car)
                .ToList();

            var totalPriceByManufacturer = listCar
            .GroupBy(c => c.Manufacturer)
            .Select(group => new
            {
                Manufacturer = group.Key,
                TotalPrice = group.Sum(c => c.Price)
            });
            var trucksWithParentCompany = listTruck 
            .Select(group => new
            {
                Name = group.Name,
                ParentCompany = group.ParentCompany
            });

            //////////////////

            Console.WriteLine("----- Car -----\n");
            Console.WriteLine("----- Danh sach cac xe co gia trong khoang 100.000 đen 250.000 -----\n");
            foreach (var item in carsWithPrice)
            {
                item.printInf();
            }
            ///
            Console.WriteLine("----- Danh sach cac xe các xe co nam san xuat > 1990 -----\n");
            foreach (var item in carsWithMadeIn)
            {
                item.printInf();
            }
            ///
            Console.WriteLine("----- Danh sach cac xe theo hang san xuat, tinh tong gia tri theo nhom -----");
            foreach (var item in totalPriceByManufacturer)
            {
                Console.WriteLine("Manufacturer:" + item.Manufacturer + " - Total Price:" + item.TotalPrice  );
            }

            /////////////////
            Console.WriteLine("\n\n\n----- Truck -----");
            Console.WriteLine("----- Danh sach Truck theo thu tu nam san xuat moi nhat -----\n");
            listTruck.Sort((tr1, tr2) => tr2.MadeIn.CompareTo(tr1.MadeIn));
            foreach (var item in listTruck)
            {
                item.printInf();
            }

            ///
            Console.WriteLine("----- Danh sach Truck theo ten cong ty chu quan cua Truck -----\n");
            foreach (var item in trucksWithParentCompany)
            {
                Console.WriteLine("Name:  " + item.Name + " ----- Parent Company:   " + item.ParentCompany);
            }

            Console.ReadLine();

             
        }
    }
}
