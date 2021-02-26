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
            //-------------------CAR------------------
                    
            CarManager carManager = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));

            //var result = carManager.GetAll();
            //foreach (var car in result.Data)
            //{
            //    Console.WriteLine(car.CarId + " " + car.ModelYear + " " + car.Description + "Günlük Kiralama Bedeli: " + car.DailyPrice + "TL");
            //}

            //carManager.Add(new Car { CarId = 6, CarName = "Toyota" , ModelYear = 2001, DailyPrice = 300, Description = "Otomatik Dizel" });

            //carManager.Update(new Car { CarId = 6, CarName = "Honda" });

            //Console.WriteLine("Renk Kodu 2 Olan Ürünleri Listele");

            //var result = carManager.GetCarsByColorId(2);
            //foreach (var car in result.Data)
            //{
            //    Console.WriteLine(car.CarId + " " + car.ModelYear + " " + car.Description + "Günlük Kiralama Bedeli: " + car.DailyPrice + "TL");

            //}

            //Console.WriteLine("---Fiyatı Min. 100 Maks. 500 Olan Ürünleri Listele---");

            //foreach (var car in carManager.GetByDailyPrice(100, 500).Data)
            //{
            //    Console.WriteLine(car.CarId + " " + car.ModelYear + " " + car.Description + "Günlük Kiralama Bedeli: " + car.DailyPrice + "TL");
            //}

            //Console.WriteLine("Araba Id, Marka, Renk Listele (Join operasyonu ile)");

            //var result = carManager.GetCarDetails();

            //if (result.Success == true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.CarId + "/" + car.BrandName + "/" + car.ColorName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


            //---------------BRAND-------------

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //brandManager.Update(new Brand { BrandId = 7, BrandName = "Honda" });

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


            //----------------COLOR---------------

            ColorManager colorManager = new ColorManager(new EfColorDal());

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

           
            
            //----------------USER--------------
            
            UserManager userManager = new UserManager(new EfUserDal());

            //var result = userManager.GetAll();
            //if (result.Success)
            //{
            //    foreach (var user in result.Data)
            //    {
            //        Console.WriteLine(user.UserId + "/" + user.FirstName + "/" + user.LastName + "/" + user.Email);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
            
            //userManager.Add(new User { UserId = 6, FirstName = "Leyla", LastName = "Türk", Email = "leyla.turk@hotmail.com", Password = "Leyla123" });




            //--------------CUSTOMER----------------

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //var result = customerManager.GetAll();
            //foreach (var customer in result.Data)
            //{
            //    Console.WriteLine(customer.UserId+"/"+customer.CustomerId+"/"+customer.CompanyName);
            //}


            //-----------RENTAL-----------

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //var result = rentalManager.GetAll();
            //foreach (var rental in result.Data)
            //{
            //    Console.WriteLine(rental.RentalId+"/"+rental.RentDate + "/" +rental.ReturnDate);
            //}

            //var result = rentalManager.GetRentalDetails();
            //if (result.Success==true)
            //{
            //    foreach (var rental in result.Data)
            //    {
            //        Console.WriteLine(rental.RentalId+"/" + rental.FirstName + "/" +rental.LastName + "/" +rental.BrandName + "/" +rental.ColorName + "/" +rental.CompanyName + "/" +rental.DailyPrice + "/" +rental.Description + "/" +rental.ModelYear + "/" +rental.RentDate + "/" +rental.ReturnDate);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            DateTime rentDate = new DateTime(2020, 01, 12);
            DateTime returnDate = new DateTime(2020, 02, 13);
            Rental rental = new Rental
            {
                CustomerId = 8,
                CarId = 8,
                RentDate = rentDate,
                ReturnDate = rentDate
            };
            var result = rentalManager.Add(rental);
            if (result.Success)
            {
                Console.WriteLine("Araç kiralandı");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
