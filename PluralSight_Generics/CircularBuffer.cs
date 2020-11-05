using System;
using System.Collections.Generic;
using System.Collections; 
using System.Text;

namespace PluralSight_Generics
{


    public interface IBuffer<T> : IEnumerable<T>{ 
        bool IsEmpty { get; }
        void Write(T value);
        T Read(); 
    }

    public class Buffer<T> : IBuffer<T>
    {

        //Implementing a queue which is a Fifo

       protected Queue<T> _queue = new Queue<T>();
        public virtual bool IsEmpty => (_queue.Count == 0); 

        public virtual T Read()
        {
           return _queue.Dequeue(); 
        }

        public virtual  void Write(T value)
        {
            _queue.Enqueue(value); 
        }


        public IEnumerator<T> GetEnumerator() {
            foreach (var item in _queue) {
                //...
                yield return item; 
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this.GetEnumerator(); 
        }
    }
    public class CircularBuffer<T> : Buffer<T>
    {
        int _capacity;

        public bool IsFull { get { return _queue.Count == _capacity; } }
        public CircularBuffer(int capacity) {
            this._capacity = capacity; 
        }

        public override void Write(T value) {
            base.Write(value);
            if (IsFull) {
                _queue.Dequeue(); 
            }
        }

    }
}
