using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class CarBrandManager : ICarBrandService
    {
        ICarBrand _ıcarBrandDal;

        public CarBrandManager(ICarBrand ıcarBrandDal)
        {
            _ıcarBrandDal = ıcarBrandDal;
        }

        public void add(CarBrand carBrand)
        {
            _ıcarBrandDal.Add(carBrand);
        }

        public void delete(CarBrand carBrand)
        {
            _ıcarBrandDal.Delete(carBrand);
        }

        public void get(int id)
        {
            _ıcarBrandDal.GetAll(p=>p.id==id);
        }

        public void update(CarBrand carBrand)
        {
            _ıcarBrandDal.Update(carBrand);
        }
    }
}
