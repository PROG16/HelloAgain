﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MarcusHultkrantz.Speak());
            AndreasBjörnlund.Speak();
            TanjaSvard.Speak();
            Console.ReadLine();
        }
    }
}
