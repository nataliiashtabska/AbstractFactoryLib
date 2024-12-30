using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibr
{
    public class AbstractFactory : IAbstractFactory
    {
        private readonly Dictionary<string, Func<IPackaging>> _packagingCreators;
        private readonly Dictionary<string, Func<IDrink>> _drinkCreators;

        public AbstractFactory()
        {
            _packagingCreators = new Dictionary<string, Func<IPackaging>>
            {
                { "Bottle", () => new Bottle() },
                { "Can", () => new Can() }
            };

            _drinkCreators = new Dictionary<string, Func<IDrink>>
            {
                { "Juice", () => new Juice() },
                { "Soda", () => new Soda() }
            };
        }

        public IPackaging CreatePackaging(string type)
        {
            if (_packagingCreators.TryGetValue(type, out var creator))
            {
                return creator();
            }

            throw new ArgumentException($"Invalid packaging type: {type}");
        }

        public IDrink CreateDrink(string type)
        {
            if (_drinkCreators.TryGetValue(type, out var creator))
            {
                return creator();
            }

            throw new ArgumentException($"Invalid drink type: {type}");
        }

        public decimal CalculateTotalCost(decimal drinkPrice, decimal packagingCount)
        {
            return drinkPrice + packagingCount;
        }




    }
}
