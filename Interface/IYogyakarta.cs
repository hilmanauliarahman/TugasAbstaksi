using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasAbstaksi.Interface
{
    class IYogyakarta : IDaerah
    {
        #region IDaerah Members

        public void Jumlahpenduduk()
        {
            Console.WriteLine("Jumlah Penduduk : 324.921.123 Jiwa");
            Console.WriteLine("=================================================");
        }

        #endregion
    }
}
