using ExceptionManager.Rules;

namespace ExceptionManager.Exceptions
{
    public class BusinessException : ExceptionBase
    {
        public BusinessException(string message) : base(message)
        {
        }

        public override void Handle()
        {
            RuleRepository.CriticalRule.Execute(this);
        }

        public override void Handle(ExceptionRule exceptionRule)
        {
            exceptionRule.Execute(this);
        }
    }
}
