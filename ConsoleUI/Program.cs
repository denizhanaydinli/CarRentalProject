using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarManager carManager = new CarManager(new InMemoryCarDal());
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Cars
            {
                Id = 1,
                BrandName="Ford",
                ModelYear=2010,
                DailyPrice=300000,


            });

            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.Id+" "+ cars.BrandName);
            }

        }
    }
}
