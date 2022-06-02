using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenbailonp
{
    public class estudiantes
    {

        public string nombre { get; set; }
        public string apellido { get; set; }
        public string institucion { get; set; }
        public int cedula { get; set; }
        public int pago { get; set; }

        public estudiantes(string nombre, string apellido, string institucion, int cedula ,int pago) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.institucion = institucion;
            this.cedula = cedula;
            this.pago = pago;

        }


        public void imprimirpago()
        {
            Console.WriteLine("\n**Datos Estudiante**" + "\nNombre: " + nombre + "\nApellido: " + apellido + "\nEdad: " + institucion
                + "\ncedula: " + cedula + "\npago: " + pago);
        }





        public string getnombre()
        {
            return nombre;
        }
        public void setnombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getapellido()
        {
            return apellido;
        }
        public void setapellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string getinstitucion()
        {
            return institucion;
        }
        public void setinstitucion(string institucion)
        {
            this.institucion = institucion;
        }

        public int getcedula()
        {
            return cedula;
        }
        public void setcedula(int cedula)
        {
            this.cedula = cedula;
        }

        public int getpago()
        {
            return pago;
        }
        public void setpago(int pago)
        {
            this.pago = pago;
        }
    }

}
