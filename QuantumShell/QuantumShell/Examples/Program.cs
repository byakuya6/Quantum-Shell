﻿using QuantumShell.Examples;
using QuantumShell.Math;
using QuantumShell.QuantumGates;
using QuantumShell.QuantumGates.RotationGates;
using QuantumShell.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace QuantumShell
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorization factorizationProblem = new Factorization();
            factorizationProblem.OrderFindingQuantumSubroutine();

            //Interpreter interpreter = new Interpreter();
            //interpreter.Run();
        }

        

        

        private static int Xor(int x, int y)
        {
            return x ^ y;
        }

        private static int f(int x)
        {
            switch (x)
            {
                case 0:
                    return 14;
                case 1:
                    return 9;
                case 2:
                    return 8;
                case 3:
                    return 2;
                case 4:
                    return 12;
                case 5:
                    return 0;
                case 6:
                    return 3;
                case 7:
                    return 6;
                case 8:
                    return 8;
                case 9:
                    return 2;
                case 10:
                    return 14;
                case 11:
                    return 9;
                case 12:
                    return 3;
                case 13:
                    return 6;
                case 14:
                    return 12;
                case 15:
                    return 6;
            }
            return 0;
        }
    }
}
