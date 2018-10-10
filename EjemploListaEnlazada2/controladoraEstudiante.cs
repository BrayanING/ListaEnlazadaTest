using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListaEnlazada2
{
    public class controladoraEstudiante
    {
        Lista MiLista;
        public controladoraEstudiante()
        {
           MiLista  = new Lista();
        }

        public  int cargarEstudiante()
        {
            var estudiante = new Estudiante() { nombre = "luis", Punteo = 76, Carrera = "Ingenieria" };
            var estudiante1 = new Estudiante() { nombre = "jose", Punteo = 89, Carrera = "Ingenieria" };
            var estudiante2 = new Estudiante() { nombre = "carlos", Punteo = 76, Carrera = "Ingenieria" };

            MiLista.InsertarInicioLista(estudiante);
            MiLista.InsertarInicioLista(estudiante1);
            MiLista.InsertarInicioLista(estudiante2);

            return MiLista.counter;
        }

        public bool existeEstudiante(string nombre)
        {
            var dato = MiLista.obtenerEstudiantePorNombre(nombre);
            return (dato != null) ? true : false;
        }

        public string filtraEstudiante(string nombre)
        {
            var estudiante = (Estudiante) MiLista.obtenerEstudiantePorNombre(nombre);
            return (estudiante != null) ? "Nombre: " + estudiante.nombre + " Punteo: " + estudiante.Punteo + " Carrera: " + estudiante.Carrera : null;

        }


    }
}
 