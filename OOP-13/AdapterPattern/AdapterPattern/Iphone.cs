using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Iphone : IIos
    {
        public string RunIosGame(string info)
        {
            return info + "\nrunning";
        }
    }
}
