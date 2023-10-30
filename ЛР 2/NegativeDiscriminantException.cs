using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_2
{
    internal class NegativeDiscriminantException:Exception
    {
        public NegativeDiscriminantException(string ex) : base(ex) { }
    }
}
