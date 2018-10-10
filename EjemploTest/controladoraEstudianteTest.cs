
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploListaEnlazada2;
namespace EjemploTest
{
    [TestClass]
    public class controladoraEstudianteTest
    {
        controladoraEstudiante controlador = new controladoraEstudiante();

        [TestMethod]
        public void verificarCarga()
        {
            int counter = controlador.cargarEstudiante();
            bool estado = counter > 0 ? true : false;
            Assert.IsTrue(estado);
        }

        [TestMethod]
        public void verificarExisteEstudiante()
        {
            controlador.cargarEstudiante();
            var estudiante = controlador.filtraEstudiante("luis");
            bool estado = (estudiante != null) ? true : false;
            Assert.IsTrue(estado);            
        }


        [TestMethod]
        public void verificarNoExisteEstudiante()
        {
            controlador.cargarEstudiante();
            var estudiante = controlador.filtraEstudiante("daniel");
            Assert.IsNull(estudiante);
        }



    }
}
