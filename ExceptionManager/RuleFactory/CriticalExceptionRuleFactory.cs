using ExceptionManager.Publisher;
using ExceptionManager.Publisher.Publishers;
using ExceptionManager.Rules;
using ExceptionManager.Strategy.Strategies;

namespace ExceptionManager.RuleFactory
{
    public class CriticalExceptionRuleFactory : ExceptionRuleFactory
    {
        public override ExceptionRule GetExceptionRule()
        {
            var p = new PublisherList {new TextPublisher(), new SQLPublisher()};
            return new ExceptionRule(p, new ContinueIfFailStrategy());
        }
    }
}