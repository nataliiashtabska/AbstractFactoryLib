using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibr
{
    public interface IAbstractFactory
    {
        IPackaging CreatePackaging(string type);
        IDrink CreateDrink(string type);

        decimal CalculateTotalCost(decimal drinkPrice, decimal packagingCount);


    }
}