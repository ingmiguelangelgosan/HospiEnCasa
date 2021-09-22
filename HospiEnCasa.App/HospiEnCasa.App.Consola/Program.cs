using System;       
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {

        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework!");
            AddPaciente();
        }

        private static void AddPaciente() {

            var paciente = new Paciente {
                Nombre = "Nicolay",
                Apellidos = "Perez",
                NumeroTelefono = "3206807252",
                Genero = Genero.masculino,
                Direccion = "Calle 4 No 7-4",
                Longitud = 5.0706F,
                Latitud = -75.52290F,
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime (1990, 04, 12)

            };
            _repoPaciente.AddPaciente(paciente);
        }
    }
}
