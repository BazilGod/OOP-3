using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class SkillsDecorator : ICharacter
    {
        
        public ICharacter character;
        public abstract double getDamage();
        public abstract double getPrice();
        public abstract double getIntelligence();

        public SkillsDecorator(ICharacter c)
        {
            this.character = c;
        }
        public virtual double Damage()
        {
            return character.Damage();
        }
        public virtual string Description()
        {
            return character.Description();
        }
        public virtual double Intelligence()
        {
            return character.Intelligence();
        }
        public virtual double Price()
        {
            return character.Price();
        }
    }
}
