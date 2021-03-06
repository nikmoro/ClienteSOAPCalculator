using System.Web.Services;

namespace CalcularAreasWS
{
    /// <summary>
    /// Descripción breve de CalcularAreasWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularAreasWebService : System.Web.Services.WebService
    {

        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hola a todos";
        //}

        [WebMethod]
        public double AreaCuadrado(double lado)
        {
            CalcularArea oCal = new CalcularArea();
            return oCal.AreaCuadrado(lado);
        }

        [WebMethod]
        public double AreaTriangulo(double _base, double altura)
        {
            CalcularArea oCal = new CalcularArea();
            return oCal.AreaTriangulo(_base, altura);
        }

        [WebMethod]
        public double AreaCirculo(double radio)
        {
            CalcularArea oCal = new CalcularArea();
            return oCal.AreaCirculo(radio); ;
        }
    }
}
