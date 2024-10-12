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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            return new SuccessResult(Messages.Added);
            _colorDal.Add(color);
        }

        public IResult Delete(Color color)
        {
            return new SuccessResult(Messages.Deleted);
            _colorDal.Delete(color);
        }

        public IDataResult<List<Color>> GetAll()
        {
           return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IResult Update(Color color)
        {
            return new SuccessResult(Messages.Updated);
            _colorDal.Update(color);
        }
    }
}
