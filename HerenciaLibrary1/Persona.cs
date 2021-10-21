using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaLibrary1
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string run;
        protected string direccion;
        protected string telefono;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public string Apellido
        {
            set
            {
                apellido = value;
            }
            get
            {
                return apellido;
            }
        }
        public string Run
        {
            set
            {
                run = value;
            }
            get
            {
                return run;
            }
        }
        public string Direccion
        {
            set
            {
                direccion = value;
            }
            get
            {
                return direccion;
            }
        }
        public string Telefono
        {
            set
            {
                telefono = value;
            }
            get
            {
                return telefono;
            }
        }
        //Se declara virtual para poder sobreescribir
        public virtual void Datos()
        {
            Console.WriteLine("Nombre: "+nombre+" "+ apellido+"\nRun : "+run+"\nDireccion: "+direccion + "\nTelefono: " +telefono+"\n");
        }
    }
}

