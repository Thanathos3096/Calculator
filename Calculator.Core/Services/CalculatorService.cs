﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core.Services
{
    public class CalculatorService : ICalculatorService
    {
        public decimal TipAmount(decimal subTotal, double generosity)
        {
            return subTotal*(decimal)(generosity/100);
        }
    }
}
