using ExceptionManager.Publisher;
using ExceptionManager.Publisher.Publishers;
using ExceptionManager.Strategy.Strategies;

namespace ExceptionManager.Rules
{
    public class RuleRepository
    {
        private static ExceptionRule _criticalRule = new ExceptionRule(new PublisherList() { new ConsolePublisher(), new TextPublisher(), new SQLPublisher() }, new RunAllStrategy());
        private static ExceptionRule _stantardRule = new ExceptionRule(new PublisherList() { new ConsolePublisher(), new TextPublisher(), new SQLPublisher() }, new RunAllStrategy());


        public static ExceptionRule CriticalRule => _criticalRule;
        public static ExceptionRule StandartRule => _stantardRule;
    }
}
