﻿using Bussiness.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new InMemoryCarDal());

Car car1 = new Car();
Car car2 = new Car();
car1.Description = "Honda";
car2.Description = "Subaru";

carManager.Add(car1);
carManager.Add(car2);


foreach (var car in carManager.GetById(2))
{
    Console.WriteLine(car.CarId + " " + car.Description);
}


foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}