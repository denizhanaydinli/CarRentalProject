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
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            this._carDal = carDal;
        }

        public void Add(Cars car)
        {
            if(car.BrandName.Length >= 2)
            {
                if(car.DailyPrice > 0)
                {
                    _carDal.Add(car);
                    Console.WriteLine("{0} added.", car.BrandName);
                }
         
                
                    else
                    {
                        Console.WriteLine("Daily price should be bigger than 0");
                    }
                
            }
            else
            {
                Console.WriteLine("Car name should be longer than 1");
            }
        }

        public void Delete(Cars car)
        {
            _carDal.Delete(car);
        }

        public List<Cars> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Cars> GetCarsByBrandId(int BrandId)
        {
            return _carDal.GetAll(b => b.Id == BrandId);
        }

        public List<Cars> GetCarsByColorId(int ColorId)
        {
            return _carDal.GetAll(b => b.Id == ColorId);
        }

        public void Update(Cars car)
        {
            _carDal.Update(car);
        }
    }
}
