using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<K , V>
    {
        K[] keys;
        V[] values;
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];

        }
        
        public void Add(K key, V value)
        {
            K[] tempKeys = keys;
            V[] tempValue = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            keys[keys.Length - 1] = key;

            for (int j= 0; j <tempValue.Length; j++)
            {
                values[j] = tempValue[j];

            }
            values[values.Length - 1] = value;

        }

        

        public int Count
        {
            get { return keys.Length; }
            
        }
        public V[] Values
        {
            get { return values; }
        }
        public K[] Keys
        {
            get { return keys; }
        }


    }
  
    
}
