using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo_de_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la cantidad de alumnos");
            int cantidadAlumnos= int.Parse(Console.ReadLine());
            Alumnos[] a=new Alumnos[cantidadAlumnos];
            for (int i=0; i<cantidadAlumnos; i++)
            {
                Console.WriteLine("Ingresa el nombre del alumno"+(i+1));
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingresa la calificacion del alumno" + (i + 1));
                double calificacion = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el aula del alumno" + (i + 1));
                char aula = Console.ReadLine()[0];
                a[i] = new Alumnos(nombre,calificacion, aula);

            }
            double suma = 0;
            double promedio = 0;
            int cantidadAlumnosSalon = 0;
            Console.WriteLine("Que aula desea promediar las calificaciones?");
            char salon = Console.ReadLine()[0];
            for (int i=0;i<cantidadAlumnos;i++)
            {
                if (salon == a[i].getAula())
                {
                    suma = suma + a[i].getCalificacion();
                    cantidadAlumnosSalon++;
                }
            }
            promedio = suma / cantidadAlumnosSalon;
            Console.WriteLine("El promedio de los alumnos del salon" +salon+" es "+promedio);
            Console.Read();
        }
    }
}
