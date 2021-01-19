using System;

namespace ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Productname = "Purina Proplan";
            urun1.Producttype = "Kedi maması";
            urun1.Productprice = 209;

            Product urun2 = new Product();
            urun2.Productname = "Alice";
            urun2.Producttype = "Kedi kumu";
            urun2.Productprice = 30;

            Product urun3 = new Product();
            urun3.Productname = "Beaphar Calming Collar";
            urun3.Producttype = "Köpek tasmaları";
            urun3.Productprice = 47;

            Product urun4 = new Product();
            urun4.Productname = "Dayang A24B Papağan Kafesi Ayaklı";
            urun4.Producttype = "Kuş Kafesi";
            urun4.Productprice = 2949;

            Product[] petshop = new Product[] { urun1, urun2, urun3, urun4 };
            int x = 0;
            while (x < petshop.Length)
            {
                Console.WriteLine("Ürün Adı : " + petshop[x].Productname + "\n\n" + "Ürün Tipi : " +
                    petshop[x].Producttype + "\n\n" + "Ürün Fiyatı : " + petshop[x].Productprice + " TL \n\n");
                x++;
            }

            for (int i = 0; i < petshop.Length; i++)
            {
                Console.WriteLine("Ürün Adı : " + petshop[i].Productname + "\n\n" + "Ürün Tipi : " +
                    petshop[i].Producttype + "\n\n" + "Ürün Fiyatı : " + petshop[i].Productprice + " TL \n\n");
            }

            string[] pet = new string[] {"Ürün Adı: Purina Proplan \n\nÜrün Tipi: Kedi Maması \n\nÜrün Fiyatı: 209 TL \n\n\n" +
                "Ürün Adı: Alice \n\nÜrün Tipi: Kedi Kumu \n\nÜrün Fiyatı: 30 TL \n\n\n" +
                "Ürün Adı: Beaphar Calming Collar \n\nÜrün Tipi: Köpek Tasmaları \n\nÜrün Fiyatı: 47 TL \n\n\n" +
                "Ürün Adı: Dayang A24B Papağan Kafesi Ayaklı \n\nÜrün Tipi: Kuş Kafesi \n\nÜrün Fiyatı: 2949 TL" };


            foreach (string pett in pet)
            {
                Console.WriteLine(pett);
            }
        }
    }
    class Product
    {
        public string Productname { get; set; }
        public string Producttype { get; set; }
        public int Productprice { get; set; }

    }
}
