using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class AddArmor:SkillsDecorator
    {
 
        public AddArmor(ICharacter C) : base(C) { }

        public override double Damage()
        {
            return 15 + base.Damage();
        }

        public override string Description()
        {
            return base.Description() + " Armor ";
        }

        public override double Intelligence()
        {
            return 50 + base.Intelligence();
        }

        public override double Price()
        {
            return 180 + base.Price();
        }
        public override double getDamage()
        {
            return 15;
        }
        public override double getPrice()
        {
            return 100;
        }
        public override double getIntelligence()
        {
            return 50;

        }
    }
}
