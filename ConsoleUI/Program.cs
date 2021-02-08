using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("---Tüm Ürünleri Listele---");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + car.ColorId + car.BrandId + car.ModelYear + " Model " + car.Description + "Günlük Kiralama Bedeli: " + car.DailyPrice);

            }
            Console.WriteLine("---Siyah Renkli Ürünleri Listele---");

            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.CarId + car.ColorId + car.BrandId + car.ModelYear + " Model " + car.Description + "Günlük Kiralama Bedeli: " + car.DailyPrice);

            }

            Console.WriteLine("---Fiyatı Min. 100 Maks. 500 Olan Ürünleri Listele---");

            foreach (var car in carManager.GetByDailyPrice(100,500))
            {
                Console.WriteLine(car.CarId + car.ColorId + car.BrandId + car.ModelYear + " Model " + car.Description + "Günlük Kiralama Bedeli: " + car.DailyPrice);
            }
        }
    }
}
