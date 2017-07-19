using ExceptionManager.Publisher;
using System;

namespace ExceptionManager.Strategy
{
    public abstract class StrategyBase
    {
        public abstract void Execute(Exception e, PublisherList publisherList);
    }
}