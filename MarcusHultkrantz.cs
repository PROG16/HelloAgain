using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAgain
{
    public static class MarcusHultkrantz
    {
        public static string Speak()
        {
            var speak = "";
            for (int i = 0; i < 100; i++)
            {
                speak += "Marcus Hultkrantz talar!!!!";
            }
            return speak;
        }
    }
}
