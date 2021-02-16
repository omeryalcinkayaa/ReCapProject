using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICarColorService
    {
        void add(CarColor carColor);
        void delete(CarColor carColor);
        void update(CarColor carColor);
        List<CarColor> GetAll();
        List<CarColor> GetAllid(int id);
    }
}
