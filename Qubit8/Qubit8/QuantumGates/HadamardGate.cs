﻿using Qubit8.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Qubit8
{
    class HadamardGate : QuantumGate
    {
        public override ComplexMatrix Transform { get; protected set; }
        public HadamardGate()
        {
            this.Transform = new ComplexMatrix(2, 2);
            Transform.Matrix[0][0].Real = 1 / System.Math.Sqrt(2);
            Transform.Matrix[0][1].Real = 1 / System.Math.Sqrt(2);
            Transform.Matrix[1][0].Real = 1 / System.Math.Sqrt(2);
            Transform.Matrix[1][1].Real = -1 / System.Math.Sqrt(2);
        }
    }
}
