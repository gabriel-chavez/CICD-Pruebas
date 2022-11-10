using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiSaludar.Controllers;

namespace TestProyect.WebApi
{
    public class SaludarController_Tests
    {
        [Fact]
        public void Get_Correctly()
        {
            var resultadoEsperado = "Hola Geovanna!";
            SaludarController saludarController = new SaludarController();
            var resultado = saludarController.Get();
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
