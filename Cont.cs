using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Cont
    {
        public string nrCont;
        public string tipCont;
        public Cont()
        {
            nrCont = "";
            tipCont = "";
        }
        public Cont(string nrCont, string tipCont)
        {
            this.nrCont = nrCont;
            this.tipCont = tipCont;
        }
    }
}
