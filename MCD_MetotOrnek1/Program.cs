﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_MetotOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            EkranaMerhabaYaz();
            EkranaMerhabaYaz();
            EkranaMerhabaYaz();
            EkranaMerhabaYaz();
            EkranaGonderilenIsimIleMerhabaYaz("faik");
            EkranaGonderilenIsimIleMerhabaYaz("erdem");
            EkranaGonderilenIsimIleMerhabaYaz("talha");

            EkranaGonderilenIsımleKacTaneMerhabaYaz("Yakup", 5);

            Console.ReadKey();

        }

        private static void EkranaMerhabaYaz()
        {
            Console.WriteLine("Merhaba");
        }

        private static void EkranaGonderilenIsimIleMerhabaYaz(string Isim)
        {
            Console.WriteLine("Merhaba sayın " +Isim.ToUpper());
        }

        private static void EkranaGonderilenIsımleKacTaneMerhabaYaz(string Isim, int KacTane)
        {
            if (KacTane > 0)
            {
                for (int i = 0; i <= KacTane; i++)
                {
                    Console.WriteLine("Merhaba sayın " +Isim.ToUpper());
                }
            }
            else if(KacTane <= 0)
            {
                Console.WriteLine("Lütfen sıfırdan farklı bir sayı gönder");
            }
        }


    }
}
