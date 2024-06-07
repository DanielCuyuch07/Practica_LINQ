using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numeros = new[] { 1, 2, 3, 5, 6, 7, 8, 9 };
            //Impares(numeros);
            //Console.ReadLine();

            GestionUniversidad ge = new GestionUniversidad();
            ge.ObtenerEstudiantesMasculinos();
            ge.ObtenerEstudianteFemeninos();
            Console.ReadLine();
        }

        static void Impares(int[] numeros)
        {

            //Console.WriteLine("Cantidades de numeros Impares:");
            //Esta operacion es capaz de decir que numeros pueden ser agregador a la lista
            //IEnumerable<int> numerosImpares = from numero in numeros where numero % 2 != 0 select numero;
            //Console.WriteLine(numerosImpares.Count());

            //Console.WriteLine("Los numeros impares son ");

            //foreach (int i in numerosImpares)
            //{
            //    Console.WriteLine(i);
            //}

        }
    }

    class GestionUniversidad
    {
        public List<Universidad> universidades;
        public List<Estudiante> estudiantes; 

        public GestionUniversidad()
        {
            universidades = new List<Universidad>();
            estudiantes = new List<Estudiante>();

            //Agregar Universidades
            universidades.Add(new Universidad { Id = 1, Nombre = "UNC" });
            universidades.Add(new Universidad { Id = 2, Nombre = "UBA" });

            //Agregar Estudiantes
            estudiantes.Add(new Estudiante { Id = 1, Nombre = "Carla", Genero = "femenino", Edad = 19, UniversidadId = 1 });
            estudiantes.Add(new Estudiante { Id = 2, Nombre = "Mateo", Genero = "masculino", Edad = 21, UniversidadId = 1 });
            estudiantes.Add(new Estudiante { Id = 3, Nombre = "Franco", Genero = "masculino", Edad = 22, UniversidadId = 2 });
            estudiantes.Add(new Estudiante { Id = 4, Nombre = "Lara", Genero = "femenino", Edad = 19, UniversidadId = 2 });
            estudiantes.Add(new Estudiante { Id = 5, Nombre = "Javier", Genero = "no binario", Edad = 25, UniversidadId = 2 });
            estudiantes.Add(new Estudiante { Id = 6, Nombre = "Lorena", Genero = "femenino", Edad = 22, UniversidadId = 2 });
        }

        public void ObtenerEstudiantesMasculinos()
        {
            // Filtrar todos los generos masculinos 
            IEnumerable<Estudiante> estudiantesMasculinos  = from estudiante in estudiantes where estudiante.Genero == "masculino" select estudiante;
            Console.WriteLine("Estudiantes Masculinos");
            foreach(Estudiante est in estudiantesMasculinos)
            {
                est.MostrarEstudiante();
            }
        }

        public void ObtenerEstudianteFemeninos()
        {
            IEnumerable<Estudiante> estudiantesFemeninos = from estudiantes in estudiantes where estudiantes.Genero == "femenino" select estudiantes;
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Estudiantes Femeninos");
            foreach (Estudiante est in estudiantesFemeninos)
            {
                est.MostrarEstudiante();
            }
        }

    }

    class Universidad 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void MostrarUniversidad()
        {
            Console.WriteLine("Universidad {0}, tiene el Id {1}", Nombre, Id);
        }
    }

    class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public int UniversidadId { get; set; }

        public void MostrarEstudiante()
        {
            Console.WriteLine("Estudiante : {0} tiene el id {1} edad {2} y un genero {3} y asiste a la universidad {4}", Nombre, Id, Edad, Genero, UniversidadId);

        }
    }
}
