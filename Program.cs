using System;

namespace Arrays_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays implícitos
            var Numeros = new[] { 09, 22, 20.04, 20 };
            Console.WriteLine(Numeros[0]);

            //Arrays de objetos
            Estudiantes[] datosEstu = new Estudiantes[5];
            Estudiantes estudiante1 = new Estudiantes("Hamel", 19, "Ing. en Sistemas");
            Estudiantes estudiante2 = new Estudiantes("Juan", 22, "Medicina");
            datosEstu[2] = new Estudiantes("Ana", 20, "Psicología");
            datosEstu[3] = new Estudiantes("Lucas", 24, "Informatica");
            datosEstu[4] = new Estudiantes("Milagros", 18, "Arquitectura");

            datosEstu[0] = estudiante1;
            datosEstu[1] = estudiante2;
            Console.WriteLine($"{datosEstu[2].getEstudiante()}");//Salida por consola
            
            //Arrays de clases anónimas
            var Empleados = new[]
            {
                new{Nombre = "Felipe", Edad = 30},
                new{Nombre = "Miguel", Edad = 28},
                new{Nombre = "Marcos", Edad = 41},
                new{Nombre = "Victor", Edad = 19}
            };
            Console.WriteLine(Empleados[1]);

        }
    }
    class Estudiantes
    {
        private String nombre;
        private int edad;
        private String carrera;

        public Estudiantes(String nombre, int edad, String carrera)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.carrera = carrera;
        }
        public String getEstudiante() 
        {
            return "Nombre: " + nombre + " Edad: " + edad + " Carrera: " + carrera;
        }
    }
}
