using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
   public class Mage:ICharacter
    {
        public double Damage() { return 70; }

        public string Description() { return "Stormwind mage"; }

        public double Intelligence() { return 90; }
        public double Price() { return 100; }
    }
    }
