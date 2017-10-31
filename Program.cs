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
            FredrikHaglund.Speak();
            Console.WriteLine(MarcusHultkrantz.Speak());
            Console.WriteLine(Khalid.Speak());

            AndreasBjörnlund.Speak();

            ErikJonson.Speak();
            MirAlbertioni.MirAlb();
            TanjaSvard.Speak();
            Torbjorn.Speak();
            MattiasClass.SpeakTo();
            MasterSpeaker();
            KlasHasselquist.Speak();
            Console.ReadLine();
            MasterSpeaker();
            MariaKällström.Speak();
           
            Patrik.Speak();
            MasterSpeaker();
            KärbelIlias.Speak();
            Console.ReadLine();
        }

        static void MasterSpeaker()
        {
            Calle.Speak();
            PerlyGustafsson.Speak();
        }
    }
}
