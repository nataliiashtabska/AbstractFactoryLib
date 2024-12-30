using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibr
{
    public class Soda : IDrink
    {
        public string GetName() => "Soda";
    }
}