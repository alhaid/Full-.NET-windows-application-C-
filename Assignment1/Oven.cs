using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Oven
    {
        private static double PopcornKernels;
        private static double Salt;
        private static double Butter;
        private static double CheeseF;
        private static int Degree;

        public Oven() { }

        public Oven(double pop, double salt, double butter, double cheesef, int degree)
        { 
            PopcornKernels = pop;
            Salt = salt;
            Butter = butter;
            CheeseF = cheesef;
            Degree = degree;
        }

        public double pop() { return PopcornKernels; }
        public double salt() { return Salt; }
        public double butter() { return Butter; }
        public double cheesef() { return CheeseF; }
        public int degree() { return Degree; }
    }
}
