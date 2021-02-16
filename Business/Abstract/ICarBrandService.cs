using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICarBrandService
    {
        void add(CarBrand carBrand);
        void delete(CarBrand carBrand);
        void update(CarBrand carBrand);
        void get(int id);

    }
}
