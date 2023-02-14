using System;
using System.Collections.Generic;

namespace FactoryPattern
{
class Program
{
static void Main(string[] args)
{
    string carName = "Yaris";

    //=========================================================
    //switch (carName)
    //{
    //    case "Yaris":
    //        Yaris yarisCar = new Yaris();
    //        Console.WriteLine(yarisCar.GetCarName());
    //        break;
    //    case "Corolla":
    //        Corolla corollaCar = new Corolla();
    //        Console.WriteLine(corollaCar.GetCarName());
    //        break;
    //    case "Civic":
    //        Civic civicCar = new Civic();
    //        Console.WriteLine(civicCar.GetCarName());
    //        break;
    //    case "City":
    //        City cityCar = new City();
    //        Console.WriteLine(cityCar.GetCarName());
    //        break;
    //    default:
    //        Console.WriteLine("Can't Maunufacture " + carName);
    //        break;
    //}

    //=========================================================
    //ICar car = null;
    //switch (carName)
    //    {
    //    case "Yaris":
    //        car = new Yaris();
    //        break;
    //    case "Corolla":
    //        car = new Corolla();
    //        break;
    //    case "Civic":
    //        car = new Civic();
    //        break;
    //    case "City":
    //        car = new City();
    //        break;
    //    default:
    //        break;
    //    }

    //if (car == null)
    //    Console.WriteLine("Can't Maunufacture " + carName);
    //else
    //    Console.WriteLine(car.GetCarName());

    //=========================================================
    //ICarFactory carFactory = null;
    //if (carName == "Yaris" || carName == "Corolla")
    //    carFactory = new ToyotaFactory();
    //else if  (carName == "Civic" || carName == "City")
    //    carFactory = new HondaFactory();

    //ICar car = null;
    //if (carFactory != null)
    //    car = carFactory.CreateCar (carName);

    //if (car == null)
    //    Console.WriteLine("Can't Maunufacture " + carName);
    //else
    //    Console.WriteLine(car.GetCarName());

    List<ICarFactory> factoryList = new List<ICarFactory>() {new ToyotaFactory(), new HondaFactory() };
    ICar car = null;
    foreach (ICarFactory carFactory in factoryList)
        {
        if (carFactory.CanCreateCar(carName))
            {
            car = carFactory.CreateCar(carName);
            break;
            }
        }

    if (car == null)
        Console.WriteLine("Can't Maunufacture " + carName);
    else
        Console.WriteLine(car.GetCarName());


    //=========================================================
    //CarFactoryProvider carFactoryProvider = new CarFactoryProvider();
    //ICar car = carFactoryProvider.CreateCar(carName);
    //if (car == null)
    //    Console.WriteLine("Can't Maunufacture " + carName);
    //else
    //    Console.WriteLine(car.GetCarName());
}
}
}
