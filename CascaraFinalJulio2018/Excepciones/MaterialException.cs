using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exception;

namespace Excepciones
{
    public class MaterialException : Exception
    {


        public MaterialException(string mensaje)
            : base(mensaje)
        {



        }
    }
}
