﻿using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
    interface IAllCars
    {
        IEnumerable<Car> Cars { get;  }
        IEnumerable<Car > getFavCars { get; set; }
        Car getOjectCar(int carId);
    }
}
