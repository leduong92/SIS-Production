using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Utilities.Exceptions
{
    public class SisException : Exception
    {
        public SisException()
        {
        }

        public SisException(string message)
            : base(message)
        {
        }

        public SisException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
