using ExceptionManager.Publisher;
using ExceptionManager.Strategy;
using System;

namespace ExceptionManager.Rules
{
    public class ExceptionRule
    {
        private readonly PublisherList _publisherList;
        private readonly StrategyBase _strategyBase;

        public ExceptionRule(PublisherList publisherList, StrategyBase strategyBase)
        {
            _publisherList = publisherList;
            _strategyBase = strategyBase;
        }

        public void Execute(Exception e)
        {
            _strategyBase.Execute(e, _publisherList);
        }
    }
}
