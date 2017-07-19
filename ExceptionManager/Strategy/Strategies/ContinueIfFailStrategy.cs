using ExceptionManager.Publisher;
using System;

namespace ExceptionManager.Strategy.Strategies
{
    public class ContinueIfFailStrategy : StrategyBase
    {
        public override void Execute(Exception e, PublisherList publisherList)
        {
            foreach (var publisherItem in publisherList)
                try
                {
                    publisherItem.Publish(e);
                }
                catch
                {
                    continue;
                }
        }
    }
}