using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> technicalUniversities = new MyDictionary<int, string>();
            technicalUniversities.Add(1, "Bursa Teknik Üniversitesi");
            technicalUniversities.Add(2, "Erzurum Teknik Üniversitesi");
            technicalUniversities.Add(3, "Eskişehir Teknik Üniversitesi");
            technicalUniversities.Add(4, "Gebze Teknik Üniversitesi");
            technicalUniversities.Add(5, "İskenderun Teknik Üniversitesi");
            technicalUniversities.Add(6, "İstanbul Teknik Üniversitesi");
            technicalUniversities.Add(7, "Karadeniz Teknik Üniversitesi");
            technicalUniversities.Add(8, "Konya Teknik Üniversitesi");
            technicalUniversities.Add(9, "Orta Doğu Teknik Üniversitesi");
            technicalUniversities.Add(10, "Ostim Teknik Üniversitesi");
            technicalUniversities.Add(2, "İstanbul Teknik Üniversitesi");       // 2 değeri mevcut olduğundan dolayı ekleme işlemi başarısız olacaktır
            Console.WriteLine(technicalUniversities.Count);
            technicalUniversities.Add(11, "Yıldız Teknik Üniversitesi");
            Console.WriteLine(technicalUniversities.Count);
            technicalUniversities.Add(11, "Yıldız Teknik Üniversitesi");       // 11 değeri mevcut olduğundan dolayı ekleme işlemi başarısız olacaktır
            Console.WriteLine(technicalUniversities.Count);
        }
    }
}
