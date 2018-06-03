using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class AddShield:SkillsDecorator
    {
       
        public AddShield(ICharacter C) : base(C) { }

        public override double Damage()
        {
            return 1 + base.Damage();
        }

        public override string Description()
        {
            return base.Description() + " Shield ";
        }

        public override double Intelligence()
        {
            return 10 + base.Intelligence();
        }

        public override double Price()
        {
            return 30 + base.Price();
        }
        public override double getDamage()
        {
            return 1;
        }
        public override double getPrice()
        {
            return 30;
        }
        public override double getIntelligence()
        {
            return 10;

        }
    }
}
