using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Lib
{
    public class ConcreteDetalIterator : IDetalIterator
    {
        IDetalPart detal;
        int curIndex;

        public ConcreteDetalIterator(IDetalPart detal, int curIndex=0)
        {
            this.detal = detal;
            this.curIndex = curIndex;
        }

        public bool HasNextDetal()
        {
            bool hasNext = false;
            if (curIndex < detal.Capacity - 1)
            {
                hasNext = true;
            }
            return hasNext;
        }

        public DetalItem GetFirstDetal()
        {
            DetalItem item = null;
            if (detal.Capacity > 0)
            {
                item = detal[0];
            }
            return item;
        }

        public DetalItem GetNextDetal()
        {
            DetalItem item = null;
            if (curIndex < detal.Capacity-1)
            {
                curIndex++;
                item = detal[curIndex];
            }
            return item;
        }

    }
}
