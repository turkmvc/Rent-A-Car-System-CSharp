using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear=2021, DailyPrice = 10000, Description = "Mercedes Car" },
                new Car { Id = 2, BrandId = 2, ColorId = 2, ModelYear=2021, DailyPrice = 20000, Description = "BMW Car" },
                new Car { Id = 3, BrandId = 3, ColorId = 3, ModelYear=2021, DailyPrice = 25000, Description = "Audi Car" },
                new Car { Id = 4, BrandId = 4, ColorId = 4, ModelYear=2021, DailyPrice = 50000, Description = "Bentley Car" }
            };

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int byId)
        {
            return _cars.Where(c => c.Id == byId).ToList();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}

