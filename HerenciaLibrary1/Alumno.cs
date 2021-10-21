using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaLibrary1
{
    public class Alumno:Persona
    {
        private int n_matricula;
        private string curso;
        public int N_matricula
        {
            set
            {
                n_matricula = value;
            }
            get
            {
                return n_matricula;
            }
        }
        public string Curso
        {
            set
            {
                curso = value;
            }
            get
            {
                return curso;            }
        }

        public override void Datos()
        {
            Console.WriteLine("Nombre: " + nombre + " " + apellido + "\nNumero Matricula: " + n_matricula+"\nCurso: "+curso+ "\n");
        }
    }
}
