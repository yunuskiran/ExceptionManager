using ExceptionManager.Rules;
using System;

namespace ExceptionManager
{
    public interface IExceptionManager
    {
        void Initalize();
        void Handle(Exception e);
        void Handle(Exception e, ExceptionRule exceptionRule);
    }
}
