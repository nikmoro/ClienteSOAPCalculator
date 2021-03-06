﻿using System;

namespace CalcularAreasWS
{
    public class CalcularArea
    {
        public double AreaCuadrado(double lado)
        {
            return lado * lado;
        }

        public double AreaTriangulo(double _base, double altura)
        {
            return (_base * altura) / 2;
        }

        public double AreaCirculo(double radio)
        {
            return (Math.PI * Math.Pow(radio, 2));
        }
    }
}