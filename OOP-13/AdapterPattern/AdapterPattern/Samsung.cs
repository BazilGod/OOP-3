using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Samsung : IAndroid
    {
        public string RunAndroidGame(string info)
        {
            return   info + "\nrunning";
        }
    }
}
