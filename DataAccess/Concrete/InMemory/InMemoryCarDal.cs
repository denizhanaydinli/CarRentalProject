using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Cars> _carList;

        public InMemoryCarDal()
        {
            _carList = new List<Cars>() { 
            new Cars{Id=1,BrandName="Mercedes",ModelYear=2004 },
            new Cars{Id=2,BrandName="BMW",ModelYear=2010 },
            new Cars{Id=3,BrandName="Lada",ModelYear=2020 },
            new Cars{Id=4,BrandName="Reanult",ModelYear=1996 },
            new Cars{Id=5,BrandName="Ford",ModelYear=2016 }

            };
        }

        public void Add(Cars car)
        {
            _carList.Add(car);
        }

        public void Delete(Cars car)
        {
            Cars carToDelete = _carList.FirstOrDefault(
                c=>c.Id==car.Id);
            _carList.Remove(carToDelete);
        }

        public List<Cars> GetAll()
        {
            return _carList;
        }

        public List<Cars> GetById(int Id)
        {
             return _carList.Where(p => p.Id == Id).ToList();
        }

        public void Update(Cars car)
        {
            Cars carToBeUpdated = _carList.SingleOrDefault(c => c.Id == car.Id);
            carToBeUpdated.Id = car.Id;
            carToBeUpdated.BrandName = car.BrandName;
            carToBeUpdated.ModelYear = car.ModelYear;
        }
    }
}
