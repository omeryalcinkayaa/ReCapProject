using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryDal;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarColorService servis = new CarColorManager(new EFCarColorDal());
            /*    servis.Add(new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = new DateTime(1/1/1994), DailyPrice = 500, Description = "iemaika" });
                servis.Add(new Car { Id = 2, BrandId = 2, ColorId = 2, ModelYear = new DateTime(2000), DailyPrice = 600, Description = "eiaieia" });
                servis.Add(new Car { Id = 3, BrandId = 3, ColorId = 4, ModelYear = new DateTime(1999), DailyPrice = 550, Description = "tükütmtkm" });
                servis.Add(new Car { Id = 4, BrandId = 4, ColorId = 3, ModelYear = new DateTime(2003), DailyPrice = 900, Description = "hnhnhnhnh" });
              */
            servis.add(new CarColor { Id = 1, ColorName = "Beyaz" });
            servis.add(new CarColor { Id = 2, ColorName = "siyah" });
            List<CarColor> liste = servis.GetAll();
           // Console.WriteLine(servis.GetAll());
            foreach (var item in liste)
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
