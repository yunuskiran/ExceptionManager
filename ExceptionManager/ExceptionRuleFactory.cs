using ExceptionManager.Rules;

namespace ExceptionManager
{
    public abstract class ExceptionRuleFactory
    {
        public abstract ExceptionRule GetExceptionRule();
    }
}
