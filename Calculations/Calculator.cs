﻿using System;

namespace Calculations
{
    public class Calculator
    {
        public int Soma(int operador1, int operador2) => operador1 + operador2;
        public int Subtracao(int operador1, int operador2) => operador1 - operador2;
        public int Multiplicao(int operador1, int operador2) => operador1 * operador2;
        public int Divisao(int dividendo, int divisor) => dividendo / divisor;
        public (int quociente, int resto) RestoDivisao(int dividendo, int divisor) => (dividendo / divisor, dividendo % divisor);
    }
}
