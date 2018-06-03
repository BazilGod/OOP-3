using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
   public class AddPVPGear:SkillsDecorator
    {
        public AddPVPGear(ICharacter C) : base(C) { }

        public override double Damage()
        {
            return 100 + base.Damage();
        }

        public override string Description()
        {
            return   base.Description()+ " PVP gear ";
        }

        public override double Intelligence()
        {
            return 50 + base.Intelligence() ;
        }

        public override double Price()
        {
            return 300 + base.Price();
        }
        public override double getDamage()
        {
            return 100;
        }
        public override double getPrice()
        {
            return 300;
        }
        public override double getIntelligence()
        {
            return 50;

        }
    }
}
