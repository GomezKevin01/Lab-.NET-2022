using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Logic
    {
        public static void DispararExceptionX()
        {
            throw new Exception();

        }

        public static void CustomException()
        {
            throw new CustomException();
        }
    }
}
