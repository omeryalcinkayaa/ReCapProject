using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class CarBrand:IEntities
    {
        public int id { get; set; }
        public int BrandName { get; set; }
    }
}
