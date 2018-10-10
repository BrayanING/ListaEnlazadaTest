using System;
using EjemploListaEnlazada2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace EjemploTest
{
    [TestClass]
    public class EstudianteTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        public void validarEstudianteSinNombre() {
            var miEstudiante = new Estudiante() { nombre = string.Empty, Punteo = 85, Carrera = "Ingeniería"};

            var resultado = miEstudiante.EstudianteValido();
            Assert.IsFalse(resultado);
        }

        public void PunteoMaximoValido() {
            var miEstudiante = new Estudiante() { nombre = "Juan", Punteo = 200, Carrera = "Ingenieria" };

            var resultado = miEstudiante.EstudianteValido();
            Assert.IsFalse(resultado);
            Assert.IsTrue(miEstudiante.Errores.Any());
        }

        //Validar punteo minimo
        public void PunteoMinimoValido()
        {
            var miEstudiante = new Estudiante() { nombre = "Luis", Punteo = -200, Carrera = "Ingenieria" };

            var resultado = miEstudiante.EstudianteValido();
            Assert.IsFalse(resultado);
            Assert.IsTrue(miEstudiante.Errores.Any());
        }
        //Validar Carrera
        public void validarEstudianteSinCarrera()
        {
            var miEstudiante = new Estudiante() { nombre = "Test", Punteo = 85, Carrera = string.Empty };

            var resultado = miEstudiante.EstudianteValido();
            Assert.IsFalse(resultado);
            Assert.IsTrue(miEstudiante.Errores.Any());
        }
        //Validar Estudiante que todo esta correcto
        public void validarEstudianteTest()
        {
            var miEstudiante = new Estudiante() { nombre = "Test", Punteo = 85, Carrera = string.Empty };

            var resultado = miEstudiante.EstudianteValido();
            Assert.IsTrue(resultado);
            Assert.IsFalse(miEstudiante.Errores.Any());
        }
        [TestMethod]
        public void DatosEstudianteResultadoTest()
        {
            var miEstudiante = new Estudiante() { nombre = "Jose", Punteo = 75, Carrera = "Ingenieria" };
            var resultado = miEstudiante.DatosResultados();
            Assert.IsTrue(resultado);
        }



    }
}
