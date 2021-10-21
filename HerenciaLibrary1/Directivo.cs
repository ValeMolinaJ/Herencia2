using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaLibrary1
{
   public class Directivo:Persona
    {
        private string cargo_Directivo;
        private string nombre_Sede;

        public string Cargo_Directivo
        {
            set
            {
                cargo_Directivo = value;
            }
            get
            {
                return cargo_Directivo;
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
            Console.WriteLine("Nombre: " + nombre + " " + apellido + "\nCargo: " + cargo_Directivo + "\nSede: " + nombre_Sede);
        }
    }
}
