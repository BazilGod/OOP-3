using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Warrior : ICharacter
    {
        public double Damage() { return 100; }
        public string Description() { return "Tauren warrior"; }
        public double Intelligence() { return 70; }
        public double Price() { return 100; }
      
    }
}
