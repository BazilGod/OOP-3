using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class AddDamagePotions:SkillsDecorator
    {

        public AddDamagePotions(ICharacter C) : base(C) { }

        public override double Damage()
        {
            return 50 + base.Damage();
        }

        public override string Description()
        {
            return base.Description() + " damage potion ";
        }

        public override double Intelligence()
        {
            return 0 + base.Intelligence();
        }

        public override double Price()
        {
            return 5 + base.Price();
        }
        public override double getDamage()
        {
            return 50;
        }
        public override double getPrice()
        {
            return 5;
        }
        public override double getIntelligence()
        {
            return 0;

        }
    }
}
