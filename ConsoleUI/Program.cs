using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());


            Console.WriteLine("---Tüm Ürünleri Listele---");

            carManager.Add(new Car {CarId=7 , ModelYear = 2000, DailyPrice = 300, Description = "Otomatik Dizel" });
            

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + " " + car.ModelYear + " " + car.Description + "Günlük Kiralama Bedeli: " + car.DailyPrice + "TL");
            }
            
            Console.WriteLine("---Renk Kodu 2 Olan Ürünleri Listele---");

            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.CarId + " " + car.ModelYear + " " + car.Description + "Günlük Kiralama Bedeli: " + car.DailyPrice + "TL");

            }

            Console.WriteLine("---Fiyatı Min. 100 Maks. 500 Olan Ürünleri Listele---");

            foreach (var car in carManager.GetByDailyPrice(100,500))
            {
                Console.WriteLine(car.CarId + " " + car.ModelYear + " " + car.Description + "Günlük Kiralama Bedeli: " + car.DailyPrice + "TL");
            }

            



        }
    }
}
