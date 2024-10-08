﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        //void Add(Car car);
        //void Delete(Car car);
        //void Update(Car car);

        //List<Car> GetAll();

        //List<Car> GetById(int carId);
        List<GetCarDetailsDto> GetCarDetails();
    }
}
