﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.App
{
    public class Calculator
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Multiplicate(int a,int b)
        {
            if(a==0 || b==0)
            {  return 0; }
            return a * b;
        }
    }
}