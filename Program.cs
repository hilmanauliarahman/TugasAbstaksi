using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using TugasAbstaksi.AbstractClass;
using TugasAbstaksi.Interface;
namespace TugasAbstaksi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                  Informasi Wilayah              ");
            Console.WriteLine("=================================================");
            //AbstractClass
            Daerah daerah;
            Daerah daerah2;
            Daerah daerah3;
            //Interface
            IDaerah idaerah;
            IDaerah idaerah2;
            IDaerah idaerah3;
            daerah = new Bandung();
            daerah.Letak();
            idaerah = new IBandung();
            idaerah.Jumlahpenduduk();
            daerah2 = new Yogyakarta();
            daerah2.Letak();
            idaerah2 = new IYogyakarta();
            idaerah2.Jumlahpenduduk();
            daerah3 = new Pangandaran();
            daerah3.Letak();
            idaerah3 = new IPangandaran();
            idaerah3.Jumlahpenduduk();

            Console.WriteLine("=================================================");
            Console.ReadKey();
        }
    }
}
