using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace GenericApp
{
    public class MultiDictionary<TK, TV> : IMultiDictionary<TK, TV>, IEnumerable<KeyValuePair<TK, IEnumerable<TV>>>
    {
        private readonly Dictionary<TK, LinkedList<TV>> _dic = new Dictionary<TK, LinkedList<TV>>();
        private readonly object _sync = new object();
        //private readonly ReaderWriterLockSlim _reader = new ReaderWriterLockSlim();
        //private readonly ConcurrentDictionary<TK, LinkedList<TV>>  _concurrentDictionary= new ConcurrentDictionary<TK, LinkedList<TV>>();

        public void Add(TK key, TV value)
        {
            //_concurrentDictionary.AddOrUpdate(key, k => new LinkedList<TV>(),(k,l) )=>(
            //{ l.AddLast(value);return 1;});
        
            

            lock (_sync)// _reader.EnterWriterLock();
            {// try
                if (value != null && key != null)
                {
                    if (!_dic.ContainsKey(key))
                    {
                        LinkedList<TV> l = new LinkedList<TV>();
                        l.AddLast(value);
                        Monitor.Enter(_dic);
                        _dic.Add(key, l);
                    }
                    else
                    {
                        if (!_dic[key].Contains(value))
                        {
                            Monitor.Enter(_dic);
                            _dic[key].AddLast(value);
                        }
                    }
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }//
             //finally 
             //{
             //  _reader.ExitWriterLock();
             //}
        }

        


        public bool Remove(TK key)
        {
            lock (_sync)
            {
                return _dic.Remove(key);
            }      
        }

        public bool Remove(TK key, TV value)
        {
            lock (_sync)
            {
                if (value != null && key != null)
                    return _dic[key].Remove(value);
                else
                {
                    throw new ArgumentNullException();
                }
            }          
        }

        public void Clear()
        {
            lock (_sync)
            {
                foreach (KeyValuePair<TK, LinkedList<TV>> a in _dic)
                {
                    a.Value.Clear();
                }
                _dic.Clear();
            }
            
        }

        public bool ContainsKey(TK key)
        {
            lock (_sync)
            {
                return _dic.ContainsKey(key); 
            }
        }

        public bool Contains(TK key, TV value)
        {
            lock (_sync)
            {
                if (value != null)
                {
                    if (ContainsKey(key))
                        return _dic[key].Contains(value);
                    else
                        return false;
                }
                else
                {
                    throw new ArgumentNullException();
                } 
            }
        }

        public ICollection<TK> Keys
        {
            get
            {
                lock (_sync)
                {
                    LinkedList<TK> keys = new LinkedList<TK>(_dic.Keys);
                    return keys; 
                }
            }
        }

        public ICollection<TV> Values
        {
            get
            {
                lock (_sync)
                {
                    LinkedList<TV> keys = new LinkedList<TV>();
                    foreach (KeyValuePair<TK, LinkedList<TV>> a in _dic)
                    {
                        LinkedList<TV> keysB = new LinkedList<TV>();
                        keysB = a.Value;
                        foreach (var k in keysB)
                            if (!keys.Contains(k))
                            {
                                keys.AddFirst(k);
                            }
                    }
                    return keys; 
                }
            }
        }

        public int Count
        {
            get
            {
                lock (_sync)
                {
                    return Values.Count; 
                }
            }
        }        
        
        public IEnumerator<KeyValuePair<TK, IEnumerable<TV>>> GetEnumerator()
        {
            lock (_sync)
            {
                foreach (var d in _dic)
                {
                    yield return new KeyValuePair<TK, IEnumerable<TV>>(d.Key, d.Value);
                } 
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _dic.GetEnumerator();
        }
    }
}
