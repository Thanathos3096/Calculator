using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Quadratic.Core.Services
{
    public class QuadraticService : IQuadraticService
    {
        public double GetQuadraticpos(int A, int B, int C)
        {

            return (-B + Math.Sqrt((B * B) - (4 * A * C))) / (2 * A);
            
        }
        public double GetQuadraticneg(int A, int B, int C)
        {
            return (-B - (Math.Sqrt((B * B) - (4 * A * C)))) / (2 * A);

        }
    }
}
