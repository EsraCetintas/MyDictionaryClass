using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(132, "Esra Çetintaş");
            myDictionary.Add(132, "Esra Çetintaş");
            Console.WriteLine(myDictionary.keysCount);
            Console.WriteLine(myDictionary.valuesCount);
            Console.ReadKey();
        }
    }

    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;
        Tkey[] tempKeys;
        Tvalue[] tempValues;
        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }

        public void Add(Tkey key,Tvalue deger)
        {
            tempKeys = keys;
            tempValues = values;
            keys = new Tkey[tempKeys.Length + 1];
            values = new Tvalue[tempValues.Length + 1];

            for(int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            keys[tempKeys.Length] = key;

            for (int i = 0; i <tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            values[tempValues.Length] = deger;
        }

        public int keysCount
        {
            get { return keys.Length; }
        }

        public int valuesCount
        {
            get { return values.Length; }
        }
    }
}
