using System;

namespace CalcularAreasWS
{
    public class CalcularArea  // Cuadrado, Triángulo y Círculo
    {
        public double ladoBase { get; set; }
        public double ladoAltura { get; set; }
        public double radio { get; set; }

        public double AreaCuadrado()
        {
            return ladoBase * ladoBase;
        }

        public double AreaTriangulo()
        {
            return (ladoBase * ladoAltura) / 2;
        }

        public double AreaCirculo()
        {
            return (Math.PI * Math.Pow(radio, 2));
        }
    }
}