using Business.Constans;
using Bussiness.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                return new ErrorResult(Messages.NameInvalid);

            }
            return new SuccessResult(Messages.Added);
            _cardal.Add(car);
        }

        public IResult Delete(Car car)
        {
            return new SuccessResult(Messages.Deleted);
            _cardal.Delete(car);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(),Messages.Listed);
        }

        public IDataResult<List<GetCarDetailsDto>> getCarDetails()
        {
            return new SuccessDataResult<List<GetCarDetailsDto>>(_cardal.GetCarDetails());
            
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(p=>p.BrandId==id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(p => p.ColorId == id));
        }

        public IResult Update(Car car)
        {
            return new SuccessResult(Messages.Updated);
            _cardal.Update(car);
        }

        //    public void Add(Car car)
        //    {
        //        _cardal.Add(car);
        //    }

        //    public void Delete(Car car)
        //    {
        //        _cardal.Delete(car);
        //    }

        //    public List<Car> GetAll()
        //    {
        //        return _cardal.GetAll();
        //    }

        //    public List<Car> GetById(int id)
        //    {
        //        return _cardal.GetById(id);
        //    }

        //    public void Update(Car car)
        //    {
        //        _cardal.Update(car);
        //    }


    }


}
