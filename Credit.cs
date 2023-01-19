using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Credit : Cont
    {
        public string soldInitialCreditor;
        public string rulajCreditor;
        public string soldFinalCreditor;

        public Credit() : base()
        {
            soldInitialCreditor = "";
            rulajCreditor = "";
            soldFinalCreditor = "";
        }
        public Credit(string nrCont, string tipCont, string soldInitialCreditor, string rulajCreditor, string soldFinalCreditor) : base(nrCont, tipCont)
        {
            this.soldInitialCreditor = soldInitialCreditor;
            this.rulajCreditor = rulajCreditor;
            this.soldFinalCreditor = soldFinalCreditor;
        }
    }
}
