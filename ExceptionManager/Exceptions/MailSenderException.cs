using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionManager.Rules;

namespace ExceptionManager.Exceptions
{
    public class MailSenderException : ExceptionBase
    {
        public MailSenderException(string message) : base(message)
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
