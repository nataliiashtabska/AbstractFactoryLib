using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibr
{
    public class SodaFactory : IAbstractFactory
    {
        public IDrink CreateDrink(string type)
        {

            return new Soda();

        }

        public IPackaging CreatePackaging(string type)
        {

            return new Can();

        }
        public decimal CalculateTotalCost(decimal drinkPrice, decimal packagingCount)
        {
            return drinkPrice + packagingCount;
        }


    }
}
