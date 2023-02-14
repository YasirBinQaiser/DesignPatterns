using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
public interface ICarFactory
    {
    string GetFactoryName();
    bool CanCreateCar(string carName);
    ICar CreateCar(string carName);
    List <string> CreateableCars();

    }

public class ToyotaFactory : ICarFactory
{

List<string> _CarList = new List<string>() { "Corolla", "Yaris" };

public string GetFactoryName()
    {
    return "Toyota";
    }

public bool CanCreateCar(string carName)
    {
    return _CarList.Contains (carName);
    }

public List<string> CreateableCars()
    {
    return _CarList;
    }
public ICar CreateCar(string carName)
    {
    if (carName == "Corolla")
        return new Corolla();

    return new Yaris();
    }
}

public class HondaFactory : ICarFactory
{
List<string> _CarList = new List<string>() { "Civic", "City" };
public bool CanCreateCar(string carName)
    {
    return _CarList.Contains (carName);
    }

public string GetFactoryName()
    {
    return "Honda";
    }
public List<string> CreateableCars()
    {
    return _CarList;
    }
public ICar CreateCar(string carName)
    {
    if (carName == "Civic")
        return new Civic();

    return new City();
    }
}


}
