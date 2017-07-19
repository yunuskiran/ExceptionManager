using System;

namespace ExceptionManager.Publisher.Publishers
{
    public class TextPublisher : PublisherBase
    {
        protected override void OnPublish(Exception ex)
        {
            Console.WriteLine("Text Publisher");
        }
    }
}
