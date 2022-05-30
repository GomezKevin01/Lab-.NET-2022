using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_POO
{
    public abstract class Transporte
    {
        public int pasajeros { get; set; }
        public string tipo { get; set; }
        public string nombre { get; set; }


        public Transporte(int pasajeros, string tipo, string nombre)
        {
            this.pasajeros = pasajeros;
            this.tipo = tipo;
            this.nombre = nombre;
        }

        public abstract void avanzar();

        public abstract void detenerse();

        public abstract string ListarTransporte();
    }
}
