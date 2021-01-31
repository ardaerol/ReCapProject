using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;

        public CarManager(ICarDal carDal)
        {
            _iCarDal = carDal;
        }

        public List<Car> GetAll()
        {
            //iş kodları
            return _iCarDal.GetAll();
        }
    }
}
