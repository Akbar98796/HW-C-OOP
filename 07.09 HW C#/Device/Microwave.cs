﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Device
{
    internal class Microwave : Device
    {
        public override void Desc()
        {
            Console.WriteLine("для подогрева еды");
        }

        public override void Show()
        {
            Console.WriteLine("Microwave");
        }

        public override void Sound()
        {
            Console.WriteLine("дыын дыын дыыын......");
        }
    }
}
