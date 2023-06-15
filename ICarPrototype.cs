using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternExample_ConsoleApp
{
    public interface ICarPrototype
    {
        ICarPrototype Clone();
    }

}
