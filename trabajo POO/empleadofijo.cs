using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_POO
{
    class empleadofijo : empleado
    {

        public int añodeentrada { get; set; }


        public empleadofijo(string nombre, string apellido, int edad, string departamento, int sueldo) : base(nombre, apellido, edad, departamento, sueldo)
        {
            this.añodeentrada = añodeentrada;
            this.sueldo = sueldo;

        }


        public int getañodeentrada()
        {
            return añodeentrada;
        }
        public void setañodeentrada(int añodeentrada)
        {
            this.añodeentrada = añodeentrada;
        }


        public void imprimirdatosempleadofijo()
        {
            Console.WriteLine("Nombre del empleado: " + getnombre() + "apellido: " + getapellido() + "edad: " + getedad() + "año de entarda: " + añodeentrada);
        }
    }
}

