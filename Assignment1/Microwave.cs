using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Microwave
    {
        private static double PopcornKernels;
        private static double Salt;
        private static double Butter;
        private static double CheeseF;

        public Microwave() { }

        public Microwave(double pop, double salt, double butter, double cheesef)
        { 
            PopcornKernels = pop;
            Salt = salt;
            Butter = butter;
            CheeseF = cheesef;
        }

        public double pop() { return PopcornKernels; }
        public double salt() { return Salt; }
        public double butter() { return Butter; }
        public double cheesef() { return CheeseF; }

    }
}
