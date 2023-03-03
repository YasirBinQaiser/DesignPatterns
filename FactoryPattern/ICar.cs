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

public class ToyotaCar : ICar
{
bool UseSmallBody = false;

public ToyotaCar (bool useSmallBody)
    {
    UseSmallBody = useSmallBody;
    }
public string GetCarName()
    {
    if (UseSmallBody)
        return "Toyota Yaris";

    return "Toyota Corolla";
    }
}


public class HondaCar : ICar
{
bool UseSmallBody = false;

public HondaCar (bool useSmallBody)
    {
    UseSmallBody = useSmallBody;
    }
public string GetCarName()
    {
    if (UseSmallBody)
        return "Honda Civic";

    return "Honda City";
    }
}

}
