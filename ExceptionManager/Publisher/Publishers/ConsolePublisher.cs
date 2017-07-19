using System;

namespace ExceptionManager.Publisher.Publishers
{
    public class ConsolePublisher : PublisherBase   
    {
        protected override void OnPublish(Exception ex)
        {
            Console.WriteLine("Console Publisher");
        }
    }
}
