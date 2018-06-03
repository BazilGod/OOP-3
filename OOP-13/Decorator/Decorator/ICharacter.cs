using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
  public  interface ICharacter
    {
        double Price();
        String Description();
        double Intelligence();
        double Damage();
    }
}
