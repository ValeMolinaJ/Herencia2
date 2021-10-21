using System;
using HerenciaLibrary1;

namespace HerenciaApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona();
            per.Nombre = "Ignacio";
            per.Apellido = "Contreras";
            per.Run = "19.325.697-9";
            per.Direccion ="Las araucarias 283";
            per.Telefono = "90831214";
            per.Datos();

            Alumno al = new Alumno();
            al.Nombre = "Martina";
            al.Apellido = "Gonzalez";
            al.N_matricula = 19539;
            al.Curso = "Administración";
            al.Datos();

            Profesor prof = new Profesor();
            prof.Nombre = "Carolina";
            prof.Apellido = "Ruiz";
            prof.Especialidad = "Analisis de datos";
            prof.N_horas = 24;
            prof.Datos();

            Administrativo admi = new Administrativo();
            admi.Nombre = "Lucia";
            admi.Apellido = "Gonzalez";
            admi.Cargo_Admin = "Recaudación";
            admi.Nombre_Sede = "Sede Los Angeles";
            admi.Datos();

            Directivo direc = new Directivo();
            direc.Nombre = "Rodrigo";
            direc.Apellido = "Fuentes";
            direc.Cargo_Directivo = "Rector";
            direc.Nombre_Sede = "Sede Los Angeles";
            direc.Datos();
            Console.ReadKey();
        }
    }
}
