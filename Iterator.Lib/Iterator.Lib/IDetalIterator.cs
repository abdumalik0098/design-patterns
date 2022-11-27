using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Lib
{
    public interface IDetalIterator
    {
        bool HasNextDetal();
        DetalItem GetFirstDetal();
        DetalItem GetNextDetal();

    }
}
