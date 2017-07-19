using ExceptionManager.Rules;

namespace ExceptionManager.Exceptions
{
    public class UserException : ExceptionBase
    {
        public UserException(string message) : base(message)
        {
        }

        public override void Handle()
        {
            RuleRepository.StandartRule.Execute(this);
        }

        public override void Handle(ExceptionRule exceptionRule)
        {
            exceptionRule.Execute(this);
        }
    }
}
