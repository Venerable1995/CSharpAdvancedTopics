using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
   public class OverdraftEventArgs : EventArgs
    {
        public Decimal AmountOverdrafted { get; private set; }
        public String MoreInfo { get; private set; }
        public bool CancelTransaction { get; set; } = false;
        public OverdraftEventArgs(decimal amountOverdrafted, String moreInfo)
        {
            AmountOverdrafted = amountOverdrafted;
            MoreInfo = moreInfo;
        }
    }
}
