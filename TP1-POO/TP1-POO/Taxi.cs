using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_POO
{
    public class Taxi : Transporte
    {
        public Taxi(int pasajeros, string tipo, string nombre) : base(pasajeros, tipo, nombre)
        {

        }
        public override void avanzar()
        {
            throw new NotImplementedException();
        }

        public override void detenerse()
        {
            throw new NotImplementedException();
        }

        public override string ListarTransporte()
        {
            return $"Candidad de pasajeros del {tipo}: {pasajeros}";
        }
    }
}
