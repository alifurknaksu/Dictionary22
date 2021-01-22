using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary22
{
    class MyDictionary<Id, Isim>
    {
        Id[] keys;
        Isim[] values;

        public MyDictionary()
        {
            keys = new Id[0];
            values = new Isim[0];
        }
        public void Add(Id key, Isim value)
        {
            Id[] tempArrayKeys = keys;
            Isim[] tempArrayValues = values;

            keys = new Id[keys.Length + 1];
            values = new Isim[values.Length + 1];

            for (int i = 0; i < tempArrayKeys.Length; i++)
            {
                keys[i] = tempArrayKeys[i];
                values[i] = tempArrayValues[i];
            }


            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public Id[] Keys
        {
            get { return keys; }
        }

        public Isim[] Values
        {
            get { return values; }
        }

    }
}