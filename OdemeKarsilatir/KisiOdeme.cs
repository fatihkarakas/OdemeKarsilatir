using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeKarsilatir
{
    public class KisiOdeme
    {
        public int Sira { get; set; }
        public string tck { get; set; }
        public string adisoyadi { get; set; }

        public string Iban { get; set; }
        public decimal Odeme { get; set; }

    }
}
