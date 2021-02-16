using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;
        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public string Add(Car car)
        {
            if ((car.Description.Length<=2)&&(car.DailyPrice>0))
            {
                _cardal.Add(car);
            }
            else
            {
                Console.WriteLine("Kayıt hatalı");
            }

            return "";
        }

        public string Delete(Car car)
        {
            _cardal.Delete(car);
            return "";
        }

        public List<Car> GetAll()
        {
            //kodlar
            return _cardal.GetAll();
        }

        public List<Car> GetAllCategory(int fiyat)
        {
            return _cardal.GetAll(p=>p.DailyPrice<fiyat);
        }

        public List<Car> GetAllid(int id)
        {
            return _cardal.GetAll(p=>p.Id==id);
        }

        public string Update(Car car)
        {
            _cardal.Update(car);
            return "";
        }
    }
}
