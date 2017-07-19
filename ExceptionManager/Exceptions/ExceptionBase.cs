using ExceptionManager.Rules;
using System;

namespace ExceptionManager.Exceptions
{
    public abstract class ExceptionBase : Exception
    {
        public ExceptionBase(string message) : base(message)
        {
        }

        public abstract void Handle();
        public abstract void Handle(ExceptionRule exceptionRule);
    }
}
