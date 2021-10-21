using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaLibrary1
{
    public class Profesor:Persona
    {
        private string especialidad;
        private int n_horas;

        public string Especialidad
        {
            set
            {
                especialidad = value;
            }
            get
            {
                return especialidad;
            }
        }
        public int N_horas
        {
            set
            {
                n_horas = value;
            }
            get
            {
                return n_horas;
            }
        }
        public override void Datos()
        {
            Console.WriteLine("Nombre: " + nombre + " " + apellido + "\nEspecialdiad: " + especialidad + "\nNumero de horas: " + n_horas+"\n");
        }
    }
}
