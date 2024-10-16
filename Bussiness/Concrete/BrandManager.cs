using Business.Constans;
using Bussiness.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            return new SuccessResult(Messages.Added);
            _brandDal.Add(brand);
        }

        public IResult Delete(Brand brand)
        {
            return new SuccessResult(Messages.Deleted);
            _brandDal.Delete(brand);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            var brand=_brandDal.Get(b=>b.BrandId == brandId);
            return new SuccessDataResult<Brand>(brand);
        }

        public IResult Update(Brand brand)
        {
            return new SuccessResult(Messages.Updated);
            _brandDal.Update(brand);
        }
    }
}
