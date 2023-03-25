using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_hospital
{
    internal class UnmatchingRegisterPasswordException : Exception
    {
        public UnmatchingRegisterPasswordException() {}
        public UnmatchingRegisterPasswordException(string message) : base(message) {}
    }
}
