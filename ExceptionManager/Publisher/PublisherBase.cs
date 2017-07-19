using System;

namespace ExceptionManager.Publisher
{
    public abstract class PublisherBase
    {
        protected PublisherBase _nextPublisherBase;
        public virtual void SetNextPublisher(PublisherBase publisherBase)
        {
            _nextPublisherBase = publisherBase;
        }

        public virtual void Publish(Exception e)
        {
            OnPublish(e);
        }

        protected abstract void OnPublish(Exception ex);

    }
}
