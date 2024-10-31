using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class TooYoungException : Exception
    // creating a custom exception to raise.
    {
        public TooYoungException() : base() { }
        public TooYoungException(string message) : base(message) { }
    }
}
