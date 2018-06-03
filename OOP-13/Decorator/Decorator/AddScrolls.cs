using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class AddScrolls:SkillsDecorator
    {

        public AddScrolls(ICharacter C) : base(C) { }

        public override double Damage()
        {
            return 0 + base.Damage();
        }

        public override string Description()
        {
            return base.Description() + " intelligence scroll ";
        }

        public override double Intelligence()
        {
            return 150 + base.Intelligence();
        }

        public override double Price()
        {
            return 10 + base.Price();
        }
        public override double getDamage()
        {
            return 0;
        }
        public override double getPrice()
        {
            return 10;
        }
        public override double getIntelligence()
        {
            return 150;

        }
    }
}
