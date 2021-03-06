using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcularAreasWS
{
    public class CalcularArea  // Cuadrado, Triángulo y Círculo
    {
        public double ladoBase { get; set; }
        public double ladoAltura { get; set; }
        public double radio { get; set; }

        public double AreaCuadrado(double lado)
        {
            lado = ladoBase;

            return ladoBase * ladoBase;
        }

        public double AreaTriangulo(double _base, double altura)
        {
            _base = ladoBase;
            altura = ladoAltura;

            return (ladoBase * ladoAltura) / 2;
        }

        public double AreaCirculo(double r)
        {
            r = radio;

            return (Math.PI * Math.Pow(radio,2));
        }
    }
}