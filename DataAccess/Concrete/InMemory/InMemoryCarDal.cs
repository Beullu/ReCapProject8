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
            _cars = new List<Car>()
            {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=1999,DailyPrice=1500,CarDescription="Mustang"},
                new Car{CarId=2,BrandId=2,ColorId=1,ModelYear=2000,DailyPrice=1000,CarDescription="BMW"},
                new Car{CarId=3,BrandId=3,ColorId=1,ModelYear=2001,DailyPrice=20004,CarDescription="Bugatti-v1"},
                new Car{CarId=4,BrandId=3,ColorId=1,ModelYear=2003,DailyPrice=20230,CarDescription="Bugatti-v2"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.CarId== car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(p=>p.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarDescription= car.CarDescription;
            carToUpdate.ModelYear= car.ModelYear;
            carToUpdate.DailyPrice=car.DailyPrice;
            
            }
    }
}
