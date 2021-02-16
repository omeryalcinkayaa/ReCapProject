using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Car:IEntities
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public DateTime ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string  Description { get; set; }

        public static List<Car> ToList()
        {
            throw new NotImplementedException();
        }
    }
}
