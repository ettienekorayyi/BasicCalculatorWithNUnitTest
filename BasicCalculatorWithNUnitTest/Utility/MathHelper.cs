﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculatorWithNUnitTest.Utility
{
    class MathHelper
    {
        public int Add(int first,int second)
        {
            return first + second;
        }
        public int Subtract(int first, int second)
        {
            return first - second;
        }
        public int Divide(int first, int second)
        {
            return first / second;
        }
        public int Multiply(int first, int second)
        {
            return first * second;
        }
    }
}
