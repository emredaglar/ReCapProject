﻿using Entities.Concrete;
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
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        //List<Car> GetById(int id);
        List<GetCarDetailsDto> getCarDetails();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
