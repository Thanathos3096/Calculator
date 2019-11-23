using System;
using System.Collections.Generic;
using System.Text;

namespace Quadratic.Core.Services
{
    public interface IQuadraticService
    {
        double GetQuadraticpos(int A, int B, int C);
        double GetQuadraticneg(int A, int B, int C);

    }
}
