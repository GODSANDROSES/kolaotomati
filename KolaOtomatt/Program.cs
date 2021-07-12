using System;

namespace KolaOtomatt
{
    class Program
    {
        static void Main(string[] args)
        {


            var ürünkodu1 =0;
            int cüzdan = 100;


            


            string[,] ürünler = new string[4, 2]
            {
                {"Kola, Kodu", "1"},
                {"Fanta, Kodu", "2"},
                {"Gazoz, Kodu", "3"},
                {"Çikolata, Kodu", "4"},
              

                

            };
            int[] fiyat = new int[4]
            
                {10, 11, 12, 13 };


            while (cüzdan >= 0 && ürünkodu1 != -1)
            {



                for (int i = 0; i <= ürünler.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= ürünler.GetUpperBound(1); j++)
                    {
                        Console.WriteLine(ürünler[i, j]);

                        
                    }
                    Console.WriteLine(fiyat[i]);
                }

                Console.WriteLine("Lütfen Ürünün Kodunu Giriniz");
                ürünkodu1 = Convert.ToInt32( Console.ReadLine());

                switch (ürünkodu1)
                {
                    case 1: Console.WriteLine("Ödeme İşlemine Devam Ediniz"); break;

                    case 2: Console.WriteLine("Ödeme İşlemine Devam Ediniz"); break;

                    case 3: Console.WriteLine("Ödeme İşlemine Devam Ediniz"); break;

                    case 4: Console.WriteLine("Ödeme İşlemine Devam Ediniz"); break;

                    case 5: Console.WriteLine("Ödeme İşlemine Devam Ediniz"); break;

                    case 6: Console.WriteLine("Ödeme İşlemine Devam Ediniz"); break;

                    case 7: Console.WriteLine("Ödeme İşlemine Devam Ediniz"); break;

                    case 8: Console.WriteLine("Ödeme İşlemine Devam Ediniz"); break;


                    default: Console.WriteLine("HATALI KOD! TEKRAR DENEYİNİZ..."); break;





                }
                Console.WriteLine("**");


                int ürünfiyat1 = fiyat[0];
                int ürünfiyat2 = fiyat[1];
                int ürünfiyat3 = fiyat[2];
                int ürünfiyat4 = fiyat[3];



                switch (ürünkodu1)
                {
                    case 1:
                        if (cüzdan >= ürünfiyat1) { Console.WriteLine("Kolanızı alabilirsiniz...");
                            cüzdan -= ürünfiyat1;
                        } 
                        else Console.WriteLine("Kod ile fiyat farklı...");
                        break;
                    case 2:
                        if (cüzdan >= ürünfiyat2) { Console.WriteLine("Fantanızı alabilirsiniz...");
                            cüzdan -= ürünfiyat2;
                        } 
                        else Console.WriteLine("Kod ile fiyat farklı...");
                        break;
                    case 3:
                        if (cüzdan >= ürünfiyat3) { Console.WriteLine("Gazozunuzu alabilirsiniz...");
                            cüzdan -= ürünfiyat3;
                        }
                        else Console.WriteLine("Kod ile fiyat farklı");
                        break;
                    case 4:
                        if (cüzdan >= ürünfiyat4) { Console.WriteLine("Çikolatanızı alabilirsiniz...");
                            cüzdan -= ürünfiyat4;
                        }
                        else Console.WriteLine("Kod ile fiyat farklı...");
                        break;
                    default: Console.WriteLine("Yetersiz Tutar!"); break;

                }
                Console.Clear();
                Console.WriteLine("Cüzdanınızdaki Kalan Bakiye: " + cüzdan);
                
            }
           




        }

    }
}
