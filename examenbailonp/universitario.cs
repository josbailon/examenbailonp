using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenbailonp
{
    class universitarios : estudiantes

    {
        public int cantidaddecredito { get; set; }
        public int preciodecredito { get; set; }
        public universitarios(string nombre, string apellido, string institucion, int cedula, int pago) : base(nombre, apellido, institucion, cedula, pago)
        {
            this.cantidaddecredito = cantidaddecredito;
            this.preciodecredito = preciodecredito;
        }
        public string getcantidaddecredito()
        {
            return nombre;
        }
        public void setcantidaddecredito(int cantidaddecredito)
        {
            this.cantidaddecredito = cantidaddecredito;
        }
        public string getpreciocredito()
        {
            return nombre;
        }
        public void setpreciocredito(int preciocretido)
        {
            this.preciodecredito = preciodecredito;
        }
        public void valormatriculacreditos()
        {
            int valor=cantidaddecredito* preciodecredito;
            Console.WriteLine("su credito es " +valor);
        }
    }
}
