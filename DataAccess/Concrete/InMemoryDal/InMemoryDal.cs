using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemoryDal
{
   public class InMemoryDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryDal()
        {
            _cars = new List<Car> { 
          /*  new Car{Id=1,BrandId=1,ColorId=1,ModelYear="1994",DailyPrice=500,Description="iemaika"},
            new Car{Id=2,BrandId=2,ColorId=2,ModelYear="2000",DailyPrice=600,Description="eiaieia"},
            new Car{Id=3,BrandId=2,ColorId=1,ModelYear="1999",DailyPrice=550,Description="tükütmtkm"},
            new Car{Id=4,BrandId=1,ColorId=2,ModelYear="2003",DailyPrice=900,Description="hnhnhnhnh"}
            */};
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deletecar = _cars.SingleOrDefault(c=>c.Id==car.Id);       
            _cars.Remove(deletecar);
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

        public void Update(Car car)
        {   Car updatecar = _cars.SingleOrDefault(c=>c.Id==car.Id);
            updatecar.Id = updatecar.Id;
            updatecar.BrandId = updatecar.BrandId;
            updatecar.ColorId = updatecar.ColorId;
            updatecar.DailyPrice = updatecar.DailyPrice;
            updatecar.ModelYear = updatecar.ModelYear;
            updatecar.Description = updatecar.Description;
        }
    }
}
