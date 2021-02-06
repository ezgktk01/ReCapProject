using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal
    {
        //List<Car> _cars;
        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car>  {

        //       new Car {CarId=1, BrandId=1, ColorId=1, DailyPrice=100, Description="Renault Megane", ModelYear=2006 },
        //       new Car {CarId=2, BrandId=1, ColorId=2, DailyPrice=150, Description="Toyota Corolla", ModelYear=2016 },
        //       new Car {CarId=3, BrandId=2, ColorId=1, DailyPrice=260, Description="BMW 318", ModelYear=2019 },
        //       new Car {CarId=4, BrandId=3, ColorId=3, DailyPrice=200, Description="Ford Focus", ModelYear=1999 },
        //   };
        //}
        //public void Add(Car car)
        //{
        //    _cars.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        //    _cars.Remove(carToDelete);
        //}

        //public List<Car> GetAll()
        //{
        //    return _cars;
        //}

        //public List<Car> GetById(int Id)
        //{
        //    return _cars.Where(c=>c.CarId == Id ).ToList();
        //}

        //public void Update(Car car)
        //{
        //   Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        //    carToUpdate.BrandId = car.BrandId;
        //    carToUpdate.ColorId = car.ColorId;
        //    carToUpdate.ModelYear = car.ModelYear;
        //    carToUpdate.DailyPrice = car.DailyPrice;
        //    carToUpdate.Description = car.Description;
        //}
    }
}
