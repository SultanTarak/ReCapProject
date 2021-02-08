using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=2019, DailyPrice=300, Description="BMW 1 Serisi"},
                new Car{CarId=2, BrandId=1, ColorId=1, ModelYear=2017, DailyPrice=270, Description="Audi A3"},
                new Car{CarId=3, BrandId=2, ColorId=1, ModelYear=2016, DailyPrice=150, Description="Renault Megane"},
                new Car{CarId=4, BrandId=3, ColorId=1, ModelYear=2015, DailyPrice=400, Description="Mercedes GLA"},
                new Car{CarId=5, BrandId=3, ColorId=1, ModelYear=2020, DailyPrice=850, Description="Porsche Panamera"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => car.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => car.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
