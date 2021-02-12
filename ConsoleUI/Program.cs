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

            //Console.WriteLine("---Tüm Ürünleri Listele---");

            //carManager.Add(new Car { CarId = 6, CarName = "Toyota" , ModelYear = 2001, DailyPrice = 300, Description = "Otomatik Dizel" });

            //carManager.Update(new Car { CarId = 6, BrandId=6, ColorId=6});

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarId + " " + car.ModelYear + " " + car.Description + "Günlük Kiralama Bedeli: " + car.DailyPrice + "TL");
            //}

            //Console.WriteLine("---Renk Kodu 2 Olan Ürünleri Listele---");

            //foreach (var car in carManager.GetCarsByColorId(2))
            //{
            //    Console.WriteLine(car.CarId + " " + car.ModelYear + " " + car.Description + "Günlük Kiralama Bedeli: " + car.DailyPrice + "TL");

            //}

            //Console.WriteLine("---Fiyatı Min. 100 Maks. 500 Olan Ürünleri Listele---");

            //foreach (var car in carManager.GetByDailyPrice(100, 500).Data)
            //{
            //    Console.WriteLine(car.CarId + " " + car.ModelYear + " " + car.Description + "Günlük Kiralama Bedeli: " + car.DailyPrice + "TL");
            //}

            Console.WriteLine("Araba Id, Marka, Renk Listele (Join operasyonu ile)");

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + "/" + car.BrandName + "/" + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            //brandManager.Update(new Brand { BrandId = 7, BrandName="Honda" });

            //Console.WriteLine("Ürünlerin Markasını Listele");

            //var result = brandManager.GetAll();

            //if (result.Success == true)
            //{
            //    foreach (var brand in result.Data)
            //    {
            //        Console.WriteLine(brand.BrandId + "/" + brand.BrandName);
            //    }
            //    Console.WriteLine(result.Message);
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //colorManager.Add(new Color { ColorId = 6, ColorName = "Green" });

            //Console.WriteLine("Ürünlerin Rengini Listele");

            //var result = colorManager.GetAll();

            //if (result.Success == true)
            //{
            //    foreach (var color in result.Data)
            //    {
            //        Console.WriteLine(color.ColorId + "/" + color.ColorName);
            //    }
            //    Console.WriteLine(result.Message);
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


        }
    }
}
