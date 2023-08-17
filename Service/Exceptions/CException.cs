using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    public class CException :Exception
    {
        public CException(string message) : base(message)
        {
        }

        public CException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
