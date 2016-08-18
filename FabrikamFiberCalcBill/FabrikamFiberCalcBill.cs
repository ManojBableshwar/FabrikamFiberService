using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrikamFiberCalcBillNS
{
    public class FabrikamFiberCalcBill
    {
        public int FirstNumber { set; private get; }
        public int SecondNumber { set; private get; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
    }
}
