using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class CustomException : Exception
    {
        public CustomException() : base("Esta es mi excepción personalizada."){

        }
    }
}
