using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_44
{
    class Company <P>
    {
        public P CEO { get; set; }
        public Company(P ceo)
        {
            this.CEO = ceo;
        }
    }
}
