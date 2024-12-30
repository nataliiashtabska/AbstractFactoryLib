using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibr
{
    public class JuiceFactory : IAbstractFactory
    {
        public IDrink CreateDrink(string type)
        {
            return new Juice();
        }

        public IPackaging CreatePackaging(string type)
        {
            return new Bottle();
        }
        public decimal CalculateTotalCost(decimal drinkCost, decimal packagingCount)
        {
            return drinkCost + packagingCount;
        }



    }
}
