using System;

namespace ExceptionManager.Publisher.Publishers
{
    public class SQLPublisher : PublisherBase
    {
        protected override void OnPublish(Exception ex)
        {
            Console.WriteLine("Sql Publisher");
        }
    }
}
