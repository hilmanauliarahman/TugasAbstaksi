using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasAbstaksi.Interface
{
    class IBandung : IDaerah
    {
        #region IDaerah Members

        public void Jumlahpenduduk()
        {
            Console.WriteLine("Jumlah Penduduk : 572.921.123 Jiwa");
            Console.WriteLine("=================================================");
        }

        #endregion
    }
}
