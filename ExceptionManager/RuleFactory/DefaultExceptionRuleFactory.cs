using ExceptionManager.Publisher;
using ExceptionManager.Rules;
using ExceptionManager.Strategy.Strategies;

namespace ExceptionManager.RuleFactory
{
    public class DefaultExceptionRuleFactory : ExceptionRuleFactory
    {
        public override ExceptionRule GetExceptionRule()
        {
            return new ExceptionRule(new PublisherList(), new RunAllStrategy());
        }
    }
}
