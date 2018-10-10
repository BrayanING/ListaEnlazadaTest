using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListaEnlazada2
{
    public class Lista
    {
        public Nodo primero;
        public int counter = 0;

        public Lista()
        {
            primero = null;
        }

        public void InsertarInicioLista(object pDato)
        {
            Nodo nuevo = new Nodo(pDato);
            nuevo.enlace = primero;
            primero = nuevo;
            counter++;
        }


        public Nodo buscarLista(object destino)
        {
            Nodo indice;
            for (indice = primero; indice != null; indice = indice.enlace)
                if (destino.Equals(indice.Dato))  //(destino == indice.Dato) // 
                    return indice;
            return null;
        }

        public object obtenerEstudiantePorNombre(string nombre)
        {
            Nodo indice;
            bool flag = false;
            Estudiante estudiante = new Estudiante();
            for (indice = primero; indice != null; indice = indice.enlace)
            {
                estudiante = (Estudiante)indice.Dato;
                if (estudiante.nombre == nombre)  //(destino == indice.Dato) // 
                {
                    flag = true;
                    break;
                }
            }

            return (flag) ? estudiante : null;
        }


    }
}
