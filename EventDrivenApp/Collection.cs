
using System.Collections;


namespace EventDrivenApp
{
    public class Collection: IEnumerable<ISubscriber>
    {
        private readonly List<ISubscriber> _subscribers = new();
        
        public void AddSubscriber(ISubscriber sub)
        {
            _subscribers.Add(sub);
        }

        public IEnumerator<ISubscriber> GetEnumerator()
        {
            return new SubscriberEnumnerator(_subscribers);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class SubscriberEnumnerator : IEnumerator<ISubscriber>
        {
            private readonly List<ISubscriber> _subscribers;
            private int _index = -1;

            public SubscriberEnumnerator(List<ISubscriber> subscribers)
            {
                _subscribers = subscribers;
            }
            public ISubscriber Current => _subscribers[_index];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                return ++_index < _subscribers.Count;
            }

            public void Reset()
            {
                _index = -1;
            }
        }
    }
}
