using Bussiness.Concrete;
using DataAccess.Concrete.EntityFreamwork;

using Entities.Concrete;

//CarManager carManager = new CarManager(new InMemoryCarDal());

//Car car1 = new Car();
//Car car2 = new Car();
//car1.Description = "Honda";
//car2.Description = "Subaru";

//carManager.Add(car1);
//carManager.Add(car2);


//foreach (var car in carManager.GetById(2))
//{
//    Console.WriteLine(car.CarId + " " + car.Description);
//}


//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine(car.Description);
//}

CarManager carManager = new CarManager(new EfCarDal());
BrandManager brandManager = new BrandManager(new EfBrandDal());
ColorManager colorManager=new ColorManager(new EfColorDal());

Brand brand1 = new Brand();
brand1.BrandName = "Focus";
brandManager.Add(brand1);

Color color1 = new Color();
color1.ColorName = "red";

colorManager.Add(color1);

Car car1 = new Car();
car1.CarName = "Ford";
car1.Description = "Ford";
car1.DailyPrice = 2;
car1.BrandId = 5;
car1.ColorId = 6;
carManager.Add(car1);

car1.BrandId = brand1.BrandId;  // BrandId ve ColorId set edilmeli
car1.ColorId = color1.ColorId;
foreach (var car in carManager.getCarDetails())
{
    Console.WriteLine(car.CarName+"/"+car.BrandName+"/"+car.ColorName+"/"+car.DailyPrice);
}
CarManager carManager1 = new CarManager(new EfCarDal());
Console.WriteLine("List of cars:");
foreach (var car in carManager1.getCarDetails())
{
    Console.WriteLine($"{car.CarId} - {car.CarName}, Brand: {car.BrandName}, Color: {car.ColorName} Price: {car.DailyPrice}");
}






