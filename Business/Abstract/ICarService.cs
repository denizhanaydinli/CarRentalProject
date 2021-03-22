using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Cars> GetAll();
        List<Cars> GetCarsByBrandId(int BrandId);
        List<Cars> GetCarsByColorId(int ColorId);
        void Add(Cars car);
        void Delete(Cars car);
        void Update(Cars car);
    }
}
