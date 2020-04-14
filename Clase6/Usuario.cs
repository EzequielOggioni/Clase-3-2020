using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase6
{
    public class Usuario
    {
        string Nombre;
        string Apellido;
        double DNI;

       public  Usuario(string nombre, string apellido, double dni)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.DNI = dni;


        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Apellido :" + Apellido);
            sb.AppendLine("Nombre :" + Apellido);
            sb.AppendFormat("DNI : {0}", DNI);
            return sb.ToString();

        }
    }
}
