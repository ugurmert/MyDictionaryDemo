using System;

namespace MyDictionaryDemo
{
    class MyDictionary<K, V>    // Generic class
    {
        // Stack bellek bölgesinde dizilerin oluşturulması
        K[] _keyArray;
        V[] _valueArray;
        K[] _tempKeyArray;
        V[] _tempValueArray;

        // Constructor metot ile _keyArray ve _valueArray dizilerinin heap bellek bölgesinde 0 boyutlu referanslarının oluşturulması
        public MyDictionary()   // Constructor method
        {
            _keyArray = new K[0];
            _valueArray = new V[0];
        }

        // _keyArray ve _valueArray dizilerine eleman ekleme metodu
        public void Add(K keyItem, V valueItem)
        {
            int count = 0;

            // keyItem değerinin _keyArray dizisinde varlığı kontrol edilir
            foreach (K item in _keyArray)
            {
                // keyItem değeri _keyArray dizisinde varsa count değerini 1 yap ve döngüden çıkılır
                if (item.Equals(keyItem))
                {
                    count = 1;
                    break;
                }
            }

            // keyItem değeri _keyArray dizisinde yoksa, çalışacak kod bloğu
            if (count == 0)
            {
                // _keyArray dizisinin tüm elemanları _tempKeyArray dizisinde tutulur
                _tempKeyArray = _keyArray;

                // _keyArray dizisinin mevcut boyutunun 1 fazlası boyutunda yeni bir referansının oluşturulması
                _keyArray = new K[_keyArray.Length + 1];
 
                // _tempKeyArray dizisindeki elemanların _keyArray dizisine aktarılması
                for (int i = 0; i < _tempKeyArray.Length; i++)
                {
                    _keyArray[i] = _tempKeyArray[i];
                }
 
                // keyItem değişkeninin _keyArray dizisinin son sırasına eklenmesi
                _keyArray[_keyArray.Length - 1] = keyItem;

                // _valueArray dizisinin tüm elemanları _tempValueArray dizisinde tutulur
                _tempValueArray = _valueArray;
 
                // _valueArray dizisinin mevcut boyutunun 1 fazlası boyutunda yeni bir referansının oluşturulması
                _valueArray = new V[_valueArray.Length + 1];

                // _tempValueArray dizisindeki elemanların _valueArray dizisine aktarılması
                for (int i = 0; i < _tempValueArray.Length; i++)
                {
                    _valueArray[i] = _tempValueArray[i];
                }

                // valueItem değişkeninin _valueArray dizisinin son sırasına eklenmesi
                _valueArray[_valueArray.Length - 1] = valueItem;
            }

            // keyItem değeri _keyArray dizisinde varsa, çalışacak kod bloğu
            else
            {
                Console.WriteLine("Ekleme işlemi başarısız. Aynı anahtara sahip değer mevcut");
            }
        }

        // Elemanların aktarıldığını doğrulamak amacı ile oluşturulmuş Count özelliği
        public int Count
        {
            get { return _keyArray.Length; }
        }
    }
}
