using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenbailonp
{
    class segundaria : estudiantes
    {
        public int nivelescursados { get; set; }
        public int preciofijo{ get; set; }
        int calcular;
        public segundaria(string nombre, string apellido, string institucion, int cedula, int pago) : base(nombre, apellido, institucion, cedula ,pago)
        {
            this.nivelescursados = nivelescursados;
            this.preciofijo = preciofijo;
        }
        public int getnivelescursados()
        {
            return nivelescursados;
        }
        public void setnivelescursados(int nivelescursados)
        {
            this.nivelescursados = nivelescursados;
        }
        public int getpreciofijo()
        {
            return preciofijo;
        }
        public void setpreciofijo(int preciofijo)
        {
            this.preciofijo = preciofijo;
        }
        public void imprimirpreciofijo()
        {
            int calular = nivelescursados * preciofijo;
            Console.WriteLine("su precio es " + calcular);
        }
       
        }
}
