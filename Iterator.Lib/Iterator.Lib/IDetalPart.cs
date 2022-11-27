using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Lib
{
    public interface IDetalPart
    {
        IDetalIterator CreateDetalIterator();
        int Capacity { get; }
        DetalItem this[int index] { get; }
        void AddDetal(DetalItem Item);
        DetalItem MoveDetalToDefective(int Id);
    }
}
