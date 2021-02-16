using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class CarColorManager : ICarColorService
    {
        ICarColorDal _ıcarColorDal;

        public CarColorManager(ICarColorDal ıcarColorDal)
        {
            _ıcarColorDal = ıcarColorDal;
        }

        public void add(CarColor carColor)
        {
            _ıcarColorDal.Add(carColor);
        }

        public void delete(CarColor carColor)
        {
            _ıcarColorDal.Delete(carColor);
        }

      
   
 

        public List<CarColor> GetAll()
        {
            return _ıcarColorDal.GetAll();

        }

        public List<CarColor> GetAllid(int id)
        {
            return _ıcarColorDal.GetAll(p => p.Id == id);
        }

        public void update(CarColor carColor)
        {
            _ıcarColorDal.Update(carColor);
        }
    }
}
