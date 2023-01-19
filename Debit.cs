using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Debit : Cont
    {
        public string soldInitialDebitor;
        public string rulajDebitor;
        public string soldFinalDebitor;

        public Debit() : base()
        {
            soldInitialDebitor = "";
            rulajDebitor = "";
            soldFinalDebitor = "";
        }
        public Debit(string nrCont, string tipCont, string soldInitialDebitor, string rulajDebitor, string soldFinalDebitor) : base(nrCont, tipCont)
        {
            this.soldInitialDebitor = soldInitialDebitor;
            this.rulajDebitor = rulajDebitor;
            this.soldFinalDebitor = soldFinalDebitor;
        }
    }
}
