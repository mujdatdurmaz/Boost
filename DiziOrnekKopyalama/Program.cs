using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnekKopyalama
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] anaDizi = {1,2,3,4,5 };
            //int[] yeniDizi = new int[5];

            ////Array.Copy(anaDizi, yeniDizi, 5);

            //foreach (int icerik in yeniDizi)
            //{
            //    Console.Write(icerik + "\t");
            //}

            //yeniDizi = (int[])anaDizi.Clone();

            //foreach (int icerik in yeniDizi)
            //{
            //    Console.Write(icerik+"\t");
            //}

            //int satir = Convert.ToInt32(Console.ReadLine());
            //int sutun = Convert.ToInt32(Console.ReadLine());
            //Random rnd = new Random();
            //int[,] dizi = new int[satir, sutun];

            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < sutun; j++)
            //    {
            //        dizi[i, j] = rnd.Next(1, 50);
            //        Console.Write(dizi[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            int Ocak = 0, Subat=0, Mart=0, toplam1=0,toplam2=0,toplam3=0,toplam4=0,toplam5=0, Gtop=0;

            int[,] dizi = new int[5, 3];
            dizi[0, 0] = 700;
            dizi[0, 1] = 600;
            dizi[0, 2] = 650;
            dizi[1, 0] = 900;
            dizi[1, 1] = 800;
            dizi[1, 2] = 700;
            dizi[2, 0] = 300;
            dizi[2, 1] = 400;
            dizi[2, 2] = 350;
            dizi[3, 0] = 500;
            dizi[3, 1] = 450;
            dizi[3, 2] = 470;
            dizi[4, 0] = 600;
            dizi[4, 1] = 500;
            dizi[4, 2] = 480;

            for (int i = 0; i < 5; i++)
            {
                Ocak += dizi[i, 0];
                Subat += dizi[i, 1];
                Mart += dizi[i, 2];
            }

            for (int i = 0; i < 3; i++)
            {
                toplam1 += dizi[0, i];
                toplam2 += dizi[1, i];
                toplam3 += dizi[2, i];
                toplam4 += dizi[3, i];
                toplam5 += dizi[4, i];
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Gtop += dizi[i, j];

                    Console.Write(dizi[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Fiat için Toplam :" + toplam1);
            Console.WriteLine("Renault için Toplam :" + toplam2);
            Console.WriteLine("VW için Toplam :" + toplam3);
            Console.WriteLine("Opel için Toplam :" + toplam4);
            Console.WriteLine("Ford için Toplam :" + toplam5);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Ocak Satış Toplamı : " + Ocak);
            Console.WriteLine("Şubat Satış Toplamı : " + Subat);
            Console.WriteLine("Mart Satış Toplamı : " + Mart);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Genel Toplam :" + Gtop);


            Console.ReadKey();

        }
    }
}
