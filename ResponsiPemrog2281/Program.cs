using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2281
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan krw1 = new Karyawan();

            krw1.Nik = "081229107634";
            krw1.Nama = "Miku";
            krw1.GajiBulanan = 3000000;

            Karyawan krw2 = new Karyawan();
            krw2.Nik = "082242899877";
            krw2.Nama = "Poi";
            krw2.GajiBulanan = 2000000;

            Console.WriteLine("No.\tNIK/Nama\t\t\t\tGaji Bulanan");
            Console.WriteLine("==============================================================");
            Console.WriteLine("1. \t{0} {1}\t\t\t{2}", krw1.Nik, krw1.Nama, krw1.GajiBulanan);
            Console.WriteLine("2. \t{0} {1}\t\t\t{2}", krw2.Nik, krw2.Nama, krw2.GajiBulanan);

            Console.WriteLine("\n\n");
            Console.WriteLine("Assyiikk Kenaikan Gaji 10%");
            Console.WriteLine("\n");
            Console.WriteLine("No.\tNIK/Nama\t\t\t\tGaji Bulanan");
            Console.WriteLine("===============================================================");
            Console.WriteLine("1. \t{0} {1}\t\t\t{2}", krw1.Nik, krw1.Nama, krw1.GajiBulanan + (krw1.GajiBulanan * 0.10));
            Console.WriteLine("2. \t{0} {1}\t\t\t{2}", krw2.Nik, krw2.Nama, krw2.GajiBulanan + (krw2.GajiBulanan * 0.10));
            Console.ReadKey();



        }
    }
}
