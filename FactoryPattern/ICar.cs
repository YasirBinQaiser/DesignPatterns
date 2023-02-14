using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
public interface ICar
    {
    string GetCarName();
    }

public class Yaris : ICar
{
public string GetCarName()
    {
    return "Toyota Yaris";
    }
}

public class Corolla : ICar
{
public string GetCarName()
    {
    return "Toyota Corolla";
    }
}


public class Civic : ICar
{
public string GetCarName()
    {
    return "Honda Civic";
    }
}

public class City : ICar
{
public string GetCarName()
    {
    return "Honda City";
    }
}


}
