using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        string Delete(Car car);
        string Add(Car car);
        string Update(Car car);
        List<Car> GetAll();
        List<Car> GetAllid(int id);
        List<Car> GetAllCategory(int fiyat);
    }
}
