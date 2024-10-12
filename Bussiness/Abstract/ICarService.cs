using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        //List<Car> GetById(int id);
        IDataResult<List<GetCarDetailsDto>> getCarDetails();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

    }
}
