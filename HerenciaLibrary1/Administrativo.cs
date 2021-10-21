using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaLibrary1
{
    public class Administrativo:Persona
    {
        private string cargo_Admin;
        private string nombre_Sede;

        public string Cargo_Admin
        {
            set
            {
                cargo_Admin = value;
            }
            get
            {
                return cargo_Admin;
            }
        }
        public string Nombre_Sede
        {
            set
            {
                nombre_Sede = value;
            }
            get
            {
                return nombre_Sede;
            }
        }
        public override void Datos()
        {
            Console.WriteLine("Nombre: " + nombre + " " + apellido + "\nCargo: " + cargo_Admin + "\nSede: " + nombre_Sede+"\n");
        }
    }
}
