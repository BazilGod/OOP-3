using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class AddWeapon : SkillsDecorator
    {
        
        public AddWeapon(ICharacter C) : base(C) { }

        public override double Damage()
        {
            return 10 + base.Damage();
        }

        public override string Description()
        {
          
            return base.Description() + " Weapon ";
        }

        public override double Intelligence()
        {
            return 40 + base.Intelligence();
        }

        public override double Price()
        {
            return 45.5 + base.Price();
        }
        public override double getDamage()
        {
            return 10;
        }
        public override double getPrice()
        {
            return 40;
        }
        public override double getIntelligence()
        {
            return 45.5;

        }
    }
}
