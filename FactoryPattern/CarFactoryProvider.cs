using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
class CarFactoryProvider
{
private readonly List<ICarFactory> _factories = new List<ICarFactory>();

public CarFactoryProvider()
    {
    _factories.Add (new HondaFactory());
    _factories.Add (new ToyotaFactory());
    }

public ICar CreateCar(string carName)
    {
    ICar car = null;
    foreach (ICarFactory carFactory in _factories)
        {
        if (carFactory.CanCreateCar(carName))
            {
            car = carFactory.CreateCar(carName);
            break;
            }
        }    
    
    return car;
    }

public List<string> GetAvailableCarTypes()
    {
    List<string> cars = new List<string>();
    foreach (ICarFactory carFactory in _factories)
        {
        cars.AddRange (carFactory.CreateableCars());
        }  
    return cars;
    }
}
}
