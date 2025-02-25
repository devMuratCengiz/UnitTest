﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.App
{
    public class Calculator
    {
        private readonly ICalculatorService _calculatorService;

        public Calculator(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public int Add(int a,int b)
        {
            return _calculatorService.Add(a,b);
        }
        public int Multip(int a,int b)
        {
            return _calculatorService.Multip(a,b);
        }
    }
}
