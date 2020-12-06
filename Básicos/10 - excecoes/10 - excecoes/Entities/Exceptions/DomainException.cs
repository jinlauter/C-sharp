using System;
using System.Collections.Generic;
using System.Text;

namespace _10___excecoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
