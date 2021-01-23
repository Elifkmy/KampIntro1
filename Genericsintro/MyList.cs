using System;
using System.Collections.Generic;
using System.Text;

namespace Genericsintro
{
    class MyList<T>
    {
        T[] items;
        //constructor ctor yaz iki kez tab tuşuna bas alttaki constructor oluşsun.
        public MyList()
        {
            items = new T[0];
        }
        //item=eleman
        public void Add(T item)
        {
            T[] tempArray = items;// tempArray geçici dizi  // Önceki Referans numarası gitmesin diye geçici dizi oluşturulur.
            items = new T[items.Length + 1]; // Dizinin eleman sayısını arttırır.newlendiği an önceki referans numaraları gider.
            for (int i = 0; i < tempArray.Length; i++)  
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        
    }
}
