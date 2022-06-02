using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenbailonp
{
    class primaria : estudiantes
    {

        public int valorxaño { get; set; }
        public int valorxmeses { get; set; }

        public int calculo;
        public primaria(string nombre, string apellido, string institucion, int cedula, int pago) : base(nombre, apellido, institucion, cedula, pago) {

            this.valorxaño = valorxaño;
            this.valorxmeses = valorxmeses;

        }




        public int getvalorxaño()
        {
            return valorxaño;
        }
        public void setvalorxaño(int valorxaño)
        {
            this.valorxaño = valorxaño;
        }
        public int getvalorxmeses()
        {
            return valorxaño;
        }
        public void setvalorxmeses(int valorxmeses)
        {
            this.valorxmeses= valorxmeses;
        }

        public void calculoprimaria()
        {
            int calculo = valorxaño * valorxmeses;
            }



    }
}
    








