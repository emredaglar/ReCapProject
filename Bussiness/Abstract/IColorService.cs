﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();

        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}
